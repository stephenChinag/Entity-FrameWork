using Entity.Data;
using Entity.Models;
using Microsoft.Extensions.Configuration;

internal class Program
{
    static void Main(string[] args)
    {
        //         IConfiguration config = new ConfigurationBuilder()
        //         .AddJsonFile("appsettings.json")
        //         .Build();


        //         // Console.WriteLine("Test");
        // Console.WriteLine(config);
        //         DataContextEF entityFramework = new DataContextEF(config);

        Computer myComputer = new Computer()
        {
            Motherboard = "Z690",
            CPUCores = 0,
            HasWifi = true,
            HasLTE = false,
            ReleaseDate = DateTime.Now,
            Price = 110.87m,
            VideoCard = "RTX 2090"
        };

        // entityFramework.Add(myComputer);
        // entityFrmework.
        // entityFramework.Add(myComputer);
        // entityFramework.SaveChanges();
        // IEnumerable<Computer>? computersEf = entityFramework.Computer?.ToList<Computer>();


        string sql = @"INSERT INTO TutorialAppSchema.Computer (
    Motherboard ,
    HasWifi ,
    HasLTE,
    ReleaseDate,
    Price,
    VideoCard
) VALUES ('" + myComputer.Motherboard
      + " ','" + myComputer.HasWifi
      + " ','" + myComputer.HasLTE
      + " ','" + myComputer.ReleaseDate
      + " ','" + myComputer.Price
      + " ','" + myComputer.VideoCard

      + "')\n";
        // File.WriteAllText("log.txt", sql);

        using StreamWriter openFile = new ("log.txt", append: true);
        openFile.WriteLine(sql);
    }



}
