
using Assignment1;

Student student=new Student();
Student mcaStudent = new MCAStudent();
Student bscStudent = new BSCStudent();

Console.WriteLine("Enter Degree Class MCA or BSC");
string stream = Console.ReadLine();

if (stream == "MCA")
{
    student.showDetails();
    mcaStudent.CalculatePercentage();

}
else
{
    student.showDetails();
    bscStudent.CalculatePercentage();
}

