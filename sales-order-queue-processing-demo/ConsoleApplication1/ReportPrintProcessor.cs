using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ReportPrintProcessor
    {
        int invoicesQty;

        public void prompt()
        {
            this.getNumberOfInvoices();
        }

        public void getNumberOfInvoices()
        {
            bool isValid = false;            

            while (!isValid)
            {
                Console.Clear();
                Console.WriteLine("Type the number of invoices generated:");

                if (int.TryParse(Console.ReadLine(), out invoicesQty))
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("That's an invalid number, please try again. (Press any key)");
                    Console.ReadLine();
                }

            }
        }

        public bool validate()
        {
            bool ret = true;

            return ret;
        }

        public void run()
        {

        }

        static void Main(string[] args)
        {
            ReportPrintProcessor processor;

            processor = new ReportPrintProcessor();
            processor.prompt();

            if (processor.validate())
            {
                processor.run();
            }

            Console.ReadLine();
        }
    }
}
