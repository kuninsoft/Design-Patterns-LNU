using System;

namespace Lab1
{
    public class ProjectManager
    {
        private static int _counter;

        public int Id { get; }
        public EmployeeInfo Info { get; }
        public Project Project { get; }
        
        // We need this to make Id counter thread-safe
        private readonly object _locker = null;

        public ProjectManager(string name, string address, string phoneNumber, string email, float salary, Project project)
        {
            // Only one thread allowed at a time
            lock(_locker)
                Id = _counter++;
            
            Info = new EmployeeInfo(name, address, phoneNumber, email, salary);
            Project = project;
        }

        public void DiscussProgress(Developer developer)
        {
            if (Project.Developers.Contains(developer))
            {
                Console.Out.WriteLine("Bla-bla-bla...");
            }
            else
            {
                throw new ArgumentException(
                    "This developer is not taking part in the project! Discussing is against NDA!");
            }
        }
    }
}