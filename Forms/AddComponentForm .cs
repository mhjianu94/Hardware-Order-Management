using System;
using System.Windows.Forms;

namespace Hardware_Order_Management
{
    public partial class AddComponentForm : Form
    {
        public Component NewComponent { get; private set; }

        public AddComponentForm()
        {
            InitializeComponent();

            name_text.Validating += new System.ComponentModel.CancelEventHandler(name_text_Validating);
            price_text.Validating += new System.ComponentModel.CancelEventHandler(price_text_Validating);
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            NewComponent = new Component
            {
                Name = name_text.Text,
                Category = category_text.Text,
                Manufacturer = manufacturer_text.Text,
                Price = int.Parse(price_text.Text),

            };

            DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void name_text_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(name_text.Text))
            {
                e.Cancel = true;
                AddComponent_errorProvider.SetError(name_text, "Name should not be empty");
            }
            else
            {
                e.Cancel = false;
                AddComponent_errorProvider.SetError(name_text, "");
            }
        }

        private void price_text_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int parsedValue;
            if (
                !int.TryParse(price_text.Text, out parsedValue)
                &&
                !string.IsNullOrEmpty(price_text.Text)
                )
            {
                e.Cancel = true;
                AddComponent_errorProvider.SetError(price_text, "Price should be a number");
            }
            else
            {
                e.Cancel = false;
                AddComponent_errorProvider.SetError(price_text, "");
            }
        }

        private void AddComponentForm_Load(object sender, EventArgs e)
        {

        }
    }
}