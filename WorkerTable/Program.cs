using System;
using Spectre.Console;
using Bogus;

namespace WorkerTable
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Randomizer.Seed = new Random(int.Parse[0]); // Definir seed
            Faker faker = new Faker("pt_PT"); //Usar o objeto faker para gerar dados

            // Create a table
            var table = new Table();

            // Add some columns
            table.AddColumn("Column1");
            table.AddColumn(new TableColumn("Column2").Centered());

            // Add some rows
            table.AddRow("Row1");
            table.AddRow(new TableRow("Row2").Centered());

            // Render the table to the console
            AnsiConsole.Write(table);
        }
    }
}
