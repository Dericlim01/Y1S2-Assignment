namespace Y1S2
{
    partial class Delete_User
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
            this.dlt_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.coach_rdbtn = new System.Windows.Forms.RadioButton();
            this.manager_rdbtn = new System.Windows.Forms.RadioButton();
            this.member_rdbtn = new System.Windows.Forms.RadioButton();
            this.user_listbx = new System.Windows.Forms.ListBox();
            this.phonenum_lbl = new System.Windows.Forms.Label();
            this.email_lbl = new System.Windows.Forms.Label();
            this.name_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dlt_btn
            // 
            this.dlt_btn.Location = new System.Drawing.Point(151, 274);
            this.dlt_btn.Name = "dlt_btn";
            this.dlt_btn.Size = new System.Drawing.Size(75, 23);
            this.dlt_btn.TabIndex = 21;
            this.dlt_btn.Text = "Delete";
            this.dlt_btn.UseVisualStyleBackColor = true;
            this.dlt_btn.Click += new System.EventHandler(this.dlt_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.coach_rdbtn);
            this.groupBox1.Controls.Add(this.manager_rdbtn);
            this.groupBox1.Controls.Add(this.member_rdbtn);
            this.groupBox1.Location = new System.Drawing.Point(485, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 100);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Role";
            // 
            // coach_rdbtn
            // 
            this.coach_rdbtn.AutoSize = true;
            this.coach_rdbtn.Location = new System.Drawing.Point(18, 67);
            this.coach_rdbtn.Name = "coach_rdbtn";
            this.coach_rdbtn.Size = new System.Drawing.Size(56, 17);
            this.coach_rdbtn.TabIndex = 2;
            this.coach_rdbtn.TabStop = true;
            this.coach_rdbtn.Text = "Coach";
            this.coach_rdbtn.UseVisualStyleBackColor = true;
            this.coach_rdbtn.CheckedChanged += new System.EventHandler(this.coach_rdbtn_CheckedChanged);
            // 
            // manager_rdbtn
            // 
            this.manager_rdbtn.AutoSize = true;
            this.manager_rdbtn.Location = new System.Drawing.Point(18, 43);
            this.manager_rdbtn.Name = "manager_rdbtn";
            this.manager_rdbtn.Size = new System.Drawing.Size(67, 17);
            this.manager_rdbtn.TabIndex = 1;
            this.manager_rdbtn.TabStop = true;
            this.manager_rdbtn.Text = "Manager";
            this.manager_rdbtn.UseVisualStyleBackColor = true;
            this.manager_rdbtn.CheckedChanged += new System.EventHandler(this.manager_rdbtn_CheckedChanged);
            // 
            // member_rdbtn
            // 
            this.member_rdbtn.AutoSize = true;
            this.member_rdbtn.Location = new System.Drawing.Point(18, 19);
            this.member_rdbtn.Name = "member_rdbtn";
            this.member_rdbtn.Size = new System.Drawing.Size(63, 17);
            this.member_rdbtn.TabIndex = 0;
            this.member_rdbtn.TabStop = true;
            this.member_rdbtn.Text = "Member";
            this.member_rdbtn.UseVisualStyleBackColor = true;
            this.member_rdbtn.CheckedChanged += new System.EventHandler(this.member_rdbtn_CheckedChanged);
            // 
            // user_listbx
            // 
            this.user_listbx.FormattingEnabled = true;
            this.user_listbx.Location = new System.Drawing.Point(485, 202);
            this.user_listbx.Name = "user_listbx";
            this.user_listbx.Size = new System.Drawing.Size(120, 95);
            this.user_listbx.TabIndex = 19;
            this.user_listbx.SelectedIndexChanged += new System.EventHandler(this.user_listbx_SelectedIndexChanged);
            // 
            // phonenum_lbl
            // 
            this.phonenum_lbl.AutoSize = true;
            this.phonenum_lbl.Location = new System.Drawing.Point(229, 158);
            this.phonenum_lbl.Name = "phonenum_lbl";
            this.phonenum_lbl.Size = new System.Drawing.Size(13, 13);
            this.phonenum_lbl.TabIndex = 18;
            this.phonenum_lbl.Text = "_";
            // 
            // email_lbl
            // 
            this.email_lbl.AutoSize = true;
            this.email_lbl.Location = new System.Drawing.Point(229, 123);
            this.email_lbl.Name = "email_lbl";
            this.email_lbl.Size = new System.Drawing.Size(13, 13);
            this.email_lbl.TabIndex = 17;
            this.email_lbl.Text = "_";
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Location = new System.Drawing.Point(229, 86);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(13, 13);
            this.name_lbl.TabIndex = 16;
            this.name_lbl.Text = "_";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Phone Number :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Email :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Name :";
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(281, 274);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 22;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Delete User";
            // 
            // Delete_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.dlt_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.user_listbx);
            this.Controls.Add(this.phonenum_lbl);
            this.Controls.Add(this.email_lbl);
            this.Controls.Add(this.name_lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Delete_User";
            this.Text = "Delete_User";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dlt_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton coach_rdbtn;
        private System.Windows.Forms.RadioButton manager_rdbtn;
        private System.Windows.Forms.RadioButton member_rdbtn;
        private System.Windows.Forms.ListBox user_listbx;
        private System.Windows.Forms.Label phonenum_lbl;
        private System.Windows.Forms.Label email_lbl;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Label label4;
    }
}