using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuotientAndReminder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Dividend");
            int Dividend =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Divisor");
            int Divisor = Convert.ToInt32(Console.ReadLine());

            float Quotient = Dividend / Divisor;
            float Reminder = Dividend % Divisor;
            Console.WriteLine("Quotient ="+Quotient);
            Console.WriteLine("Reminder ="+Reminder);
        }
    }
}
