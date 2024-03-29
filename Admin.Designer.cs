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
            this.label1 = new System.Windows.Forms.Label();
            this.lblidentity = new System.Windows.Forms.Label();
            this.manage_btn = new System.Windows.Forms.Button();
            this.coach_p_edit_btn = new System.Windows.Forms.Button();
            this.edit_profile_btn = new System.Windows.Forms.Button();
            this.couch_add_btn = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Home Page";
            // 
            // lblidentity
            // 
            this.lblidentity.AutoSize = true;
            this.lblidentity.Location = new System.Drawing.Point(340, 107);
            this.lblidentity.Name = "lblidentity";
            this.lblidentity.Size = new System.Drawing.Size(13, 13);
            this.lblidentity.TabIndex = 1;
            this.lblidentity.Text = "_";
            // 
            // manage_btn
            // 
            this.manage_btn.Location = new System.Drawing.Point(322, 313);
            this.manage_btn.Name = "manage_btn";
            this.manage_btn.Size = new System.Drawing.Size(89, 23);
            this.manage_btn.TabIndex = 13;
            this.manage_btn.Text = "Manage";
            this.manage_btn.UseVisualStyleBackColor = true;
            this.manage_btn.Click += new System.EventHandler(this.manage_btn_Click);
            // 
            // coach_p_edit_btn
            // 
            this.coach_p_edit_btn.Location = new System.Drawing.Point(322, 272);
            this.coach_p_edit_btn.Name = "coach_p_edit_btn";
            this.coach_p_edit_btn.Size = new System.Drawing.Size(89, 23);
            this.coach_p_edit_btn.TabIndex = 12;
            this.coach_p_edit_btn.Text = "Edit Coach Profile";
            this.coach_p_edit_btn.UseVisualStyleBackColor = true;
            this.coach_p_edit_btn.Click += new System.EventHandler(this.coach_p_edit_btn_Click);
            // 
            // edit_profile_btn
            // 
            this.edit_profile_btn.Location = new System.Drawing.Point(322, 232);
            this.edit_profile_btn.Name = "edit_profile_btn";
            this.edit_profile_btn.Size = new System.Drawing.Size(89, 23);
            this.edit_profile_btn.TabIndex = 11;
            this.edit_profile_btn.Text = "Edit Profile";
            this.edit_profile_btn.UseVisualStyleBackColor = true;
            this.edit_profile_btn.Click += new System.EventHandler(this.edit_profile_btn_Click);
            // 
            // couch_add_btn
            // 
            this.couch_add_btn.Location = new System.Drawing.Point(322, 191);
            this.couch_add_btn.Name = "couch_add_btn";
            this.couch_add_btn.Size = new System.Drawing.Size(89, 23);
            this.couch_add_btn.TabIndex = 10;
            this.couch_add_btn.Text = "Add Couch";
            this.couch_add_btn.UseVisualStyleBackColor = true;
            this.couch_add_btn.Click += new System.EventHandler(this.couch_add_btn_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(322, 144);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add Member";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.manage_btn);
            this.Controls.Add(this.coach_p_edit_btn);
            this.Controls.Add(this.edit_profile_btn);
            this.Controls.Add(this.couch_add_btn);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblidentity);
            this.Controls.Add(this.label1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblidentity;
        private System.Windows.Forms.Button manage_btn;
        private System.Windows.Forms.Button coach_p_edit_btn;
        private System.Windows.Forms.Button edit_profile_btn;
        private System.Windows.Forms.Button couch_add_btn;
        private System.Windows.Forms.Button btnAdd;
    }
}