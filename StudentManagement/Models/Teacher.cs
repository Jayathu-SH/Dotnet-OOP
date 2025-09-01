namespace StudentManagement.Models
{
    public class Teacher : Person//inheritence
    {
        public string Subject { get; private set; }//encapsulation

        public Teacher(string name, int age, string subject)
        : base(name, age)//inheritence
        {
            Subject = subject;
        }

        public override void ShowInfo()//polymorphism
        {
            System.Console.WriteLine($"[Teacher] Name: {Name}, Age:{Age},Subject:{Subject}");
        }
    }
}