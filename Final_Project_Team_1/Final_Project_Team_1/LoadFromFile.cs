using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Team_1
{
    class LoadFromFile
    {
        public static int GetId()
        {
            int tempId;

            using (StreamReader reader = new StreamReader($"C:\\Users\\Romario\\Desktop\\C#\\Final-project-Team-1\\Final_Project_Team_1\\Final_Project_Team_1\\ID.dat"))
            {
                string readStr;
                readStr = reader.ReadLine();
                tempId = Int32.Parse(readStr);
            }
            return tempId;
        }

    }

}


