using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class First
    {
        public string[] Name { get; set; }
        public int[] Salary { get; set; }
        public string[] Date { get; set; }
        public First() {
            Name = new string[10] { "A1", "A2","A3", "A4", "A5", "A6", "A7", "A8", "A9", "A10" };

            Salary = new int[10] { 200, 300, 400, 100, 200, 600, 800, 200, 600, 200 };
            
            Date = new string[10] { "26/12/2020", "24/12/2020", "25/11/2020" , "6/10/2020" , "26/12/2020" , "26/12/2020" , "26/12/2020" , "26/12/2020" , "26/12/2020" , "26/12/2020"};
            
        }

        public void Afisho()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(Name[i] + " , " + Salary[i] + " , " + Date[i]);
            }
        }
        public First(string[] emri, int[] paga, string[] data)
        {
            for (int i = 0; i < 10; i++)
            {
                Name[i] = emri[i];
                Salary[i] = paga[i];
                Date[i] = data[i];
            }


        }


    }
}
