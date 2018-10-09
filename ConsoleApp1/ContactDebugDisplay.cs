namespace ContactWriter
{
    internal class ContactDebugDisplay
    {
        private readonly Contact _contact;

        public ContactDebugDisplay(Contact contact)
        {
            _contact = contact;
        }

        public string UpperName { get {
                return _contact.FirstName.ToUpperInvariant();
            }}

        public string  AgeInHex { get {
                return _contact.AgeInYears.ToString("X");    
            } }
    }
}