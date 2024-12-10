using SiteMark1.Core.Context;
using SiteMark1.Entities;
using SiteMark1Test.MockContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteMark1Test.EntitiesTest
{
    [TestClass]
    public class CidadeTest
    {
        // teste de integração
        [TestMethod]
        public void ListarCidade()
        {
            MockDBContext contexto = new MockDBContext();
            foreach(Cidade cidade in contexto.Cidades.ToList())
            {
                Console.WriteLine(cidade.NmCidade);
            }
            Assert.IsTrue(contexto.Cidades.ToList().Count > 0);
        }
    }
}
