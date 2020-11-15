using System;

/*Даний інтерфейс поганий тим, що він включає занадто багато методів.
 А що, якщо наш клас товарів не може мати знижок або промокодом, або для нього немає сенсу встановлювати матеріал з 
 якого зроблений (наприклад, для книг). Таким чином, щоб не реалізовувати в кожному класі невикористовувані в ньому методи, краще 
розбити інтерфейс на кілька дрібних і кожним конкретним класом реалізовувати потрібні інтерфейси.
Перепишіть, розбивши інтерфейс на декілька інтерфейсів, керуючись принципом розділення інтерфейсу. 
Опишіть класи книжки (розмір та колір не потрібні, але потрібна ціна та знижки) та верхній одяг (колір, розмір, ціна знижка),
які реалізують притаманні їм інтерфейси.*/
namespace Solid4
{
    interface ISize
    {
        void SetSize(byte size);
    }
    interface IColor
    {
        void SetColor(byte color);
    }
    interface IPrice
    {
        void SetPrice(double price);
    }
    interface IPromocode
    {
        void ApplyPromocode(String promocode);
    }
    interface IDiscount
    {
        void ApplyDiscount(String discount);
    }



    class Outerwear: IPrice, IDiscount, IColor, ISize
    {
        double Price;
        string Discount;
        byte Size;
        byte Color;

        void ISize.SetSize(byte size)
        {
            Size = size;
        }
        void IPrice.SetPrice(double price)
        {
            Price = price;
        }
        void IDiscount.ApplyDiscount(string discount)
        {
            Discount = discount;
        }
        void IColor.SetColor(byte color)
        {
            Color = color;
        }
    }
    class Book : IPrice, IDiscount
    {
        double Price;
        string Discount;

        void IPrice.SetPrice(double price)
        {
            Price = price;
        }
        void IDiscount.ApplyDiscount(string discount)
        {
            Discount = discount;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.ReadKey();
        }
    }
}