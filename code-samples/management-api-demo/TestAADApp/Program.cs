using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Azure.Management.Fluent;
using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
using Microsoft.Azure.Management.ResourceManager.Fluent;

namespace TestAADApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var Credentials = SdkContext.AzureCredentialsFactory.FromFile("app.properties");
            var azure = Azure.Configure().WithLogLevel(HttpLoggingDelegatingHandler.Level.Basic)
                .Authenticate(Credentials)
                .WithDefaultSubscription();
            Console.WriteLine("Logged in into azure, lets create a resource group");
            var resourceGroup = azure.ResourceGroups.Define("demo1-group")
                    .WithRegion(Region.AsiaSouthEast)
                    .Create();
            Console.WriteLine("Resource group created");

        }
    }
}
