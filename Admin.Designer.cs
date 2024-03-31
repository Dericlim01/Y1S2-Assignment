namespace Y1S2
{
    partial class Admin
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
            this.lblname = new System.Windows.Forms.Label();
            this.manage_btn = new System.Windows.Forms.Button();
            this.coach_p_edit_btn = new System.Windows.Forms.Button();
            this.edit_profile_btn = new System.Windows.Forms.Button();
            this.couch_add_btn = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.logout_btn = new System.Windows.Forms.Button();
            this.manager_add_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbltype = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold);
            this.lblname.Location = new System.Drawing.Point(464, 56);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(76, 23);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Name :";
            // 
            // manage_btn
            // 
            this.manage_btn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.manage_btn.Location = new System.Drawing.Point(526, 129);
            this.manage_btn.Name = "manage_btn";
            this.manage_btn.Size = new System.Drawing.Size(184, 58);
            this.manage_btn.TabIndex = 13;
            this.manage_btn.Text = "Manage User";
            this.manage_btn.UseVisualStyleBackColor = false;
            this.manage_btn.Click += new System.EventHandler(this.manage_btn_Click);
            // 
            // coach_p_edit_btn
            // 
            this.coach_p_edit_btn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.coach_p_edit_btn.Location = new System.Drawing.Point(297, 129);
            this.coach_p_edit_btn.Name = "coach_p_edit_btn";
            this.coach_p_edit_btn.Size = new System.Drawing.Size(184, 58);
            this.coach_p_edit_btn.TabIndex = 12;
            this.coach_p_edit_btn.Text = "Edit Coach Profile";
            this.coach_p_edit_btn.UseVisualStyleBackColor = false;
            this.coach_p_edit_btn.Click += new System.EventHandler(this.coach_p_edit_btn_Click);
            // 
            // edit_profile_btn
            // 
            this.edit_profile_btn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.edit_profile_btn.Location = new System.Drawing.Point(526, 50);
            this.edit_profile_btn.Name = "edit_profile_btn";
            this.edit_profile_btn.Size = new System.Drawing.Size(184, 58);
            this.edit_profile_btn.TabIndex = 11;
            this.edit_profile_btn.Text = "Edit Profile";
            this.edit_profile_btn.UseVisualStyleBackColor = false;
            this.edit_profile_btn.Click += new System.EventHandler(this.edit_profile_btn_Click);
            // 
            // couch_add_btn
            // 
            this.couch_add_btn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.couch_add_btn.Location = new System.Drawing.Point(60, 129);
            this.couch_add_btn.Name = "couch_add_btn";
            this.couch_add_btn.Size = new System.Drawing.Size(184, 58);
            this.couch_add_btn.TabIndex = 10;
            this.couch_add_btn.Text = "Add Coach";
            this.couch_add_btn.UseVisualStyleBackColor = false;
            this.couch_add_btn.Click += new System.EventHandler(this.couch_add_btn_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAdd.Location = new System.Drawing.Point(60, 50);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(184, 58);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add Member";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.logout_btn);
            this.groupBox1.Controls.Add(this.manager_add_btn);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.manage_btn);
            this.groupBox1.Controls.Add(this.couch_add_btn);
            this.groupBox1.Controls.Add(this.coach_p_edit_btn);
            this.groupBox1.Controls.Add(this.edit_profile_btn);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(0, 225);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(805, 224);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Features";
            // 
            // logout_btn
            // 
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.logout_btn.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.logout_btn.Location = new System.Drawing.Point(725, 194);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(75, 25);
            this.logout_btn.TabIndex = 20;
            this.logout_btn.Text = "Log Out";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // manager_add_btn
            // 
            this.manager_add_btn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.manager_add_btn.Location = new System.Drawing.Point(297, 50);
            this.manager_add_btn.Name = "manager_add_btn";
            this.manager_add_btn.Size = new System.Drawing.Size(184, 58);
            this.manager_add_btn.TabIndex = 15;
            this.manager_add_btn.Text = "Add Manager";
            this.manager_add_btn.UseVisualStyleBackColor = false;
            this.manager_add_btn.Click += new System.EventHandler(this.manager_add_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Y1S2.Properties.Resources.logo_2;
            this.pictureBox1.Location = new System.Drawing.Point(36, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 28.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Location = new System.Drawing.Point(26, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 55);
            this.label2.TabIndex = 17;
            this.label2.Text = "The Wave";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Y1S2.Properties.Resources.profile3;
            this.pictureBox3.Location = new System.Drawing.Point(302, 20);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(181, 183);
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltype.Location = new System.Drawing.Point(464, 113);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(65, 23);
            this.lbltype.TabIndex = 19;
            this.lbltype.Text = "Type:";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbltype);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox3);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Button manage_btn;
        private System.Windows.Forms.Button coach_p_edit_btn;
        private System.Windows.Forms.Button edit_profile_btn;
        private System.Windows.Forms.Button couch_add_btn;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.Button manager_add_btn;
        private System.Windows.Forms.Button logout_btn;
    }
}