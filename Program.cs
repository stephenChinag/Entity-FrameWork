using System.Text.Json;
using Entity.Data;
using Entity.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

internal class Program
{
    static void Main(string[] args)
    {


        // IConfiguration config = new ConfigurationBuilder()
        // .AddJsonFile("appsettings.json").Build();

        // IConfiguration config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
        // DataContextDapper dapper = new DataContextDapper(config);



        // string ComputersJson = File.ReadAllText("Computers.json");

        // JsonSerializerOptions options = new JsonSerializerOptions()
        // {
        //     PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        // };

        IEnumerable<Computer>? computers = JsonConvert.DeserializeObject<IEnumerable<Computer>>(File.ReadAllText("Computers.json"));


        if (computers != null)
        {
            foreach (Computer computer in computers)
            {
                Console.WriteLine($" {computer.Motherboard}");
            }
        }
        else
        {
            Console.WriteLine("No computers found.");
        }

        string computersCopy = JsonConvert.SerializeObject(computers, Formatting.Indented);
        File.WriteAllText("ComputersCopy.json", computersCopy);

    }



}
