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
    public partial class ShowRecordsForm : Form
    {
        CovidForm parent;
        public ShowRecordsForm(CovidForm parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        public void createRecord(List<test> patientRecords)
        {//show everything in form very organized
            txtRecords.Text = "";
            txtRecords.Text += String.Format("{0, -20} {1, -12} {2, -12} {3, -8}\r\n", "Name", "Test  Date", "Test  Type", "Result");
            txtRecords.Text += String.Format("{0, -20} {1, -12} {2, -12} {3, -8}\r\n", "====", "==========", "==========", "======");
            foreach (test record in patientRecords)
            {
                txtRecords.Text += String.Format("{0, -20} {1, -12} {2, -12} {3, -8}\r\n", record.Name, record.Date, record.TestType, record.testResult);
            }
        }
    }
}
