﻿namespace Y1S2
{
    partial class AddCoach
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
            this.addcouch_btn = new System.Windows.Forms.Button();
            this.lvl_txtbx = new System.Windows.Forms.TextBox();
            this.phoneNum_txtbx = new System.Windows.Forms.TextBox();
            this.email_txtbx = new System.Windows.Forms.TextBox();
            this.pass_txtbx = new System.Windows.Forms.TextBox();
            this.name_txtbx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addcouch_btn
            // 
            this.addcouch_btn.Location = new System.Drawing.Point(308, 302);
            this.addcouch_btn.Name = "addcouch_btn";
            this.addcouch_btn.Size = new System.Drawing.Size(75, 23);
            this.addcouch_btn.TabIndex = 21;
            this.addcouch_btn.Text = "Add";
            this.addcouch_btn.UseVisualStyleBackColor = true;
            this.addcouch_btn.Click += new System.EventHandler(this.addcouch_btn_Click);
            // 
            // lvl_txtbx
            // 
            this.lvl_txtbx.Location = new System.Drawing.Point(349, 224);
            this.lvl_txtbx.Name = "lvl_txtbx";
            this.lvl_txtbx.Size = new System.Drawing.Size(100, 20);
            this.lvl_txtbx.TabIndex = 20;
            // 
            // phoneNum_txtbx
            // 
            this.phoneNum_txtbx.Location = new System.Drawing.Point(349, 200);
            this.phoneNum_txtbx.Name = "phoneNum_txtbx";
            this.phoneNum_txtbx.Size = new System.Drawing.Size(100, 20);
            this.phoneNum_txtbx.TabIndex = 19;
            // 
            // email_txtbx
            // 
            this.email_txtbx.Location = new System.Drawing.Point(349, 172);
            this.email_txtbx.Name = "email_txtbx";
            this.email_txtbx.Size = new System.Drawing.Size(100, 20);
            this.email_txtbx.TabIndex = 18;
            // 
            // pass_txtbx
            // 
            this.pass_txtbx.Location = new System.Drawing.Point(349, 144);
            this.pass_txtbx.Name = "pass_txtbx";
            this.pass_txtbx.Size = new System.Drawing.Size(100, 20);
            this.pass_txtbx.TabIndex = 17;
            // 
            // name_txtbx
            // 
            this.name_txtbx.Location = new System.Drawing.Point(349, 114);
            this.name_txtbx.Name = "name_txtbx";
            this.name_txtbx.Size = new System.Drawing.Size(100, 20);
            this.name_txtbx.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Level :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Phone Number :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Email :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Password :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name :";
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(412, 302);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 22;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(337, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Add Coach";
            // 
            // AddCoach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.addcouch_btn);
            this.Controls.Add(this.lvl_txtbx);
            this.Controls.Add(this.phoneNum_txtbx);
            this.Controls.Add(this.email_txtbx);
            this.Controls.Add(this.pass_txtbx);
            this.Controls.Add(this.name_txtbx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddCoach";
            this.Text = "AddCoach";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addcouch_btn;
        private System.Windows.Forms.TextBox lvl_txtbx;
        private System.Windows.Forms.TextBox phoneNum_txtbx;
        private System.Windows.Forms.TextBox email_txtbx;
        private System.Windows.Forms.TextBox pass_txtbx;
        private System.Windows.Forms.TextBox name_txtbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Label label6;
    }
}