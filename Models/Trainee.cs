namespace asptask2.Models
{
    public class Trainee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Address { get; set; }
        public float Grade { get; set; }
        public Department Department { get; set; }

    }
}
