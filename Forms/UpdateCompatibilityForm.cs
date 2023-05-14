using System;
using System.Windows.Forms;

namespace Hardware_Order_Management
{
    public partial class UpdateCompatibilityForm : Form
    {
        public Compatibility UpdatedCompatibility { get; private set; }

        public UpdateCompatibilityForm(Compatibility compatibilityToUpdate)
        {
            InitializeComponent();

            UpdatedCompatibility = compatibilityToUpdate;

            component1IdTextBox.Text = compatibilityToUpdate.Component1Id.ToString();
            component2IdTextBox.Text = compatibilityToUpdate.Component2Id.ToString();

            component1IdTextBox.Validating += new System.ComponentModel.CancelEventHandler(component1_text_Validating);
            component2IdTextBox.Validating += new System.ComponentModel.CancelEventHandler(component2_text_Validating);

        }
 
        private void updateButton_Click(object sender, EventArgs e)
        {

            UpdatedCompatibility.Component1Id = int.Parse(component1IdTextBox.Text);
            UpdatedCompatibility.Component2Id = int.Parse(component2IdTextBox.Text);
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
                UpdateCompat_errorProvider.SetError(component1IdTextBox, "Error");
            }
            else
            {
                e.Cancel = false;
                UpdateCompat_errorProvider.SetError(component1IdTextBox, "");
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
                UpdateCompat_errorProvider.SetError(component2IdTextBox, "Error");
            }
            else
            {
                e.Cancel = false;
                UpdateCompat_errorProvider.SetError(component2IdTextBox, "");
            }
        }
        private void UpdateCompatibilityForm_Load(object sender, EventArgs e)
        {

        }
    }
}