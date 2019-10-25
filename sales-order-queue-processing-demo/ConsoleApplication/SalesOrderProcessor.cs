using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class SalesOrderProcessor
    {
        public void prompt()
        {
            Console.WriteLine("");
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
            SalesOrderProcessor processor;

            processor = new SalesOrderProcessor();
            processor.prompt();

            if (processor.validate())
            {
                processor.run();
            }

            Console.ReadLine();
        }
    }
}
