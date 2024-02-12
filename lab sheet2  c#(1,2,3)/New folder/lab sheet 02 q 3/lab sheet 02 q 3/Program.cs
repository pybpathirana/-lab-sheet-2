using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab_sheet_02_q_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TemparetureTracker temp = new TemparetureTracker();
            temp.Input();
            temp.Display();
        }

        public class TemparetureTracker
        {
             double[] myarray = new double[7];

            public void Input()
            {
                for (int i = 0; i < 7; i++)
                {
                    Console.WriteLine("Enter temperature: ");
                    myarray[i] = double.Parse(Console.ReadLine());
                }
            }

            public void Display()
            {
                Console.WriteLine(" Weekly Temperature Report");
                for (int i = 0; i < 7; i++)
                {
                    Console.WriteLine(myarray[i]);
                }
            }
        }
    }
}
