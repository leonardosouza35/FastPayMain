using Fantasy.FastPay.Domain.Entites;
using Fantasy.FastPay.Web.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fantasy.FastPay.Web.ManualMapper
{
    public class PaisMapper
    {
        public PaisDTO MapDTO(Pais pais)
        {
            var paisDTO = new PaisDTO();
            paisDTO.Id = pais.Id;
            paisDTO.Nome = pais.Nome;
            paisDTO.Descricao = pais.Descricao;

            return paisDTO;
        }


        public List<PaisDTO> MapDTO(List<Pais> pais)
        {
            return pais.Select(p =>
                new PaisDTO()
                {
                    Id = p.Id,
                    Nome = p.Nome,
                    Descricao = p.Descricao
                }).ToList();                        
        }
    }
}