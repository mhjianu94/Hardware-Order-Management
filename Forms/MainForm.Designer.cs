namespace Hardware_Order_Management
{
    partial class MainForm
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
            this.componentsLabel = new System.Windows.Forms.Label();
            this.compatibilityLabel = new System.Windows.Forms.Label();
            this.computersLabel = new System.Windows.Forms.Label();
            this.addComponentButton = new System.Windows.Forms.Button();
            this.updateComponentButton = new System.Windows.Forms.Button();
            this.deleteComponentButton = new System.Windows.Forms.Button();
            this.addCompatibilityButton = new System.Windows.Forms.Button();
            this.updateCompatibilityButton = new System.Windows.Forms.Button();
            this.deleteCompatibilityButton = new System.Windows.Forms.Button();
            this.addComputerButton = new System.Windows.Forms.Button();
            this.updateComputerButton = new System.Windows.Forms.Button();
            this.deleteComputerButton = new System.Windows.Forms.Button();
            this.componentsList = new System.Windows.Forms.ListView();
            this.compatibilityList = new System.Windows.Forms.ListView();
            this.computersList = new System.Windows.Forms.ListView();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // componentsLabel
            // 
            this.componentsLabel.AutoSize = true;
            this.componentsLabel.Location = new System.Drawing.Point(14, 48);
            this.componentsLabel.Name = "componentsLabel";
            this.componentsLabel.Size = new System.Drawing.Size(83, 16);
            this.componentsLabel.TabIndex = 0;
            this.componentsLabel.Text = "Components";
            // 
            // compatibilityLabel
            // 
            this.compatibilityLabel.AutoSize = true;
            this.compatibilityLabel.Location = new System.Drawing.Point(13, 226);
            this.compatibilityLabel.Name = "compatibilityLabel";
            this.compatibilityLabel.Size = new System.Drawing.Size(84, 16);
            this.compatibilityLabel.TabIndex = 1;
            this.compatibilityLabel.Text = "Compatibility";
            // 
            // computersLabel
            // 
            this.computersLabel.AutoSize = true;
            this.computersLabel.Location = new System.Drawing.Point(13, 403);
            this.computersLabel.Name = "computersLabel";
            this.computersLabel.Size = new System.Drawing.Size(72, 16);
            this.computersLabel.TabIndex = 2;
            this.computersLabel.Text = "Computers";
            // 
            // addComponentButton
            // 
            this.addComponentButton.Location = new System.Drawing.Point(549, 68);
            this.addComponentButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addComponentButton.Name = "addComponentButton";
            this.addComponentButton.Size = new System.Drawing.Size(75, 37);
            this.addComponentButton.TabIndex = 6;
            this.addComponentButton.Text = "Add";
            this.addComponentButton.UseVisualStyleBackColor = true;
            this.addComponentButton.Click += new System.EventHandler(this.addComponentButton_Click);
            // 
            // updateComponentButton
            // 
            this.updateComponentButton.Location = new System.Drawing.Point(549, 109);
            this.updateComponentButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateComponentButton.Name = "updateComponentButton";
            this.updateComponentButton.Size = new System.Drawing.Size(75, 40);
            this.updateComponentButton.TabIndex = 7;
            this.updateComponentButton.Text = "Update";
            this.updateComponentButton.UseVisualStyleBackColor = true;
            this.updateComponentButton.Click += new System.EventHandler(this.updateComponentButton_Click);
            // 
            // deleteComponentButton
            // 
            this.deleteComponentButton.Location = new System.Drawing.Point(549, 153);
            this.deleteComponentButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteComponentButton.Name = "deleteComponentButton";
            this.deleteComponentButton.Size = new System.Drawing.Size(75, 38);
            this.deleteComponentButton.TabIndex = 8;
            this.deleteComponentButton.Text = "Delete";
            this.deleteComponentButton.UseVisualStyleBackColor = true;
            this.deleteComponentButton.Click += new System.EventHandler(this.deleteComponentButton_Click);
            // 
            // addCompatibilityButton
            // 
            this.addCompatibilityButton.Location = new System.Drawing.Point(549, 246);
            this.addCompatibilityButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addCompatibilityButton.Name = "addCompatibilityButton";
            this.addCompatibilityButton.Size = new System.Drawing.Size(75, 40);
            this.addCompatibilityButton.TabIndex = 9;
            this.addCompatibilityButton.Text = "Add";
            this.addCompatibilityButton.UseVisualStyleBackColor = true;
            this.addCompatibilityButton.Click += new System.EventHandler(this.addCompatibilityButton_Click);
            // 
            // updateCompatibilityButton
            // 
            this.updateCompatibilityButton.Location = new System.Drawing.Point(549, 290);
            this.updateCompatibilityButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateCompatibilityButton.Name = "updateCompatibilityButton";
            this.updateCompatibilityButton.Size = new System.Drawing.Size(75, 42);
            this.updateCompatibilityButton.TabIndex = 10;
            this.updateCompatibilityButton.Text = "Update";
            this.updateCompatibilityButton.UseVisualStyleBackColor = true;
            this.updateCompatibilityButton.Click += new System.EventHandler(this.updateCompatibilityButton_Click);
            // 
            // deleteCompatibilityButton
            // 
            this.deleteCompatibilityButton.Location = new System.Drawing.Point(547, 336);
            this.deleteCompatibilityButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteCompatibilityButton.Name = "deleteCompatibilityButton";
            this.deleteCompatibilityButton.Size = new System.Drawing.Size(75, 39);
            this.deleteCompatibilityButton.TabIndex = 11;
            this.deleteCompatibilityButton.Text = "Delete";
            this.deleteCompatibilityButton.UseVisualStyleBackColor = true;
            this.deleteCompatibilityButton.Click += new System.EventHandler(this.deleteCompatibilityButton_Click);
            // 
            // addComputerButton
            // 
            this.addComputerButton.Location = new System.Drawing.Point(545, 421);
            this.addComputerButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addComputerButton.Name = "addComputerButton";
            this.addComputerButton.Size = new System.Drawing.Size(75, 39);
            this.addComputerButton.TabIndex = 12;
            this.addComputerButton.Text = "Add";
            this.addComputerButton.UseVisualStyleBackColor = true;
            this.addComputerButton.Click += new System.EventHandler(this.addComputerButton_Click);
            // 
            // updateComputerButton
            // 
            this.updateComputerButton.Location = new System.Drawing.Point(545, 464);
            this.updateComputerButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateComputerButton.Name = "updateComputerButton";
            this.updateComputerButton.Size = new System.Drawing.Size(75, 39);
            this.updateComputerButton.TabIndex = 13;
            this.updateComputerButton.Text = "Update";
            this.updateComputerButton.UseVisualStyleBackColor = true;
            this.updateComputerButton.Click += new System.EventHandler(this.updateComputerButton_Click);
            // 
            // deleteComputerButton
            // 
            this.deleteComputerButton.Location = new System.Drawing.Point(545, 507);
            this.deleteComputerButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteComputerButton.Name = "deleteComputerButton";
            this.deleteComputerButton.Size = new System.Drawing.Size(75, 40);
            this.deleteComputerButton.TabIndex = 14;
            this.deleteComputerButton.Text = "Delete";
            this.deleteComputerButton.UseVisualStyleBackColor = true;
            this.deleteComputerButton.Click += new System.EventHandler(this.deleteComputerButton_Click);
            // 
            // componentsList
            // 
            this.componentsList.FullRowSelect = true;
            this.componentsList.HideSelection = false;
            this.componentsList.Location = new System.Drawing.Point(13, 68);
            this.componentsList.Margin = new System.Windows.Forms.Padding(4);
            this.componentsList.MultiSelect = false;
            this.componentsList.Name = "componentsList";
            this.componentsList.Size = new System.Drawing.Size(525, 138);
            this.componentsList.TabIndex = 15;
            this.componentsList.UseCompatibleStateImageBehavior = false;
            this.componentsList.SelectedIndexChanged += new System.EventHandler(this.componentsList_SelectedIndexChanged);
            // 
            // compatibilityList
            // 
            this.compatibilityList.FullRowSelect = true;
            this.compatibilityList.HideSelection = false;
            this.compatibilityList.Location = new System.Drawing.Point(15, 246);
            this.compatibilityList.Margin = new System.Windows.Forms.Padding(4);
            this.compatibilityList.Name = "compatibilityList";
            this.compatibilityList.Size = new System.Drawing.Size(525, 139);
            this.compatibilityList.TabIndex = 16;
            this.compatibilityList.UseCompatibleStateImageBehavior = false;
            this.compatibilityList.SelectedIndexChanged += new System.EventHandler(this.compatibilityList_SelectedIndexChanged);
            // 
            // computersList
            // 
            this.computersList.FullRowSelect = true;
            this.computersList.HideSelection = false;
            this.computersList.Location = new System.Drawing.Point(16, 423);
            this.computersList.Margin = new System.Windows.Forms.Padding(4);
            this.computersList.Name = "computersList";
            this.computersList.Size = new System.Drawing.Size(525, 149);
            this.computersList.TabIndex = 17;
            this.computersList.UseCompatibleStateImageBehavior = false;
            this.computersList.DoubleClick += new System.EventHandler(this.computersListView_DoubleClick);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.importToolStripMenuItem,
            this.generateToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(644, 28);
            this.menuStrip.TabIndex = 18;
            this.menuStrip.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // generateToolStripMenuItem
            // 
            this.generateToolStripMenuItem.Name = "generateToolStripMenuItem";
            this.generateToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.generateToolStripMenuItem.Text = "Generate";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 617);
            this.Controls.Add(this.computersList);
            this.Controls.Add(this.compatibilityList);
            this.Controls.Add(this.componentsList);
            this.Controls.Add(this.deleteComputerButton);
            this.Controls.Add(this.updateComputerButton);
            this.Controls.Add(this.addComputerButton);
            this.Controls.Add(this.deleteCompatibilityButton);
            this.Controls.Add(this.updateCompatibilityButton);
            this.Controls.Add(this.addCompatibilityButton);
            this.Controls.Add(this.deleteComponentButton);
            this.Controls.Add(this.updateComponentButton);
            this.Controls.Add(this.addComponentButton);
            this.Controls.Add(this.computersLabel);
            this.Controls.Add(this.compatibilityLabel);
            this.Controls.Add(this.componentsLabel);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Hardware - Componente, Compatibilitati, Calculatoare";
            this.Load += new System.EventHandler(this.MainProgram_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label componentsLabel;
        private System.Windows.Forms.Label compatibilityLabel;
        private System.Windows.Forms.Label computersLabel;
        private System.Windows.Forms.Button addComponentButton;
        private System.Windows.Forms.Button updateComponentButton;
        private System.Windows.Forms.Button deleteComponentButton;
        private System.Windows.Forms.Button addCompatibilityButton;
        private System.Windows.Forms.Button updateCompatibilityButton;
        private System.Windows.Forms.Button deleteCompatibilityButton;
        private System.Windows.Forms.Button addComputerButton;
        private System.Windows.Forms.Button updateComputerButton;
        private System.Windows.Forms.Button deleteComputerButton;
        private System.Windows.Forms.ListView componentsList;
        private System.Windows.Forms.ListView compatibilityList;
        private System.Windows.Forms.ListView computersList;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateToolStripMenuItem;
    }
}