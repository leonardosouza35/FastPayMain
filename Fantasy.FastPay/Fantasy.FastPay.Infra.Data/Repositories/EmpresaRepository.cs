using Fantasy.FastPay.Domain.Entites;
using Fantasy.FastPay.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fantasy.FastPay.Infra.Data.Repositories
{
    public class EmpresaRepository: RepositoryBase<Empresa>, IEmpresaRepository
    {

        public List<Empresa> ObterTodasAsEmpresas()
        {
            var listaEmpresas = new List<Empresa>();
            var dataReader = ExecuteReader("select nome from empresas");
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    var empresa = new Empresa();
                    empresa.Nome = dataReader["nome"].ToString();

                    listaEmpresas.Add(empresa);
                }
            }
            return listaEmpresas;
        }

        public Empresa ObterPorId(int empresaId)
        {
            throw new NotImplementedException();
        }

        public void Adicionar(Empresa empresa)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Empresa empresa)
        {
            throw new NotImplementedException();
        }

        public void Remover(Empresa empresa)
        {
            throw new NotImplementedException();
        }
    }
}
