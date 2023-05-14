using Hardware_Order_Management.Types;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;

namespace Hardware_Order_Management.Forms
{
    public partial class ComputerDetailsForm : Form
    {
        public ComputerDetailsForm()
        {
            InitializeComponent();
        }

        private Computer computer;
        private HardwareDBContext db;

        public ComputerDetailsForm(Computer selectedComputer, HardwareDBContext _db)
        {
            InitializeComponent();
            computer = selectedComputer;
        }

        private void ComputerDetailsForm_Load(object sender, EventArgs e)
        {
            db = new HardwareDBContext();
            computer = db.Computers
                .Include(c => c.ComputerComponents)
                .FirstOrDefault(c => c.Id == computer.Id);

            foreach (var cc in computer.ComputerComponents)
            {
                db.Entry(cc).Reference(c => c.Component).Load();
            }

            computer_name_label.Text = computer.Model;

            computerDetailsListView.View = View.Details;
            computerDetailsListView.Columns.Add("ID", 30, HorizontalAlignment.Left);
            computerDetailsListView.Columns.Add("Name", 100, HorizontalAlignment.Left);
            computerDetailsListView.Columns.Add("Category", 70, HorizontalAlignment.Left);
            computerDetailsListView.Columns.Add("Manufacturer", 120, HorizontalAlignment.Left);
            computerDetailsListView.Columns.Add("Price", 50, HorizontalAlignment.Left);

            foreach (var computerComponent in computer.ComputerComponents)
            {
                Component component = computerComponent.Component;

                ListViewItem item = new ListViewItem(component.Id.ToString());
                item.SubItems.Add(component.Name.ToString());
                item.SubItems.Add(component.Category.ToString());
                item.SubItems.Add(component.Manufacturer.ToString());
                item.SubItems.Add(component.Price.ToString());

                item.Tag = component; 
                computerDetailsListView.Items.Add(item);
            }

            var components = db.Components.ToList();
            componentDropdown.DataSource = components;
            componentDropdown.DisplayMember = "Name";
            componentDropdown.ValueMember = "Id";

        }

        private void RefreshLists()
        {
            computerDetailsListView.Items.Clear();

            computerDetailsListView.View = View.Details;
            computerDetailsListView.Columns.Add("ID", 30, HorizontalAlignment.Left);
            computerDetailsListView.Columns.Add("Name", 100, HorizontalAlignment.Left);
            computerDetailsListView.Columns.Add("Category", 70, HorizontalAlignment.Left);
            computerDetailsListView.Columns.Add("Manufacturer", 120, HorizontalAlignment.Left);
            computerDetailsListView.Columns.Add("Price", 50, HorizontalAlignment.Left);

            foreach (var computerComponent in computer.ComputerComponents)
            {
                Component component = computerComponent.Component;

                ListViewItem item = new ListViewItem(component.Id.ToString());
                item.Tag = component;
                item.SubItems.Add(component.Name.ToString());
                item.SubItems.Add(component.Category.ToString());
                item.SubItems.Add(component.Manufacturer.ToString());
                item.SubItems.Add(component.Price.ToString());

                computerDetailsListView.Items.Add(item);
            }
        }

        private void componentsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (computerDetailsListView.SelectedItems.Count > 0)
            {
                var selectedComponent = (Component)computerDetailsListView.SelectedItems[0].Tag;
            }
        }
        private void removeComponentButton_Click(object sender, EventArgs e)
        {
            if (computerDetailsListView.SelectedItems.Count > 0)
            {
                var selectedComponent = (Component)computerDetailsListView.SelectedItems[0].Tag;

                var computerComponent = db.ComputerComponents
                    .Where(cc => cc.ComponentId == selectedComponent.Id && cc.ComputerId == computer.Id)
                    .FirstOrDefault();

                if (computerComponent != null)
                {
                    db.ComputerComponents.Remove(computerComponent);
                    db.SaveChanges(); 
                    RefreshLists();
                }
                else
                {
                    MessageBox.Show("Componenta selectată nu a fost găsită în computer.");
                }
            }
        }

        private void addComponentButton_Click(object sender, EventArgs e)
        {
                var compatibilities = db.Compatibilities.ToList();
                var selectedComponent = (Component)componentDropdown.SelectedItem;

                if (computer.ComputerComponents.Any(cc => cc.ComponentId == selectedComponent.Id))
                {
                    MessageBox.Show("Această componentă a fost deja adăugată la computer.");
                    return;
                }

                var areAllComponentsCompatible = true;

                foreach (var computerComp in computer.ComputerComponents)
                {
                    var componentId = computerComp.ComponentId;
                    var isCompatible = compatibilities.Any(compat =>
                        (compat.Component1Id == componentId && compat.Component2Id == selectedComponent.Id && compat.AreCompatible)
                        ||
                        (compat.Component1Id == selectedComponent.Id && compat.Component2Id == componentId && compat.AreCompatible)
                    );

                    if (!isCompatible)
                    {
                        areAllComponentsCompatible = false;
                        break;
                    }
                }

                if (!areAllComponentsCompatible)
                {
                    MessageBox.Show("Componenta selectată nu este compatibilă cu toate componentele computerului.");
                    return;
                }


            var computerComponent = new ComputerComponent
            {
                ComputerId = computer.Id,
                ComponentId = selectedComponent.Id
            };

            db.ComputerComponents.Add(computerComponent);
            db.SaveChanges(); 

            ListViewItem item = new ListViewItem(new string[]
            {
                selectedComponent.Name,
                selectedComponent.Category,
                selectedComponent.Manufacturer,
                selectedComponent.Price.ToString()
            });

            item.Tag = selectedComponent; 

            computerDetailsListView.Items.Add(item);

        }
    }
}
