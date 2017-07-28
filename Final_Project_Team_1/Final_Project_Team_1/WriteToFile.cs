using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Team_1
{
    class WriteToFile
    {
        public static void WriteID(int ID)
        {
            using (StreamWriter writer = new StreamWriter($"C:\\Users\\Romario\\Desktop\\C#\\Final-project-Team-1\\Final_Project_Team_1\\Final_Project_Team_1\\ID.dat"))
            {
                string writeStr = ID.ToString();
                writer.WriteLine(writeStr);
            }

        }
        public static void WriteEmploeeObj(Emploee obj)
        {

        }
        public static void WriteEmploeToCollection(Emploee obj) { }
    }
}
