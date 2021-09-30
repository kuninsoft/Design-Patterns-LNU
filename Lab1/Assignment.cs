using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab1
{
    public class Assignment
    {
        private readonly Dictionary<Project, DateTime> _receivedTasks;

        public Assignment()
        {
            _receivedTasks = new Dictionary<Project, DateTime>();
        }

        public void AssignProject(Project project, Developer developer)
        {
            _receivedTasks.Add(project, DateTime.MaxValue);
            project.AddDeveloper(developer);
        }

        public void UnassignProject(Project project, Developer developer)
        {
            if(_receivedTasks.ContainsKey(project))
                _receivedTasks.Remove(project);
            project.RemoveDeveloper(developer);
        }

        // Returns list of projects till certain date
        // I'm using LINQ here (C# syntax similar to SQL) for getting this list
        public List<Project> GetTasksToDate(DateTime date) =>
            (from projectDate in _receivedTasks
                where projectDate.Value.CompareTo(date) < 0
                select projectDate.Key).ToList();
    }
}