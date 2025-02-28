using FactoryMethod.Interfaces;

namespace FactoryMethod.Entities;
public class PDFReport : IReport
{
    public void Generate()
    {
        Console.WriteLine("Generating PDF report...");
    }
}
