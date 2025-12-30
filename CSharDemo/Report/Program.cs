

namespace Report1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region old code
            //PDF p = new PDF();
            //p.GenerateReport();
            //p.Parse();
            //p.Validate();
            //p.Save();

            //DOCX d = new DOCX();
            //d.GenerateReport();
            //d.Parse();
            //d.Validate();
            //d.Save();
            #endregion


            while (true)
            {
                Console.WriteLine("Enter your choice: 1. PDF, 2. DOCX, 3. Excel, 4. XML, 5. JSON");
                int choice = Convert.ToInt32(Console.ReadLine());

                ReportFactory factory = new ReportFactory();
                Report report = factory.GetSomeReport(choice);
                report.GenerateReport();

                Console.WriteLine("Do you want to continue? 'y/n'");
                string ynChoice = Console.ReadLine();

                if (ynChoice == "n")
                {
                    break;
                }
            }

        }
    }
}

public abstract class Report
{
    protected abstract void Parse();
    protected abstract void Validate();
    protected abstract void Save();
    public virtual void GenerateReport()
    {

        Parse();
        Validate();
        Save();
        Console.WriteLine("Report generated.");
    }
}

public abstract class SpecialReport : Report
{
    protected abstract void ReValidate();
    public override void GenerateReport()
    {

        Parse();
        Validate();
        ReValidate();
        Save();
        Console.WriteLine("Special Report generated.");
    }
}
public class ReportFactory
{
    public Report GetSomeReport(int choice)
    {
        Report someReport = null;
        switch (choice)
        {
            case 1:
                someReport = new PDF();
                break;
            case 2:
                someReport = new DOCX();
                break;
            case 3:
                someReport = new Excel();
                break;
            case 4:
                someReport = new XML();
                break;
            case 5:
                someReport = new JSON();
                break;
            default:
                someReport = null;
                break;
        }
        return someReport;
    }
}
public class XML : SpecialReport
{
    protected override void Parse()
    {

        Console.WriteLine("XML parsed.");
    }
    protected override void Validate()
    {

        Console.WriteLine("XML validated.");
    }
    protected override void Save()
    {

        Console.WriteLine("XML Saved.");
    }
    protected override void ReValidate()
    {

        Console.WriteLine("XML Re-Validated.");
    }
}

public class JSON : SpecialReport
{
    protected override void Parse()
    {

        Console.WriteLine("JSON parsed.");
    }
    protected override void Validate()
    {

        Console.WriteLine("JSON validated.");
    }
    protected override void Save()
    {

        Console.WriteLine("JSON Saved.");
    }
    protected override void ReValidate()
    {

        Console.WriteLine("JSON Re-Validated.");
    }

}
public class PDF : Report
{
    protected override void Parse()
    {

        Console.WriteLine("PDF parsed.");
    }
    protected override void Validate()
    {

        Console.WriteLine("PDF validated.");
    }
    protected override void Save()
    {

        Console.WriteLine("PDF Saved.");
    }


}
public class DOCX : Report
{
    protected override void Parse()
    {

        Console.WriteLine("DOCX parsed.");
    }
    protected override void Validate()
    {

        Console.WriteLine("DOCX validated.");
    }
    protected override void Save()
    {

        Console.WriteLine("DOCX Saved.");
    }

}

public class Excel : Report
{
    protected override void Parse()
    {

        Console.WriteLine("Excel parsed.");
    }
    protected override void Validate()
    {

        Console.WriteLine("Excel validated.");
    }
    protected override void Save()
    {

        Console.WriteLine("Excel Saved.");
    }

}
    
