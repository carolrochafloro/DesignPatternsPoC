using FactoryMethod.Entities;
using FactoryMethod.Interfaces;

namespace FactoryMethod.Generators;
public class PDFReportGenerator : ReportGenerator
{
    public override IReport CreateReport()
    {
        return new PDFReport();
    }
}
