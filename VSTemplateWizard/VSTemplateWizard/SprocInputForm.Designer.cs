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
            this.dbnameTxt = new System.Windows.Forms.TextBox();
            this.sprocnameTxt = new System.Windows.Forms.TextBox();
            this.rollbackCmb = new System.Windows.Forms.ComboBox();
            this.actionCmb = new System.Windows.Forms.ComboBox();
            this.itemTxt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(328, 275);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 2;
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
            // dbnameTxt
            // 
            this.dbnameTxt.Location = new System.Drawing.Point(146, 33);
            this.dbnameTxt.Name = "dbnameTxt";
            this.dbnameTxt.Size = new System.Drawing.Size(221, 20);
            this.dbnameTxt.TabIndex = 8;
            this.dbnameTxt.Text = "ArchiveDB";
            // 
            // sprocnameTxt
            // 
            this.sprocnameTxt.Location = new System.Drawing.Point(146, 59);
            this.sprocnameTxt.Name = "sprocnameTxt";
            this.sprocnameTxt.Size = new System.Drawing.Size(221, 20);
            this.sprocnameTxt.TabIndex = 9;
            // 
            // rollbackCmb
            // 
            this.rollbackCmb.FormattingEnabled = true;
            this.rollbackCmb.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.rollbackCmb.Location = new System.Drawing.Point(146, 83);
            this.rollbackCmb.Name = "rollbackCmb";
            this.rollbackCmb.Size = new System.Drawing.Size(64, 21);
            this.rollbackCmb.Sorted = true;
            this.rollbackCmb.TabIndex = 10;
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
            // itemTxt
            // 
            this.itemTxt.Location = new System.Drawing.Point(146, 137);
            this.itemTxt.MaxLength = 7;
            this.itemTxt.Name = "itemTxt";
            this.itemTxt.Size = new System.Drawing.Size(100, 20);
            this.itemTxt.TabIndex = 12;
            // 
            // SprocInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 310);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "SprocInputForm";
            this.Text = "Stored Procedure Template";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}