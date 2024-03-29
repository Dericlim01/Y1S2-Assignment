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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bckBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Topic = new System.Windows.Forms.Label();
            this.competitionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.swimmingclubdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.swimmingclubdbDataSet = new Y1S2.swimmingclubdbDataSet();
            this.competitionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.competitionTableAdapter = new Y1S2.swimmingclubdbDataSetTableAdapters.CompetitionTableAdapter();
            this.memberListBox = new System.Windows.Forms.ListBox();
            this.competitionListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.assignMembNamelbl = new System.Windows.Forms.Label();
            this.assignMembLevellbl = new System.Windows.Forms.Label();
            this.assignMembAgelbl = new System.Windows.Forms.Label();
            this.assignCompVenuelbl = new System.Windows.Forms.Label();
            this.assignCompDatelbl = new System.Windows.Forms.Label();
            this.assignCompNamelbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.competitionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swimmingclubdbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swimmingclubdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.competitionBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // assignMemberbtn
            // 
            this.assignMemberbtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.assignMemberbtn.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.assignMemberbtn.FlatAppearance.BorderSize = 3;
            this.assignMemberbtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignMemberbtn.Location = new System.Drawing.Point(315, 391);
            this.assignMemberbtn.Name = "assignMemberbtn";
            this.assignMemberbtn.Size = new System.Drawing.Size(139, 47);
            this.assignMemberbtn.TabIndex = 54;
            this.assignMemberbtn.Text = "Assign";
            this.assignMemberbtn.UseVisualStyleBackColor = false;
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
            this.Topic.Location = new System.Drawing.Point(218, 45);
            this.Topic.Name = "Topic";
            this.Topic.Size = new System.Drawing.Size(404, 32);
            this.Topic.TabIndex = 16;
            this.Topic.Text = "Assign Member Competition ";
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
            // memberListBox
            // 
            this.memberListBox.FormattingEnabled = true;
            this.memberListBox.Location = new System.Drawing.Point(183, 115);
            this.memberListBox.Name = "memberListBox";
            this.memberListBox.Size = new System.Drawing.Size(124, 108);
            this.memberListBox.TabIndex = 55;
            this.memberListBox.SelectedIndexChanged += new System.EventHandler(this.memberListBox_SelectedIndexChanged);
            // 
            // competitionListBox
            // 
            this.competitionListBox.FormattingEnabled = true;
            this.competitionListBox.Location = new System.Drawing.Point(597, 115);
            this.competitionListBox.Name = "competitionListBox";
            this.competitionListBox.Size = new System.Drawing.Size(152, 108);
            this.competitionListBox.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(447, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 18);
            this.label2.TabIndex = 57;
            this.label2.Text = "Competition List:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 18);
            this.label3.TabIndex = 58;
            this.label3.Text = "Member List:";
            // 
            // assignMembNamelbl
            // 
            this.assignMembNamelbl.AutoSize = true;
            this.assignMembNamelbl.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignMembNamelbl.Location = new System.Drawing.Point(73, 275);
            this.assignMembNamelbl.Name = "assignMembNamelbl";
            this.assignMembNamelbl.Size = new System.Drawing.Size(104, 18);
            this.assignMembNamelbl.TabIndex = 59;
            this.assignMembNamelbl.Text = "Member Name:";
            // 
            // assignMembLevellbl
            // 
            this.assignMembLevellbl.AutoSize = true;
            this.assignMembLevellbl.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignMembLevellbl.Location = new System.Drawing.Point(73, 310);
            this.assignMembLevellbl.Name = "assignMembLevellbl";
            this.assignMembLevellbl.Size = new System.Drawing.Size(112, 18);
            this.assignMembLevellbl.TabIndex = 60;
            this.assignMembLevellbl.Text = "Member Level:";
            // 
            // assignMembAgelbl
            // 
            this.assignMembAgelbl.AutoSize = true;
            this.assignMembAgelbl.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignMembAgelbl.Location = new System.Drawing.Point(73, 343);
            this.assignMembAgelbl.Name = "assignMembAgelbl";
            this.assignMembAgelbl.Size = new System.Drawing.Size(96, 18);
            this.assignMembAgelbl.TabIndex = 61;
            this.assignMembAgelbl.Text = "Member Age:";
            // 
            // assignCompVenuelbl
            // 
            this.assignCompVenuelbl.AutoSize = true;
            this.assignCompVenuelbl.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignCompVenuelbl.Location = new System.Drawing.Point(447, 343);
            this.assignCompVenuelbl.Name = "assignCompVenuelbl";
            this.assignCompVenuelbl.Size = new System.Drawing.Size(152, 18);
            this.assignCompVenuelbl.TabIndex = 64;
            this.assignCompVenuelbl.Text = "Competition Venue:";
            // 
            // assignCompDatelbl
            // 
            this.assignCompDatelbl.AutoSize = true;
            this.assignCompDatelbl.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignCompDatelbl.Location = new System.Drawing.Point(447, 310);
            this.assignCompDatelbl.Name = "assignCompDatelbl";
            this.assignCompDatelbl.Size = new System.Drawing.Size(144, 18);
            this.assignCompDatelbl.TabIndex = 63;
            this.assignCompDatelbl.Text = "Competition Date:";
            // 
            // assignCompNamelbl
            // 
            this.assignCompNamelbl.AutoSize = true;
            this.assignCompNamelbl.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignCompNamelbl.Location = new System.Drawing.Point(447, 275);
            this.assignCompNamelbl.Name = "assignCompNamelbl";
            this.assignCompNamelbl.Size = new System.Drawing.Size(144, 18);
            this.assignCompNamelbl.TabIndex = 62;
            this.assignCompNamelbl.Text = "Competition Name:";
            // 
            // AssignCompetition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.assignCompVenuelbl);
            this.Controls.Add(this.assignCompDatelbl);
            this.Controls.Add(this.assignCompNamelbl);
            this.Controls.Add(this.assignMembAgelbl);
            this.Controls.Add(this.assignMembLevellbl);
            this.Controls.Add(this.assignMembNamelbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.competitionListBox);
            this.Controls.Add(this.memberListBox);
            this.Controls.Add(this.assignMemberbtn);
            this.Controls.Add(this.panel1);
            this.Name = "AssignCompetition";
            this.Text = "AssignCompetition";
            this.Load += new System.EventHandler(this.AssignCompetition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.competitionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swimmingclubdbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swimmingclubdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.competitionBindingSource1)).EndInit();
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
        private System.Windows.Forms.ListBox memberListBox;
        private System.Windows.Forms.ListBox competitionListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label assignMembNamelbl;
        private System.Windows.Forms.Label assignMembLevellbl;
        private System.Windows.Forms.Label assignMembAgelbl;
        private System.Windows.Forms.Label assignCompVenuelbl;
        private System.Windows.Forms.Label assignCompDatelbl;
        private System.Windows.Forms.Label assignCompNamelbl;
    }
}