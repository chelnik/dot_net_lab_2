namespace IT_Lab2.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public bool ClassLeader { get; set; }
        public int GroupId { get; set; }
        public virtual Group? Group { get; set; }
    }
}
