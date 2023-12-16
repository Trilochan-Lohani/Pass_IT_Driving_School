using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pass_IT_Driving_School
{
    public partial class BookLesson : Form
    {

        public static BookLesson bookLesson;
        public Label lablefirstname, lablesurname;
        public BookLesson()
        {
            InitializeComponent();
            bookLesson = this;
            lablefirstname = lblLBNameDisplay;
            lablesurname = lblLBLastnameDisplay;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Record Saved successfully!!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {


            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BookLesson_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Now;
        }
    }
}
