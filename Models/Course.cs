namespace asptask2.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Degree { get; set; }
        public float Mindegree { get; set; }
        public Department Department { get; set; }
    }
}
