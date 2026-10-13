
using System.Text;
using SchoolSystem;
class Program
{


    static void Main(string[] args)
    {
        

        var schoolReport = new SchoolReport("Annual Report");
        schoolReport.DisplayReportTitle();

        // Create a new student object
        var ahmad =new Student("Ahmad");
        ahmad.Age = 15;
        ahmad.StudentId = "S12345";
        ahmad.Grade = 10;
        ahmad.DisplayInfo();
        ahmad.DisplayStudentInfo();
        var mohammad =new Student("Mohammad");
        mohammad.Age = 16;
        mohammad.StudentId = "S14715";
        mohammad.Grade = 70;
        mohammad.DisplayInfo();
        mohammad.DisplayStudentInfo();


        // Create a new teacher object
        var teacher = new Teacher( "Mr. Smith");
        teacher.Subject = "Mathematics";
        teacher.Age = 35;
        teacher.DisplayTeacherInfo();



    }

}



