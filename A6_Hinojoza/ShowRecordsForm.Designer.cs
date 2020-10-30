namespace A6_Hinojoza
{
    partial class ShowRecordsForm
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
            this.txtRecords = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtRecords
            // 
            this.txtRecords.BackColor = System.Drawing.Color.White;
            this.txtRecords.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRecords.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecords.Location = new System.Drawing.Point(0, 0);
            this.txtRecords.Multiline = true;
            this.txtRecords.Name = "txtRecords";
            this.txtRecords.ReadOnly = true;
            this.txtRecords.Size = new System.Drawing.Size(869, 433);
            this.txtRecords.TabIndex = 0;
            // 
            // ShowRecordsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(869, 433);
            this.Controls.Add(this.txtRecords);
            this.Name = "ShowRecordsForm";
            this.Text = "Result Recorded";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRecords;
    }
}