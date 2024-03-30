namespace Y1S2
{
    partial class Enroll
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
            this.reenter_pass_txtbx = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pn_txtbx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.register_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.a_rdbtn = new System.Windows.Forms.RadioButton();
            this.i_rdbtn = new System.Windows.Forms.RadioButton();
            this.b_rdbtn = new System.Windows.Forms.RadioButton();
            this.email_txtbx = new System.Windows.Forms.TextBox();
            this.age_txtbx = new System.Windows.Forms.TextBox();
            this.password_txtbx = new System.Windows.Forms.TextBox();
            this.name_txtbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reenter_pass_txtbx
            // 
            this.reenter_pass_txtbx.Location = new System.Drawing.Point(250, 145);
            this.reenter_pass_txtbx.Name = "reenter_pass_txtbx";
            this.reenter_pass_txtbx.Size = new System.Drawing.Size(100, 20);
            this.reenter_pass_txtbx.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Email :";
            // 
            // pn_txtbx
            // 
            this.pn_txtbx.Location = new System.Drawing.Point(250, 174);
            this.pn_txtbx.Name = "pn_txtbx";
            this.pn_txtbx.Size = new System.Drawing.Size(100, 20);
            this.pn_txtbx.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Age :";
            // 
            // register_btn
            // 
            this.register_btn.Location = new System.Drawing.Point(250, 275);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(75, 23);
            this.register_btn.TabIndex = 23;
            this.register_btn.Text = "Register";
            this.register_btn.UseVisualStyleBackColor = true;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.a_rdbtn);
            this.groupBox1.Controls.Add(this.i_rdbtn);
            this.groupBox1.Controls.Add(this.b_rdbtn);
            this.groupBox1.Location = new System.Drawing.Point(490, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(119, 100);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Level";
            // 
            // a_rdbtn
            // 
            this.a_rdbtn.AutoSize = true;
            this.a_rdbtn.Location = new System.Drawing.Point(18, 67);
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
            this.i_rdbtn.Location = new System.Drawing.Point(18, 44);
            this.i_rdbtn.Name = "i_rdbtn";
            this.i_rdbtn.Size = new System.Drawing.Size(79, 17);
            this.i_rdbtn.TabIndex = 1;
            this.i_rdbtn.TabStop = true;
            this.i_rdbtn.Text = "Intermidiate";
            this.i_rdbtn.UseVisualStyleBackColor = true;
            this.i_rdbtn.CheckedChanged += new System.EventHandler(this.i_rdbtn_CheckedChanged);
            // 
            // b_rdbtn
            // 
            this.b_rdbtn.AutoSize = true;
            this.b_rdbtn.Location = new System.Drawing.Point(18, 21);
            this.b_rdbtn.Name = "b_rdbtn";
            this.b_rdbtn.Size = new System.Drawing.Size(67, 17);
            this.b_rdbtn.TabIndex = 0;
            this.b_rdbtn.TabStop = true;
            this.b_rdbtn.Text = "Beginner";
            this.b_rdbtn.UseVisualStyleBackColor = true;
            this.b_rdbtn.CheckedChanged += new System.EventHandler(this.b_rdbtn_CheckedChanged);
            // 
            // email_txtbx
            // 
            this.email_txtbx.Location = new System.Drawing.Point(250, 232);
            this.email_txtbx.Name = "email_txtbx";
            this.email_txtbx.Size = new System.Drawing.Size(100, 20);
            this.email_txtbx.TabIndex = 21;
            // 
            // age_txtbx
            // 
            this.age_txtbx.Location = new System.Drawing.Point(250, 202);
            this.age_txtbx.Name = "age_txtbx";
            this.age_txtbx.Size = new System.Drawing.Size(100, 20);
            this.age_txtbx.TabIndex = 20;
            // 
            // password_txtbx
            // 
            this.password_txtbx.Location = new System.Drawing.Point(250, 117);
            this.password_txtbx.Name = "password_txtbx";
            this.password_txtbx.Size = new System.Drawing.Size(100, 20);
            this.password_txtbx.TabIndex = 19;
            // 
            // name_txtbx
            // 
            this.name_txtbx.Location = new System.Drawing.Point(250, 91);
            this.name_txtbx.Name = "name_txtbx";
            this.name_txtbx.Size = new System.Drawing.Size(100, 20);
            this.name_txtbx.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Phone Number :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Re-enter Password :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Name :";
            // 
            // Enroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reenter_pass_txtbx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pn_txtbx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.email_txtbx);
            this.Controls.Add(this.age_txtbx);
            this.Controls.Add(this.password_txtbx);
            this.Controls.Add(this.name_txtbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Enroll";
            this.Text = "Enroll";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox reenter_pass_txtbx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pn_txtbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton a_rdbtn;
        private System.Windows.Forms.RadioButton i_rdbtn;
        private System.Windows.Forms.RadioButton b_rdbtn;
        private System.Windows.Forms.TextBox email_txtbx;
        private System.Windows.Forms.TextBox age_txtbx;
        private System.Windows.Forms.TextBox password_txtbx;
        private System.Windows.Forms.TextBox name_txtbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}