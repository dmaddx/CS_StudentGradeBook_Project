namespace StudentGradeBook
{
    partial class frmAddUpdateScore
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
            this.lblScr = new System.Windows.Forms.Label();
            this.txtboxScr = new System.Windows.Forms.TextBox();
            this.btnAddUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblScr
            // 
            this.lblScr.AutoSize = true;
            this.lblScr.Location = new System.Drawing.Point(37, 27);
            this.lblScr.Name = "lblScr";
            this.lblScr.Size = new System.Drawing.Size(38, 13);
            this.lblScr.TabIndex = 0;
            this.lblScr.Text = "Score:";
            // 
            // txtboxScr
            // 
            this.txtboxScr.Location = new System.Drawing.Point(81, 20);
            this.txtboxScr.Name = "txtboxScr";
            this.txtboxScr.Size = new System.Drawing.Size(66, 20);
            this.txtboxScr.TabIndex = 1;
            this.txtboxScr.Tag = "Score";
            // 
            // btnAddUpdate
            // 
            this.btnAddUpdate.Location = new System.Drawing.Point(28, 64);
            this.btnAddUpdate.Name = "btnAddUpdate";
            this.btnAddUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnAddUpdate.TabIndex = 2;
            this.btnAddUpdate.Text = "Add";
            this.btnAddUpdate.UseVisualStyleBackColor = true;
            this.btnAddUpdate.Click += new System.EventHandler(this.btnAddUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(109, 64);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmAddUpdateScore
            // 
            this.AcceptButton = this.btnAddUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(204, 103);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddUpdate);
            this.Controls.Add(this.txtboxScr);
            this.Controls.Add(this.lblScr);
            this.Name = "frmAddUpdateScore";
            this.Text = "Add Score";
            this.Load += new System.EventHandler(this.frmAddUpdateScore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScr;
        private System.Windows.Forms.TextBox txtboxScr;
        private System.Windows.Forms.Button btnAddUpdate;
        private System.Windows.Forms.Button btnCancel;
    }
}