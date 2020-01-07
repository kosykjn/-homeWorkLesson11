using System;

namespace homeWorkLesson11_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var notebook = new Notebook("HP 250", "USA", 10000);
            notebook.Print();

            Console.ReadKey();
        }
    }
}
