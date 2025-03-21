using Entity.Data;
using Entity.Models;

internal class Program
{
    static void Main(string[] args)
    {

        // Console.WriteLine("Test");

        DataContextEF entityFramework = new DataContextEF();

        Computer myComputer = new Computer()
        {
            Motherboard = "Z690",
            CPUCores = 0 ,
            HasWifi = true,
            HasLTE = false,
            ReleaseDate = DateTime.Now,
            Price = 110.87m,
            VideoCard = "RTX 2090"
        };

        // entityFramework.Add(myComputer);
        // entityFrmework.
        entityFramework.Add(myComputer);
        entityFramework.SaveChanges();
        IEnumerable<Computer>? computersEf = entityFramework.Computer?.ToList<Computer>();


        if (computersEf != null)
        {


            foreach (Computer singleComputer in computersEf)
            {

                Console.WriteLine(
         "'" + singleComputer.ComputeId
         + "','" + singleComputer.Motherboard
         + "','" + singleComputer.HasWifi
         + "','" + singleComputer.HasLTE
         + "','" + singleComputer.ReleaseDate
         + "','" + singleComputer.Price
         + "','" + singleComputer.VideoCard
         + "'"
     );
            }
        }


    }
}
