namespace StudentManagement.Models
{
    public class Student : Person
    {
        public string StudentId { get; private set; }

        public Student(string name, int age, string studentId)
        : base(name, age)
        {
            StudentId = studentId;
        }

        public override void ShowInfo()
        {
            System.Console.WriteLine($"[Student] Name: {Name},Age:{Age},ID: {StudentId}");
        }
    }
}