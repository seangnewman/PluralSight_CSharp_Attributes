using System.Diagnostics;

namespace ContactWriter
{
    [DebuggerDisplay("FirstName = {FirstName} and AgeInYears = {AgeInYears}")]
    [DebuggerTypeProxy(typeof(ContactDebugDisplay))]
    public class Contact
    {
        public string FirstName { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int AgeInYears { get; set; }
    }
}
