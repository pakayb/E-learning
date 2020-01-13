namespace ELearningV2.Models
{
    public class Part
    {
        public long Id { get; set; }
        public int PartNumber { get; set; }
        public long LessonId { get; set; }
        public string Context { get; set; }
    }
}