using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            List<Person> people = new List<Person>();
            List<Organization> organizations = new List<Organization>();
            List<Friend> friends = new List<Friend>();

            for (int i = 0; i < random.Next(1, 100); i++)
            {
                Person person = new Person();
                Organization organization = new Organization();
                Friend friend = new Friend();

                person.Name = string.Format("Name_{0}", random.Next(1, 30));
                person.Adress = string.Format("Adress_{0}", random.Next(1, 30));
                person.PhoneNumber = string.Format("PhoneNumber_8{0}", + random.Next(0000000000, 999999999));

                organization.Name = string.Format("OrgName_{0}", random.Next(1, 30));
                organization.Adress = string.Format("Adress_{0}", random.Next(1, 30));
                organization.PhoneNumber = string.Format("PhoneNumber_8{0}", + random.Next(0000000000, 999999999));
                organization.Fax = string.Format("Fax_{0}", random.Next(000000, 999999));
                organization.ContactPerson = string.Format("ContactPerson_{0}", random.Next(1, 100));

                friend.Name = string.Format("Name_{0}", random.Next(1, 30));
                friend.Adress = string.Format("Adress_{0}", random.Next(1, 30));
                friend.PhoneNumber = string.Format("PhoneNumber_8{0}", 8 + random.Next(0000000000, 999999999));
                friend.BirthDay = DateTime.Now.AddDays(random.Next(10000));


                people.Add(person);
                organizations.Add(organization);
                friends.Add(friend);
            }


            Console.WriteLine("Кого вы хотите найти?");
            Console.WriteLine("1. Человека");
            Console.WriteLine("2. Организацию");
            Console.WriteLine("3. Друга/знакомого");
            int choise = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------");
            bool isFind = false;

            switch (choise)
            {
                case 1:
                    {
                        Console.WriteLine("-----------------------------");
                        Console.WriteLine("Введите его фамилию");
                        string SeconName = Console.ReadLine();
                        foreach (Person person in people)
                        {
                            if (person.Name == SeconName)
                            {
                                person.ShowInfo();
                                isFind = true;
                                Console.WriteLine();
                            }
                        }
                    }
                    break;

                case 2:
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Введите ее название");
                    string Name = Console.ReadLine();
                    foreach (Organization organization in organizations)
                    {
                        if (organization.Name == Name)
                        {
                            organization.ShowInfo();
                            isFind = true;
                            Console.WriteLine();
                        }
                    }
                    break;
                case 3:
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Введите его фамилию:");
                    string SecondName = Console.ReadLine();
                    foreach (Friend friend in friends)
                    {
                        if (friend.Name == SecondName)
                        {
                            friend.ShowInfo();
                            isFind = true;
                            Console.WriteLine();
                        }
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Неверные данные");
                    }
                    break;
            }

            
            Console.WriteLine();
            if (!isFind)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("----------------------------------");
                Console.WriteLine();
                Console.WriteLine("Информации об этом у нас нет!");
                Console.WriteLine();
                Console.WriteLine("----------------------------------");
            }
            Console.WriteLine();
            
            Console.ResetColor();
        }
    }
}
