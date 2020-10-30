using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A6_Hinojoza
{
    public partial class RecordTestForm : Form
    {
        //set parent
        private CovidForm parent;
        //private RadioButton checkedButton;
        public RecordTestForm(CovidForm parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //create a new patient if everything is validated
            if (this.ValidateChildren())
            {
                test newPatient = new test()
                {
                    Name = txtName.Text,
                    Date = dtpTestDate.Value.ToString("dd-MM-yyyy"),
                    TestType = pnlTestType.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text,
                    testResult = checkResult
                };
                parent.addPatientResult(newPatient);
                this.Close();
            }
        }

        private String checkResult
        {//check if the test was posittive or negative
            get
            {
                if (cbPositive.Checked)
                {
                    return "Positive";
                }
                else
                {
                    return "Negative";
                }
            }
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {//validate the txt name
            if (txtName.Text.Trim() == "")
            {
                errorProvider.SetError(txtName, "Must enter a name");
                e.Cancel = true;
                return;
            }

            errorProvider.SetError(txtName, "");
        }

        private void pnlTestType_Validating(object sender, CancelEventArgs e)
        {//validate the radio buttons
            bool rbChecked = rbAntibody.Checked || rbAntigen.Checked || rbPCR.Checked;

            if (rbChecked == false)
            {
                errorProvider.SetError(pnlTestType, "Select Test Type");
                e.Cancel = true;
                return;
            }
            errorProvider.SetError(pnlTestType, "");
            
        }

        private void dateTimePicker1_Validating(object sender, CancelEventArgs e)
        {//validate the date
            if (dtpTestDate.Value > DateTime.Now)
            {
                errorProvider.SetError(dtpTestDate, "Select A Past Date");
                e.Cancel = true;
                return;
            }
            errorProvider.SetError(dtpTestDate, "");
        }

       
    }
}
