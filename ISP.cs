namespace SOLIDExamples.ISP
{
    public class Document
    {
        public void Print(IPrinter printer)
        {
            printer.Print(this);
        }

    }
    public class Mail : Document
    {
        public void Fax(IFax printer)
        {
            printer.Fax(this);
        }
    }

    public interface IPrinter
    {
        void Print(Document doc);
    }

    public interface IScanner
    {
        void Scan(Document doc);
    }
    public interface IFax
    {
        void Fax(Document doc);
    }


    public class MultiFunctionPrinter : IPrinter, IScanner, IFax
    {
        public void Print(Document doc)
        {
        }

        public void Fax(Document doc)
        {
        }

        public void Scan(Document doc)
        {
        }
    }

    public class OldPrinter : IPrinter
    {
        public void Print(Document doc)
        {
            //
        }
    }

    public class FaxDevice : IFax
    {
        public void Fax(Document doc)
        {
            //
        }
    }

    public class ISP
    {
        public void Main()
        {
            var newDoc = new Document();
            var printer = new MultiFunctionPrinter();
            newDoc.Print(printer);
        }
    }
}