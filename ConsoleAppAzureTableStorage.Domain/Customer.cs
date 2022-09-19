using Microsoft.WindowsAzure.Storage.Table;

namespace ConsoleAppAzureTableStorage.Domain
{
    public class Customer : TableEntity
    {
        public string CustomerId { get; set; } 
        public string customerLastName { get; set; }
        public string customerFirstName { get; set; }
        public EnumCustomerType enumCustomerType { get; set; }


        //REQUIRED for the RETRIEVE!!!!
        public Customer()
        {

        }

        public Customer(string customerid, string customerlastname, string customerfirstname,  EnumCustomerType enumcustomertype)
        {
            this.CustomerId = customerid;
            this.customerLastName = customerlastname;
            this.customerFirstName = customerfirstname;
            this.enumCustomerType = enumcustomertype;


            //Good PK and RK?
            PartitionKey = CustomerId;
            RowKey = customerLastName + customerFirstName;
        }
    }
}
