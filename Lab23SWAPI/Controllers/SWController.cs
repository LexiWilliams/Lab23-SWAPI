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
        public async Task<IActionResult> GetPersonByName()
        {
            var personList = await GetPersonList();
            return View(personList);
        }
        public async Task<IActionResult> GetPlanetByName()
        {
            var planetList = await GetPlanetList();
            return View(planetList);
        }
        public async Task<PlanetList> GetPlanetList()
        {
            var client = GetHttpClient();
            var response = await client.GetAsync($"api/planets");
            var planetList = await response.Content.ReadAsAsync<PlanetList>();
            return planetList;
        }
        public async Task<PersonList> GetPersonList()
        {
            var client = GetHttpClient();
            var response = await client.GetAsync($"api/people");
            var personList = await response.Content.ReadAsAsync<PersonList>();
            return personList;
        }
        public async Task<Person> GetPersonById(int index)
        {
            var client = GetHttpClient();
            var response = await client.GetAsync($"api/people/{index}");
            var person = await response.Content.ReadAsAsync<Person>();           
            return person;
        }
        public async Task<Person> GetPersonByUrl(string url2)
        {
            var client = GetHttpClient();
            var response = await client.GetAsync($"{url2}");
            var person = await response.Content.ReadAsAsync<Person>();
            return person;
        }
        public async Task<Planet> GetPlanetByUrl(string nameURL)
        {
            var client = new HttpClient();


            var response = await client.GetAsync($"{nameURL}");
            var planet = await response.Content.ReadAsAsync<Planet>();
            return planet;
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
        public IActionResult ResultPlanetIndex(int index)
        {
            var planet = GetPlanetById(index).Result;
            return View(planet);
        }
        public IActionResult ResultPersonIndex(int index)
        {
            var person = GetPersonById(index).Result;
            return View(person);
        }
        public async Task<IActionResult> ResultPersonName(string nameURL)
        {
            string url1 = nameURL.Remove(0, 17);
            string url2 = url1.TrimEnd('/');
            var person = await GetPersonByUrl(url2); //must await async methods
            return View(person);
        }
        public async Task<IActionResult> ResultPlanetName(string nameURL)
        {
            var planet = await GetPlanetByUrl(nameURL); //must await async methods
            return View(planet);
        }
    }
}