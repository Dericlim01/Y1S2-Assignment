namespace Y1S2
{
    partial class Edit_Competition
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
            this.components = new System.ComponentModel.Container();
            this.editCompbtn = new System.Windows.Forms.Button();
            this.editCompDetailTB = new System.Windows.Forms.TextBox();
            this.editCompNameTB = new System.Windows.Forms.TextBox();
            this.competitionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.swimmingclubdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.swimmingclubdbDataSet = new Y1S2.swimmingclubdbDataSet();
            this.editCompVenueTB = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Topic = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lbltype = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.competitionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.competitionTableAdapter = new Y1S2.swimmingclubdbDataSetTableAdapters.CompetitionTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.editCompIdLbl = new System.Windows.Forms.Label();
            this.editCompDate1 = new System.Windows.Forms.DateTimePicker();
            this.editDueDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.competitionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swimmingclubdbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swimmingclubdbDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.competitionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // editCompbtn
            // 
            this.editCompbtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.editCompbtn.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.editCompbtn.FlatAppearance.BorderSize = 3;
            this.editCompbtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editCompbtn.Location = new System.Drawing.Point(318, 366);
            this.editCompbtn.Name = "editCompbtn";
            this.editCompbtn.Size = new System.Drawing.Size(184, 58);
            this.editCompbtn.TabIndex = 54;
            this.editCompbtn.Text = "Edit";
            this.editCompbtn.UseVisualStyleBackColor = false;
            this.editCompbtn.Click += new System.EventHandler(this.editCompbtn_Click);
            // 
            // editCompDetailTB
            // 
            this.editCompDetailTB.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editCompDetailTB.Location = new System.Drawing.Point(102, 309);
            this.editCompDetailTB.Name = "editCompDetailTB";
            this.editCompDetailTB.Size = new System.Drawing.Size(686, 25);
            this.editCompDetailTB.TabIndex = 51;
            // 
            // editCompNameTB
            // 
            this.editCompNameTB.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editCompNameTB.Location = new System.Drawing.Point(174, 186);
            this.editCompNameTB.Name = "editCompNameTB";
            this.editCompNameTB.Size = new System.Drawing.Size(195, 25);
            this.editCompNameTB.TabIndex = 49;
            // 
            // competitionBindingSource1
            // 
            this.competitionBindingSource1.DataMember = "Competition";
            this.competitionBindingSource1.DataSource = this.swimmingclubdbDataSetBindingSource;
            // 
            // swimmingclubdbDataSetBindingSource
            // 
            this.swimmingclubdbDataSetBindingSource.DataSource = this.swimmingclubdbDataSet;
            this.swimmingclubdbDataSetBindingSource.Position = 0;
            // 
            // swimmingclubdbDataSet
            // 
            this.swimmingclubdbDataSet.DataSetName = "swimmingclubdbDataSet";
            this.swimmingclubdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // editCompVenueTB
            // 
            this.editCompVenueTB.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editCompVenueTB.Location = new System.Drawing.Point(579, 243);
            this.editCompVenueTB.Name = "editCompVenueTB";
            this.editCompVenueTB.Size = new System.Drawing.Size(200, 25);
            this.editCompVenueTB.TabIndex = 46;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Topic);
            this.panel1.Controls.Add(this.lblname);
            this.panel1.Controls.Add(this.lbltype);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-8, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 109);
            this.panel1.TabIndex = 41;
            // 
            // Topic
            // 
            this.Topic.AutoSize = true;
            this.Topic.Font = new System.Drawing.Font("Consolas", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Topic.Location = new System.Drawing.Point(249, 40);
            this.Topic.Name = "Topic";
            this.Topic.Size = new System.Drawing.Size(329, 32);
            this.Topic.TabIndex = 16;
            this.Topic.Text = "Edit Competition Page";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.lblname.Location = new System.Drawing.Point(619, 23);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(48, 18);
            this.lblname.TabIndex = 15;
            this.lblname.Text = "Name:";
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.lbltype.Location = new System.Drawing.Point(619, 54);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(48, 18);
            this.lbltype.TabIndex = 13;
            this.lbltype.Text = "Type:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Y1S2.Properties.Resources.logo_2;
            this.pictureBox1.Location = new System.Drawing.Point(21, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Location = new System.Drawing.Point(-48, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 88);
            this.label1.TabIndex = 10;
            this.label1.Text = "The Wave";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // competitionBindingSource
            // 
            this.competitionBindingSource.DataMember = "Competition";
            this.competitionBindingSource.DataSource = this.swimmingclubdbDataSetBindingSource;
            // 
            // competitionTableAdapter
            // 
            this.competitionTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(314, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 63;
            this.label2.Text = "Competition ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(510, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 64;
            this.label3.Text = "Venue:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(1, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 20);
            this.label4.TabIndex = 65;
            this.label4.Text = "Competition Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(375, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 20);
            this.label5.TabIndex = 66;
            this.label5.Text = "Competition Due Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(1, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 20);
            this.label6.TabIndex = 67;
            this.label6.Text = "Competition Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 12.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(15, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 68;
            this.label7.Text = "Details:";
            // 
            // editCompIdLbl
            // 
            this.editCompIdLbl.AutoSize = true;
            this.editCompIdLbl.Font = new System.Drawing.Font("Consolas", 12.25F, System.Drawing.FontStyle.Bold);
            this.editCompIdLbl.Location = new System.Drawing.Point(458, 138);
            this.editCompIdLbl.Name = "editCompIdLbl";
            this.editCompIdLbl.Size = new System.Drawing.Size(0, 20);
            this.editCompIdLbl.TabIndex = 69;
            // 
            // editCompDate1
            // 
            this.editCompDate1.Location = new System.Drawing.Point(169, 247);
            this.editCompDate1.Name = "editCompDate1";
            this.editCompDate1.Size = new System.Drawing.Size(200, 20);
            this.editCompDate1.TabIndex = 70;
            // 
            // editDueDate
            // 
            this.editDueDate.Location = new System.Drawing.Point(579, 188);
            this.editDueDate.Name = "editDueDate";
            this.editDueDate.Size = new System.Drawing.Size(200, 20);
            this.editDueDate.TabIndex = 71;
            // 
            // Edit_Competition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editDueDate);
            this.Controls.Add(this.editCompDate1);
            this.Controls.Add(this.editCompIdLbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.editCompbtn);
            this.Controls.Add(this.editCompDetailTB);
            this.Controls.Add(this.editCompNameTB);
            this.Controls.Add(this.editCompVenueTB);
            this.Controls.Add(this.panel1);
            this.Name = "Edit_Competition";
            this.Text = "Edit_Competition";
            this.Load += new System.EventHandler(this.Edit_Competition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.competitionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swimmingclubdbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swimmingclubdbDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.competitionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editCompbtn;
        private System.Windows.Forms.TextBox editCompDetailTB;
        private System.Windows.Forms.TextBox editCompNameTB;
        private System.Windows.Forms.BindingSource competitionBindingSource1;
        private System.Windows.Forms.BindingSource swimmingclubdbDataSetBindingSource;
        private swimmingclubdbDataSet swimmingclubdbDataSet;
        private System.Windows.Forms.TextBox editCompVenueTB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Topic;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource competitionBindingSource;
        private swimmingclubdbDataSetTableAdapters.CompetitionTableAdapter competitionTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label editCompIdLbl;
        private System.Windows.Forms.DateTimePicker editCompDate1;
        private System.Windows.Forms.DateTimePicker editDueDate;
    }
}