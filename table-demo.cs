using System;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;

namespace TableDemo1
{
     class Contact : TableEntity
    {
        public string contactType { get; set; }
        public string contactId { get; set; }
        public Contact() { }


        /// <summary>
        /// Construct a new Entity instance using PartitionKey and RowKey
        /// The parameter names MUST MATCH with PROPERTY NAMES inside Azure Table
        /// </summary>
        /// <param name="PartitionKey"> The property from table </param>
        /// <param name="RowKey"> The property from table</param>
        public Contact(string PartitionKey, string RowKey)
        {
            contactType = PartitionKey;
            contactId = RowKey;
        }
        //  Names MUST match with property names in Table
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string origin { get; set; }
    }

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
