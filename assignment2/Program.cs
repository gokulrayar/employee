using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id = 12;
            string name = "sam";
            char gender = 'M';
            double salary = 99000.90;
            DateTime dateOfJoining = new DateTime(2012, 12, 12);

            if(salary > 900000)
            {
                double tax = salary * 0.3;
                Console.WriteLine( "Employee with Id {0},Name{1},Gender{2} and salary{3} has to pay 30% tax.", id, name, gender, salary);
                Console.WriteLine("Tax to be paid:{0}", tax);
            }
            else
            {
                double tax = salary * 0.15;
                Console.WriteLine("Employee with ID {0},Name{1},Gender{2},and salary {3} has to pay 15% tax.", id, name, gender, salary);
                Console.WriteLine("Tax to be paid: {0}", tax);
            }
        }
    }
}
