namespace UTS_72220538.Model

{
    
    public class Courses
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string ImageName { get; set; }
        public int Duration { get; set; }
        public string Description { get; set; }
        public Categories Categories { get; set; } = new Categories();
    }
}
