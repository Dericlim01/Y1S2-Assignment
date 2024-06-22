namespace Y1S2
{
    partial class AddMember
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.a_rdbtn = new System.Windows.Forms.RadioButton();
            this.i_rdbtn = new System.Windows.Forms.RadioButton();
            this.b_rdbtn = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRegister.Location = new System.Drawing.Point(344, 313);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(99, 40);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(368, 255);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(368, 214);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(368, 146);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Phone Number :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Email :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Add Member";
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(479, 313);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(99, 40);
            this.back_btn.TabIndex = 17;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.a_rdbtn);
            this.groupBox1.Controls.Add(this.i_rdbtn);
            this.groupBox1.Controls.Add(this.b_rdbtn);
            this.groupBox1.Location = new System.Drawing.Point(560, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 100);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Level";
            // 
            // a_rdbtn
            // 
            this.a_rdbtn.AutoSize = true;
            this.a_rdbtn.Location = new System.Drawing.Point(21, 68);
            this.a_rdbtn.Name = "a_rdbtn";
            this.a_rdbtn.Size = new System.Drawing.Size(68, 17);
            this.a_rdbtn.TabIndex = 2;
            this.a_rdbtn.TabStop = true;
            this.a_rdbtn.Text = "Advance";
            this.a_rdbtn.UseVisualStyleBackColor = true;
            this.a_rdbtn.CheckedChanged += new System.EventHandler(this.a_rdbtn_CheckedChanged);
            // 
            // i_rdbtn
            // 
            this.i_rdbtn.AutoSize = true;
            this.i_rdbtn.Location = new System.Drawing.Point(21, 44);
            this.i_rdbtn.Name = "i_rdbtn";
            this.i_rdbtn.Size = new System.Drawing.Size(83, 17);
            this.i_rdbtn.TabIndex = 1;
            this.i_rdbtn.TabStop = true;
            this.i_rdbtn.Text = "Intermediate";
            this.i_rdbtn.UseVisualStyleBackColor = true;
            this.i_rdbtn.CheckedChanged += new System.EventHandler(this.i_rdbtn_CheckedChanged);
            // 
            // b_rdbtn
            // 
            this.b_rdbtn.AutoSize = true;
            this.b_rdbtn.Location = new System.Drawing.Point(21, 20);
            this.b_rdbtn.Name = "b_rdbtn";
            this.b_rdbtn.Size = new System.Drawing.Size(67, 17);
            this.b_rdbtn.TabIndex = 0;
            this.b_rdbtn.TabStop = true;
            this.b_rdbtn.Text = "Begineer";
            this.b_rdbtn.UseVisualStyleBackColor = true;
            this.b_rdbtn.CheckedChanged += new System.EventHandler(this.b_rdbtn_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(272, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Password :";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(368, 175);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 2;
            // 
            // AddMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddMember";
            this.Text = "AddMember";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton a_rdbtn;
        private System.Windows.Forms.RadioButton i_rdbtn;
        private System.Windows.Forms.RadioButton b_rdbtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPassword;
    }
}