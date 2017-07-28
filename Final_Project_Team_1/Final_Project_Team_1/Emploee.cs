using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Team_1
{
    class Emploee
    {
        static int ID { get; set; }
        string LastName { get; set; }
        string FirstName { get; set; }
        string Patronymic { get; set; }
        string BirthDate { get; set; }
        string Position { get; set; }
        string Department { get; set; }
        int RoomNumber { get; set; }
        int ServicePhoneNumber { get; set; }
        string ServiceEMail { get; set; }
        double MonthSalary { get; set; }
        string HireDate { get; set; }
        string NotesFild { get; set; }

        public Emploee(string lastName, string firstName, string patronymic, string birthDate, string position, string department, int roomNumber, int servicePhoneNumber, string serviceEMail, double monthSalary, string hireDate, string notesFild)
        {
            LastName = lastName;
            FirstName = firstName;
            Patronymic = patronymic;
            BirthDate = birthDate;
            Position = position;
            Department = department;
            RoomNumber = roomNumber;
            ServicePhoneNumber = servicePhoneNumber;
            ServiceEMail = serviceEMail;
            MonthSalary = monthSalary;
            HireDate = hireDate;
            NotesFild = notesFild;
            ID = LoadFromFile.GetId() + 1;
            WriteToFile.WriteID(ID);
        }
        public Emploee()
        {
            Console.WriteLine("Введіть прізвище працівника");
            LastName = InitializeEmploee.InitStringField();
            Console.WriteLine("Введіть ім'я працівника");
            FirstName = InitializeEmploee.InitStringField();
            Console.WriteLine("Введіть по-батькові працівника");
            Patronymic = InitializeEmploee.InitStringField();

            Console.WriteLine("Введіть дату народження працівника у форматі ДД.ММ.РРРР");
            BirthDate = Console.ReadLine();

            Console.WriteLine("Введіть посаду працівника");
            Position = InitializeEmploee.InitStringField();
            Console.WriteLine("Введіть відділ працівника");
            Department = InitializeEmploee.InitStringField();

            Console.WriteLine("Введіть номер кімнати працівника");
            RoomNumber = Int32.Parse( Console.ReadLine());
            Console.WriteLine("Введіть службовий телефон працівника");
            ServicePhoneNumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введіть службовий емеіл працівника");
            ServiceEMail = Console.ReadLine();
            Console.WriteLine("Введіть місячну зарплату працівника");
            MonthSalary = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть дату прийняття працівника на роботу у форматі ДД.ММ.РРРР");
            HireDate = Console.ReadLine();

            Console.WriteLine("Введіть додаткову інформацію про працівника");
            NotesFild = InitializeEmploee.InitStringField();
            ID = LoadFromFile.GetId()+1;
            WriteToFile.WriteID(ID);
        }
        
    }
}
