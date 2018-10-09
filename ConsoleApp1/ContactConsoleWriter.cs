using System;
using System.Diagnostics;
using static System.Console;


namespace ContactWriter
{



    public class ContactConsoleWriter
    {
        private readonly Contact _contact;

        public ContactConsoleWriter(Contact contact)
        {
            _contact = contact;
        }

        //[Obsolete("This is beta and will be removed in production",true)]
        public void Write()
        {
            WriteFirstName();
            WriteAge();
        }

        private void WriteAge()
        {
            OutputDebugInfo();
            OutputExtraInfo();
             WriteLine(_contact.AgeInYears);
        }

        [Conditional("EXTRA")]
        private void OutputExtraInfo()
        {
            Console.WriteLine("***** EXTRA MODE *****");   
        }

        [Conditional("DEBUG")]
        private void OutputDebugInfo()
        {
            WriteLine(" ****** DEBUG MODE *****");
        }

        private void WriteFirstName()
        {
             WriteLine(_contact.FirstName);
        }
    }
}
