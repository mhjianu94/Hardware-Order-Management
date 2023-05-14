namespace Hardware_Order_Management
{
    partial class UpdateCompatibilityForm
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
            this.Component1Label = new System.Windows.Forms.Label();
            this.component1IdTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.Component2Label = new System.Windows.Forms.Label();
            this.component2IdTextBox = new System.Windows.Forms.TextBox();
            this.areCompatibleLabel = new System.Windows.Forms.Label();
            this.areCompatibleCheckBox = new System.Windows.Forms.CheckBox();
            this.UpdateCompat_errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.UpdateCompat_errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Component1Label
            // 
            this.Component1Label.AutoSize = true;
            this.Component1Label.Location = new System.Drawing.Point(16, 18);
            this.Component1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Component1Label.Name = "Component1Label";
            this.Component1Label.Size = new System.Drawing.Size(89, 16);
            this.Component1Label.TabIndex = 0;
            this.Component1Label.Text = "Component 1:";
            // 
            // component1IdTextBox
            // 
            this.component1IdTextBox.Location = new System.Drawing.Point(136, 18);
            this.component1IdTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.component1IdTextBox.Name = "component1IdTextBox";
            this.component1IdTextBox.Size = new System.Drawing.Size(280, 22);
            this.component1IdTextBox.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addButton.Location = new System.Drawing.Point(211, 105);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 28);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(316, 105);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 28);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // Component2Label
            // 
            this.Component2Label.AutoSize = true;
            this.Component2Label.Location = new System.Drawing.Point(16, 57);
            this.Component2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Component2Label.Name = "Component2Label";
            this.Component2Label.Size = new System.Drawing.Size(89, 16);
            this.Component2Label.TabIndex = 0;
            this.Component2Label.Text = "Component 2:";
            // 
            // component2IdTextBox
            // 
            this.component2IdTextBox.Location = new System.Drawing.Point(136, 53);
            this.component2IdTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.component2IdTextBox.Name = "component2IdTextBox";
            this.component2IdTextBox.Size = new System.Drawing.Size(280, 22);
            this.component2IdTextBox.TabIndex = 1;
            // 
            // areCompatibleLabel
            // 
            this.areCompatibleLabel.Location = new System.Drawing.Point(0, 0);
            this.areCompatibleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.areCompatibleLabel.Name = "areCompatibleLabel";
            this.areCompatibleLabel.Size = new System.Drawing.Size(133, 28);
            this.areCompatibleLabel.TabIndex = 4;
            // 
            // areCompatibleCheckBox
            // 
            this.areCompatibleCheckBox.Location = new System.Drawing.Point(0, 0);
            this.areCompatibleCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.areCompatibleCheckBox.Name = "areCompatibleCheckBox";
            this.areCompatibleCheckBox.Size = new System.Drawing.Size(139, 30);
            this.areCompatibleCheckBox.TabIndex = 5;
            // 
            // UpdateCompat_errorProvider
            // 
            this.UpdateCompat_errorProvider.ContainerControl = this;
            // 
            // UpdateCompatibilityForm
            // 
            this.AcceptButton = this.addButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(448, 146);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.component2IdTextBox);
            this.Controls.Add(this.component1IdTextBox);
            this.Controls.Add(this.Component2Label);
            this.Controls.Add(this.Component1Label);
            this.Controls.Add(this.areCompatibleLabel);
            this.Controls.Add(this.areCompatibleCheckBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateCompatibilityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Compatibility";
            this.Load += new System.EventHandler(this.UpdateCompatibilityForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UpdateCompat_errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label Component1Label;
        private System.Windows.Forms.TextBox component1IdTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label Component2Label;
        private System.Windows.Forms.TextBox component2IdTextBox;
        private System.Windows.Forms.Label areCompatibleLabel;
        private System.Windows.Forms.CheckBox areCompatibleCheckBox;
        private System.Windows.Forms.ErrorProvider UpdateCompat_errorProvider;
    }
}