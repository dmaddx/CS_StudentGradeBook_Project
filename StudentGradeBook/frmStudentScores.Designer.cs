namespace StudentGradeBook
{
    partial class frmStudentScores
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
            this.lblStudent = new System.Windows.Forms.Label();
            this.lstboxStudent = new System.Windows.Forms.ListView();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.lblScrTotal = new System.Windows.Forms.Label();
            this.txtboxScrTotal = new System.Windows.Forms.TextBox();
            this.lblScrCount = new System.Windows.Forms.Label();
            this.txtboxScrCount = new System.Windows.Forms.TextBox();
            this.lblAvg = new System.Windows.Forms.Label();
            this.txtboxAvg = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Location = new System.Drawing.Point(12, 19);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(52, 13);
            this.lblStudent.TabIndex = 0;
            this.lblStudent.Text = "Students:";
            // 
            // lstboxStudent
            // 
            this.lstboxStudent.HideSelection = false;
            this.lstboxStudent.Location = new System.Drawing.Point(15, 45);
            this.lstboxStudent.Name = "lstboxStudent";
            this.lstboxStudent.Size = new System.Drawing.Size(284, 122);
            this.lstboxStudent.TabIndex = 1;
            this.lstboxStudent.UseCompatibleStateImageBehavior = false;
            this.lstboxStudent.View = System.Windows.Forms.View.List;
            this.lstboxStudent.SelectedIndexChanged += new System.EventHandler(this.lstboxStudent_SelectedIndexChanged);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(305, 45);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(88, 23);
            this.btnAddNew.TabIndex = 2;
            this.btnAddNew.Text = "Add New...";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(305, 74);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update...";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(305, 103);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(88, 23);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // lblScrTotal
            // 
            this.lblScrTotal.AutoSize = true;
            this.lblScrTotal.Location = new System.Drawing.Point(164, 189);
            this.lblScrTotal.Name = "lblScrTotal";
            this.lblScrTotal.Size = new System.Drawing.Size(65, 13);
            this.lblScrTotal.TabIndex = 5;
            this.lblScrTotal.Text = "Score Total:";
            // 
            // txtboxScrTotal
            // 
            this.txtboxScrTotal.Enabled = false;
            this.txtboxScrTotal.Location = new System.Drawing.Point(235, 182);
            this.txtboxScrTotal.Name = "txtboxScrTotal";
            this.txtboxScrTotal.Size = new System.Drawing.Size(64, 20);
            this.txtboxScrTotal.TabIndex = 6;
            // 
            // lblScrCount
            // 
            this.lblScrCount.AutoSize = true;
            this.lblScrCount.Location = new System.Drawing.Point(161, 215);
            this.lblScrCount.Name = "lblScrCount";
            this.lblScrCount.Size = new System.Drawing.Size(68, 13);
            this.lblScrCount.TabIndex = 7;
            this.lblScrCount.Text = "Score count:";
            // 
            // txtboxScrCount
            // 
            this.txtboxScrCount.Enabled = false;
            this.txtboxScrCount.Location = new System.Drawing.Point(235, 208);
            this.txtboxScrCount.Name = "txtboxScrCount";
            this.txtboxScrCount.Size = new System.Drawing.Size(64, 20);
            this.txtboxScrCount.TabIndex = 8;
            // 
            // lblAvg
            // 
            this.lblAvg.AutoSize = true;
            this.lblAvg.Location = new System.Drawing.Point(179, 241);
            this.lblAvg.Name = "lblAvg";
            this.lblAvg.Size = new System.Drawing.Size(50, 13);
            this.lblAvg.TabIndex = 9;
            this.lblAvg.Text = "Average:";
            // 
            // txtboxAvg
            // 
            this.txtboxAvg.Enabled = false;
            this.txtboxAvg.Location = new System.Drawing.Point(235, 234);
            this.txtboxAvg.Name = "txtboxAvg";
            this.txtboxAvg.Size = new System.Drawing.Size(64, 20);
            this.txtboxAvg.TabIndex = 10;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(316, 231);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(77, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmStudentScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(408, 267);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtboxAvg);
            this.Controls.Add(this.lblAvg);
            this.Controls.Add(this.txtboxScrCount);
            this.Controls.Add(this.lblScrCount);
            this.Controls.Add(this.txtboxScrTotal);
            this.Controls.Add(this.lblScrTotal);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.lstboxStudent);
            this.Controls.Add(this.lblStudent);
            this.Name = "frmStudentScores";
            this.Text = "Student Scores";
            this.Load += new System.EventHandler(this.frmStudentScores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.ListView lstboxStudent;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label lblScrTotal;
        private System.Windows.Forms.TextBox txtboxScrTotal;
        private System.Windows.Forms.Label lblScrCount;
        private System.Windows.Forms.TextBox txtboxScrCount;
        private System.Windows.Forms.Label lblAvg;
        private System.Windows.Forms.TextBox txtboxAvg;
        private System.Windows.Forms.Button btnExit;
    }
}

