using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Text;
using System.Xml.Serialization;
using System.Drawing;
using Hardware_Order_Management.Forms;

namespace Hardware_Order_Management
{
    public partial class MainForm : Form
    {
        private HardwareDBContext db;
        ContextMenuStrip contextMenu = new ContextMenuStrip();

        public MainForm()
        {
            InitializeComponent();
            db = new HardwareDBContext();
            RefreshLists();

            componentsList.SelectedIndexChanged += componentsListView_SelectedIndexChanged;
            compatibilityList.SelectedIndexChanged += compatibilityListView_SelectedIndexChanged;
            computersList.SelectedIndexChanged += computersListView_SelectedIndexChanged;

            //MENU STRIP
            this.Controls.Add(menuStrip);
            saveToolStripMenuItem.Click += SaveMenuItem_Click;
            exportToolStripMenuItem.Click += ExportMenuItem_Click;
            importToolStripMenuItem.Click += ImportMenuItem_Click;
            generateToolStripMenuItem.Click += GenerateGraphic_Click;


            // STATUS STRIP
            StatusStrip statusStrip = new StatusStrip();
            ToolStripStatusLabel statusLabel = new ToolStripStatusLabel("Status: Ready");
            statusStrip.Items.Add(statusLabel);
            this.Controls.Add(statusStrip);

            // CONTEXT MENU
            ToolStripMenuItem deleteMenuItem = new ToolStripMenuItem("Delete");
            ToolStripMenuItem updateMenuItem = new ToolStripMenuItem("Update");
            contextMenu.Items.Add(deleteMenuItem);
            contextMenu.Items.Add(updateMenuItem);

            computersList.ContextMenuStrip = contextMenu;
            compatibilityList.ContextMenuStrip = contextMenu;
            componentsList.ContextMenuStrip = contextMenu;

            deleteMenuItem.Click += DeleteMenuItem_Click;
            updateMenuItem.Click += UpdateMenuItem_Click;

            this.saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            this.exportToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.E;
            this.importToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.I;

        }

        private void MainProgram_Load(object sender, EventArgs e)
        {
            componentsList.View = View.Details;
            componentsList.Columns.Add("ID", 30, HorizontalAlignment.Left);
            componentsList.Columns.Add("Name", 100, HorizontalAlignment.Left);
            componentsList.Columns.Add("Category", 70, HorizontalAlignment.Left);
            componentsList.Columns.Add("Manufacturer", 120, HorizontalAlignment.Left);
            componentsList.Columns.Add("Price", 50, HorizontalAlignment.Left);
            
            componentsList.Items.Clear();
            foreach (Component component in db.Components)
            {
                ListViewItem item = new ListViewItem(component.Id.ToString());
                item.SubItems.Add(component.Name.ToString());
                item.SubItems.Add(component.Category.ToString());
                item.SubItems.Add(component.Manufacturer.ToString());
                item.SubItems.Add(component.Price.ToString());
                item.Tag = component;

                componentsList.Items.Add(item);
            }

            compatibilityList.View = View.Details;
            compatibilityList.Columns.Add("ID", 30, HorizontalAlignment.Left);
            compatibilityList.Columns.Add("Component 1 ID", 100, HorizontalAlignment.Left);
            compatibilityList.Columns.Add("Component 2 ID", 100, HorizontalAlignment.Left);
            compatibilityList.Columns.Add("Are Compatible", 100, HorizontalAlignment.Left);

            compatibilityList.Items.Clear();
            foreach (Compatibility compatibility in db.Compatibilities)
            {
                ListViewItem item = new ListViewItem(compatibility.Id.ToString());
                item.SubItems.Add(compatibility.Component1Id.ToString());
                item.SubItems.Add(compatibility.Component2Id.ToString());
                item.SubItems.Add(compatibility.AreCompatible.ToString());
                item.Tag = compatibility;

                compatibilityList.Items.Add(item);
            }

            computersList.View = View.Details;
            computersList.Columns.Add("ID", 40, HorizontalAlignment.Left);
            computersList.Columns.Add("Model", 200, HorizontalAlignment.Left);

            computersList.Items.Clear();
            foreach (Computer computer in db.Computers)
            {
                ListViewItem item = new ListViewItem(computer.Id.ToString());
                item.SubItems.Add(computer.Model.ToString());
                item.Tag = computer;
                
                computersList.Items.Add(item);
            }

        }

