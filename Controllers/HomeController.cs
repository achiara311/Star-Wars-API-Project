using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SWAPI.Models;

namespace SWAPI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
          
            return View();
        }

        public async Task<People> GetPersonbyId(int id)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri($"https://swapi.co");

            var response = await client.GetAsync($"api/people/{id}");
            var person = await response.Content.ReadAsAsync<People>();
            return person;
        }

        public async Task <Planet> GetPlanetById(int id)
        {

            var client = new HttpClient();
            client.BaseAddress = new Uri($"https://swapi.co");

            var response = await client.GetAsync($"api/planets/{id}");
            var planet = await response.Content.ReadAsAsync<Planet>();
            return planet;
        }

        public IActionResult ResultsPeople(int id)
        {
            var people = GetPersonbyId(id).Result; 
            
            return View(people);
           
        }

        public IActionResult ResultsPlanet(int id)
        {
            var planet = GetPlanetById(id).Result;

            return View(planet);
        }
    }
    
}
