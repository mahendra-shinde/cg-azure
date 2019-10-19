using System;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;

namespace BlobDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set the connection string (copy from azure portal )
            string connString = @"DefaultEndpointsProtocol=https;AccountName=maxunlimited;AccountKey=Lx23qtdr1sI9+Nd20bef7fP63fStAWxIehFcQbkOIrIjoLIYZG6BR3mpDd0nRdYG8VdnT97xS9QNTXA2rHn2GA==;EndpointSuffix=core.windows.net";
            // Create a storage account connection
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(connString);
            Console.WriteLine("Connected to " + storageAccount.BlobEndpoint);

            var client = storageAccount.CreateCloudTableClient();
            var table = client.GetTableReference("contacts");
            TableOperation retrieveOperation = TableOperation.Retrieve<Contact>("official", "101");
            TableResult result = table.Execute(retrieveOperation);
            Contact contact = result.Result as Contact;
            Console.Write("Name found: " + contact.lastname + " " + contact.firstname);
            Console.ReadLine();
        }
    }
}
