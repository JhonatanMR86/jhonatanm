using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Text;

namespace jhonatanm.Functions.Entities
{
    public class todoEntities : TableEntity
    {
        public int Employed { get; set; }

        public DateTime date { get; set; }

        public int Type { get; set; }

        public bool Consolidated { get; set; }
    }
}
