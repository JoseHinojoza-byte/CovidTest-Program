namespace A6_Hinojoza
{
    partial class CovidForm
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
            this.btnRecordTest = new System.Windows.Forms.Button();
            this.btnViewResults = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalTest = new System.Windows.Forms.Label();
            this.lblPositivity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRecordTest
            // 
            this.btnRecordTest.Location = new System.Drawing.Point(57, 27);
            this.btnRecordTest.Name = "btnRecordTest";
            this.btnRecordTest.Size = new System.Drawing.Size(83, 23);
            this.btnRecordTest.TabIndex = 0;
            this.btnRecordTest.Text = "Record Test";
            this.btnRecordTest.UseVisualStyleBackColor = true;
            this.btnRecordTest.Click += new System.EventHandler(this.btnRecordTest_Click);
            // 
            // btnViewResults
            // 
            this.btnViewResults.Location = new System.Drawing.Point(57, 94);
            this.btnViewResults.Name = "btnViewResults";
            this.btnViewResults.Size = new System.Drawing.Size(83, 23);
            this.btnViewResults.TabIndex = 1;
            this.btnViewResults.Text = "View Results";
            this.btnViewResults.UseVisualStyleBackColor = true;
            this.btnViewResults.Click += new System.EventHandler(this.btnViewResults_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(57, 161);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(83, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Test Recorded:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Positivity:";
            // 
            // lblTotalTest
            // 
            this.lblTotalTest.AutoSize = true;
            this.lblTotalTest.Location = new System.Drawing.Point(385, 45);
            this.lblTotalTest.Name = "lblTotalTest";
            this.lblTotalTest.Size = new System.Drawing.Size(10, 13);
            this.lblTotalTest.TabIndex = 5;
            this.lblTotalTest.Text = "-";
            // 
            // lblPositivity
            // 
            this.lblPositivity.AutoSize = true;
            this.lblPositivity.Location = new System.Drawing.Point(385, 78);
            this.lblPositivity.Name = "lblPositivity";
            this.lblPositivity.Size = new System.Drawing.Size(10, 13);
            this.lblPositivity.TabIndex = 6;
            this.lblPositivity.Text = "-";
            // 
            // CovidForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 246);
            this.Controls.Add(this.lblPositivity);
            this.Controls.Add(this.lblTotalTest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnViewResults);
            this.Controls.Add(this.btnRecordTest);
            this.Name = "CovidForm";
            this.Text = "Assignment 6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRecordTest;
        private System.Windows.Forms.Button btnViewResults;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalTest;
        private System.Windows.Forms.Label lblPositivity;
    }
}

