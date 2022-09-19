using AzureCustomerTable;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            TableStorageSample tableSample = new TableStorageSample();
            tableSample.RunDemo().Wait();

        }
    }
}
