using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace StudentGradeBook
{
    public partial class frmStudentScores : Form
    {
        public frmStudentScores()
        {
            InitializeComponent();
        }

        private List<Student> students = new List<Student>();

        /// <summary>
        /// 3 sample students to load random scores for each when application starts
        /// </summary>
        private void FillSampleStudents()
        {
            Student student;
            Random rand = new Random();
            int count;
            int score;

            string[] studentName = new string[3] { "Tony Stark", "Bruce Banner", "Steve Rogers" };
            for (int i = 0; i < 3; i++)
            {
                List<int> scores = new List<int>();
                count = rand.Next(1, 5);
                for (int j = 0; j < count; j++)
                {
                    score = rand.Next(0, 101);
                    scores.Add(score);
                }
                student = new Student(studentName[i], scores);
                students.Add(student);
            }
        }


        private void frmStudentScores_Load(object sender, EventArgs e)
        {
            FillSampleStudents();
            FillStudentListBox();
        }

        private void FillStudentListBox()
        {
            lstboxStudent.Items.Clear();
            foreach (Student s in students)
            {
                if (s != null)
                {
                    lstboxStudent.Items.Add(new ListViewItem(new[] { s.ToString() }));
                }
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddNewStudent addNewStudentForm = new frmAddNewStudent();
            Student student = addNewStudentForm.GetNewStudent();
            students.Add(student);
            FillStudentListBox();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //The currently selected student from the list
            var studentScoreIndex = lstboxStudent.Items.IndexOf(SelectedStudent());


            //A list that holds scores for currently selected student
            if (studentScoreIndex < 0)
            {
                MessageBox.Show("Select a Student.");
            }
            else
            {
                var selectStudent = students[studentScoreIndex];
                //Name of currently selected student
                List<int> studentScores = selectStudent.StudentScore;
                frmUpdateStudentScores updateScore = new frmUpdateStudentScores(selectStudent);
                DialogResult newScore = updateScore.ShowDialog();
                if (newScore == DialogResult.OK)
                {
                    studentScores.Clear();
                    studentScores = (List<int>)updateScore.Tag;
                    foreach (int score in studentScores)
                    {
                        selectStudent.StudentScore.Add(score);
                    }
                    
                    ClearCalculations();
                    FillStudentListBox();
                }
                else
                {
                    studentScores = selectStudent.StudentScore;
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var index = lstboxStudent.Items.IndexOf(SelectedStudent());
            students.RemoveAt(index);
            lstboxStudent.Items.Remove(SelectedStudent());
            ClearCalculations();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Calls to method upon student selection change
        /// </summary>
        private void lstboxStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateStudentScore();
        }

        /// <summary>
        /// Finds the student that is selected from the list view
        /// </summary>
        private ListViewItem SelectedStudent()
        {
            ListViewItem studentList = new ListViewItem();
            foreach (ListViewItem selectedStudent in lstboxStudent.SelectedItems)
            {
                studentList = selectedStudent;
            }
            return studentList;
        }

        private void ClearCalculations()
        {
            txtboxScrTotal.Clear();
            txtboxScrCount.Clear();
            txtboxAvg.Clear();
        }

        /// <summary>
        /// Calculates the sum and average of the student that is selected
        /// </summary>
        private void CalculateStudentScore()
        {
            if (SelectedStudent().Selected)
            {
                var index = lstboxStudent.Items.IndexOf(SelectedStudent());
                var studentScore = students[index].StudentScore;
                if (studentScore.Count > 0)
                {
                    txtboxScrTotal.Text = studentScore.Sum().ToString();
                    txtboxScrCount.Text = studentScore.Count.ToString();
                    txtboxAvg.Text = studentScore.Average().ToString();
                }
            }
            else
            {
                ClearCalculations();
            }
        }

    }

}
