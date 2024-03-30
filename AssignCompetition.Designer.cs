namespace Y1S2
{
    partial class AssignCompetition
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
            this.assignMemberbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bckBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Topic = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.competitionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.swimmingclubdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.swimmingclubdbDataSet = new Y1S2.swimmingclubdbDataSet();
            this.competitionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.competitionTableAdapter = new Y1S2.swimmingclubdbDataSetTableAdapters.CompetitionTableAdapter();
            this.competitionListBox = new System.Windows.Forms.ListBox();
            this.assignCompVenuelbl = new System.Windows.Forms.Label();
            this.assignCompDatelbl = new System.Windows.Forms.Label();
            this.assignCompNamelbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.assignCompIdlbl = new System.Windows.Forms.Label();
            this.memberListBox = new System.Windows.Forms.ListBox();
            this.assignMembNamelbl = new System.Windows.Forms.Label();
            this.assignMembLevellbl = new System.Windows.Forms.Label();
            this.assignMembAgelbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.competitionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swimmingclubdbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swimmingclubdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.competitionBindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // assignMemberbtn
            // 
            this.assignMemberbtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.assignMemberbtn.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.assignMemberbtn.FlatAppearance.BorderSize = 3;
            this.assignMemberbtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignMemberbtn.Location = new System.Drawing.Point(344, 406);
            this.assignMemberbtn.Name = "assignMemberbtn";
            this.assignMemberbtn.Size = new System.Drawing.Size(107, 42);
            this.assignMemberbtn.TabIndex = 54;
            this.assignMemberbtn.Text = "Assign";
            this.assignMemberbtn.UseVisualStyleBackColor = false;
            this.assignMemberbtn.Click += new System.EventHandler(this.assignMemberbtn_Click);
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
            // bckBtn
            // 
            this.bckBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bckBtn.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold);
            this.bckBtn.Location = new System.Drawing.Point(678, 40);
            this.bckBtn.Name = "bckBtn";
            this.bckBtn.Size = new System.Drawing.Size(89, 37);
            this.bckBtn.TabIndex = 23;
            this.bckBtn.Text = "Back";
            this.bckBtn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.bckBtn);
            this.panel1.Controls.Add(this.Topic);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-8, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 93);
            this.panel1.TabIndex = 41;
            // 
            // Topic
            // 
            this.Topic.AutoSize = true;
            this.Topic.Font = new System.Drawing.Font("Consolas", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Topic.Location = new System.Drawing.Point(211, 28);
            this.Topic.Name = "Topic";
            this.Topic.Size = new System.Drawing.Size(404, 32);
            this.Topic.TabIndex = 16;
            this.Topic.Text = "Assign Member Competition ";
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
            // competitionBindingSource
            // 
            this.competitionBindingSource.DataMember = "Competition";
            this.competitionBindingSource.DataSource = this.swimmingclubdbDataSetBindingSource;
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
            // competitionBindingSource1
            // 
            this.competitionBindingSource1.DataMember = "Competition";
            this.competitionBindingSource1.DataSource = this.swimmingclubdbDataSetBindingSource;
            // 
            // competitionTableAdapter
            // 
            this.competitionTableAdapter.ClearBeforeFill = true;
            // 
            // competitionListBox
            // 
            this.competitionListBox.BackColor = System.Drawing.Color.LightSkyBlue;
            this.competitionListBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.competitionListBox.FormattingEnabled = true;
            this.competitionListBox.ItemHeight = 18;
            this.competitionListBox.Location = new System.Drawing.Point(71, 34);
            this.competitionListBox.Name = "competitionListBox";
            this.competitionListBox.Size = new System.Drawing.Size(189, 112);
            this.competitionListBox.TabIndex = 56;
            this.competitionListBox.SelectedIndexChanged += new System.EventHandler(this.competitionListBox_SelectedIndexChanged);
            // 
            // assignCompVenuelbl
            // 
            this.assignCompVenuelbl.AutoSize = true;
            this.assignCompVenuelbl.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignCompVenuelbl.Location = new System.Drawing.Point(662, 377);
            this.assignCompVenuelbl.Name = "assignCompVenuelbl";
            this.assignCompVenuelbl.Size = new System.Drawing.Size(0, 18);
            this.assignCompVenuelbl.TabIndex = 64;
            // 
            // assignCompDatelbl
            // 
            this.assignCompDatelbl.AutoSize = true;
            this.assignCompDatelbl.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignCompDatelbl.Location = new System.Drawing.Point(649, 344);
            this.assignCompDatelbl.Name = "assignCompDatelbl";
            this.assignCompDatelbl.Size = new System.Drawing.Size(0, 18);
            this.assignCompDatelbl.TabIndex = 63;
            // 
            // assignCompNamelbl
            // 
            this.assignCompNamelbl.AutoSize = true;
            this.assignCompNamelbl.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignCompNamelbl.Location = new System.Drawing.Point(649, 309);
            this.assignCompNamelbl.Name = "assignCompNamelbl";
            this.assignCompNamelbl.Size = new System.Drawing.Size(0, 18);
            this.assignCompNamelbl.TabIndex = 62;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(502, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 18);
            this.label7.TabIndex = 68;
            this.label7.Text = "Competition Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(502, 344);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 18);
            this.label8.TabIndex = 69;
            this.label8.Text = "Competition Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(502, 377);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 18);
            this.label9.TabIndex = 70;
            this.label9.Text = "Competition Venue:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(502, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 18);
            this.label10.TabIndex = 71;
            this.label10.Text = "Competition ID:";
            // 
            // assignCompIdlbl
            // 
            this.assignCompIdlbl.AutoSize = true;
            this.assignCompIdlbl.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignCompIdlbl.Location = new System.Drawing.Point(636, 276);
            this.assignCompIdlbl.Name = "assignCompIdlbl";
            this.assignCompIdlbl.Size = new System.Drawing.Size(0, 18);
            this.assignCompIdlbl.TabIndex = 72;
            // 
            // memberListBox
            // 
            this.memberListBox.BackColor = System.Drawing.Color.LightSkyBlue;
            this.memberListBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberListBox.FormattingEnabled = true;
            this.memberListBox.ItemHeight = 18;
            this.memberListBox.Location = new System.Drawing.Point(50, 34);
            this.memberListBox.Name = "memberListBox";
            this.memberListBox.Size = new System.Drawing.Size(175, 112);
            this.memberListBox.TabIndex = 55;
            this.memberListBox.SelectedIndexChanged += new System.EventHandler(this.memberListBox_SelectedIndexChanged);
            // 
            // assignMembNamelbl
            // 
            this.assignMembNamelbl.AutoSize = true;
            this.assignMembNamelbl.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignMembNamelbl.Location = new System.Drawing.Point(203, 290);
            this.assignMembNamelbl.Name = "assignMembNamelbl";
            this.assignMembNamelbl.Size = new System.Drawing.Size(0, 18);
            this.assignMembNamelbl.TabIndex = 59;
            // 
            // assignMembLevellbl
            // 
            this.assignMembLevellbl.AutoSize = true;
            this.assignMembLevellbl.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignMembLevellbl.Location = new System.Drawing.Point(214, 325);
            this.assignMembLevellbl.Name = "assignMembLevellbl";
            this.assignMembLevellbl.Size = new System.Drawing.Size(0, 18);
            this.assignMembLevellbl.TabIndex = 60;
            // 
            // assignMembAgelbl
            // 
            this.assignMembAgelbl.AutoSize = true;
            this.assignMembAgelbl.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignMembAgelbl.Location = new System.Drawing.Point(198, 358);
            this.assignMembAgelbl.Name = "assignMembAgelbl";
            this.assignMembAgelbl.Size = new System.Drawing.Size(0, 18);
            this.assignMembAgelbl.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 18);
            this.label4.TabIndex = 65;
            this.label4.Text = "Member Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(72, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 18);
            this.label5.TabIndex = 66;
            this.label5.Text = "Member Level:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(72, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 18);
            this.label6.TabIndex = 67;
            this.label6.Text = "Member Age:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.memberListBox);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(35, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 299);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Member Info";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.competitionListBox);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(466, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 299);
            this.groupBox2.TabIndex = 74;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Competition Info";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // AssignCompetition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.assignCompIdlbl);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.assignCompVenuelbl);
            this.Controls.Add(this.assignCompDatelbl);
            this.Controls.Add(this.assignCompNamelbl);
            this.Controls.Add(this.assignMembAgelbl);
            this.Controls.Add(this.assignMembLevellbl);
            this.Controls.Add(this.assignMembNamelbl);
            this.Controls.Add(this.assignMemberbtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "AssignCompetition";
            this.Text = "AssignCompetition";
            this.Load += new System.EventHandler(this.AssignCompetition_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.competitionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swimmingclubdbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swimmingclubdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.competitionBindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button assignMemberbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bckBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Topic;
        private System.Windows.Forms.BindingSource competitionBindingSource;
        private System.Windows.Forms.BindingSource swimmingclubdbDataSetBindingSource;
        private swimmingclubdbDataSet swimmingclubdbDataSet;
        private System.Windows.Forms.BindingSource competitionBindingSource1;
        private swimmingclubdbDataSetTableAdapters.CompetitionTableAdapter competitionTableAdapter;
        private System.Windows.Forms.ListBox competitionListBox;
        private System.Windows.Forms.Label assignCompVenuelbl;
        private System.Windows.Forms.Label assignCompDatelbl;
        private System.Windows.Forms.Label assignCompNamelbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label assignCompIdlbl;
        private System.Windows.Forms.ListBox memberListBox;
        private System.Windows.Forms.Label assignMembNamelbl;
        private System.Windows.Forms.Label assignMembLevellbl;
        private System.Windows.Forms.Label assignMembAgelbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}