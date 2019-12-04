// <copyright file="SOAPWebService.asmx.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WebServiceChallenge
{
    using System.Threading;
    using System.Web.Services;
    using log4net;

    /// <summary>
    /// Description résumée de SOAPWebService.
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante.
    [System.Web.Script.Services.ScriptService]
    public class SOAPWebService : WebService
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public long Fibonacci(string number)
        {
            Log.Info($"Fibonacci started with Number : {number}");
            Thread.Sleep(10000);
            long result = -1;
            bool isConverted = int.TryParse(number, out int convertedNumber);
            if (isConverted)
            {
                if (convertedNumber <= 100 && convertedNumber >= 0)
                {
                    result = FibonacciCalcul.GetFibonacci(convertedNumber);
                }
            }

            Log.Info($"Fibonacci finished with result : {result}");
            return result;
        }

        [WebMethod]
        public string XmlToJson(string xmlString)
        {
            Log.Info($"XmlToJson started with xmlString : {xmlString}");

            var json = XmlToJsonConverter.XmlToJson(xmlString);

            Log.Info($"XmlToJson finished with result : {json}");

            return json;
        }
    }
}
