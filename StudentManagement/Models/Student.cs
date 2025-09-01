namespace StudentManagement.Models
{
    public class Student : Person//inheritence
    {
        public string StudentId { get; private set; }

        public Student(string name, int age, string studentId)
        : base(name, age)//inheritence
        {
            StudentId = studentId;
        }

        public override void ShowInfo()//polymorphism
        {
            System.Console.WriteLine($"[Student] Name: {Name},Age:{Age},ID: {StudentId}");
        }
    }
}