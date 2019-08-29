using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Lab23SWAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab23SWAPI.Controllers
{
    public class SWController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public async Task<Person> GetPersonById(int index)
        {
            var client = GetHttpClient();
            var response = await client.GetAsync($"api/people/{index}");
            var person = await response.Content.ReadAsAsync<Person>();           
            return person;
        }
        public async Task<Planet> GetPlanetById(int index)
        {
            var client = GetHttpClient();

            var response = await client.GetAsync($"api/planets/{index}");
            var planet = await response.Content.ReadAsAsync<Planet>();
            return planet;
        }
        public static HttpClient GetHttpClient()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://swapi.co");
            return client;
        }
        public IActionResult ResultPlanet(int index)
        {
            var planet = GetPlanetById(index).Result;
            return View(planet);
        }
        public IActionResult ResultPerson(int index)
        {
            var person = GetPersonById(index).Result;
            return View(person);
        }
    }
}