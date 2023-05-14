
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hardware_Order_Management.Types
{
    public class ComputerComponent
    {
        [Key, Column(Order = 0)]
        public int ComputerId { get; set; }
        public Computer Computer { get; set; }

        [Key, Column(Order = 1)]
        public int ComponentId { get; set; }
        public Component Component { get; set; }
    }
}
