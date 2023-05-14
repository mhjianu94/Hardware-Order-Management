
using Hardware_Order_Management.Types;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hardware_Order_Management
{
    public class Component
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Manufacturer { get; set; }
        public int Price { get; set; }

        public ICollection<ComputerComponent> ComputerComponents { get; set; }
        public Component()
        {
            ComputerComponents = new List<ComputerComponent>();
        }
    }
}
