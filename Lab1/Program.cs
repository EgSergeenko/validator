using System;

namespace ValidationSystem
{
    class Program
    {
        static void Main()
        {
            Validator v = new Validator("a");
            Student s1 = new Student("Ivan");
            Student s2 = new Student("Dan");
            s1.DoTask("a");
            s2.DoTask("b");
            v.AddStudent(s1);
            v.AddStudent(s2);
            v.Validate(s1);
            v.Validate(s2);
            v.ShowInfo();
            Console.ReadKey();
        }
    }
}
