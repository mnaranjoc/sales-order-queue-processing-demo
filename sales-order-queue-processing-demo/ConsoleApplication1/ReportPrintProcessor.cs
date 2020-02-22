using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ReportPrintProcessor
    {
        List<Invoice> invoices = new List<Invoice>();
        List<string> customerList = new List<string>();

        public void init()
        {
            getInvoicesList();
            getCustomerList();
            printDocuments();
        }

        public void printDocuments()
        {

        }

        public void getCustomerList()
        {
            
            var customers = from c in invoices
                            group c by c.CustId into newGroup
                            select newGroup;

            foreach(var cust in customers)
            {
                customerList.Add(cust.Key);
            }
        }

        public void getInvoicesList()
        {
            Random custRand = new Random();
            var customerIdNameList = createCustomerList();

            for (int i = 0; i < 1500; i++)
            {
                invoices.Add(new Invoice
                {
                    CustId = customerIdNameList.Keys.ElementAt(custRand.Next(0, customerIdNameList.Count)),
                    InvoiceAmount = 999,
                    InvoiceDate = DateTime.Today
                });
            }
        }

        public Dictionary<string, string> createCustomerList()
        {
            var customerIdNameList = new Dictionary<string, string>();

            customerIdNameList.Add("0001", "James");
            customerIdNameList.Add("0002", "John");
            customerIdNameList.Add("0003", "Robert");
            customerIdNameList.Add("0004", "Michael");
            customerIdNameList.Add("0005", "William");
            customerIdNameList.Add("0006", "David");
            customerIdNameList.Add("0007", "Richard");
            customerIdNameList.Add("0008", "Joseph");
            customerIdNameList.Add("0009", "Charles");
            customerIdNameList.Add("0010", "Thomas");

            return customerIdNameList;
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
            ReportPrintProcessor processor = new ReportPrintProcessor();

            processor.init();

            if (processor.validate())
            {
                processor.run();
            }

            Console.ReadLine();
        }
    }
}
