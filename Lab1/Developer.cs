using System;
using System.Collections.Generic;

namespace Lab1
{
    public class Developer
    {
        private static int _counter;

        public int Id { get; }
        public EmployeeInfo Info { get; }
        public int Position { get; }
        public string Rank { get; }

        private readonly Assignment _assignment;

        // We need this to make Id counter thread-safe
        private readonly object _locker = null;

        public Developer(string name, string address, string phoneNumber, string email, float salary, int position, string rank)
        {
            // Only one thread allowed at a time
            lock(_locker)
                Id = _counter++;
            
            Info = new EmployeeInfo(name, address, phoneNumber, email, salary);
            Position = position;
            Rank = rank;

            _assignment = new Assignment();
        }

        // We can assign project only if it is not already assigned
        public bool AssignPossibility(Project project) =>
            !project.Developers.Contains(this);

        public List<Project> AssignedProjects() => 
            _assignment.GetTasksToDate(DateTime.Now);

        public void Assign(Project project) => 
            _assignment.AssignProject(project, this);

        public void Unassign(Project project) => 
            _assignment.UnassignProject(project, this);
    }
}