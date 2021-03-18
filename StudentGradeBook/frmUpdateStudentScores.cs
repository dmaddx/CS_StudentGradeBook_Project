using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StudentGradeBook
{
    public partial class frmUpdateStudentScores : Form
    {

        Student studClone;
        Student _student;
        //private string _name;
        //private List<int> _scores = new List<int>();

        public frmUpdateStudentScores()
        {
            InitializeComponent();
        }

        public frmUpdateStudentScores(Student student)
        {
            InitializeComponent();
            _student = new Student(student.StudentName, student.StudentScore);
            studClone = _student.DeepCopy();
        }

        private void frmUpdateStudentScores_Load(object sender, EventArgs e)
        {
            DisplayStudentInfo();
        }


        /// <summary>
        /// Fills in selected student information
        /// </summary>
        public void DisplayStudentInfo()
        {
            lstboxScrs.Clear();
            txtboxName.Text = studClone.StudentName;
            foreach (int score in studClone.StudentScore)
            {
                lstboxScrs.Items.Add(score.ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddUpdateScore addScore = new frmAddUpdateScore("add");
            DialogResult newScore = addScore.ShowDialog();
            if (newScore == DialogResult.OK)
            {
                studClone.StudentScore.Add(Convert.ToInt32(addScore.Tag));
                DisplayStudentInfo();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int newScore;
            var index = lstboxScrs.Items.IndexOf(SelectedScore());
            if (!(SelectedScore().Selected))
            {
                MessageBox.Show("Select a Score");
            }
            else
            {
                frmAddUpdateScore updateScore = new frmAddUpdateScore(SelectedScore().Text, "update");
                DialogResult updtScore = updateScore.ShowDialog();
                if (updtScore == DialogResult.OK)
                {
                    lstboxScrs.Clear();
                    newScore = Convert.ToInt32(updateScore.Tag);
                    studClone.StudentScore.RemoveAt(index);
                    studClone.StudentScore.Insert(index, newScore);
                    DisplayStudentInfo();
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (!(SelectedScore().Selected))
            {
                MessageBox.Show("Select a Score");
            }
            else
            {
                var index = lstboxScrs.Items.IndexOf(SelectedScore());
                studClone.StudentScore.RemoveAt(index);
                lstboxScrs.Items.Remove(SelectedScore());
            }
        }

        private void btnClrScrs_Click(object sender, EventArgs e)
        {
            studClone.StudentScore.Clear();
            lstboxScrs.Items.Clear();
        }

        /// <summary>
        /// Determines the Score that was selected from the list view
        /// </summary>
        /// <returns>score - the list view value that is selected</returns>
        private ListViewItem SelectedScore()
        {
            ListViewItem score = new ListViewItem();
            foreach (ListViewItem selectedScore in lstboxScrs.SelectedItems)
            {
                score = selectedScore;
            }
            return score;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            _student.StudentScore.Clear();
            List<int> studScores = new List<int>();
            foreach (var s in studClone.StudentScore)
            {
                studScores.Add(s);
            }
            this.Tag = studScores;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
