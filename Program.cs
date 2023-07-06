using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace grades
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("students.txt");
            int br2 = 0; int br3 = 0; int br4 = 0; int br5 = 0; int br6= 0;
            string line = "";
            while (line != null)
            {
                line = reader.ReadLine();
                if (line == "2")
                {
                    br2++;
                }
                else if (line == "3")
                {
                    br3++;
                }
                else if (line == "4")
                {
                    br4++;
                }
                else if (line == "5")
                {
                    br5++;
                }
                else if (line == "6")
                {
                    br6++;
                }
            }
            reader.Close();

            StreamWriter Writer = new StreamWriter("output.txt");
            Writer.WriteLine("Двойки: "+br2);
            Writer.WriteLine("Тройки: " + br3);
            Writer.WriteLine("Четворки: " + br4);
            Writer.WriteLine("Петици: " + br5);
            Writer.WriteLine("Шестици: " + br6);
            Writer.Close();
           
        }
    }
}