        private void RefreshLists()
        {
            componentsList.Items.Clear();
            foreach (Component component in db.Components)
            {
                ListViewItem item = new ListViewItem(component.Id.ToString());
                item.SubItems.Add(component.Name.ToString());
                item.SubItems.Add(component.Category.ToString());
                item.SubItems.Add(component.Manufacturer.ToString());
                item.SubItems.Add(component.Price.ToString());
                item.Tag = component;

                componentsList.Items.Add(item);
            }

            compatibilityList.Items.Clear();
            foreach (Compatibility compatibility in db.Compatibilities)
            {
                ListViewItem item = new ListViewItem(compatibility.Id.ToString());
                item.SubItems.Add(compatibility.Component1Id.ToString());
                item.SubItems.Add(compatibility.Component2Id.ToString());
                item.SubItems.Add(compatibility.AreCompatible.ToString());
                item.Tag = compatibility;

                compatibilityList.Items.Add(item);
            }

            computersList.Items.Clear();
            foreach (Computer computer in db.Computers)
            {
                ListViewItem item = new ListViewItem(computer.Id.ToString());
                item.SubItems.Add(computer.Model.ToString());
                item.Tag = computer;

                computersList.Items.Add(item);
            }
        }

        private void SaveMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "TXT Files (*.txt)|*.txt";
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.AddExtension = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine("====Components====");
                foreach (var component in db.Components.ToList())
                {
                    sb.AppendLine($"ID: {component.Id}, Name: {component.Name}, Category: {component.Category}, Manufacturer: {component.Manufacturer}, Price: {component.Price}");
                }

                sb.AppendLine("\n====Compatibilities====");
                foreach (var compatibility in db.Compatibilities.ToList())
                {
                    sb.AppendLine($"ID: {compatibility.Id}, Component 1 ID: {compatibility.Component1Id}, Component 2 ID: {compatibility.Component2Id}, Are Compatible: {compatibility.AreCompatible}");
                }

                sb.AppendLine("\n====Computers====");
                foreach (var computer in db.Computers.ToList())
                {
                    sb.AppendLine($"ID: {computer.Id}, Model: {computer.Model}");
                }

