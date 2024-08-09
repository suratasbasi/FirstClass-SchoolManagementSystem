using FirstClass_SchoolManagementSystem;

public class Program
{
    public static void Main(string[] args)
    {

        Person teacher1 = new Person();
        teacher1.Name = "Hürrem";
        teacher1.Surname = "Sultan";
        teacher1.dateOfBirth = new DateTime(1510, 8, 27);

        teacher1.TeacherInformation();

        Person teacher2 = new Person();
        teacher2.Name = "Mahidevran";
        teacher2.Surname = "Sultan";
        teacher2.dateOfBirth = new DateTime(1505, 3, 13);

        teacher2.TeacherInformation();

        Person student1 = new Person();
        student1.Name = "Mihrimah";
        student1.Surname = "Sultan";
        student1.dateOfBirth = new DateTime(1530, 11, 3);

        student1.StudentInformation();

        Person student2 = new Person();
        student2.Name = "Şehzade";
        student2.Surname = "Mustafa";
        student2.dateOfBirth = new DateTime(1525, 2, 22);

        student2.StudentInformation();

    }
}