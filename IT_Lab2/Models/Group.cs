﻿namespace IT_Lab2.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Student>? Students { get; set; }
    }
}
