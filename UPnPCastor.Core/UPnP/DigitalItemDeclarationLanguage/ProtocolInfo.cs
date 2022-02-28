namespace UPnPCastor.Core.UPnP.DigitalItemDeclarationLanguage
{
    public class ProtocolInfo
    {
        private const string DLNA_ORG = "DLNA.ORG";

        public string Pn { get; set; }

        public string Op { get; set; } = "01";

        public int Ci { get; set; }

        public string Flags { get; set; } = "01700000000000000000000000000000";

        private string _mimeType;

        public ProtocolInfo(string uri)
        {
            _mimeType = MimeMapping.MimeUtility.GetMimeMapping(Path.GetFileName(uri));
        }

        public override string ToString()
        {
            string text = $"http-get:*:{_mimeType}:";
            var properties = GetType().GetProperties();
            List<string> stringValues = new();

            foreach (var property in properties)
            {
                object? value = property.GetValue(this);

                if (value is not null)
                {
                    stringValues.Add($"{DLNA_ORG}_{property.Name.ToUpper()}={value}");
                }
            }

            return $"{text}{string.Join(';', stringValues)}";
        }
    }
}