using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementPractice
{
    public class PersonClass
    {
            //In order to encapsulate. These features should be in private 
            private string name;
            private string surName;
            private int dateOfBirth;
         
            //In order to reach properties. I declared them as public.
            public string Name
            {
                get
                {
                    return name;

                }
                set
                {
                    name = value;
                }

            }

            public string Surname
            {
                get
                {
                    return surName;
                }

                set
                {
                     surName = value;
                    
                }
            }

            public int DateOfBirth
            {
                get
                {
                return dateOfBirth;
                }
                set
                {
                    if (value >= 1960)
                    {
                    dateOfBirth = value;
                    }
                }

            }

            public void showStudent()
            {
            Console.WriteLine($"Öğrencinin adı:  {name}\nSoyadı :  {surName}\nDoğumTarihi : {DateOfBirth}");
        }




        public void showTeacher()
        {
            Console.WriteLine($"Öğretmenin adı:  {name}\n Soyadı :  {surName}\nDoğumTarihi : {DateOfBirth}");
        }













    }
}
