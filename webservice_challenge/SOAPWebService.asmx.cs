using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace webservice_challenge
{
    /// <summary>
    /// Description résumée de SOAPWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class SOAPWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public Int64 Fibonacci(string Number)
        {
            Int64 result= (Int64)(-1);
            bool isConverted = int.TryParse(Number, out int convertedNumber);
            if (isConverted)
            {
                if (convertedNumber <= 100 && convertedNumber >= 0)
                {
                    var FibCalcul = new FibonacciCalcul();
                    result = FibCalcul.GetFibonacci(convertedNumber);
                } 
            }

            return result;
        }

    }
}
