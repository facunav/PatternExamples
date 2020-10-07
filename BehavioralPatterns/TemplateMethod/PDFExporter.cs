using System;

namespace BehavioralPatterns.TemplateMethod
{
    public class PDFExporter : DataExporter
    {
        public override void ExportData()
        {
            Console.WriteLine("Exporting the data to a PDF file.");
        }
    }
}
