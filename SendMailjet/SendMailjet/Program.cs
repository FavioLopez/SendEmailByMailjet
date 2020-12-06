using Mailjet.Client;
using Mailjet.Client.Resources;
using Newtonsoft.Json.Linq;
using System;
using System.Threading.Tasks;

namespace SendMailjet
{
    class Program
    {
        static void Main(string[] args)
        {
            RunAsync().Wait();
        }
        static async Task RunAsync()
        {
            FacturaReporte facturaReporte = new FacturaReporte();
            string fac = facturaReporte.factura();
            //MailjetClient client = new MailjetClient(Environment.GetEnvironmentVariable("MJ_APIKEY_PUBLIC"), Environment.GetEnvironmentVariable("MJ_APIKEY_PRIVATE"));
            MailjetClient cli = new MailjetClient("e61028175953457b9abf53f13f5cbb8d", "0d77e47c3b62e5ea63165692ddc32e1c")
            {
                Version = ApiVersion.V3_1,
            };
            MailjetRequest request = new MailjetRequest
            {
                Resource = Send.Resource,
            }
               .Property(Send.Messages, new JArray {
                new JObject {
                 {"From", new JObject {
                  {"Email", "fab00442@gmail.com"},
                  {"Name", "Favio LopezUCB"}
                  }},
                 {"To", new JArray {
                  new JObject {
                   {"Email", "fabilopalfa@gmail.com"},
                   {"Name", "Favio Lopez"}
                   }
                  }},
                 {"Subject", "Mira este emaill"},
                 {"TextPart", "Aqui tiens tu factura querido amigo"},
                 {"HTMLPart", fac },
                 }
                });
            MailjetResponse response = await cli.PostAsync(request);
        }
    }
}