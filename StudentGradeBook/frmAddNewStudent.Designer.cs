namespace StudentGradeBook
{
    partial class frmAddNewStudent
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
            this.lblScr = new System.Windows.Forms.Label();
            this.txtboxScr = new System.Windows.Forms.TextBox();
            this.lblScrs = new System.Windows.Forms.Label();
            this.txtboxScrs = new System.Windows.Forms.TextBox();
            this.btnAddScr = new System.Windows.Forms.Button();
            this.btnScrs = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(22, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // txtboxName
            // 
            this.txtboxName.Location = new System.Drawing.Point(66, 16);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(227, 20);
            this.txtboxName.TabIndex = 1;
            this.txtboxName.Tag = "Name";
            // 
            // lblScr
            // 
            this.lblScr.AutoSize = true;
            this.lblScr.Location = new System.Drawing.Point(22, 55);
            this.lblScr.Name = "lblScr";
            this.lblScr.Size = new System.Drawing.Size(38, 13);
            this.lblScr.TabIndex = 2;
            this.lblScr.Text = "Score:";
            // 
            // txtboxScr
            // 
            this.txtboxScr.Location = new System.Drawing.Point(66, 48);
            this.txtboxScr.Name = "txtboxScr";
            this.txtboxScr.Size = new System.Drawing.Size(100, 20);
            this.txtboxScr.TabIndex = 3;
            this.txtboxScr.Tag = "Score";
            // 
            // lblScrs
            // 
            this.lblScrs.AutoSize = true;
            this.lblScrs.Location = new System.Drawing.Point(17, 85);
            this.lblScrs.Name = "lblScrs";
            this.lblScrs.Size = new System.Drawing.Size(43, 13);
            this.lblScrs.TabIndex = 4;
            this.lblScrs.Text = "Scores:";
            // 
            // txtboxScrs
            // 
            this.txtboxScrs.Enabled = false;
            this.txtboxScrs.Location = new System.Drawing.Point(66, 78);
            this.txtboxScrs.Name = "txtboxScrs";
            this.txtboxScrs.Size = new System.Drawing.Size(227, 20);
            this.txtboxScrs.TabIndex = 5;
            this.txtboxScrs.Tag = "Scores";
            // 
            // btnAddScr
            // 
            this.btnAddScr.Location = new System.Drawing.Point(205, 45);
            this.btnAddScr.Name = "btnAddScr";
            this.btnAddScr.Size = new System.Drawing.Size(88, 23);
            this.btnAddScr.TabIndex = 6;
            this.btnAddScr.Text = "Add Score";
            this.btnAddScr.UseVisualStyleBackColor = true;
            this.btnAddScr.Click += new System.EventHandler(this.btnAddScr_Click);
            // 
            // btnScrs
            // 
            this.btnScrs.Location = new System.Drawing.Point(205, 113);
            this.btnScrs.Name = "btnScrs";
            this.btnScrs.Size = new System.Drawing.Size(88, 23);
            this.btnScrs.TabIndex = 7;
            this.btnScrs.Text = "Clear Scores";
            this.btnScrs.UseVisualStyleBackColor = true;
            this.btnScrs.Click += new System.EventHandler(this.btnScrs_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(99, 158);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(88, 23);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(205, 158);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmAddNewStudent
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(312, 191);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnScrs);
            this.Controls.Add(this.btnAddScr);
            this.Controls.Add(this.txtboxScrs);
            this.Controls.Add(this.lblScrs);
            this.Controls.Add(this.txtboxScr);
            this.Controls.Add(this.lblScr);
            this.Controls.Add(this.txtboxName);
            this.Controls.Add(this.lblName);
            this.Name = "frmAddNewStudent";
            this.Text = "Add New Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.Label lblScr;
        private System.Windows.Forms.TextBox txtboxScr;
        private System.Windows.Forms.Label lblScrs;
        private System.Windows.Forms.TextBox txtboxScrs;
        private System.Windows.Forms.Button btnAddScr;
        private System.Windows.Forms.Button btnScrs;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}