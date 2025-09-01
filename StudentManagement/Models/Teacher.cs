namespace StudentManagement.Models
{
    public class Teacher : Person
    {
        public string Subject { get; private set; }

        public Teacher(string name, int age, string subject)
        : base(name, age)
        {
            Subject = subject;
        }

        public override void ShowInfo()
        {
            System.Console.WriteLine($"[Teacher] Name: {Name}, Age:{Age},Subject:{Subject}");
        }
    }
}