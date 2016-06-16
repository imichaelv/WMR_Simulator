namespace wms_simulator.View
{
    partial class MainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.StartButton = new System.Windows.Forms.Button();
            this.SuppliersBox = new System.Windows.Forms.CheckBox();
            this.StoresBox = new System.Windows.Forms.CheckBox();
            this.speedbar = new System.Windows.Forms.TrackBar();
            this.SimulateSpeedLabel = new System.Windows.Forms.Label();
            this.AmountSuppliersBar = new System.Windows.Forms.TrackBar();
            this.AmountStoresBar = new System.Windows.Forms.TrackBar();
            this.AmountSuppliersLabel = new System.Windows.Forms.Label();
            this.AmountStoresLabel = new System.Windows.Forms.Label();
            this.SupplierProcessSpeedBar = new System.Windows.Forms.TrackBar();
            this.SupplierProcesSpeedLabel = new System.Windows.Forms.Label();
            this.StoresProcessSpeed = new System.Windows.Forms.Label();
            this.StoresProcessSpeedBar = new System.Windows.Forms.TrackBar();
            this.SupplierAmountDisplay = new System.Windows.Forms.Label();
            this.SupplierProcessSpeedDisplay = new System.Windows.Forms.Label();
            this.StoresAmmountDisplay = new System.Windows.Forms.Label();
            this.StoresProcessSpeedDisplay = new System.Windows.Forms.Label();
            this.SimulatorSpeedDisplay = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountSuppliersBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountStoresBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierProcessSpeedBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoresProcessSpeedBar)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(334, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpMenuToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpMenuToolStripMenuItem
            // 
            this.helpMenuToolStripMenuItem.Name = "helpMenuToolStripMenuItem";
            this.helpMenuToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.helpMenuToolStripMenuItem.Text = "Help Menu";
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aToolStripMenuItem.Text = "About";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(334, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(94, 17);
            this.StatusLabel.Text = "                             ";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(0, 27);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(136, 30);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Start Simulator";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // SuppliersBox
            // 
            this.SuppliersBox.AutoSize = true;
            this.SuppliersBox.Checked = true;
            this.SuppliersBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SuppliersBox.Location = new System.Drawing.Point(12, 63);
            this.SuppliersBox.Name = "SuppliersBox";
            this.SuppliersBox.Size = new System.Drawing.Size(69, 17);
            this.SuppliersBox.TabIndex = 3;
            this.SuppliersBox.Text = "Suppliers";
            this.SuppliersBox.UseVisualStyleBackColor = true;
            this.SuppliersBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.SuppliersBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.checkBox1_KeyDown);
            // 
            // StoresBox
            // 
            this.StoresBox.AutoSize = true;
            this.StoresBox.Checked = true;
            this.StoresBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.StoresBox.Location = new System.Drawing.Point(12, 87);
            this.StoresBox.Name = "StoresBox";
            this.StoresBox.Size = new System.Drawing.Size(56, 17);
            this.StoresBox.TabIndex = 4;
            this.StoresBox.Text = "Stores";
            this.StoresBox.UseVisualStyleBackColor = true;
            this.StoresBox.CheckedChanged += new System.EventHandler(this.StoresBox_CheckedChanged);
            // 
            // speedbar
            // 
            this.speedbar.AccessibleDescription = "sdsad";
            this.speedbar.AccessibleName = "";
            this.speedbar.Location = new System.Drawing.Point(12, 137);
            this.speedbar.Name = "speedbar";
            this.speedbar.Size = new System.Drawing.Size(190, 45);
            this.speedbar.TabIndex = 5;
            this.speedbar.Scroll += new System.EventHandler(this.speedbar_Scroll);
            // 
            // SimulateSpeedLabel
            // 
            this.SimulateSpeedLabel.AutoSize = true;
            this.SimulateSpeedLabel.Location = new System.Drawing.Point(15, 121);
            this.SimulateSpeedLabel.Name = "SimulateSpeedLabel";
            this.SimulateSpeedLabel.Size = new System.Drawing.Size(89, 13);
            this.SimulateSpeedLabel.TabIndex = 6;
            this.SimulateSpeedLabel.Text = "Simulating Speed";
            this.SimulateSpeedLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // AmountSuppliersBar
            // 
            this.AmountSuppliersBar.AccessibleDescription = "sdsad";
            this.AmountSuppliersBar.AccessibleName = "";
            this.AmountSuppliersBar.Location = new System.Drawing.Point(12, 201);
            this.AmountSuppliersBar.Name = "AmountSuppliersBar";
            this.AmountSuppliersBar.Size = new System.Drawing.Size(190, 45);
            this.AmountSuppliersBar.TabIndex = 7;
            this.AmountSuppliersBar.Scroll += new System.EventHandler(this.AmountSuppliersBar_Scroll);
            // 
            // AmountStoresBar
            // 
            this.AmountStoresBar.AccessibleDescription = "sdsad";
            this.AmountStoresBar.AccessibleName = "";
            this.AmountStoresBar.Location = new System.Drawing.Point(12, 329);
            this.AmountStoresBar.Maximum = 63;
            this.AmountStoresBar.Name = "AmountStoresBar";
            this.AmountStoresBar.Size = new System.Drawing.Size(190, 45);
            this.AmountStoresBar.TabIndex = 8;
            this.AmountStoresBar.Scroll += new System.EventHandler(this.AmountStoresBar_Scroll);
            // 
            // AmountSuppliersLabel
            // 
            this.AmountSuppliersLabel.AutoSize = true;
            this.AmountSuppliersLabel.Location = new System.Drawing.Point(15, 185);
            this.AmountSuppliersLabel.Name = "AmountSuppliersLabel";
            this.AmountSuppliersLabel.Size = new System.Drawing.Size(89, 13);
            this.AmountSuppliersLabel.TabIndex = 9;
            this.AmountSuppliersLabel.Text = "Amount Suppliers";
            // 
            // AmountStoresLabel
            // 
            this.AmountStoresLabel.AutoSize = true;
            this.AmountStoresLabel.Location = new System.Drawing.Point(15, 313);
            this.AmountStoresLabel.Name = "AmountStoresLabel";
            this.AmountStoresLabel.Size = new System.Drawing.Size(76, 13);
            this.AmountStoresLabel.TabIndex = 10;
            this.AmountStoresLabel.Text = "Amount Stores";
            // 
            // SupplierProcessSpeedBar
            // 
            this.SupplierProcessSpeedBar.AccessibleDescription = "sdsad";
            this.SupplierProcessSpeedBar.AccessibleName = "";
            this.SupplierProcessSpeedBar.Location = new System.Drawing.Point(12, 265);
            this.SupplierProcessSpeedBar.Name = "SupplierProcessSpeedBar";
            this.SupplierProcessSpeedBar.Size = new System.Drawing.Size(190, 45);
            this.SupplierProcessSpeedBar.TabIndex = 11;
            this.SupplierProcessSpeedBar.Scroll += new System.EventHandler(this.SupplierProcessSpeedBar_Scroll);
            // 
            // SupplierProcesSpeedLabel
            // 
            this.SupplierProcesSpeedLabel.AutoSize = true;
            this.SupplierProcesSpeedLabel.Location = new System.Drawing.Point(15, 249);
            this.SupplierProcesSpeedLabel.Name = "SupplierProcesSpeedLabel";
            this.SupplierProcesSpeedLabel.Size = new System.Drawing.Size(120, 13);
            this.SupplierProcesSpeedLabel.TabIndex = 12;
            this.SupplierProcesSpeedLabel.Text = "Supplier Process Speed";
            // 
            // StoresProcessSpeed
            // 
            this.StoresProcessSpeed.AutoSize = true;
            this.StoresProcessSpeed.Location = new System.Drawing.Point(15, 377);
            this.StoresProcessSpeed.Name = "StoresProcessSpeed";
            this.StoresProcessSpeed.Size = new System.Drawing.Size(112, 13);
            this.StoresProcessSpeed.TabIndex = 14;
            this.StoresProcessSpeed.Text = "Stores Process Speed";
            // 
            // StoresProcessSpeedBar
            // 
            this.StoresProcessSpeedBar.AccessibleDescription = "sdsad";
            this.StoresProcessSpeedBar.AccessibleName = "";
            this.StoresProcessSpeedBar.Location = new System.Drawing.Point(12, 393);
            this.StoresProcessSpeedBar.Name = "StoresProcessSpeedBar";
            this.StoresProcessSpeedBar.Size = new System.Drawing.Size(190, 45);
            this.StoresProcessSpeedBar.TabIndex = 13;
            this.StoresProcessSpeedBar.Scroll += new System.EventHandler(this.StoresProcessSpeedBar_Scroll);
            // 
            // SupplierAmountDisplay
            // 
            this.SupplierAmountDisplay.AutoSize = true;
            this.SupplierAmountDisplay.Location = new System.Drawing.Point(208, 201);
            this.SupplierAmountDisplay.Name = "SupplierAmountDisplay";
            this.SupplierAmountDisplay.Size = new System.Drawing.Size(13, 13);
            this.SupplierAmountDisplay.TabIndex = 15;
            this.SupplierAmountDisplay.Text = "0";
            // 
            // SupplierProcessSpeedDisplay
            // 
            this.SupplierProcessSpeedDisplay.AutoSize = true;
            this.SupplierProcessSpeedDisplay.Location = new System.Drawing.Point(208, 265);
            this.SupplierProcessSpeedDisplay.Name = "SupplierProcessSpeedDisplay";
            this.SupplierProcessSpeedDisplay.Size = new System.Drawing.Size(13, 13);
            this.SupplierProcessSpeedDisplay.TabIndex = 16;
            this.SupplierProcessSpeedDisplay.Text = "0";
            // 
            // StoresAmmountDisplay
            // 
            this.StoresAmmountDisplay.AutoSize = true;
            this.StoresAmmountDisplay.Location = new System.Drawing.Point(208, 329);
            this.StoresAmmountDisplay.Name = "StoresAmmountDisplay";
            this.StoresAmmountDisplay.Size = new System.Drawing.Size(13, 13);
            this.StoresAmmountDisplay.TabIndex = 17;
            this.StoresAmmountDisplay.Text = "0";
            // 
            // StoresProcessSpeedDisplay
            // 
            this.StoresProcessSpeedDisplay.AutoSize = true;
            this.StoresProcessSpeedDisplay.Location = new System.Drawing.Point(208, 393);
            this.StoresProcessSpeedDisplay.Name = "StoresProcessSpeedDisplay";
            this.StoresProcessSpeedDisplay.Size = new System.Drawing.Size(13, 13);
            this.StoresProcessSpeedDisplay.TabIndex = 18;
            this.StoresProcessSpeedDisplay.Text = "0";
            // 
            // SimulatorSpeedDisplay
            // 
            this.SimulatorSpeedDisplay.AutoSize = true;
            this.SimulatorSpeedDisplay.Location = new System.Drawing.Point(208, 137);
            this.SimulatorSpeedDisplay.Name = "SimulatorSpeedDisplay";
            this.SimulatorSpeedDisplay.Size = new System.Drawing.Size(13, 13);
            this.SimulatorSpeedDisplay.TabIndex = 19;
            this.SimulatorSpeedDisplay.Text = "0";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 461);
            this.Controls.Add(this.SimulatorSpeedDisplay);
            this.Controls.Add(this.StoresProcessSpeedDisplay);
            this.Controls.Add(this.StoresAmmountDisplay);
            this.Controls.Add(this.SupplierProcessSpeedDisplay);
            this.Controls.Add(this.SupplierAmountDisplay);
            this.Controls.Add(this.StoresProcessSpeed);
            this.Controls.Add(this.StoresProcessSpeedBar);
            this.Controls.Add(this.SupplierProcesSpeedLabel);
            this.Controls.Add(this.SupplierProcessSpeedBar);
            this.Controls.Add(this.AmountStoresLabel);
            this.Controls.Add(this.AmountSuppliersLabel);
            this.Controls.Add(this.AmountStoresBar);
            this.Controls.Add(this.AmountSuppliersBar);
            this.Controls.Add(this.SimulateSpeedLabel);
            this.Controls.Add(this.speedbar);
            this.Controls.Add(this.StoresBox);
            this.Controls.Add(this.SuppliersBox);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainView";
            this.Text = "WMS Simulator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountSuppliersBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountStoresBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierProcessSpeedBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoresProcessSpeedBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.CheckBox SuppliersBox;
        private System.Windows.Forms.CheckBox StoresBox;
        private System.Windows.Forms.TrackBar speedbar;
        private System.Windows.Forms.Label SimulateSpeedLabel;
        private System.Windows.Forms.TrackBar AmountSuppliersBar;
        private System.Windows.Forms.TrackBar AmountStoresBar;
        private System.Windows.Forms.Label AmountSuppliersLabel;
        private System.Windows.Forms.Label AmountStoresLabel;
        private System.Windows.Forms.TrackBar SupplierProcessSpeedBar;
        private System.Windows.Forms.Label SupplierProcesSpeedLabel;
        private System.Windows.Forms.Label StoresProcessSpeed;
        private System.Windows.Forms.TrackBar StoresProcessSpeedBar;
        private System.Windows.Forms.Label SupplierAmountDisplay;
        private System.Windows.Forms.Label SupplierProcessSpeedDisplay;
        private System.Windows.Forms.Label StoresAmmountDisplay;
        private System.Windows.Forms.Label StoresProcessSpeedDisplay;
        private System.Windows.Forms.Label SimulatorSpeedDisplay;
    }
}