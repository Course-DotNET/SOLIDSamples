namespace SOLIDExamples.DipBad
{

    public class Document
    {
        private Fax fax;

        public Document(Fax fax)
        {
            this.fax = fax;
        }

        public void Send()
        {
            fax.Send(this);
        }
    }


    public class Fax
    {
        public void Send(Document d)
        {

        }
    }

    public class DIP
    {
        public void Main()
        {
            var newDoc = new Document(new Fax());
            newDoc.Send();
        }
    }
}