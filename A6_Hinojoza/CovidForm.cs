using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Jose Hinojoza
 * A6
 * This program helps keep record of who has been tested and how. It keeps track of the number of tested 
 * patients and displays the positivity rate.
 * 
 * 
 */
namespace A6_Hinojoza
{
    public partial class CovidForm : Form
    {
        //create record of patients in a list
        List<test> patientsRecords = new List<test>();
        int totalPatients = 0;
        int positivePatients = 0;
        public CovidForm()
        {
            InitializeComponent();
        }

        private void btnRecordTest_Click(object sender, EventArgs e)
        {
            RecordTestForm recordTestForm = new RecordTestForm(this);
            recordTestForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnViewResults_Click(object sender, EventArgs e)
        {
            ShowRecordsForm recordListForm = new ShowRecordsForm(this);
            //pass the list to create a record
            
            recordListForm.createRecord(patientsRecords);
            recordListForm.Show();
        }
        public void addPatientResult(test patient)
        {
            //all good here
            //the number of patients is added everytime a new patient is created
            //added to the list of patients for the txt file print
            totalPatients++;
            
            if(patient.testResult == "Positive")
            {
                positivePatients++;
            }
            lblTotalTest.Text = totalPatients.ToString();
            lblPositivity.Text = ((double)positivePatients / totalPatients).ToString("P");//integer division!
            patientsRecords.Add(patient);
            
        }
    }
}
