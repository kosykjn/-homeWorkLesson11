using System;

namespace homeWorkLesson11_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var store = new Store(
                new Article("Article #1", "Shop #1", 10.0),
                new Article("Article #2", "Shop #2", 15.0),
                new Article("Article #3", "Shop #3", 20.0));

            Console.WriteLine("Введите индекс товара, информацию о котором желаете получить:");
            var index = Convert.ToInt32(Console.ReadLine());
            var findArticle1 = store[index];

            if (findArticle1 != null)
            {
                findArticle1.DisplayInfo();
            }
            else
            {
                Console.WriteLine("Товара под таким индексом не существует!");
            }

            Console.WriteLine("Введите имя товара, информацию о котором желаете получить:");
            var name = Console.ReadLine();
            var findArticle2 = store[name];

            if (findArticle2 != null)
            {
                findArticle2.DisplayInfo();
            }
            else
            {
                Console.WriteLine("Товара с таким именем не существует!");
            }

            Console.ReadKey();
        }
    }
}
