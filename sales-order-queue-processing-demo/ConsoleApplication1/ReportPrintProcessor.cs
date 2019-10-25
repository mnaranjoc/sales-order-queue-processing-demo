using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ReportPrintProcessor
    {
        public void prompt()
        {

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
        }
    }
}
