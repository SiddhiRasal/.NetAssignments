using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class MCAStudent:Student
    {

        Student student = new Student();
        public void getMarks()
        {
            List<int> list = new List<int>();
            Console.WriteLine("How many subjects");
            student.noOfSubjects = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= student.noOfSubjects; i++)
            {
                Console.WriteLine(String.Format("Enter Marks for subject {0} Out of 100:", i));
                list.Add(Convert.ToInt32(Convert.ToInt32(Console.ReadLine())));
            }
            student.total = list.Sum();
        }

        public override void CalculatePercentage()
        {
            double percentage;
            getMarks();
            percentage = student.total / student.noOfSubjects;
            Console.WriteLine("Percentage is : " + percentage + " % ");
        }

    }
}
