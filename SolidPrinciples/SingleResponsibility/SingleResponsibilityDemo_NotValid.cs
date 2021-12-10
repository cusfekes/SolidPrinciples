
namespace SolidPrinciples.SingleResponsibility_NotValid
{
    public class SingleResponsibilityDemo
    {
        public static void Main()
        {
            // Create temp students
            Student student1 = new Student(100, "Kate", "Olsen", 22, "kate@live.com");
            Student student2 = new Student(101, "Jack", "Curry", 23, "jack@live.com");
            Student student3 = new Student(102, "Elizabeth", "Smith", 25, "elizabeth@live.com");

            // Add students to class
            Classroom classroom = new Classroom();
            classroom.AddStudent(student1);
            classroom.AddStudent(student2);
            classroom.AddStudent(student3);

            // Display students
            classroom.ListClassroom();

            //Remove a student from classroom
            classroom.RemoveStudent(1);

            // Display all students again
            classroom.ListClassroom();

            // Send mail to student
            classroom.SendMailToStudent(100, "this text is mail body");
        }
    }

    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }

        public string Email { get; set; }

        public Student(int id, string name, string surname, int age, string email)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Age = age;
            Email = email;
        }
    }

    public class Classroom
    {
        private readonly List<Student> students = new List<Student>();
        private readonly List<int> scores = new List<int>();

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void RemoveStudent(int index)
        {
            students.RemoveAt(index);
        }

        public Student? GetStudentById(int id)
        {
            return students.Where(i => i.Id == id).FirstOrDefault();
        }

        public void ListClassroom()
        {
            Console.WriteLine("\nStudent List--------------------");
            foreach (var student in students)
            {
                Console.WriteLine($"{ student.Id} : {student.Name} {student.Surname}");
            }
            Console.WriteLine("--------------------------------");
        }

        public void AddScoreToClass(int score)
        {
            scores.Add(score);
        }

        public void SendMailToStudent(int studentId, string mailBody)
        {
            Student student = GetStudentById(studentId);
            string email = student.Email;
            SendMail(mailBody, email);
        }

        private void SendMail(string mailBody, string email)
        {
            //....
        }
    }
}
