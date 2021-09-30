namespace Lab1
{
    public struct EmployeeInfo
    {
        public string Name { get; }
        public string Address { get; }
        public string PhoneNumber { get; }
        public string Email { get; }
        public float Salary { get; }

        public EmployeeInfo(string name, string address, string phoneNumber, string email, float salary)
        {
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;
            Salary = salary;
        }
    }
}