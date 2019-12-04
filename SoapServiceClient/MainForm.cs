using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoapServiceClient.SOAPServiceReference;

namespace SoapServiceClient
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private async void BtnCallFibonacci_Click(object sender, EventArgs e)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            TxtResponse.Text = "Calling Fibonacci Methode \r\n";
            try
            {
                var client = new SOAPWebServiceSoapClient();
                var response = await client.FibonacciAsync(txtParam.Text);
                TxtResponse.Text += $"Result Fibonacci Methode : {response.Body.FibonacciResult.ToString()} \r\n";
            }
            catch (Exception ex)
            {
                TxtResponse.Text = ex.ToString();
            }
            finally
            {
                watch.Stop();
                TxtResponse.Text += $"Finished Calling Fibonacci Methode : {watch.ElapsedMilliseconds } ms";
            }
        }

        private async void BtnCallXmlToJson_Click(object sender, EventArgs e)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            TxtResponseJson.Text = "Calling XmlToJson Methode \r\n";
            try
            {
                var client = new SOAPWebServiceSoapClient();
                var response = await client.XmlToJsonAsync(TxtParamXml.Text);
                var json = response.Body.XmlToJsonResult.ToString();
                TxtResponseJson.Text += $"Result XmlToJson Methode : {json} \r\n";
                RtbJson.Text = json;
            }
            catch (Exception ex)
            {
                TxtResponseJson.Text = ex.ToString();
            }
            finally
            {
                watch.Stop();
                TxtResponseJson.Text += $"Finished Calling XmlToJson Methode : {watch.ElapsedMilliseconds } ms";
            }
        }



    }
}
