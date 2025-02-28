using FactoryMethod.Interfaces;

namespace FactoryMethod.Entities;
public class JsonReport : IReport
{
    public void Generate()
    {
        Console.WriteLine("Generating Json report...");
    }
}
