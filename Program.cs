
using SchoolManagementPractice;



public class Program
{
    public static void Main(string[] args)
    {
        //I created few student and teacher objects from
        //PersonClass and i print their informations via using methods

        PersonClass StudentOne = new PersonClass();

        {
            StudentOne.Name = "Yiğit";
            StudentOne.Surname = "Gökmen";
            StudentOne.DateOfBirth = 1998;

            StudentOne.showStudent();

        }

        Console.WriteLine("");

        PersonClass StudentTwo = new PersonClass();

        {
            StudentTwo.Name = "Ali";
            StudentTwo.Surname = "Veli";
            StudentTwo.DateOfBirth = 2000;

            StudentTwo.showStudent();

        }

        Console.WriteLine("");

        PersonClass TeacherOne = new PersonClass();
        {

            TeacherOne.Name = "Öğretmen Hasan";
            TeacherOne.Surname = "Ali";
            TeacherOne.DateOfBirth = 1980;

            TeacherOne.showTeacher();
        }









    }

}




