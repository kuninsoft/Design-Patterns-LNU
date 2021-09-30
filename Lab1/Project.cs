using System;
using System.Collections.Generic;

namespace Lab1
{
    public class Project
    {
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public List<string> TaskList { get; set; }
        public List<Developer> Developers { get; set; }

        public Project(string title, DateTime startDate)
        {
            Title = title;
            StartDate = startDate;

            TaskList = new List<string>();
            Developers = new List<Developer>();
        }
        
        public void AddDeveloper(Developer developer)
        {
            if (!Developers.Contains(developer))
                Developers.Add(developer);
        }

        public void RemoveDeveloper(Developer developer)
        {
            if (Developers.Contains(developer))
                Developers.Remove(developer);
        }
    }
}