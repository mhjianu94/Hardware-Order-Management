using Hardware_Order_Management.Types;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace Hardware_Order_Management
{
    public class Computer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Model { get; set; }
        public List<Component> Components { get; set; }
        public ICollection<ComputerComponent> ComputerComponents { get; set; }
        public Computer()
        {
            ComputerComponents = new List<ComputerComponent>();
        }
    }
}
