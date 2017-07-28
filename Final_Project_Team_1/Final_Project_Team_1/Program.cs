using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Team_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LoadFromFile.GetId());
            MailAddress email = new MailAddress("dsfsdfsd@ddd.com");
            Emploee e1 = new Emploee();
            Console.WriteLine(LoadFromFile.GetId());
        }
    }
}
