using FactoryMethod.Generators;

ReportGenerator generator;

Console.WriteLine("Choose a format for your report: (1) PDF | (2) Csv | (3) Json");
string choice = Console.ReadLine();

switch (choice)
{
    case "1":
        generator = new PDFReportGenerator();
        break;
    case "2":
        generator = new CsvReportGenerator();
        break;
    case "3":
        generator = new JsonReportGenerator();
        break;
    default:
        Console.WriteLine("Invalid option");
        return;
}

generator.GenerateReport();

Console.WriteLine("Your report was generated!");
Console.ReadLine();