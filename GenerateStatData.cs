using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware_Order_Management
{
    public class GenerateStatData
    {
        HardwareDBContext db;
        public GenerateStatData(HardwareDBContext db)
        {
            this.db = db;
        }
        public Dictionary<string, int> GetCategoryCounts()
        {
           
            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (var component in db.Components)
            {
                if (counts.ContainsKey(component.Category))
                {
                    counts[component.Category]++;
                }
                else
                {
                    counts[component.Category] = 1;
                }
            }

            return counts;
        }
    }
    

}
