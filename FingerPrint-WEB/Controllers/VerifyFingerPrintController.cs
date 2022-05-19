using FingerPrintDataAcessLayer.Model;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace FingerPrint_WEB.Controllers
{
    public class VerifyFingerPrintController : Controller
    {
        private static string url = "https://localhost:7156/";
        public IActionResult FingerPrintVerify()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> GetFingerPrint(int id)
        {
            FingerPrint singlefinger = new FingerPrint();
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Clear();
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var fingerId = await client.GetAsync("/api/FingerPrintApi/GetFingerById?id=" +id);
                if (fingerId.IsSuccessStatusCode)
                {
                    var fingers = fingerId.Content.ReadAsStringAsync().Result;
                    singlefinger = JsonConvert.DeserializeObject<FingerPrint>(fingers);
                }

            }
            return View(singlefinger);

        }
    }
}
