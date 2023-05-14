using System;
using System.Windows.Forms;

namespace Hardware_Order_Management
{
    public partial class AddCompatibilityForm : Form
    {
        public Compatibility NewCompatibility { get; private set; }

        public AddCompatibilityForm()
        {
            InitializeComponent();

            component1IdTextBox.Validating += new System.ComponentModel.CancelEventHandler(component1_text_Validating);
            component2IdTextBox.Validating += new System.ComponentModel.CancelEventHandler(component2_text_Validating);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
           
            NewCompatibility = new Compatibility
            {
                Component1Id = int.Parse(component1IdTextBox.Text),
                Component2Id = int.Parse(component2IdTextBox.Text),
                AreCompatible = true,
            };

            DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void component1_text_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int parsedValue;

            if (
                !int.TryParse(component1IdTextBox.Text, out parsedValue)
                ||
                string.IsNullOrEmpty(component1IdTextBox.Text)
                )
            {
                e.Cancel = true;
                AddCompat_errorProvider.SetError(component1IdTextBox, "Error");
            }
            else
            {
                e.Cancel = false;
                AddCompat_errorProvider.SetError(component1IdTextBox, "");
            }
        }

        private void component2_text_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int parsedValue;
            if (
                !int.TryParse(component2IdTextBox.Text, out parsedValue) 
                || 
                string.IsNullOrEmpty(component2IdTextBox.Text)
                )
            {
                e.Cancel = true;
                AddCompat_errorProvider.SetError(component2IdTextBox, "Error");
            }
            else
            {
                e.Cancel = false;
                AddCompat_errorProvider.SetError(component2IdTextBox, "");
            }
        }

        private void AddCompatibilityForm_Load(object sender, EventArgs e)
        {

        }
    }
}