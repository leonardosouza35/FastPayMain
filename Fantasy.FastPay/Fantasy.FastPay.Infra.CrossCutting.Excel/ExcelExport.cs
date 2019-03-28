using ClosedXML.Excel;
using Fantasy.FastPay.Infra.CrossCutting.Excel.Attributes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Fantasy.FastPay.Infra.CrossCutting.Excel
{
    public class ExcelExport
    {
        private string _fileName;
        private XLWorkbook _xLWorkbook;
        public MemoryStream _memoryStream { get; private set; }
        

        public ExcelExport(string fileName)
        {
            _fileName = fileName;
        }


        public void Export()
        {
            using (_xLWorkbook = new XLWorkbook())
            {
                var worksheet = _xLWorkbook.Worksheets.Add("Exemplo");
            }

        }


        private void CreateHeader<T>(IEnumerable<T> list, IXLWorksheet workshhet) where T : class
        {
            var firsItem = list.First();
            
            var properties = firsItem.GetType().GetProperties();

            var columnCount = 1;
            foreach (var property in properties.Where(p => !Attribute.IsDefined(p, typeof(IgnoreAttribute),false)))
            {
                var attribute = (ExcelAttribute)property.GetCustomAttributes(typeof(ExcelAttribute),false).First();
                
                workshhet.Cell(1, columnCount).SetValue(attribute.DisplayName);
                workshhet.Cell(1, columnCount).Style.Font.Bold = true;
                workshhet.Cell(1, columnCount).Style.Font.FontSize = 11;

                columnCount++;
            }

        }

        private void FillWorkSheet<T>(IEnumerable<T> list, IXLWorksheet worksheet) where T: class
        {
            var rowIndex = 2;
            var colIndex = 1;

            foreach (var item in list)
            {
                // Obter todas as propriedades de cada item dentro de list
                // mas somente pegar propriedades que não estejam com IgnoreAttribute                                                    
                foreach(var property in item.GetType().GetProperties().Where(p => !Attribute.IsDefined(p, typeof(IgnoreAttribute)))){

                    // property.GetValue(item, null) obtem o valor da propriedade em tempo de execução
                    // e em seguida, o valor é atribuído a célula do excel gerenciado pelo CloseXML
                    worksheet.Cell(rowIndex, colIndex).SetValue(property.GetValue(item, null));
                    colIndex++;
                }
                
                colIndex = 1; // Reseta para primeira coluna antes de partir para a próxima linha 

                rowIndex++; // incrementa para adicionar mais uma linha e vai fazer isso enquanto existir itens dentro de list
            }
        }

        public void CreateInMemory<T>(IEnumerable<T> list, string sheetName) where T: class
        {
            using (_xLWorkbook = new XLWorkbook())
            {
                var workSheet = _xLWorkbook.Worksheets.Add(sheetName);
                CreateHeader(list, workSheet);
                FillWorkSheet(list, workSheet);
                workSheet.Columns().AdjustToContents();
                SaveInStream(_xLWorkbook);
            }
        }

        private void SaveInStream(XLWorkbook _xLWorkbook)
        {
            using (_memoryStream = new MemoryStream())
            {
                _xLWorkbook.SaveAs(_memoryStream);
                _memoryStream.Position = 0;
            }
        }

        public byte[] GetByteArray()
        {
            return _memoryStream.ToArray();
        }
    }
}
