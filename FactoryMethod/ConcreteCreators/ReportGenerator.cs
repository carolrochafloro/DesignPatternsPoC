using FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Generators;
public abstract class ReportGenerator
{
    public abstract IReport CreateReport();

    public void GenerateReport()
    {
        IReport report = CreateReport();
        report.Generate();
    }
}
