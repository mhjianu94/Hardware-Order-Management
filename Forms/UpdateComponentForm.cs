using System;
using System.Windows.Forms;

namespace Hardware_Order_Management
{
    public partial class UpdateComponentForm : Form
    {
        public Component UpdatedComponent { get; private set; }

        public UpdateComponentForm(Component componentToUpdate)
        {
            InitializeComponent();

            UpdatedComponent = componentToUpdate;

            name_text.Text = componentToUpdate.Name;
            category_text.Text = componentToUpdate.Category;
            manufacturer_text.Text = componentToUpdate.Manufacturer;
            price_text.Text = componentToUpdate.Price.ToString();

            name_text.Validating += new System.ComponentModel.CancelEventHandler(name_text_Validating);
            price_text.Validating += new System.ComponentModel.CancelEventHandler(price_text_Validating);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
           UpdatedComponent.Name = name_text.Text;
           UpdatedComponent.Manufacturer = manufacturer_text.Text;
           UpdatedComponent.Category= category_text.Text;
           UpdatedComponent.Price = int.Parse(price_text.Text);

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
                UpdateComponent_errorProvider.SetError(name_text, "Name should not be empty");
            }
            else
            {
                e.Cancel = false;
                UpdateComponent_errorProvider.SetError(name_text, "");
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
                UpdateComponent_errorProvider.SetError(price_text, "Price should be a number");
            }
            else
            {
                e.Cancel = false;
                UpdateComponent_errorProvider.SetError(price_text, "");
            }
        }

        private void UpdateComponentForm_Load(object sender, EventArgs e)
        {

        }
    }
}