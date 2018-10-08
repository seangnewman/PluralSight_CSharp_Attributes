using System;
using static System.Console;


namespace ContactWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact Cody = new Contact
            {
                FirstName = "Cody",
                AgeInYears = 20
            };

            var CodyWriter = new ContactConsoleWriter(Cody);
            CodyWriter.Write();
             
        }
    }
}
