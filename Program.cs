using System.Text.Json;
using AutoMapper;
using Entity.Data;
using Entity.Models;
using Entity_Framework.Models;
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

        // IEnumerable<Computer>? computers = JsonConvert.DeserializeObject<IEnumerable<Computer>>(File.ReadAllText("Computers.json"));
        string ComputersJson = File.ReadAllText("ComputersSnake.json");
        Mapper mapper = new Mapper(new MapperConfiguration(cfg =>
        {


            cfg.CreateMap<ComputersSnake, Computer>()
            .ForMember(destination => destination.ComputeId, opt => opt.MapFrom(src => src.computer_id)).
            ForMember(destination => destination.Motherboard, opt => opt.MapFrom(src => src.motherboard)).
            ForMember(destination => destination.CPUCores, opt => opt.MapFrom(src => src.cpu_cores)).
            ForMember(destination => destination.VideoCard, opt => opt.MapFrom(src => src.video_card)).
            ForMember(destination => destination.ReleaseDate, opt => opt.MapFrom(src => src.release_date)).
            ForMember(destination => destination.Price, opt => opt.MapFrom(src => src.price)).
            ForMember(destination => destination.HasWifi, opt => opt.MapFrom(src => src.has_wifi)).
            ForMember(destination => destination.HasLTE, opt => opt.MapFrom(src => src.has_lte));
        }));
        // if (computers != null)
        // {
        //     foreach (Computer computer in computers)
        //     {
        //         Console.WriteLine($" {computer.Motherboard}");
        //     }
        // }
        // else
        // {
        //     Console.WriteLine("No computers found.");
        // }

        // string computersCopy = JsonConvert.SerializeObject(computers, Formatting.Indented);
        // File.WriteAllText("ComputersCopy.json", computersCopy);

    }



}
