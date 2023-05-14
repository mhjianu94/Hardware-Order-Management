using System;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Hardware_Order_Management
{
    public partial class AddComputerForm : Form
    {
        public Computer NewComputer { get; private set; }

        public AddComputerForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            NewComputer = new Computer
            {
                Model = nameTextBox.Text,
            };

            nameTextBox.Validating += new System.ComponentModel.CancelEventHandler(name_text_Validating);

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
                AddComputer_errorProvider.SetError(nameTextBox, "Name should not be at least 3 caracters");
            }
            else
            {
                e.Cancel = false;
                AddComputer_errorProvider.SetError(nameTextBox, "");
            }

        }
        private void AddComputerForm_Load(object sender, EventArgs e)
        {

        }
    }
}