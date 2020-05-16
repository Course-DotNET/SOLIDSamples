using System.Net.NetworkInformation;
using System.Xml.Serialization;

namespace SOLIDExamples.DIP
{

    public class Document
    {
        private ISender fax;

        public Document(ISender fax)
        {
            this.fax = fax;
        }

        public void Send()
        {
            fax.Send(this);
        }
    }

    public interface ISender
    {
        void Send(Document d);
    }

    public class Fax : ISender
    {
        public void Send(Document d)
        {

        }
    }
    public class Email : ISender
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