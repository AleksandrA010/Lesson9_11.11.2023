using System;
using LabWork.Figure;
using System.Threading;

namespace LabWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ICipher cipherA = new ACipher();
            //ICipher cipherB = new BCipher();
            //string str = "Hello World";
            //Console.WriteLine($"Для шифрования/дешифрования используется строка — {str}.\n");
            //str = cipherA.encode(str);
            //Console.WriteLine(str);
            //str = cipherA.decode(str);
            //Console.WriteLine(str);
            //str = cipherB.encode(str);
            //Console.WriteLine(str);
            //str = cipherB.decode(str);
            //Console.WriteLine(str);
            //Console.CursorVisible = false;
            //Console.Write("\nДля продолжения нажмите на любую клавишу.");
            //Console.ReadKey();
            //Console.Clear();
            //Console.CursorVisible = true;
            int height = 2;
            int width = 12;
            int radius = 3;
            var point = new Point(ConsoleColor.Red, 1);
            var rectangle = new Rectangle(ConsoleColor.Blue, 1, height, width);
            var circle = new Circle(ConsoleColor.Green, 1, radius);
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("drawPoint — нарисовать точку.");
                Console.WriteLine("drawRectangle — нарисовать прямоугольник.");
                Console.WriteLine("drawCircle — нарисовать круг");
                Console.WriteLine("сalAreaRectangle — вычислить площадь прямоугольника.");
                Console.WriteLine("сalAreaCircle — вычислить площадь круга.");
                Console.WriteLine("break — для закрытия приложения.");
                Console.Write("\nВведите команду: ");
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "drawPoint":
                        Console.Clear();
                        point.Draw();
                        Console.CursorVisible = false;
                        Console.Write("\nДля продолжения нажмите на любую клавишу.");
                        Console.ReadKey();
                        Console.Clear();
                        Console.CursorVisible = true;
                        break;
                    case "drawRectangle":
                        Console.Clear();
                        Console.Write("Введите длину: ");
                        int.TryParse(Console.ReadLine(), out height);
                        Console.Write("Введите ширину: ");
                        int.TryParse(Console.ReadLine(), out width);
                        rectangle.SetSize(width, height);
                        rectangle.Draw();
                        Console.CursorVisible = false;
                        Console.Write("\nДля продолжения нажмите на любую клавишу.");
                        Console.ReadKey();
                        Console.Clear();
                        Console.CursorVisible = true;
                        break;
                    case "drawCircle":
                        Console.Clear();
                        Console.Write("Введите радиус: ");
                        int.TryParse(Console.ReadLine(), out radius);
                        circle.SetRadius(radius);
                        circle.Draw();
                        Console.CursorVisible = false;
                        Console.Write("\nДля продолжения нажмите на любую клавишу.");
                        Console.ReadKey();
                        Console.Clear();
                        Console.CursorVisible = true;
                        break;
                    case "сalAreaRectangle":
                        Console.Clear();
                        Console.WriteLine($"Площадь прямоугольника со сторонами {height}, {width} — {rectangle.CalArea()}\n");
                        Console.CursorVisible = false;
                        Console.Write("\nДля продолжения нажмите на любую клавишу.");
                        Console.ReadKey();
                        Console.Clear();
                        Console.CursorVisible = true;
                        break;
                    case "сalAreaCircle":
                        Console.Clear();
                        Console.WriteLine($"Площадь круга с радиусом {radius} — {circle.CalArea()}\n");
                        Console.CursorVisible = false;
                        Console.Write("\nДля продолжения нажмите на любую клавишу.");
                        Console.ReadKey();
                        Console.Clear();
                        Console.CursorVisible = true;
                        break;
                    case "break":
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Команда введена не верно.");
                        Console.CursorVisible = false;
                        Thread.Sleep(3000);
                        Console.Clear();
                        Console.CursorVisible = true;
                        break;
                }
            }
        }
    }
}