                System.IO.File.WriteAllText(saveFileDialog.FileName, sb.ToString());
            }
        }

        private void ExportMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON Files (*.json)|*.json";
            saveFileDialog.DefaultExt = "json";
            saveFileDialog.AddExtension = true;

            var data = new
            {
                Components = db.Components.ToList(),
                Compatibilities = db.Compatibilities.ToList(),
                Computers = db.Computers.ToList()
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string json = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.Indented);
                System.IO.File.WriteAllText(saveFileDialog.FileName, json);
            }
        }

        private void ImportMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON Files (*.json)|*.json";
            openFileDialog.DefaultExt = "json";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string json = System.IO.File.ReadAllText(openFileDialog.FileName);
                Data data = JsonConvert.DeserializeObject<Data>(json);

                foreach (Component component in data.Components)
                {
                    db.Components.Add(component);
                }
                foreach (Compatibility compatibility in data.Compatibilities)
                {
                    db.Compatibilities.Add(compatibility);
                }
                foreach (Computer computer in data.Computers)
                {
                    db.Computers.Add(computer);       
                }

                db.SaveChanges();
                RefreshLists();
            }
        }

        private void GenerateGraphic_Click(object sender, EventArgs e) {
            var statsData = new GenerateStatData(db);
            var data = statsData.GetCategoryCounts();

            GenerateGraphics chart = new GenerateGraphics(data);
            chart.Dock = DockStyle.Fill;

            Form chartForm = new Form();
            chartForm.Text = "Category Chart";
            chartForm.Size = new Size(800, 600); 

            chartForm.Controls.Add(chart);

            chartForm.Show();
        }


        private void addComponentButton_Click(object sender, EventArgs e)
        {
            var addComponentForm = new AddComponentForm();
            if (addComponentForm.ShowDialog() == DialogResult.OK)
            {
                db.Components.Add(addComponentForm.NewComponent);
                db.SaveChanges();
                RefreshLists();

            }
        }

        private void updateComponentButton_Click(object sender, EventArgs e)
        {
            if (componentsList.SelectedItems.Count > 0)
            {
                var component = (Component)componentsList.SelectedItems[0].Tag;
                if (component != null)
                {
                    var updateComponentForm = new UpdateComponentForm(component);
                    if (updateComponentForm.ShowDialog() == DialogResult.OK)
                    {
                        db.Entry(updateComponentForm.UpdatedComponent).State = EntityState.Modified;
                        db.SaveChanges();
                        RefreshLists();
                    }
                }
            }
        }

        private void deleteComponentButton_Click(object sender, EventArgs e)
        {
            if (componentsList.SelectedItems.Count > 0)
            {
                var component = (Component)componentsList.SelectedItems[0].Tag;
                if (component != null)
                {
                    db.Components.Remove(component);
                    db.SaveChanges();
                    RefreshLists();
                }
            }
        }

        private void addCompatibilityButton_Click(object sender, EventArgs e)
        {
            var addCompatibilityForm = new AddCompatibilityForm();
            if (addCompatibilityForm.ShowDialog() == DialogResult.OK)
            {
                db.Compatibilities.Add(addCompatibilityForm.NewCompatibility);
                db.SaveChanges();
                RefreshLists();
            }
        }

        private void updateCompatibilityButton_Click(object sender, EventArgs e)
        {
            if (compatibilityList.SelectedItems.Count > 0)
            {
                var compatibility = (Compatibility)compatibilityList.SelectedItems[0].Tag;
                if (compatibility != null)
                {
                    var updateCompatibilityForm = new UpdateCompatibilityForm(compatibility);
                    if (updateCompatibilityForm.ShowDialog() == DialogResult.OK)
                    {
                        db.Entry(updateCompatibilityForm.UpdatedCompatibility).State = EntityState.Modified;
                        db.SaveChanges();
                        RefreshLists();
                    }
                }
            }
        }

        private void deleteCompatibilityButton_Click(object sender, EventArgs e)
        {
            if (compatibilityList.SelectedItems.Count > 0)
            {
                var compatibility = (Compatibility)compatibilityList.SelectedItems[0].Tag;
                if (compatibility != null)
                {
                    db.Compatibilities.Remove(compatibility);
                    db.SaveChanges();
                    RefreshLists();
                }
            }
        }

        private void addComputerButton_Click(object sender, EventArgs e)
        {
            var addComputerForm = new AddComputerForm();
            if (addComputerForm.ShowDialog() == DialogResult.OK)
            {
                db.Computers.Add(addComputerForm.NewComputer);
                db.SaveChanges();
                RefreshLists();
            }
        }

        private void updateComputerButton_Click(object sender, EventArgs e)
        {
            if (computersList.SelectedItems.Count > 0)
            {
                var computer = (Computer)computersList.SelectedItems[0].Tag;
                if (computer != null)
                {
                    var updateComputerForm = new UpdateComputerForm(computer);
                    if (updateComputerForm.ShowDialog() == DialogResult.OK)
                    {
                        db.Entry(updateComputerForm.UpdatedComputer).State = EntityState.Modified;
                        db.SaveChanges();
                        RefreshLists();
                    }
                }
            }
        }

        private void deleteComputerButton_Click(object sender, EventArgs e)
        {
          

            if (computersList.SelectedItems.Count > 0)
            {
                var computer = (Computer)computersList.SelectedItems[0].Tag;

                var computerComponents = db.ComputerComponents
                          .Where(cc => cc.ComputerId == computer.Id)
                          .ToList();

                db.ComputerComponents.RemoveRange(computerComponents);


                if (computer != null)
                {
                    db.Computers.Remove(computer);
                    db.SaveChanges();
                    RefreshLists();
                }
            }
        }
        private void componentsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (componentsList.SelectedItems.Count > 0)
            {
                var selectedComponent = (Component)componentsList.SelectedItems[0].Tag;
            }
        }
        private void computersListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (computersList.SelectedItems.Count > 0)
            {
                var selectedComputer = (Computer)computersList.SelectedItems[0].Tag;
            }
        }
        private void compatibilityListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (compatibilityList.SelectedItems.Count > 0)
            {
                var selectedCompatibility = (Compatibility)compatibilityList.SelectedItems[0].Tag;
            }
        }

        private void UpdateMenuItem_Click(object sender, EventArgs e)
        {
            if (contextMenu.SourceControl == componentsList)
            {
                if (componentsList.SelectedItems.Count > 0)
                {
                    var component = (Component)componentsList.SelectedItems[0].Tag;
                    if (component != null)
                    {
                        var updateComputerForm = new UpdateComponentForm(component);
                        if (updateComputerForm.ShowDialog() == DialogResult.OK)
                        {
                            db.Entry(updateComputerForm.UpdatedComponent).State = EntityState.Modified;
                            db.SaveChanges();
                            RefreshLists();
                        }
                    }
                }
            }
            else if (contextMenu.SourceControl == compatibilityList)
            {
                if (compatibilityList.SelectedItems.Count > 0)
                {
                    var compatibility = (Compatibility)compatibilityList.SelectedItems[0].Tag;
                    if (compatibility != null)
                    {
                        var updateCompatibilityForm = new UpdateCompatibilityForm(compatibility);
                        if (updateCompatibilityForm.ShowDialog() == DialogResult.OK)
                        {
                            db.Entry(updateCompatibilityForm.UpdatedCompatibility).State = EntityState.Modified;
                            db.SaveChanges();
                            RefreshLists();
                        }
                    }
                }
            }
            else if (contextMenu.SourceControl == computersList)
            {
                if (computersList.SelectedItems.Count > 0)
                {
                    var computer = (Computer)computersList.SelectedItems[0].Tag;
                    if (computer != null)
                    {
                        var updateComputerForm = new UpdateComputerForm(computer);
                        if (updateComputerForm.ShowDialog() == DialogResult.OK)
                        {
                            db.Entry(updateComputerForm.UpdatedComputer).State = EntityState.Modified;
                            db.SaveChanges();
                            RefreshLists();
                        }
                    }
                }
            }
        }

        private void DeleteMenuItem_Click(object sender, EventArgs e)
        {
            if (contextMenu.SourceControl == componentsList)
            {
                var component = (Component)componentsList.SelectedItems[0].Tag;
                if (component != null)
                {
                    db.Components.Remove(component);
                    db.SaveChanges();
                    RefreshLists();
                }
            }
            else if (contextMenu.SourceControl == compatibilityList)
            {
                var compatibilitie = (Compatibility)compatibilityList.SelectedItems[0].Tag;
                if (compatibilitie != null)
                {
                    db.Compatibilities.Remove(compatibilitie);
                    db.SaveChanges();
                    RefreshLists();
                }
            }
            else if (contextMenu.SourceControl == computersList)
            {
                var computer = (Computer)computersList.SelectedItems[0].Tag;
                if (computer != null)
                {
                    db.Computers.Remove(computer);
                    db.SaveChanges();
                    RefreshLists();
                }

            }
        }

        private void computersListView_DoubleClick(object sender, EventArgs e)
        {
            if (computersList.SelectedItems.Count > 0)
            {
                var computer = (Computer)computersList.SelectedItems[0].Tag;
                if (computer != null)
                {
                    var computerDetailsForm = new ComputerDetailsForm(computer,db);
                    computerDetailsForm.Show();
                }
            }
        }

        private void componentsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void compatibilityList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}