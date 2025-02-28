using FactoryMethod.Entities;
using FactoryMethod.Interfaces;

namespace FactoryMethod.Generators;
public class JsonReportGenerator : ReportGenerator
{
    public override IReport CreateReport()
    {
        return new JsonReport();
    }
}
