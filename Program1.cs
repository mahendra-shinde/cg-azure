using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace NoSQL_Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString =
  @"mongodb://max1:eVDcLBFB3lPxtNbUvrt3YYO0XjaMWHjMDJFF2ImDbFoXw9iWeCLMszUaOgL39S31v4YCBIPiNraabUFcpDIXow==@max1.documents.azure.com:10255/?ssl=true&replicaSet=globaldb";
            MongoClientSettings settings = MongoClientSettings.FromUrl(
              new MongoUrl(connectionString)
            );
            settings.SslSettings =
              new SslSettings() { EnabledSslProtocols = SslProtocols.Tls12 };
            var mongoClient = new MongoClient(settings);
            List<String> dbs= mongoClient.ListDatabaseNames().ToList<String>();
            foreach(String s in dbs)
            {
                Console.WriteLine("Database found! "+ s);
            }
            Console.ReadLine();
        }
    }
}
