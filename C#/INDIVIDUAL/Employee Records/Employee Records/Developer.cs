using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Records
{
    public class Developer : Employee
    {
        public string TaxType { get; set; }
        public string CostCenter { get; set; }

        public Developer(string costCenter, string taxType)
        {
            TaxType = taxType;
            CostCenter = costCenter;
        }

        public Developer()
        {
        }
    }
}
