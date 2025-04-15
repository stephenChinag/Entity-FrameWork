using Microsoft.EntityFrameworkCore;

namespace Entity.Models
{

    public class Computer
    {
        public int ComputeId { get; set; }
        public string Motherboard { get; set; }
        public int? CPUCores { get; set; }

        public bool HasWifi { get; set; }
        public bool HasLTE { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public Decimal Price { get; set; }
        public string VideoCard { get; set; }
        public Computer()
        {

            VideoCard ??= "";
            Motherboard ??= "";
            CPUCores ??= 0;
        }


    }


}