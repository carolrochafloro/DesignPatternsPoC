using FactoryMethod.Entities;
using FactoryMethod.Interfaces;

namespace FactoryMethod.Generators;
public class CsvReportGenerator : ReportGenerator
{
    public override IReport CreateReport()
    {
        return new CsvReport();
    }
}
