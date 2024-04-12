namespace asptask2.Models
{
    public class CourseResult
    {
        public int Id { get; set; }
        public float Degree { get; set; }
        public int crs_id { get; set; }
        public Course course { get; set; }
        public Trainee trainee { get; set; }

    }
}
