using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;

namespace BlobDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set the connection string (copy from azure portal )
            string connString = @"DefaultEndpointsProtocol=https;AccountName=maxunlimited;AccountKey=1+8/2RVS89+7ztWLSNwmWJ0H62d9e19Ahrpx1oHAiyWMlr6UX58htjLMoeosiil1u/MJVyMuFZIznWaFqL+cdQ==;EndpointSuffix=core.windows.net";
            // Create a storage account connection
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(connString);
            Console.WriteLine("Connected to " + storageAccount.BlobEndpoint);
            // Get Blob client object (proxy)
            CloudBlobClient client = storageAccount.CreateCloudBlobClient();
            // Using blob client, get container
            CloudBlobContainer container = client.GetContainerReference("myfiles");
            // Prepare a new/existing blob 
            CloudBlockBlob blob= container.GetBlockBlobReference("earth.jpg");
            // Set the properties for blob
            blob.Properties.ContentType = "image/jpeg";
            // Start uploading the local file
            blob.UploadFromFile(@"c:\users\mahendra\desktop\earth.jpg");
            Console.WriteLine("File uploaded successfuly!");
            Console.ReadLine();
        }
    }
}
