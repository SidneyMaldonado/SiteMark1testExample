using SiteMark1.Core.Context;
using SiteMark1.Core.Reposiries;
using SiteMark1.Entities;
using SiteMark1Test.MockContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteMark1Test.RepositoryTest
{
    [TestClass]
    public class CidadeRepositoryTest
    {
        [TestMethod]
        public void CidadeRepostoryTest()
        {
            MockDBContext contexto = new MockDBContext();
            DBContexto contexto2 = new DBContexto();
            CidadeRepository cidrepo = new CidadeRepository(contexto);
            foreach (Cidade cidade in contexto.Cidades.ToList())
            {
                Console.WriteLine(cidade.NmCidade);
            }
            Console.WriteLine("------------------");
            CidadeRepository cidrepo2 = new CidadeRepository(contexto);
            foreach (Cidade cidade in contexto2.Cidades.ToList())
            {
                Console.WriteLine(cidade.NmCidade);
            }
           Assert.IsTrue(contexto.Cidades.ToList().Count > 0);
        }
    }
}
