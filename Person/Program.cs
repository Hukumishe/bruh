using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            List<Abiturient> abiturients = new List<Abiturient>();
            List<Student> students = new List<Student>();
            List<Teacher> teachers = new List<Teacher>();

            for (int i = 0; i < random.Next(1, 100); i++)
            {
                Abiturient abiturient = new Abiturient();
                Student student = new Student();
                Teacher teacher = new Teacher();


                abiturient.SecondName = string.Format("SecondName_{0}", random.Next(1, 30));
                abiturient.BirthDay =  DateTime.Now.AddDays(-random.Next(10000));
                abiturient.Faculty = string.Format("Faculty_{0}", random.Next(1, 50));

                student.SecondName = string.Format("SecondName_{0}", random.Next(1, 30));
                student.Faculty = string.Format("Faculty_{0}", random.Next(1, 50));
                student.BirthDay = DateTime.Now.AddDays(-random.Next(10000));
                student.Course = random.Next(1, 6);

                teacher.SecondName = string.Format("SecondName_{0}", random.Next(1, 30));
                teacher.Faculty = string.Format("Faculty_{0}", random.Next(1, 50));
                teacher.Position = string.Format("Position{0}", random.Next(1, 50));
                teacher.Experience = DateTime.Now.AddDays(-random.Next(7000));
                teacher.BirthDay = DateTime.Now.AddDays(-random.Next(15000));
                

                abiturients.Add(abiturient);
                students.Add(student);
                teachers.Add(teacher);
            }

            
                Console.WriteLine("Введите диапозон:");
                int AgeStart = int.Parse(Console.ReadLine());
                int AgeEnd = int.Parse(Console.ReadLine());
                Console.WriteLine(" -- Результат поиска -- ");
                bool isFind = false;

                Console.WriteLine("Абитуриенты");
                foreach (Abiturient abiturient in abiturients)
                {
                    if (abiturient.BirthDay.Year <= AgeStart || abiturient.BirthDay.Year >= AgeEnd)
                    {
                        abiturient.ShowInfo();
                        Console.WriteLine("Текущий возраст: " + (DateTime.Now.Year - abiturient.BirthDay.Year));
                        isFind = true;
                        Console.WriteLine();
                    }

                }


                Console.WriteLine();
                Console.WriteLine("Студенты");
                foreach (Student student in students)
                {
                    if (student.BirthDay.Year <= AgeStart || student.BirthDay.Year >= AgeEnd)
                    {
                        student.ShowInfo();
                        Console.WriteLine("Текущий возраст: " + (DateTime.Now.Year - student.BirthDay.Year));
                        isFind = true;
                        Console.WriteLine();
                    }

                }

                Console.WriteLine();
                Console.WriteLine("Учителя");
                foreach (Teacher teacher in teachers)
                {
                    if (teacher.BirthDay.Year <= AgeStart || teacher.BirthDay.Year >= AgeEnd)
                    {
                        teacher.ShowInfo();
                        Console.WriteLine("Текущий возраст: " + (DateTime.Now.Year - teacher.BirthDay.Year));
                        isFind = true;
                        Console.WriteLine();
                    }

                }
                Console.WriteLine("----------------------------------");
                Console.WriteLine();
                if (!isFind)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Подобных студентов у нас нет!");
                }
                Console.WriteLine();
                Console.WriteLine("----------------------------------");
                Console.ReadLine();
        }
    }
}
