namespace Y1S2
{
    partial class Admin_Suggestion
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.suggest_listbx = new System.Windows.Forms.ListBox();
            this.member_listbx = new System.Windows.Forms.ListBox();
            this.suggestion_lbl = new System.Windows.Forms.Label();
            this.name_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(483, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Suggestion List :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(483, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "User List :";
            // 
            // suggest_listbx
            // 
            this.suggest_listbx.FormattingEnabled = true;
            this.suggest_listbx.Location = new System.Drawing.Point(483, 246);
            this.suggest_listbx.Name = "suggest_listbx";
            this.suggest_listbx.Size = new System.Drawing.Size(120, 95);
            this.suggest_listbx.TabIndex = 13;
            this.suggest_listbx.SelectedIndexChanged += new System.EventHandler(this.suggest_listbx_SelectedIndexChanged);
            // 
            // member_listbx
            // 
            this.member_listbx.FormattingEnabled = true;
            this.member_listbx.Location = new System.Drawing.Point(483, 107);
            this.member_listbx.Name = "member_listbx";
            this.member_listbx.Size = new System.Drawing.Size(120, 95);
            this.member_listbx.TabIndex = 12;
            this.member_listbx.SelectedIndexChanged += new System.EventHandler(this.member_listbx_SelectedIndexChanged);
            // 
            // suggestion_lbl
            // 
            this.suggestion_lbl.AutoSize = true;
            this.suggestion_lbl.Location = new System.Drawing.Point(222, 148);
            this.suggestion_lbl.Name = "suggestion_lbl";
            this.suggestion_lbl.Size = new System.Drawing.Size(13, 13);
            this.suggestion_lbl.TabIndex = 11;
            this.suggestion_lbl.Text = "_";
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Location = new System.Drawing.Point(219, 107);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(13, 13);
            this.name_lbl.TabIndex = 10;
            this.name_lbl.Text = "_";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Suggestion :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name :";
            // 
            // Admin_Suggestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.suggest_listbx);
            this.Controls.Add(this.member_listbx);
            this.Controls.Add(this.suggestion_lbl);
            this.Controls.Add(this.name_lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Admin_Suggestion";
            this.Text = "Admin_Suggestion";
            this.Load += new System.EventHandler(this.Admin_Suggestion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox suggest_listbx;
        private System.Windows.Forms.ListBox member_listbx;
        private System.Windows.Forms.Label suggestion_lbl;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}