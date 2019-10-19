using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlobDemo1
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
}
