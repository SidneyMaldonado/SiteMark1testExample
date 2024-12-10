using SiteMark1.Core.Interfaces;
using SiteMark1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteMark1Test.MockContext
{
    public class MockDBContext: IDBContexto
    {

        public List<Cidade> Cidades { get; set; }
        public MockDBContext()
        {
            Cidades = new List<Cidade>();
            Cidades.Add(new Cidade()
            {
                IdCidade = 1, NmCidade = "Campo Grande", CdEstado = 1, DmSituacao=true
            });  
        }
        public List<Cidade> ListarCidades()
        {
                return Cidades.ToList();
        }
    }
 
}
