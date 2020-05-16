namespace SOLIDExamples
{
    public class Document
    {
        public void Print(IMachine printer)
        {
            printer.Print(this);
        }
    }

    public class Mail : Document
    {
        public void Fax(IMachine printer)
        {
            printer.Fax(this);
        }
    }

    public interface IMachine
    {
        void Print(Document doc);
        void Fax(Document doc);
        void Scanner(Document doc);
    }


    public class MultiFunctionPrinter : IMachine
    {
        public void Print(Document doc)
        {
        }

        public void Fax(Document doc)
        {
        }

        public void Scanner(Document doc)
        {
        }
    }

    public class OldPrinter : IMachine
    {
        public void Print(Document doc)
        {
            //
        }

        public void Fax(Document doc)
        {
            throw new System.NotImplementedException();
        }

        public void Scanner(Document doc)
        {
            throw new System.NotImplementedException();
        }
    }

    public class ISPBad
    {
        public void Main()
        {
            var newDoc = new Document();
            var printer = new MultiFunctionPrinter();
            newDoc.Print(printer);
        }
    }
}