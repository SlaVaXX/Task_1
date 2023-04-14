using System;

namespace Prak // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            CharLine Line = new CharLine();
            for (int i = 0;;)
            {
                string Temp;
                Console.WriteLine(
                    "\nВведіть команду:\n(new - створити/заново створити рядок)\n(print - вивести рядок в консоль)\n(length - вивести довжину рядка)\n(replace - замінити символ в рядку на новий)\n(clear - почистити консоль)\n(end - завершити виконання програми)\n");
                Temp = Console.ReadLine().ToLower().Trim();
                if (Temp == "new")
                {
                    Console.Clear();
                    Console.WriteLine("\nВведіть рядок:\nПопередження: усі пробіли та цифри будуть прибрані з рядка!");
                    Line = new CharLine(Console.ReadLine());
                    i++;
                }
                else if (Temp == "print" && i > 0)
                {
                    Line.PrintString();
                }
                else if (Temp == "length" && i > 0)
                {
                    Console.WriteLine($"\nДовжина рядка = {Line.LineLength()}");
                }
                else if (Temp == "replace" && i > 0)
                {
                    Console.WriteLine();
                    string oldChar, newChar;
                    Console.Write("Введіть символ, який хочете замінити: ");
                    oldChar = Console.ReadLine();
                    Console.Write("Введіть новий символ: ");
                    newChar = Console.ReadLine();
                    try
                    {
                        Line.ReplaceChar(oldChar, newChar);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else if (Temp == "clear")
                {
                    Console.Clear();
                }
                else if (Temp == "end")
                {
                    Console.Clear();
                    break;
                }
            } //end for
        }
    }
}