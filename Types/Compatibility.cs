using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware_Order_Management
{
    public class Compatibility
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Component1Id { get; set; }
        public int Component2Id { get; set; }
        public bool AreCompatible { get; set; }
    }
}
