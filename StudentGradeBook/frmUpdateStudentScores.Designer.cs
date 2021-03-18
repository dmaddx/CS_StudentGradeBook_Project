namespace StudentGradeBook
{
    partial class frmUpdateStudentScores
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.lblScrs = new System.Windows.Forms.Label();
            this.lstboxScrs = new System.Windows.Forms.ListView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClrScrs = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(23, 27);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // txtboxName
            // 
            this.txtboxName.Enabled = false;
            this.txtboxName.Location = new System.Drawing.Point(67, 20);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(227, 20);
            this.txtboxName.TabIndex = 1;
            // 
            // lblScrs
            // 
            this.lblScrs.AutoSize = true;
            this.lblScrs.Location = new System.Drawing.Point(18, 53);
            this.lblScrs.Name = "lblScrs";
            this.lblScrs.Size = new System.Drawing.Size(43, 13);
            this.lblScrs.TabIndex = 2;
            this.lblScrs.Text = "Scores:";
            // 
            // lstboxScrs
            // 
            this.lstboxScrs.HideSelection = false;
            this.lstboxScrs.Location = new System.Drawing.Point(67, 53);
            this.lstboxScrs.Name = "lstboxScrs";
            this.lstboxScrs.Size = new System.Drawing.Size(129, 135);
            this.lstboxScrs.TabIndex = 3;
            this.lstboxScrs.UseCompatibleStateImageBehavior = false;
            this.lstboxScrs.View = System.Windows.Forms.View.List;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(213, 53);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(213, 90);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(213, 127);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClrScrs
            // 
            this.btnClrScrs.Location = new System.Drawing.Point(213, 164);
            this.btnClrScrs.Name = "btnClrScrs";
            this.btnClrScrs.Size = new System.Drawing.Size(75, 23);
            this.btnClrScrs.TabIndex = 7;
            this.btnClrScrs.Text = "Clear Scores";
            this.btnClrScrs.UseVisualStyleBackColor = true;
            this.btnClrScrs.Click += new System.EventHandler(this.btnClrScrs_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(121, 206);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(213, 206);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmUpdateStudentScores
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(310, 245);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnClrScrs);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstboxScrs);
            this.Controls.Add(this.lblScrs);
            this.Controls.Add(this.txtboxName);
            this.Controls.Add(this.lblName);
            this.Name = "frmUpdateStudentScores";
            this.Text = "Update Student Scores";
            this.Load += new System.EventHandler(this.frmUpdateStudentScores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.Label lblScrs;
        private System.Windows.Forms.ListView lstboxScrs;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClrScrs;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}