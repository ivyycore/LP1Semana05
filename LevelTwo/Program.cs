using System;
using Spectre.Console;
namespace LevelTwo
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine();
            if (args.Length == 00)
            {   
                //the default image "tux.jpg" is used if not inputs are placed
                CanvasImage default_image = new CanvasImage("tux.jpg");
                default_image.MaxWidth(24); //max size
                AnsiConsole.Write(default_image); // renders in the console

            }
            else
            {
                CanvasImage input_image = new CanvasImage(args[0]);
                input_image.MaxWidth(int.Parse(args[1]));
                AnsiConsole.Write(input_image);
            }
        }
    }
}
