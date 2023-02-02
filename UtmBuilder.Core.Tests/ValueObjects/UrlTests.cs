using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtmBuilder.Core.ValueObjects;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.Tests.ValueObjects
{
    [TestClass]
    public class UrlTests
    {
        private const string InvalidUrl = "banana";
        private const string ValidUrl = "https://balta.io";

        [TestMethod]
        [TestCategory("teste de url")]
        [ExpectedException(typeof(InvalidUrlException))]
        public void DeveRetornarExcecaoQuandoUrlForInvalida()
        {
            
                var url = new Url(InvalidUrl);              
            

        }

        [TestMethod]
        [TestCategory("teste de url")]
        public void NaoDeveRetornarExcecaoQuandoUrlForValida()
        {
            new Url(ValidUrl);
            Assert.IsTrue(true);

        }

        [TestMethod]
        [DataRow(" ", true)]
        [DataRow("http", true)]
        [DataRow("banana", true)]
        [DataRow("https://balta.io", false)]
        public void TestDataRow(
            string link,
            bool expectedException)
        {
            if(expectedException)
            {
                try
                {
                    new Url(link);
                    Assert.Fail();
                }
                catch (InvalidUrlException)
                {

                    Assert.IsTrue(true);
                }
            }

        }

    }
}
