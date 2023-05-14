namespace Hardware_Order_Management.Forms
{
    partial class ComputerDetailsForm
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.computerDetailsListView = new System.Windows.Forms.ListView();
            this.computer_name_label = new System.Windows.Forms.Label();
            this.componentDropdown = new System.Windows.Forms.ComboBox();
            this.addComponentButton = new System.Windows.Forms.Button();
            this.removeComponentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // computerDetailsListView
            // 
            this.computerDetailsListView.FullRowSelect = true;
            this.computerDetailsListView.HideSelection = false;
            this.computerDetailsListView.Location = new System.Drawing.Point(12, 41);
            this.computerDetailsListView.Name = "computerDetailsListView";
            this.computerDetailsListView.Size = new System.Drawing.Size(466, 368);
            this.computerDetailsListView.TabIndex = 0;
            this.computerDetailsListView.UseCompatibleStateImageBehavior = false;
            // 
            // computer_name_label
            // 
            this.computer_name_label.AutoSize = true;
            this.computer_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computer_name_label.Location = new System.Drawing.Point(7, 9);
            this.computer_name_label.Name = "computer_name_label";
            this.computer_name_label.Size = new System.Drawing.Size(155, 25);
            this.computer_name_label.TabIndex = 1;
            this.computer_name_label.Text = "Computer Name";
            // 
            // componentDropdown
            // 
            this.componentDropdown.FormattingEnabled = true;
            this.componentDropdown.Location = new System.Drawing.Point(15, 415);
            this.componentDropdown.Name = "componentDropdown";
            this.componentDropdown.Size = new System.Drawing.Size(200, 24);
            this.componentDropdown.TabIndex = 2;
            // 
            // addComponentButton
            // 
            this.addComponentButton.Location = new System.Drawing.Point(220, 415);
            this.addComponentButton.Name = "addComponentButton";
            this.addComponentButton.Size = new System.Drawing.Size(75, 23);
            this.addComponentButton.TabIndex = 3;
            this.addComponentButton.Text = "Add";
            this.addComponentButton.UseVisualStyleBackColor = true;
            this.addComponentButton.Click += new System.EventHandler(this.addComponentButton_Click);
            // 
            // removeComponentButton
            // 
            this.removeComponentButton.Location = new System.Drawing.Point(301, 415);
            this.removeComponentButton.Name = "removeComponentButton";
            this.removeComponentButton.Size = new System.Drawing.Size(75, 23);
            this.removeComponentButton.TabIndex = 3;
            this.removeComponentButton.Text = "Remove";
            this.removeComponentButton.UseVisualStyleBackColor = true;
            this.removeComponentButton.Click += new System.EventHandler(this.removeComponentButton_Click);

            // 
            // ComputerDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 450);
            this.Controls.Add(this.computer_name_label);
            this.Controls.Add(this.computerDetailsListView);
            this.Controls.Add(this.removeComponentButton);
            this.Controls.Add(this.addComponentButton);
            this.Controls.Add(this.componentDropdown);
            this.Name = "ComputerDetailsForm";
            this.Text = "Computer Details";
            this.Load += new System.EventHandler(this.ComputerDetailsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView computerDetailsListView;
        private System.Windows.Forms.Label computer_name_label;
        private System.Windows.Forms.ComboBox componentDropdown;
        private System.Windows.Forms.Button addComponentButton;
        private System.Windows.Forms.Button removeComponentButton;
    }
}