namespace Y1S2
{
    partial class Manager
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resultBtn = new System.Windows.Forms.Button();
            this.listFromCoachBtn = new System.Windows.Forms.Button();
            this.memberListBtn = new System.Windows.Forms.Button();
            this.compBtn = new System.Windows.Forms.Button();
            this.assBtn = new System.Windows.Forms.Button();
            this.profileBtn = new System.Windows.Forms.Button();
            this.logout_btn = new System.Windows.Forms.Button();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbltype = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
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
            this.label1.TabIndex = 9;
            this.label1.Text = "The Wave";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.resultBtn);
            this.groupBox1.Controls.Add(this.listFromCoachBtn);
            this.groupBox1.Controls.Add(this.memberListBtn);
            this.groupBox1.Controls.Add(this.compBtn);
            this.groupBox1.Controls.Add(this.assBtn);
            this.groupBox1.Controls.Add(this.profileBtn);
            this.groupBox1.Controls.Add(this.logout_btn);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 225);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(805, 223);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Features";
            // 
            // resultBtn
            // 
            this.resultBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.resultBtn.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.resultBtn.FlatAppearance.BorderSize = 3;
            this.resultBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultBtn.Location = new System.Drawing.Point(60, 129);
            this.resultBtn.Name = "resultBtn";
            this.resultBtn.Size = new System.Drawing.Size(184, 58);
            this.resultBtn.TabIndex = 7;
            this.resultBtn.Text = "Manage Competition Result";
            this.resultBtn.UseVisualStyleBackColor = false;
            this.resultBtn.Click += new System.EventHandler(this.resultBtn_Click);
            // 
            // listFromCoachBtn
            // 
            this.listFromCoachBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.listFromCoachBtn.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.listFromCoachBtn.FlatAppearance.BorderSize = 3;
            this.listFromCoachBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listFromCoachBtn.Location = new System.Drawing.Point(526, 129);
            this.listFromCoachBtn.Name = "listFromCoachBtn";
            this.listFromCoachBtn.Size = new System.Drawing.Size(184, 58);
            this.listFromCoachBtn.TabIndex = 6;
            this.listFromCoachBtn.Text = "List From Coach";
            this.listFromCoachBtn.UseVisualStyleBackColor = false;
            this.listFromCoachBtn.Click += new System.EventHandler(this.listFromCoachBtn_Click);
            // 
            // memberListBtn
            // 
            this.memberListBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.memberListBtn.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.memberListBtn.FlatAppearance.BorderSize = 3;
            this.memberListBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberListBtn.Location = new System.Drawing.Point(526, 50);
            this.memberListBtn.Name = "memberListBtn";
            this.memberListBtn.Size = new System.Drawing.Size(184, 58);
            this.memberListBtn.TabIndex = 5;
            this.memberListBtn.Text = "View Member List";
            this.memberListBtn.UseVisualStyleBackColor = false;
            this.memberListBtn.Click += new System.EventHandler(this.memberListBtn_Click);
            // 
            // compBtn
            // 
            this.compBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.compBtn.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.compBtn.FlatAppearance.BorderSize = 3;
            this.compBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compBtn.Location = new System.Drawing.Point(297, 50);
            this.compBtn.Name = "compBtn";
            this.compBtn.Size = new System.Drawing.Size(184, 58);
            this.compBtn.TabIndex = 4;
            this.compBtn.Text = "Manage Competition";
            this.compBtn.UseVisualStyleBackColor = false;
            this.compBtn.Click += new System.EventHandler(this.compBtn_Click);
            // 
            // assBtn
            // 
            this.assBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.assBtn.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.assBtn.FlatAppearance.BorderSize = 3;
            this.assBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assBtn.Location = new System.Drawing.Point(297, 129);
            this.assBtn.Name = "assBtn";
            this.assBtn.Size = new System.Drawing.Size(184, 58);
            this.assBtn.TabIndex = 3;
            this.assBtn.Text = "Assign Member ";
            this.assBtn.UseVisualStyleBackColor = false;
            this.assBtn.Click += new System.EventHandler(this.assBtn_Click);
            // 
            // profileBtn
            // 
            this.profileBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.profileBtn.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.profileBtn.FlatAppearance.BorderSize = 3;
            this.profileBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileBtn.Location = new System.Drawing.Point(60, 50);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.Size = new System.Drawing.Size(184, 58);
            this.profileBtn.TabIndex = 2;
            this.profileBtn.Text = "Edit Profile";
            this.profileBtn.UseVisualStyleBackColor = false;
            this.profileBtn.Click += new System.EventHandler(this.profileBtn_Click);
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
            // Manager
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
            this.Name = "Manager";
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.Manager_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button resultBtn;
        private System.Windows.Forms.Button listFromCoachBtn;
        private System.Windows.Forms.Button memberListBtn;
        private System.Windows.Forms.Button compBtn;
        private System.Windows.Forms.Button assBtn;
        private System.Windows.Forms.Button profileBtn;
        private System.Windows.Forms.Button logout_btn;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.Label lblname;
    }
}