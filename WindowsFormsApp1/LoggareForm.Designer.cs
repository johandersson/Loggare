namespace WindowsFormsApp1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtBoxLog = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kopieraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taBortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logEntryBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.saveButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arkivToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exporteraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valtDatumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allaDatumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.omLoggareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(461, 211);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 37);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Logga!";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBoxLog
            // 
            this.txtBoxLog.Font = new System.Drawing.Font("Gentium Book Basic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLog.Location = new System.Drawing.Point(16, 32);
            this.txtBoxLog.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxLog.Multiline = true;
            this.txtBoxLog.Name = "txtBoxLog";
            this.txtBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxLog.Size = new System.Drawing.Size(545, 171);
            this.txtBoxLog.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(16, 293);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(228, 116);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kopieraToolStripMenuItem,
            this.taBortToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(202, 52);
            // 
            // kopieraToolStripMenuItem
            // 
            this.kopieraToolStripMenuItem.Name = "kopieraToolStripMenuItem";
            this.kopieraToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.kopieraToolStripMenuItem.Text = "Kopiera till urklipp";
            this.kopieraToolStripMenuItem.Click += new System.EventHandler(this.kopieraToolStripMenuItem_Click);
            // 
            // taBortToolStripMenuItem
            // 
            this.taBortToolStripMenuItem.Name = "taBortToolStripMenuItem";
            this.taBortToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.taBortToolStripMenuItem.Text = "Ta bort";
            this.taBortToolStripMenuItem.Click += new System.EventHandler(this.taBortToolStripMenuItem_Click);
            // 
            // logEntryBox
            // 
            this.logEntryBox.Font = new System.Drawing.Font("Gentium Book Basic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logEntryBox.Location = new System.Drawing.Point(252, 293);
            this.logEntryBox.Margin = new System.Windows.Forms.Padding(4);
            this.logEntryBox.Multiline = true;
            this.logEntryBox.Name = "logEntryBox";
            this.logEntryBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logEntryBox.Size = new System.Drawing.Size(577, 116);
            this.logEntryBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Loggar valt datum:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(574, 32);
            this.monthCalendar1.MaxDate = new System.DateTime(2123, 1, 1, 15, 37, 0, 0);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 9;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(754, 416);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 35);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Spara";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arkivToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(901, 30);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arkivToolStripMenuItem
            // 
            this.arkivToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exporteraToolStripMenuItem,
            this.omLoggareToolStripMenuItem});
            this.arkivToolStripMenuItem.Name = "arkivToolStripMenuItem";
            this.arkivToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.arkivToolStripMenuItem.Text = "Arkiv";
            // 
            // exporteraToolStripMenuItem
            // 
            this.exporteraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.valtDatumToolStripMenuItem,
            this.allaDatumToolStripMenuItem});
            this.exporteraToolStripMenuItem.Name = "exporteraToolStripMenuItem";
            this.exporteraToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.exporteraToolStripMenuItem.Text = "Exportera";
            // 
            // valtDatumToolStripMenuItem
            // 
            this.valtDatumToolStripMenuItem.Name = "valtDatumToolStripMenuItem";
            this.valtDatumToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.valtDatumToolStripMenuItem.Text = "Valt datum";
            this.valtDatumToolStripMenuItem.Click += new System.EventHandler(this.ExportLogForSpecificDate);
            // 
            // allaDatumToolStripMenuItem
            // 
            this.allaDatumToolStripMenuItem.Name = "allaDatumToolStripMenuItem";
            this.allaDatumToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.allaDatumToolStripMenuItem.Text = "Alla datum";
            this.allaDatumToolStripMenuItem.Click += new System.EventHandler(this.ExportAllLogs);
            // 
            // omLoggareToolStripMenuItem
            // 
            this.omLoggareToolStripMenuItem.Name = "omLoggareToolStripMenuItem";
            this.omLoggareToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.omLoggareToolStripMenuItem.Text = "Om Loggare";
            this.omLoggareToolStripMenuItem.Click += new System.EventHandler(this.AboutProgram);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 571);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logEntryBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtBoxLog);
            this.Controls.Add(this.btnSave);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Loggare";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtBoxLog;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox logEntryBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem taBortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopieraToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arkivToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exporteraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem valtDatumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allaDatumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem omLoggareToolStripMenuItem;
    }
}

