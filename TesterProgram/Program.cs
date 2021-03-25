using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesLibrary;

namespace TesterProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Student Info Below:");

           Student v1 = new Student();
            v1.FirstName = " Bob ";
            v1.LastName = "Johnson";
            v1.Id = "idisid";
            v1.Gpa = 3.0f;
            Console.WriteLine(v1);

            Student v2 = new Student("Sue", "Johnson", "idisid", 3.0f);
            Console.WriteLine(v2);
        }
    }
}
