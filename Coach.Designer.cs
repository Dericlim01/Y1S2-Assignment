namespace Y1S2
{
    partial class Coach
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPfm = new System.Windows.Forms.Button();
            this.btnTrainSch = new System.Windows.Forms.Button();
            this.btnRcmd = new System.Windows.Forms.Button();
            this.edit_profile_btn = new System.Windows.Forms.Button();
            this.logout_btn = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.lbltype = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Y1S2.Properties.Resources.logo_2;
            this.pictureBox1.Location = new System.Drawing.Point(36, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 28.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Location = new System.Drawing.Point(26, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 55);
            this.label1.TabIndex = 9;
            this.label1.Text = "The Wave";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.btnPfm);
            this.groupBox1.Controls.Add(this.btnTrainSch);
            this.groupBox1.Controls.Add(this.btnRcmd);
            this.groupBox1.Controls.Add(this.edit_profile_btn);
            this.groupBox1.Controls.Add(this.logout_btn);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 225);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(805, 224);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Features";
            // 
            // btnPfm
            // 
            this.btnPfm.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPfm.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnPfm.FlatAppearance.BorderSize = 3;
            this.btnPfm.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPfm.Location = new System.Drawing.Point(144, 129);
            this.btnPfm.Name = "btnPfm";
            this.btnPfm.Size = new System.Drawing.Size(184, 72);
            this.btnPfm.TabIndex = 7;
            this.btnPfm.Text = "Performance";
            this.btnPfm.UseVisualStyleBackColor = false;
            this.btnPfm.Click += new System.EventHandler(this.btnPfm_Click);
            // 
            // btnTrainSch
            // 
            this.btnTrainSch.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnTrainSch.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnTrainSch.FlatAppearance.BorderSize = 3;
            this.btnTrainSch.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrainSch.Location = new System.Drawing.Point(468, 43);
            this.btnTrainSch.Name = "btnTrainSch";
            this.btnTrainSch.Size = new System.Drawing.Size(200, 73);
            this.btnTrainSch.TabIndex = 5;
            this.btnTrainSch.Text = "Training Schedule";
            this.btnTrainSch.UseVisualStyleBackColor = false;
            this.btnTrainSch.Click += new System.EventHandler(this.btnTrainSch_Click);
            // 
            // btnRcmd
            // 
            this.btnRcmd.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRcmd.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnRcmd.FlatAppearance.BorderSize = 3;
            this.btnRcmd.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.btnRcmd.Location = new System.Drawing.Point(468, 129);
            this.btnRcmd.Name = "btnRcmd";
            this.btnRcmd.Size = new System.Drawing.Size(200, 72);
            this.btnRcmd.TabIndex = 3;
            this.btnRcmd.Text = "Recommendation";
            this.btnRcmd.UseVisualStyleBackColor = false;
            this.btnRcmd.Click += new System.EventHandler(this.btnRcmd_Click);
            // 
            // edit_profile_btn
            // 
            this.edit_profile_btn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.edit_profile_btn.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.edit_profile_btn.FlatAppearance.BorderSize = 3;
            this.edit_profile_btn.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_profile_btn.Location = new System.Drawing.Point(144, 43);
            this.edit_profile_btn.Name = "edit_profile_btn";
            this.edit_profile_btn.Size = new System.Drawing.Size(184, 73);
            this.edit_profile_btn.TabIndex = 2;
            this.edit_profile_btn.Text = "Edit Profile";
            this.edit_profile_btn.UseVisualStyleBackColor = false;
            this.edit_profile_btn.Click += new System.EventHandler(this.edit_profile_btn_Click);
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
            this.lblname.TabIndex = 12;
            this.lblname.Text = "Name:";
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltype.Location = new System.Drawing.Point(464, 113);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(65, 23);
            this.lbltype.TabIndex = 10;
            this.lbltype.Text = "Type:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Y1S2.Properties.Resources.profile3;
            this.pictureBox3.Location = new System.Drawing.Point(302, 20);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(181, 183);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // Coach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lbltype);
            this.Controls.Add(this.pictureBox3);
            this.Name = "Coach";
            this.Text = "Coach";
            this.Load += new System.EventHandler(this.Coach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPfm;
        private System.Windows.Forms.Button btnTrainSch;
        private System.Windows.Forms.Button btnRcmd;
        private System.Windows.Forms.Button edit_profile_btn;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}