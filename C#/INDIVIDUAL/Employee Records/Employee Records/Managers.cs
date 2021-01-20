using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Records
{
    public class Managers : Employee
    {

        public string CostCenter { get; set; }
        public string TaxType { get; set; }


        public Managers(string costCenter, string taxType)
        {
            CostCenter = costCenter;
            TaxType = taxType;


        }

        public Managers()
        {
        }
    }
}
