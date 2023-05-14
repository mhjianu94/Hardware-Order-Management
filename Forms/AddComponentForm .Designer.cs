namespace Hardware_Order_Management
{
    partial class AddComponentForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.name_Label = new System.Windows.Forms.Label();
            this.name_text = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.category_label = new System.Windows.Forms.Label();
            this.category_text = new System.Windows.Forms.TextBox();
            this.manufacturer_label = new System.Windows.Forms.Label();
            this.manufacturer_text = new System.Windows.Forms.TextBox();
            this.price_label = new System.Windows.Forms.Label();
            this.price_text = new System.Windows.Forms.TextBox();
            this.AddComponent_errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AddComponent_errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // name_Label
            // 
            this.name_Label.AutoSize = true;
            this.name_Label.Location = new System.Drawing.Point(56, 21);
            this.name_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name_Label.Name = "name_Label";
            this.name_Label.Size = new System.Drawing.Size(47, 16);
            this.name_Label.TabIndex = 0;
            this.name_Label.Text = "Name:";
            // 
            // name_text
            // 
            this.name_text.Location = new System.Drawing.Point(128, 15);
            this.name_text.Margin = new System.Windows.Forms.Padding(4);
            this.name_text.Name = "name_text";
            this.name_text.Size = new System.Drawing.Size(223, 22);
            this.name_text.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addButton.Location = new System.Drawing.Point(155, 171);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 28);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(263, 171);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 28);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // category_label
            // 
            this.category_label.AutoSize = true;
            this.category_label.Location = new System.Drawing.Point(43, 50);
            this.category_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.category_label.Name = "category_label";
            this.category_label.Size = new System.Drawing.Size(65, 16);
            this.category_label.TabIndex = 0;
            this.category_label.Text = "Category:";
            // 
            // category_text
            // 
            this.category_text.Location = new System.Drawing.Point(128, 47);
            this.category_text.Margin = new System.Windows.Forms.Padding(4);
            this.category_text.Name = "category_text";
            this.category_text.Size = new System.Drawing.Size(223, 22);
            this.category_text.TabIndex = 1;
            // 
            // manufacturer_label
            // 
            this.manufacturer_label.AutoSize = true;
            this.manufacturer_label.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.manufacturer_label.Location = new System.Drawing.Point(21, 84);
            this.manufacturer_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.manufacturer_label.Name = "manufacturer_label";
            this.manufacturer_label.Size = new System.Drawing.Size(87, 16);
            this.manufacturer_label.TabIndex = 0;
            this.manufacturer_label.Text = "Manufacturer:";
            // 
            // manufacturer_text
            // 
            this.manufacturer_text.Location = new System.Drawing.Point(128, 81);
            this.manufacturer_text.Margin = new System.Windows.Forms.Padding(4);
            this.manufacturer_text.Name = "manufacturer_text";
            this.manufacturer_text.Size = new System.Drawing.Size(223, 22);
            this.manufacturer_text.TabIndex = 1;
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.Location = new System.Drawing.Point(62, 116);
            this.price_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(41, 16);
            this.price_label.TabIndex = 0;
            this.price_label.Text = "Price:";
            // 
            // price_text
            // 
            this.price_text.Location = new System.Drawing.Point(128, 113);
            this.price_text.Margin = new System.Windows.Forms.Padding(4);
            this.price_text.Name = "price_text";
            this.price_text.Size = new System.Drawing.Size(223, 22);
            this.price_text.TabIndex = 1;
            // 
            // AddComponent_errorProvider
            // 
            this.AddComponent_errorProvider.ContainerControl = this;
            // 
            // AddComponentForm
            // 
            this.AcceptButton = this.addButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(371, 207);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.price_text);
            this.Controls.Add(this.price_label);
            this.Controls.Add(this.manufacturer_text);
            this.Controls.Add(this.manufacturer_label);
            this.Controls.Add(this.category_text);
            this.Controls.Add(this.category_label);
            this.Controls.Add(this.name_text);
            this.Controls.Add(this.name_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddComponentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Component";
            this.Load += new System.EventHandler(this.AddComponentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AddComponent_errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label name_Label;
        private System.Windows.Forms.TextBox name_text;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label category_label;
        private System.Windows.Forms.TextBox category_text;
        private System.Windows.Forms.Label manufacturer_label;
        private System.Windows.Forms.TextBox manufacturer_text;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.TextBox price_text;
        private System.Windows.Forms.ErrorProvider AddComponent_errorProvider;

    }
}