namespace VSTemplateWizard
{
    partial class SprocInputForm
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
            this.okBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.itemTxt = new System.Windows.Forms.TextBox();
            this.actionCmb = new System.Windows.Forms.ComboBox();
            this.rollbackCmb = new System.Windows.Forms.ComboBox();
            this.sprocnameTxt = new System.Windows.Forms.TextBox();
            this.dbnameTxt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.commentsTxt = new System.Windows.Forms.TextBox();
            this.taskTxt = new System.Windows.Forms.TextBox();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.revisionTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // okBtn
            // 
            this.okBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okBtn.Location = new System.Drawing.Point(247, 427);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 30;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Database name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Stored procedure name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Is rollback required?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Action:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(99, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Item #:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.itemTxt);
            this.groupBox1.Controls.Add(this.actionCmb);
            this.groupBox1.Controls.Add(this.rollbackCmb);
            this.groupBox1.Controls.Add(this.sprocnameTxt);
            this.groupBox1.Controls.Add(this.dbnameTxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 183);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stored procedure details";
            // 
            // itemTxt
            // 
            this.itemTxt.Location = new System.Drawing.Point(146, 137);
            this.itemTxt.MaxLength = 7;
            this.itemTxt.Name = "itemTxt";
            this.itemTxt.Size = new System.Drawing.Size(100, 20);
            this.itemTxt.TabIndex = 12;
            // 
            // actionCmb
            // 
            this.actionCmb.FormattingEnabled = true;
            this.actionCmb.Items.AddRange(new object[] {
            "Create",
            "Alter",
            "Remove"});
            this.actionCmb.Location = new System.Drawing.Point(146, 110);
            this.actionCmb.Name = "actionCmb";
            this.actionCmb.Size = new System.Drawing.Size(121, 21);
            this.actionCmb.TabIndex = 11;
            // 
            // rollbackCmb
            // 
            this.rollbackCmb.FormattingEnabled = true;
            this.rollbackCmb.Items.AddRange(new object[] {
            "No",
            "Yes",
            "N/A"});
            this.rollbackCmb.Location = new System.Drawing.Point(146, 83);
            this.rollbackCmb.Name = "rollbackCmb";
            this.rollbackCmb.Size = new System.Drawing.Size(64, 21);
            this.rollbackCmb.TabIndex = 10;
            // 
            // sprocnameTxt
            // 
            this.sprocnameTxt.Location = new System.Drawing.Point(146, 59);
            this.sprocnameTxt.Name = "sprocnameTxt";
            this.sprocnameTxt.Size = new System.Drawing.Size(221, 20);
            this.sprocnameTxt.TabIndex = 9;
            // 
            // dbnameTxt
            // 
            this.dbnameTxt.Location = new System.Drawing.Point(146, 33);
            this.dbnameTxt.Name = "dbnameTxt";
            this.dbnameTxt.Size = new System.Drawing.Size(221, 20);
            this.dbnameTxt.TabIndex = 8;
            this.dbnameTxt.Text = "ArchiveDB";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.commentsTxt);
            this.groupBox2.Controls.Add(this.taskTxt);
            this.groupBox2.Controls.Add(this.usernameTxt);
            this.groupBox2.Controls.Add(this.revisionTxt);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 210);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Revision details";
            // 
            // commentsTxt
            // 
            this.commentsTxt.Location = new System.Drawing.Point(85, 103);
            this.commentsTxt.MaxLength = 80;
            this.commentsTxt.Multiline = true;
            this.commentsTxt.Name = "commentsTxt";
            this.commentsTxt.Size = new System.Drawing.Size(282, 89);
            this.commentsTxt.TabIndex = 20;
            // 
            // taskTxt
            // 
            this.taskTxt.Location = new System.Drawing.Point(85, 77);
            this.taskTxt.MaxLength = 7;
            this.taskTxt.Name = "taskTxt";
            this.taskTxt.Size = new System.Drawing.Size(100, 20);
            this.taskTxt.TabIndex = 19;
            // 
            // usernameTxt
            // 
            this.usernameTxt.Location = new System.Drawing.Point(85, 51);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(100, 20);
            this.usernameTxt.TabIndex = 17;
            this.usernameTxt.Text = "Juan L. Hidalgo";
            // 
            // revisionTxt
            // 
            this.revisionTxt.Location = new System.Drawing.Point(85, 24);
            this.revisionTxt.Name = "revisionTxt";
            this.revisionTxt.Size = new System.Drawing.Size(54, 20);
            this.revisionTxt.TabIndex = 16;
            this.revisionTxt.Text = "001";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Comments:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Task #:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "User name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Revision #:";
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(328, 427);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 32;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // SprocInputForm
            // 
            this.AcceptButton = this.okBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(415, 462);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "SprocInputForm";
            this.Text = "Stored Procedure Template";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox itemTxt;
        private System.Windows.Forms.ComboBox actionCmb;
        private System.Windows.Forms.ComboBox rollbackCmb;
        private System.Windows.Forms.TextBox sprocnameTxt;
        private System.Windows.Forms.TextBox dbnameTxt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox commentsTxt;
        private System.Windows.Forms.TextBox taskTxt;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.TextBox revisionTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelBtn;
    }
}