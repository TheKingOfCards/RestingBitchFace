using RestSharp;
using System.Text.Json;

RestClient client = new("https://swapi.py4e.com/api/");


string search = "2";
Console.WriteLine("Put in a single number to find the planet you want");

search = Console.ReadLine();
Console.Clear();

RestRequest request = new($"planets/{search}/");

RestResponse response = client.GetAsync(request).Result;

// Console.WriteLine(response.Content);

File.WriteAllText("pokemon.json", response.Content);

StarWarsPlanet planet = JsonSerializer.Deserialize<StarWarsPlanet>(response.Content);


Console.WriteLine("Name: " + planet.name);
Console.WriteLine("Population: " + planet.population);
Console.WriteLine("Terrain: " + planet.terrain);
Console.WriteLine("Rotation Period: " + planet.rotation_period);
Console.WriteLine("Orbital Period: " + planet.orbital_period);


Console.ReadLine();