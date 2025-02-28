using FactoryMethod.Interfaces;

namespace FactoryMethod.Entities;
public class CsvReport : IReport
{
    public void Generate()
    {
        Console.WriteLine("Generating csv report...");
    }
}
