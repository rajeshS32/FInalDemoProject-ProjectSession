using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Entity_Layer;
using System.Text;

namespace UILayer.Controllers
{
    public class CreateNewSessionController : Controller
    {
        Uri baseAddress = new Uri("https://localhost:44368/api");
        HttpClient client;
        public CreateNewSessionController()
        {
            client = new HttpClient();
            client.BaseAddress = baseAddress;
        }
        public IActionResult Index()
        {
            List<Create_NewSession> session = new List<Create_NewSession>();
            using (var client = new HttpClient())
            {
                UriBuilder builder = new UriBuilder("https://localhost:44368/api/CreateNewSession/getall");
                //builder.Query = "userName=" + userName + "&passWord=" + password;

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var responseTask = client.GetAsync(builder.Uri).Result;

                if (responseTask.IsSuccessStatusCode)
                {
                    var JsonContent = responseTask.Content.ReadAsStringAsync().Result;
                    session = JsonConvert.DeserializeObject<List<Create_NewSession>>(JsonContent);
                }
            }
            return View(session);
        }

        //Httppost
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Create_NewSession model)
        {

            string data = JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(data, Encoding.UTF8, "Application/json");
            HttpResponseMessage response = client.PostAsync(client.BaseAddress + "/CreateNewSession/add", content).Result;
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        //HttpPut

        public ActionResult Edit(int id)
            {
                Create_NewSession model = new Create_NewSession();
                HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/CreateNewSession/edit/"+ id).Result;
                if (response.IsSuccessStatusCode)
                {
                    string data = response.Content.ReadAsStringAsync().Result;
                    model = JsonConvert.DeserializeObject<Create_NewSession>(data);
                }
                return View("Create", model);
            }
        
        [HttpPut]
        public ActionResult Edit(Create_NewSession model)
        {
            string data = JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(data, Encoding.UTF8, "Application/json");
            HttpResponseMessage response = client.PutAsync(client.BaseAddress + "/CreateNewSession/edit/" + model.PrimaryID, content).Result;
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View("Create", model);
        }

    }
}
