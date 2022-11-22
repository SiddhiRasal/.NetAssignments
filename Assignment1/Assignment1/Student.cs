using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Student
    {
        public int noOfSubjects;
        public int total;
        public  void showDetails()
        {
         
            Console.WriteLine("Enter Student Roll No");
            int RollNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Student Name");
            string name = Console.ReadLine();
        }
        public virtual void CalculatePercentage()
        {
            Console.WriteLine("inside base class");
        }
        
    }
}
