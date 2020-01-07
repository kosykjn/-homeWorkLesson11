using System;

namespace homeWorkLesson11_1
{
    struct Notebook
    {
        public string Model;
        public string Manufacturer;
        public int Price;

        public Notebook(string model, string manufacturer, int price)
        {
            Model = model;
            Manufacturer = manufacturer;
            Price = price;
        }
        public void Print()
        {
            Console.WriteLine($"Модель: {Model}\nПроизводитель: {Manufacturer}\nЦена:{Price}");
        }
    }
}
