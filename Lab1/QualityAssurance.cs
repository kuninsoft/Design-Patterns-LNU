using System.Collections.Generic;

namespace Lab1
{
    public class QualityAssurance
    {
        private static int _counter;

        public int Id { get; }
        public EmployeeInfo Info { get; }
        public string Position { get; }
        public string Rank { get; }

        private readonly List<Project> _assignedProjects;
        
        // We need this to make Id counter thread-safe
        private readonly object _locker = null;

        public QualityAssurance(string name, string address, string phoneNumber, string email, float salary, string position, string rank)
        {
            // Only one thread allowed at a time
            lock(_locker)
                Id = _counter++;
            
            Info = new EmployeeInfo(name, address, phoneNumber, email, salary);
            Position = position;
            Rank = rank;

            _assignedProjects = new List<Project>();
        }
    }
}