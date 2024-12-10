using Microsoft.EntityFrameworkCore;
using SiteMark1.Core.Context;
using SiteMark1.Core.Interfaces;
using SiteMark1.Entities;

namespace SiteMark1.Core.Reposiries
{
    public class CidadeRepository
    {
        public  IDBContexto _contexto { get; set; }

        public CidadeRepository(IDBContexto contexto)
        {
            _contexto = contexto;
        }

        public List<Cidade> ListarCidade()
        {
            return _contexto.ListarCidades();
        }
    }
}
