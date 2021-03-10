using AnnonssystemMVC.Helper;
using AnnonssystemMVC.Models;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace AnnonssystemMVC.Controllers
{
    public class HomeController : Controller
    {
        SamverkandeAPI api = new SamverkandeAPI();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger; 
        }

        public async Task<IActionResult> ReadAllaAds()
        {
            List<Ads> annonser = new List<Ads>();
            HttpClient client = api.Initial();
            HttpResponseMessage response = await client.GetAsync("api/Ads");
            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
                annonser = JsonConvert.DeserializeObject<List<Ads>>(result); 
            }
            return View(annonser); 
        }

        public async Task<IActionResult> ReadAd(int id)
        {
            if(id == 0)
            {
                return NotFound(); 
            }

            Ads annons = new Ads();
            HttpClient client = api.Initial();
            HttpResponseMessage response = await client.GetAsync("api/Ads/" + id);

            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
                annons = JsonConvert.DeserializeObject<Ads>(result); 

            }
            return View(annons); 
        }

        public async Task<IActionResult> ReadAnnonsor(IFormCollection id)
        {
            int annonsorId = Convert.ToInt32(id["annonsorId"]); 
            Annonsorer annonsor = new Annonsorer();
            HttpClient client = api.Initial();
            HttpResponseMessage response = await client.GetAsync("api/Annonsorer" + id);

            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
                annonsor = JsonConvert.DeserializeObject<Annonsorer>(result); 
            }
            return View(annonsor); 
        }

        public async Task<IActionResult> ReadAnnonsorDetalj(int id)
        {
            Annonsorer annonsorDetalj = new Annonsorer();
            HttpClient client = api.Initial();
            HttpResponseMessage response = await client.GetAsync("api/Annonsorer/" + id);

            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
                annonsorDetalj = JsonConvert.DeserializeObject<Annonsorer>(result);
            }

            return View(annonsorDetalj); 
        }

        public async Task<IActionResult> ReadPrenumerant(IFormCollection id)
        {
            int prenumerantId = Convert.ToInt32(id["prenumerantId"]); 
            Prenumeranter prenumerant = new Prenumeranter();
            HttpClient client = api.Initial();
            HttpResponseMessage response = await client.GetAsync("api/Prenumeranter/" + prenumerantId);

            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
                prenumerant = JsonConvert.DeserializeObject<Prenumeranter>(result);
            }
            return View(prenumerant); 
        }


        public ActionResult VerifyAnnonsor()
        {
            return View(); 
        }

        public ActionResult VerifyPrenumerant()
        {
            return View(); 
        }

        [HttpPost]
        public async Task<ActionResult> CreateAdConfirmed(IFormCollection nyAnnons)
        {
            string rubrik = nyAnnons["rubrik"];
            int annonsor = Convert.ToInt32(nyAnnons["annonsor"]);
            int annonsPris = Convert.ToInt32(nyAnnons["annonspris"]);
            int pris = Convert.ToInt32(nyAnnons["pris"]);
            string innehall = nyAnnons["innehall"];

            Ads annons = new Ads();
            annons.Ad_Rubrik = rubrik;
            annons.Ad_Annonsor = annonsor;
            annons.Ad_AnnonsPris = annonsPris;
            annons.Ad_VaransPris = pris;
            annons.Ad_Innehall = innehall; 

            if (ModelState.IsValid)
            {
                HttpClient client = api.Initial();
                HttpResponseMessage response = await client.PostAsJsonAsync("api/Ads", annons);
                response.EnsureSuccessStatusCode();
                return RedirectToAction("ReadAllaAds");
            }
            else
            {
                return View(annons);
            }
        }

        public async Task<IActionResult> CreateAd(IFormCollection annonsorId)
        {
            int aId = Convert.ToInt32(annonsorId["annonsorId"]);
            Annonsorer getAnnonsor = new Annonsorer();
            Ads noAd = new Ads();
            HttpClient client = api.Initial();
            HttpResponseMessage response = await client.GetAsync("api/Annonsorer/" + aId);

            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
                getAnnonsor = JsonConvert.DeserializeObject<Annonsorer>(result);
            }

            var tuple = new Tuple<Annonsorer, Ads>(getAnnonsor, noAd);

            return View(tuple);
        }

        public ActionResult CreateAnnonsor()
        {
            return View(); 
        }

        [HttpPost]
        public async Task<ActionResult> CreateAnnonsor(Annonsorer annonsor)
        {
            if (ModelState.IsValid)
            {
                HttpClient client = api.Initial();
                annonsor.An_AnnonsPris = 40; 
                HttpResponseMessage response = await client.PostAsJsonAsync("api/Annonsorer", annonsor);
                response.EnsureSuccessStatusCode();
                return RedirectToAction("ReadAnnonsorId");
            }
            else
            {
                return View(annonsor); 
            }
        }

        public ActionResult CreateAnnonsorPrenumerant()
        {
            return View(); 
        }

        [HttpPost]
        public async Task<ActionResult> CreateAnnonsorPrenumerant(IFormCollection annonsor)
        {
            int id = Convert.ToInt32(annonsor["Pr_Id"]);
            string fornamn = annonsor["Pr_Fornamn"];
            string efternamn = annonsor["Pr_Efternamn"];
            string utdelningsadress = annonsor["Pr_Utdelningsadress"];
            string postnummer = annonsor["Pr_Postnummer"];
            string ort = annonsor["Pr_Ort"];
            string epost = annonsor["Pr_Epost"];
            string mobil = annonsor["Pr_Mobil"];
            string personnummer = annonsor["Pr_Personnummer"];

            Annonsorer nyAnnonsor = new Annonsorer(); 
            nyAnnonsor.An_Fornamn = fornamn;
            nyAnnonsor.An_Efternamn = efternamn;
            nyAnnonsor.An_Utdelningsadress = utdelningsadress;
            nyAnnonsor.An_UPostnummer = postnummer;
            nyAnnonsor.An_UOrt = ort;
            nyAnnonsor.An_Epost = epost;
            nyAnnonsor.An_Mobil = mobil;
            nyAnnonsor.An_Personnummer = personnummer;
            nyAnnonsor.An_AnnonsPris = 0; 

            if (ModelState.IsValid)
            {
                HttpClient client = api.Initial();
                HttpResponseMessage response = await client.PostAsJsonAsync("api/Annonsorer", nyAnnonsor);
                response.EnsureSuccessStatusCode();
                return RedirectToAction("ReadAnnonsorId"); 
            }
            else
            {
                return View(annonsor);
            }
        }

        public async Task<ActionResult> ReadAnnonsorId()
        {
            Annonsorer annonsorId = new Annonsorer(); 
            HttpClient client = api.Initial();
            HttpResponseMessage response = await client.GetAsync("api/AnnonsorId");
            
            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
                annonsorId = JsonConvert.DeserializeObject<Annonsorer>(result); 
            }
            return View(annonsorId);
        }

        public async Task<IActionResult> UpdateAd(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            Ads annons = new Ads();
            HttpClient client = api.Initial();
            HttpResponseMessage response = await client.GetAsync("api/Ads/" + id);

            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
                annons = JsonConvert.DeserializeObject<Ads>(result);

            }
            return View(annons);
        }

        public async Task<IActionResult> UpdateAdConfirm(IFormCollection annons)
        {
            int id = Convert.ToInt32(annons["Ad_Id"]);
            string rubrik = annons["Ad_Rubrik"];
            int pris = Convert.ToInt32(annons["Ad_VaransPris"]);
            string innehall = annons["Ad_Innehall"];

            Ads updateAnnons = new Ads();
            updateAnnons.Ad_Id = id;
            updateAnnons.Ad_Rubrik = rubrik;
            updateAnnons.Ad_VaransPris = pris;
            updateAnnons.Ad_Innehall = innehall;

            if (ModelState.IsValid)
            {
                HttpClient client = api.Initial();
                HttpResponseMessage response = await client.PutAsJsonAsync("api/Ads/" + id, updateAnnons);
                response.EnsureSuccessStatusCode();
                return RedirectToAction("ReadAllaAds");
            }
            else
            {
                return View(updateAnnons); 
            }
        }

        public async Task<ActionResult> DeleteAd(int id)
        {
            if(id == 0)
            {
                return NotFound(); 
            }

            Ads ad = new Ads();
            HttpClient client = api.Initial();
            HttpResponseMessage response = await client.GetAsync("api/Ads/" + id);

            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
                ad = JsonConvert.DeserializeObject<Ads>(result); 
            }
            return View(ad); 
        }

        [HttpPost, ActionName("DeleteAd")]
        public async Task<ActionResult> DeleteAdConfirmed(int id)
        {
            Ads ad = new Ads();
            HttpClient client = api.Initial();
            HttpResponseMessage response = await client.DeleteAsync("api/Ads/" + id);
            return RedirectToAction("ReadAllaAds"); 
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
