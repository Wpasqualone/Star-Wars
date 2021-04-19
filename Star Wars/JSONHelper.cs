using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Star_Wars.Objects;

namespace Star_Wars
{
    public class JSONHelper
    {
        static readonly HttpClient client = new HttpClient();

        public static async Task<Planet> GetPlanet(int planetID)
        {
            Planet returnPlanet = new Planet();
            try
            {
                HttpResponseMessage response = await client.GetAsync("https://swapi.dev/api/planets/" + planetID);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                returnPlanet = JsonConvert.DeserializeObject<Planet>(responseBody);
            }
            catch (HttpRequestException error)
            {
                Console.WriteLine("\n Exception caught!");
                Console.WriteLine("Message: {0}", error.Message);
            }

            return returnPlanet;
        }

        public static async Task<Person> GetPerson(int personID)
        {
            Person returnPerson = new Person();
            try
            {
                HttpResponseMessage response = await client.GetAsync("https://swapi.dev/api/people/" + personID);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                returnPerson = JsonConvert.DeserializeObject<Person>(responseBody);
            }
            catch (HttpRequestException error)
            {
                Console.WriteLine("\n Exception caught!");
                Console.WriteLine("Message: {0}", error.Message);
            }

            return returnPerson;
        }

        public static async Task<AllSpecies> GetSpecies()
        {
            AllSpecies returnSpecies = new AllSpecies();
            try
            {
                HttpResponseMessage response = await client.GetAsync("https://swapi.dev/api/species/");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                returnSpecies = JsonConvert.DeserializeObject<AllSpecies>(responseBody);
            }
            catch (HttpRequestException error)
            {
                Console.WriteLine("\n Exception caught!");
                Console.WriteLine("Message: {0}", error.Message);
            }

            return returnSpecies;
        }

        public static async Task<string> GetShipName(string URL)
        {
            Ship currentShip = new Ship();
            try
            {
                HttpResponseMessage response = await client.GetAsync(URL);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                currentShip = JsonConvert.DeserializeObject<Ship>(responseBody);
            }
            catch (HttpRequestException error)
            {
                Console.WriteLine("\n Exception caught!");
                Console.WriteLine("Message: {0}", error.Message);
            }

            return currentShip.name;
        }

    }
}
