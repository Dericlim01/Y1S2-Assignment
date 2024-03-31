namespace Y1S2
{
    partial class Member
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbltype = new System.Windows.Forms.Label();
            this.logout_btn = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.send_suggest = new System.Windows.Forms.Button();
            this.view_performance_btn = new System.Windows.Forms.Button();
            this.training_sche_btn = new System.Windows.Forms.Button();
            this.all_comp_btn = new System.Windows.Forms.Button();
            this.enunroll_btn = new System.Windows.Forms.Button();
            this.edit_profile_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 28.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Location = new System.Drawing.Point(26, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "The Wave";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltype.Location = new System.Drawing.Point(464, 113);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(65, 23);
            this.lbltype.TabIndex = 4;
            this.lbltype.Text = "Type:";
            // 
            // logout_btn
            // 
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.logout_btn.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.logout_btn.Location = new System.Drawing.Point(725, 194);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(75, 25);
            this.logout_btn.TabIndex = 1;
            this.logout_btn.Text = "Log Out";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(464, 56);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(65, 23);
            this.lblname.TabIndex = 6;
            this.lblname.Text = "Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.send_suggest);
            this.groupBox1.Controls.Add(this.view_performance_btn);
            this.groupBox1.Controls.Add(this.training_sche_btn);
            this.groupBox1.Controls.Add(this.all_comp_btn);
            this.groupBox1.Controls.Add(this.enunroll_btn);
            this.groupBox1.Controls.Add(this.edit_profile_btn);
            this.groupBox1.Controls.Add(this.logout_btn);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 225);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(805, 224);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Features";
            // 
            // send_suggest
            // 
            this.send_suggest.BackColor = System.Drawing.Color.CornflowerBlue;
            this.send_suggest.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.send_suggest.FlatAppearance.BorderSize = 3;
            this.send_suggest.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send_suggest.Location = new System.Drawing.Point(60, 129);
            this.send_suggest.Name = "send_suggest";
            this.send_suggest.Size = new System.Drawing.Size(184, 58);
            this.send_suggest.TabIndex = 7;
            this.send_suggest.Text = "Send Suggestion";
            this.send_suggest.UseVisualStyleBackColor = false;
            this.send_suggest.Click += new System.EventHandler(this.send_suggest_Click);
            // 
            // view_performance_btn
            // 
            this.view_performance_btn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.view_performance_btn.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.view_performance_btn.FlatAppearance.BorderSize = 3;
            this.view_performance_btn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_performance_btn.Location = new System.Drawing.Point(526, 129);
            this.view_performance_btn.Name = "view_performance_btn";
            this.view_performance_btn.Size = new System.Drawing.Size(184, 58);
            this.view_performance_btn.TabIndex = 6;
            this.view_performance_btn.Text = "View Performance";
            this.view_performance_btn.UseVisualStyleBackColor = false;
            this.view_performance_btn.Click += new System.EventHandler(this.view_performance_btn_Click);
            // 
            // training_sche_btn
            // 
            this.training_sche_btn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.training_sche_btn.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.training_sche_btn.FlatAppearance.BorderSize = 3;
            this.training_sche_btn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.training_sche_btn.Location = new System.Drawing.Point(526, 50);
            this.training_sche_btn.Name = "training_sche_btn";
            this.training_sche_btn.Size = new System.Drawing.Size(184, 58);
            this.training_sche_btn.TabIndex = 5;
            this.training_sche_btn.Text = "Training Schedule";
            this.training_sche_btn.UseVisualStyleBackColor = false;
            // 
            // all_comp_btn
            // 
            this.all_comp_btn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.all_comp_btn.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.all_comp_btn.FlatAppearance.BorderSize = 3;
            this.all_comp_btn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.all_comp_btn.Location = new System.Drawing.Point(297, 50);
            this.all_comp_btn.Name = "all_comp_btn";
            this.all_comp_btn.Size = new System.Drawing.Size(184, 58);
            this.all_comp_btn.TabIndex = 4;
            this.all_comp_btn.Text = "Competition";
            this.all_comp_btn.UseVisualStyleBackColor = false;
            this.all_comp_btn.Click += new System.EventHandler(this.all_comp_btn_Click);
            // 
            // enunroll_btn
            // 
            this.enunroll_btn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.enunroll_btn.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.enunroll_btn.FlatAppearance.BorderSize = 3;
            this.enunroll_btn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enunroll_btn.Location = new System.Drawing.Point(297, 129);
            this.enunroll_btn.Name = "enunroll_btn";
            this.enunroll_btn.Size = new System.Drawing.Size(184, 58);
            this.enunroll_btn.TabIndex = 3;
            this.enunroll_btn.Text = "Unenroll";
            this.enunroll_btn.UseVisualStyleBackColor = false;
            this.enunroll_btn.Click += new System.EventHandler(this.enunroll_btn_Click);
            // 
            // edit_profile_btn
            // 
            this.edit_profile_btn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.edit_profile_btn.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.edit_profile_btn.FlatAppearance.BorderSize = 3;
            this.edit_profile_btn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_profile_btn.Location = new System.Drawing.Point(60, 50);
            this.edit_profile_btn.Name = "edit_profile_btn";
            this.edit_profile_btn.Size = new System.Drawing.Size(184, 58);
            this.edit_profile_btn.TabIndex = 2;
            this.edit_profile_btn.Text = "Edit Profile";
            this.edit_profile_btn.UseVisualStyleBackColor = false;
            this.edit_profile_btn.Click += new System.EventHandler(this.edit_profile_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Y1S2.Properties.Resources.logo_2;
            this.pictureBox1.Location = new System.Drawing.Point(36, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Y1S2.Properties.Resources.profile3;
            this.pictureBox3.Location = new System.Drawing.Point(302, 20);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(181, 183);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lbltype);
            this.Controls.Add(this.pictureBox3);
            this.Name = "Member";
            this.Text = "Member";
            this.Load += new System.EventHandler(this.Member_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button edit_profile_btn;
        private System.Windows.Forms.Button send_suggest;
        private System.Windows.Forms.Button view_performance_btn;
        private System.Windows.Forms.Button training_sche_btn;
        private System.Windows.Forms.Button all_comp_btn;
        private System.Windows.Forms.Button enunroll_btn;
    }
}