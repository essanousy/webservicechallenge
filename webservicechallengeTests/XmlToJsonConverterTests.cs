using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebServiceChallenge.Tests
{
    [TestClass()]
    public class XmlToJsonConverterTests
    {
        [TestMethod()]
        public void XmlToJsonTest()
        {
            
            string xmlstring = "<root><item>test</item></root>";
            string json = XmlToJsonConverter.XmlToJson(xmlstring);
            Assert.AreEqual(json, @"{""root"":{""item"":""test""}}");
        }

        [TestMethod]
        public void XmlToJsonTestBadFormat()
        {
            
            string xmlstring = "<root><item>test</item>";
            string json = XmlToJsonConverter.XmlToJson(xmlstring);

            Assert.AreEqual(json, @"Bad Xml format");
        }

        [TestMethod]
        public void XmlToJsonTestNullParam()
        {
            
            string xmlstring = null;
            string json = XmlToJsonConverter.XmlToJson(xmlstring);

            Assert.AreEqual(json, @"Bad Xml format");
        }

    }
}