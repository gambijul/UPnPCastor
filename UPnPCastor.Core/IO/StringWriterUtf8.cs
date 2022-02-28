using System.Text;

namespace UPnPCastor.Core.IO
{
    public class StringWriterUtf8 : StringWriter
    {
        public override Encoding Encoding => Encoding.UTF8;
    }
}