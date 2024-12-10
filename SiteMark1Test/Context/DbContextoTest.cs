using Microsoft.AspNetCore.Http.HttpResults;
using SiteMark1.Core.Context;
using SiteMark1Test.MockContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteMark1Test.Context
{
    [TestClass]
    public class DbContextoTest
    {

        [TestMethod]
        public void DTestConnect()
        {
            try
            {
                MockDBContext contexto = new MockDBContext();
                Assert.IsNotNull(contexto);
            } catch (Exception ex)
            {
                Assert.AreEqual(true,false);
            }
        }

    }
}
