namespace Entity_Framework.Models
{
    public class ComputersSnake
    {
        public int computer_id { get; set; }
        public string motherboard { get; set; }

        public bool has_lte { get; set; }
        public bool has_wifi { get; set; }
        public DateTime? release_date { get; set; }
        public Decimal price { get; set; }
        public string video_card { get; set; }

        public int? cpu_cores { get; set; }


        public ComputersSnake()
        {


            if (video_card == null)
            {
                video_card = string.Empty;
            }
            if (motherboard == null)
            {
                motherboard = string.Empty;
            }
            if (cpu_cores == null)
            {
                cpu_cores = 0;
            }
        }
    }
}



