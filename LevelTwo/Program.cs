using System;
using Spectre.Console;
namespace LevelTwo
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(SoGoodClass.SoGoodMethod());
            if (args.Length == 00)
            {
                CanvasImage default_image = new CanvasImage("tux.jpg");
                default_image.MaxWidth(24);
                AnsiConsole.Write(default_image);
            }
        }
    }
}
