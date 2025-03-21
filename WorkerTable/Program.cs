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
        }
    }
}
