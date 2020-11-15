using System;


// Порушений принцип підстановки Лісков
// Нащадок(Квадрат) має вужчий функціонал аніж предок(прямокутник)
// через це маємо невизначеність і неочікувану поведінку від класу для користувача.


// Переробимо принцип наслідування в наших класах.
namespace Solid3
{
    abstract class Figure
    {
        public abstract int GetArea();
    }
    class Rectangle : Figure
    {
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public  int Width { get; set; }
        public  int Height { get; set; }
        public override int GetArea()
        {
            return Width * Height;
        }
    }

    //тепер квадрат наслідується від фігури
    class Square : Figure
    {
        public int Side { get; set; }
        public Square(int side)
        {
            Side = side;
        }
        public override int GetArea()
        {
            return Side * Side;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Figure rect = new Square(5);

            Console.WriteLine(rect.GetArea());
            //Відповідь 100? Що не так???
            Console.ReadKey();
        }
    }
}