namespace lab3.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string FIO { get; set; }
        public int Age { get; set; }

        public int Rent_id { get; set; }

        public Rent? Rent { get; set; }
    }

}
}