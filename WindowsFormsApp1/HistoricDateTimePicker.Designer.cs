
namespace Loggare
{
    partial class HistoricDateTimePicker
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.changeDateOKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(117, 40);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // changeDateOKButton
            // 
            this.changeDateOKButton.Location = new System.Drawing.Point(186, 86);
            this.changeDateOKButton.Name = "changeDateOKButton";
            this.changeDateOKButton.Size = new System.Drawing.Size(75, 23);
            this.changeDateOKButton.TabIndex = 1;
            this.changeDateOKButton.Text = "OK";
            this.changeDateOKButton.UseVisualStyleBackColor = true;
            this.changeDateOKButton.Click += new System.EventHandler(this.changeDateOKButton_Click);
            // 
            // HistoricDateTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 139);
            this.Controls.Add(this.changeDateOKButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "HistoricDateTimePicker";
            this.Text = "HistoricDateTimePicker";
            this.Load += new System.EventHandler(this.HistoricDateTimePicker_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button changeDateOKButton;
    }
}