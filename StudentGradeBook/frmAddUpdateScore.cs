using System;
using System.Windows.Forms;

namespace StudentGradeBook
{
    public partial class frmAddUpdateScore : Form
    {

        string _score;
        string _addOrUpdate;

        public frmAddUpdateScore()
        {
            InitializeComponent();
        }

        public frmAddUpdateScore(string score, string addOrUpdate)
        {
            InitializeComponent();
            _addOrUpdate = addOrUpdate;
            _score = score;
            txtboxScr.Text = _score;
        }

        public frmAddUpdateScore(string addOrUpdate)
        {
            InitializeComponent();
            _addOrUpdate = addOrUpdate;
        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            if (Validator.IsInt(txtboxScr) && Validator.IsWithinRange(txtboxScr, 0, 100))
            {
                this.Tag = txtboxScr.Text;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Changes the form text add or update
        /// </summary>
        private void updateOrAdd()
        {
            if (_addOrUpdate == "add")
            {
                this.Text = "Add Score";
                this.btnAddUpdate.Text = "Add";
            }
            else
            {
                this.Text = "Update Score";
                this.btnAddUpdate.Text = "Update";
            }
        }

        private void frmAddUpdateScore_Load(object sender, EventArgs e)
        {
            updateOrAdd();
        }
    }
}
