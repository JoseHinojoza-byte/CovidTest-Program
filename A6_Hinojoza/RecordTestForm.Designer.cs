namespace A6_Hinojoza
{
    partial class RecordTestForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTestDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.rbPCR = new System.Windows.Forms.RadioButton();
            this.rbAntigen = new System.Windows.Forms.RadioButton();
            this.rbAntibody = new System.Windows.Forms.RadioButton();
            this.pnlTestType = new System.Windows.Forms.Panel();
            this.cbPositive = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlTestType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(68, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 2;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date:";
            // 
            // dtpTestDate
            // 
            this.dtpTestDate.CustomFormat = "";
            this.dtpTestDate.Location = new System.Drawing.Point(68, 75);
            this.dtpTestDate.Name = "dtpTestDate";
            this.dtpTestDate.Size = new System.Drawing.Size(200, 20);
            this.dtpTestDate.TabIndex = 3;
            this.dtpTestDate.Value = new System.DateTime(2020, 10, 13, 0, 0, 0, 0);
            this.dtpTestDate.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimePicker1_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Test Type:";
            // 
            // rbPCR
            // 
            this.rbPCR.AutoSize = true;
            this.rbPCR.Location = new System.Drawing.Point(3, 3);
            this.rbPCR.Name = "rbPCR";
            this.rbPCR.Size = new System.Drawing.Size(47, 17);
            this.rbPCR.TabIndex = 0;
            this.rbPCR.TabStop = true;
            this.rbPCR.Text = "PCR";
            this.rbPCR.UseVisualStyleBackColor = true;
            this.rbPCR.Validating += new System.ComponentModel.CancelEventHandler(this.pnlTestType_Validating);
            // 
            // rbAntigen
            // 
            this.rbAntigen.AutoSize = true;
            this.rbAntigen.Location = new System.Drawing.Point(3, 26);
            this.rbAntigen.Name = "rbAntigen";
            this.rbAntigen.Size = new System.Drawing.Size(61, 17);
            this.rbAntigen.TabIndex = 1;
            this.rbAntigen.TabStop = true;
            this.rbAntigen.Text = "Antigen";
            this.rbAntigen.UseVisualStyleBackColor = true;
            this.rbAntigen.Validating += new System.ComponentModel.CancelEventHandler(this.pnlTestType_Validating);
            // 
            // rbAntibody
            // 
            this.rbAntibody.AutoSize = true;
            this.rbAntibody.Location = new System.Drawing.Point(3, 49);
            this.rbAntibody.Name = "rbAntibody";
            this.rbAntibody.Size = new System.Drawing.Size(66, 17);
            this.rbAntibody.TabIndex = 2;
            this.rbAntibody.TabStop = true;
            this.rbAntibody.Text = "Antibody";
            this.rbAntibody.UseVisualStyleBackColor = true;
            this.rbAntibody.Validating += new System.ComponentModel.CancelEventHandler(this.pnlTestType_Validating);
            // 
            // pnlTestType
            // 
            this.pnlTestType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTestType.Controls.Add(this.rbAntibody);
            this.pnlTestType.Controls.Add(this.rbPCR);
            this.pnlTestType.Controls.Add(this.rbAntigen);
            this.pnlTestType.Location = new System.Drawing.Point(68, 128);
            this.pnlTestType.Name = "pnlTestType";
            this.pnlTestType.Size = new System.Drawing.Size(73, 76);
            this.pnlTestType.TabIndex = 5;
            this.pnlTestType.Validating += new System.ComponentModel.CancelEventHandler(this.pnlTestType_Validating);
            // 
            // cbPositive
            // 
            this.cbPositive.AutoSize = true;
            this.cbPositive.Location = new System.Drawing.Point(68, 242);
            this.cbPositive.Name = "cbPositive";
            this.cbPositive.Size = new System.Drawing.Size(96, 17);
            this.cbPositive.TabIndex = 7;
            this.cbPositive.Text = "Positive Result";
            this.cbPositive.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(193, 297);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(68, 297);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // RecordTestForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(325, 357);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cbPositive);
            this.Controls.Add(this.pnlTestType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpTestDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RecordTestForm";
            this.Text = "Record Test";
            this.pnlTestType.ResumeLayout(false);
            this.pnlTestType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTestDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbPCR;
        private System.Windows.Forms.RadioButton rbAntigen;
        private System.Windows.Forms.RadioButton rbAntibody;
        private System.Windows.Forms.Panel pnlTestType;
        private System.Windows.Forms.CheckBox cbPositive;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}