using System;
using System.Windows.Forms;

namespace Hardware_Order_Management
{
    public partial class UpdateComputerForm : Form
    {
        public Computer UpdatedComputer { get; private set; }

        public UpdateComputerForm(Computer computerToUpdate)
        {
            InitializeComponent();

            UpdatedComputer = computerToUpdate;
            nameTextBox.Text = computerToUpdate.Model;

            nameTextBox.Validating += new System.ComponentModel.CancelEventHandler(name_text_Validating);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {

            UpdatedComputer.Model = nameTextBox.Text;

            DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void name_text_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (nameTextBox.Text.Length < 3)
            {
                e.Cancel = true;
                UpdateComputer_errorProvider.SetError(nameTextBox, "Name should be at least 3 caracters");
            }
            else
            {
                e.Cancel = false;
                UpdateComputer_errorProvider.SetError(nameTextBox, "");
            }

        }

        private void UpdateComputerForm_Load(object sender, EventArgs e)
        {

        }
    }
}