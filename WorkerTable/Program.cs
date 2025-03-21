using System;
using Spectre.Console;
using Bogus;

namespace WorkerTable
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Randomizer.Seed = new Random(int.Parse(args[0])); // Definir seed
            Faker faker = new Faker("pt_PT"); //Usar o objeto faker para gerar dados

            // Create a table
            var table = new Table();

            // Add some columns
            table.AddColumn("ID");
            table.AddColumn(new TableColumn("Name"));
            table.AddColumn(new TableColumn("Job"));

            // Add some rows
            foreach (int nid in args)
                {
                    table.AddRow("nid");
                    table.AddRow(new TableRow(faker.Random.FullName));
                    table.AddRow(new TableRow(faker.Random.JobTitle));
                }

            // Render the table to the console
            AnsiConsole.Write(table);
        }
    }
}
