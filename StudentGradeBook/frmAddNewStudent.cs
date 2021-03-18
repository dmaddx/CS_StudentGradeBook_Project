using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StudentGradeBook
{
    public partial class frmAddNewStudent : Form
    {
        public frmAddNewStudent()
        {
            InitializeComponent();
        }

        private Student student;
        List<int> studScores = new List<int>();

        public Student GetNewStudent()
        {
            this.ShowDialog();
            return student;
        }

        private void btnAddScr_Click(object sender, EventArgs e)
        {

            if (Validator.IsPresent(txtboxScr) && Validator.IsInt(txtboxScr) && Validator.IsWithinRange(txtboxScr, 0, 100))
            {
                //sets the string for the scores text box
                if (txtboxScr.Text != "")
                {
                    studScores.Add(Convert.ToInt32(txtboxScr.Text));
                    if (txtboxScrs.Text == "")
                    {
                        txtboxScrs.Text = txtboxScr.Text;
                    }
                    else
                    {
                        txtboxScrs.Text += " " + txtboxScr.Text;
                    }
                }
            }
            txtboxScr.Clear();
        }

        private void btnScrs_Click(object sender, EventArgs e)
        {
            txtboxScrs.Clear();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(txtboxName) && Validator.IsAlphabetic(txtboxName))
            {
                student = new Student(txtboxName.Text, studScores);
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
