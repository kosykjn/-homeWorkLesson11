using System;

namespace homeWorkLesson11_6
{
    class Article
    {
        public string Name { get; }
        public string ShopName { get; }
        public double Cost { get; }

        public Article(string name, string shopName, double cost)
        {
            Name = name;
            ShopName = shopName;
            Cost = cost;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Название: {Name}\nМагазин: {ShopName}\nСтоимость: {Cost}");
        }
    }
}
