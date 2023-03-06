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
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(461, 194);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Logga!";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBoxLog
            // 
            this.txtBoxLog.Font = new System.Drawing.Font("Gentium Book Basic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLog.Location = new System.Drawing.Point(16, 15);
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
            this.logEntryBox.Font = new System.Drawing.Font("Gentium Book Basic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logEntryBox.Location = new System.Drawing.Point(252, 293);
            this.logEntryBox.Margin = new System.Windows.Forms.Padding(4);
            this.logEntryBox.Multiline = true;
            this.logEntryBox.Name = "logEntryBox";
            this.logEntryBox.ReadOnly = true;
            this.logEntryBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logEntryBox.Size = new System.Drawing.Size(309, 116);
            this.logEntryBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Loggar valt datum:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(574, 15);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 9;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(700, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Exportera alla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 491);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logEntryBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtBoxLog);
            this.Controls.Add(this.btnSave);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Loggare";
            this.contextMenuStrip1.ResumeLayout(false);
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
        private System.Windows.Forms.Button button1;
    }
}

