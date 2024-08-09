using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass_SchoolManagementSystem
{
    public class Person
    {
        public string name;
        public string surname;
        public DateTime dateOfBirth;

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
                return surname;
            }
            set
            {
                surname = value;
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                return dateOfBirth;
            }
            set
            {
                dateOfBirth = value;
            }
        }

        public void TeacherInformation()
        {
            Console.WriteLine("Öğretmenin adı ve soyadı: " + name + " " + surname + "\nDoğum tarihi: " + dateOfBirth.ToString("dd.MM.yyyy"));
        }

        public void StudentInformation()
        {
            Console.WriteLine("Öğrencinin adı ve soyadı: " + name + " " + surname + "\nDoğum tarihi: " + dateOfBirth.ToString("dd.MM.yyyy"));
        }

    }
}
