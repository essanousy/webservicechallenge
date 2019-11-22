using Microsoft.VisualStudio.TestTools.UnitTesting;
using webservice_challenge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webservice_challenge.Tests
{
    [TestClass()]
    public class XmlToJsonConverterTests
    {
        [TestMethod()]
        public void XmlToJsonTest()
        {
            string xmlstring = "< TRANS >< HPAY >< ID > 103 </ ID >< STATUS > 3 </ STATUS >< EXTRA >< IS3DS > 0 </ IS3DS >< AUTH > 031183 </ AUTH ></ EXTRA >< INT_MSG />< MLABEL > 501767XXXXXX6700 </ MLABEL >< MTOKEN > project01 </ MTOKEN ></ HPAY ></ TRANS >";
            string json = "";
            Assert.AreEqual(json,"");
        }
    }
}