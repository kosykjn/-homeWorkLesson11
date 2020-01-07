using System;

namespace homeWorkLesson11_3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.change = "не изменено";

            MyStruct myStruct;
            myStruct.change = "не изменено";

            ClassTaker(myClass);
            Console.WriteLine(myClass.change);

            StruktTaker(myStruct);
            Console.WriteLine(myStruct.change);


            Console.ReadKey();
        }

        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "изменено";
        }

        static void StruktTaker(MyStruct myStruct)
        {
            myStruct.change = "изменено";
        }
    }
}
