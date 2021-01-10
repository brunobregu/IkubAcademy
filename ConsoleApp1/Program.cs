using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ushtrimi 3- Tema 2
            Console.WriteLine("Vendosni numrin e studenteve ne klase: ");
            int studentNumber = int.Parse(Console.ReadLine());
            string[] studentName = new string[studentNumber];
            double[] studentGrade = new double[studentNumber];

            for(int i = 0; i < studentNumber; i++)
            {
                Console.WriteLine("Vendosni emrin e studentit numer: " + (i + 1));
                string emri = Console.ReadLine();
                studentName[i] = emri;
                Console.WriteLine("Vendosni noten per studentin : " + studentName[i]);
                double nota = Convert.ToDouble(Console.ReadLine());
                studentGrade[i] = nota;
            }

            Console.WriteLine("-------Te dhenat qe ju vendoset--------");
            for(int i = 0; i < studentNumber; i++)
            {
                Console.WriteLine("Studenti " + studentName[i] + " ka marre noten " + studentGrade[i]);
            }


            
            double S = 0;
            int poz = 0;
            double max = studentGrade[0];

            for(int i = 0; i < studentNumber; i++)
            {
                S += studentGrade[i];
                if(studentGrade[i] > max)
                {
                    max = studentGrade[i];
                    poz = i;
                }
            }
            double Mes = (S / studentNumber) * 1.0;

            List<string> Name = new List<string>();
            for (int i = 0; i < studentNumber; i++)
            {
                if(studentGrade[i] == studentGrade[poz])
                {
                    Name.Add(studentName[i]);
                }
            }

            Console.WriteLine("----------Studenti/et me note me te larte -------");
            foreach(var item in Name)
            {
                Console.WriteLine("Studenti me note me te larte eshte " + item + " qe ka marre noten " + max + "\n");
            }
            
            Console.WriteLine("---------- Mesatarja e klases -------");
            Console.WriteLine("Klasa ka mesatare " + Mes);

            //Ushtrimi 2 - Tema 2
            Console.WriteLine("Vendosni pagen per 10 punonjes");
            int[] pagat = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Vendos pagen e punonjesit: " + (i + 1));
                int paga = Convert.ToInt32(Console.ReadLine());
                pagat[i] = paga;
            }

            Console.WriteLine("-------Pagat e punonjesve -------");

            foreach (int items in pagat)
            {
                Console.WriteLine(items);
            }

            Console.WriteLine("-----Taksat per cdo page ------");

            foreach (int items in pagat)
            {
                var taksat = new Taxpayer(items);
                Console.WriteLine("Punonjesi me page: " + items + " paguan " + taksat.TaxOwed + "$ takse");
            }

            //Ushtrimi-1 Tema 1

            var afisho = new First();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Punonjesi " + afisho.Name[i] + "  ka page " + afisho.Salary[i] +
                    "  $ ne muaj dhe eshte punesuar ne daten  " + afisho.Date[i]);
            }
            Console.ReadKey();
        }
    }
}
