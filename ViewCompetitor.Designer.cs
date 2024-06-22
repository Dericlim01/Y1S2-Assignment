namespace Y1S2
{
    partial class ViewCompetitor
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
            this.competitionTableAdapter = new Y1S2.swimmingclubdbDataSetTableAdapters.CompetitionTableAdapter();
            this.competitionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.swimmingclubdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.swimmingclubdbDataSet = new Y1S2.swimmingclubdbDataSet();
            this.competitionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Topic = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bckBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.assignCompIdlbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.assignCompVenuelbl = new System.Windows.Forms.Label();
            this.assignCompDatelbl = new System.Windows.Forms.Label();
            this.assignCompNamelbl = new System.Windows.Forms.Label();
            this.competitionListBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.viewCompVenuelbl = new System.Windows.Forms.Label();
            this.viewCompDatelbl = new System.Windows.Forms.Label();
            this.viewComNamelbl = new System.Windows.Forms.Label();
            this.viewCompIdlbl = new System.Windows.Forms.Label();
            this.assignMembAgelbl = new System.Windows.Forms.Label();
            this.assignMembLevellbl = new System.Windows.Forms.Label();
            this.assignMembNamelbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.viewCompMemberRank = new System.Windows.Forms.Label();
            this.viewCompMemberName = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.compMemberListBox = new System.Windows.Forms.ListBox();
            this.viewCompMemberAge = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.competitionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swimmingclubdbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swimmingclubdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.competitionBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // competitionTableAdapter
            // 
            this.competitionTableAdapter.ClearBeforeFill = true;
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
            // competitionBindingSource
            // 
            this.competitionBindingSource.DataMember = "Competition";
            this.competitionBindingSource.DataSource = this.swimmingclubdbDataSetBindingSource;
            // 
            // Topic
            // 
            this.Topic.AutoSize = true;
            this.Topic.Font = new System.Drawing.Font("Consolas", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Topic.Location = new System.Drawing.Point(317, 45);
            this.Topic.Name = "Topic";
            this.Topic.Size = new System.Drawing.Size(254, 32);
            this.Topic.TabIndex = 16;
            this.Topic.Text = "View Competitor ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.bckBtn);
            this.panel1.Controls.Add(this.Topic);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-11, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 93);
            this.panel1.TabIndex = 73;
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
            // assignCompIdlbl
            // 
            this.assignCompIdlbl.AutoSize = true;
            this.assignCompIdlbl.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignCompIdlbl.Location = new System.Drawing.Point(178, 250);
            this.assignCompIdlbl.Name = "assignCompIdlbl";
            this.assignCompIdlbl.Size = new System.Drawing.Size(0, 18);
            this.assignCompIdlbl.TabIndex = 84;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(26, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 18);
            this.label10.TabIndex = 83;
            this.label10.Text = "Competition ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 18);
            this.label9.TabIndex = 82;
            this.label9.Text = "Competition Venue:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 18);
            this.label8.TabIndex = 81;
            this.label8.Text = "Competition Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 18);
            this.label7.TabIndex = 80;
            this.label7.Text = "Competition Name:";
            // 
            // assignCompVenuelbl
            // 
            this.assignCompVenuelbl.AutoSize = true;
            this.assignCompVenuelbl.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignCompVenuelbl.Location = new System.Drawing.Point(204, 351);
            this.assignCompVenuelbl.Name = "assignCompVenuelbl";
            this.assignCompVenuelbl.Size = new System.Drawing.Size(0, 18);
            this.assignCompVenuelbl.TabIndex = 79;
            // 
            // assignCompDatelbl
            // 
            this.assignCompDatelbl.AutoSize = true;
            this.assignCompDatelbl.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignCompDatelbl.Location = new System.Drawing.Point(191, 318);
            this.assignCompDatelbl.Name = "assignCompDatelbl";
            this.assignCompDatelbl.Size = new System.Drawing.Size(0, 18);
            this.assignCompDatelbl.TabIndex = 78;
            // 
            // assignCompNamelbl
            // 
            this.assignCompNamelbl.AutoSize = true;
            this.assignCompNamelbl.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignCompNamelbl.Location = new System.Drawing.Point(191, 283);
            this.assignCompNamelbl.Name = "assignCompNamelbl";
            this.assignCompNamelbl.Size = new System.Drawing.Size(0, 18);
            this.assignCompNamelbl.TabIndex = 77;
            // 
            // competitionListBox
            // 
            this.competitionListBox.BackColor = System.Drawing.Color.LightSkyBlue;
            this.competitionListBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.competitionListBox.FormattingEnabled = true;
            this.competitionListBox.ItemHeight = 18;
            this.competitionListBox.Location = new System.Drawing.Point(50, 34);
            this.competitionListBox.Name = "competitionListBox";
            this.competitionListBox.Size = new System.Drawing.Size(225, 94);
            this.competitionListBox.TabIndex = 75;
            this.competitionListBox.SelectedIndexChanged += new System.EventHandler(this.competitionListBox_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.viewCompVenuelbl);
            this.groupBox2.Controls.Add(this.viewCompDatelbl);
            this.groupBox2.Controls.Add(this.viewComNamelbl);
            this.groupBox2.Controls.Add(this.viewCompIdlbl);
            this.groupBox2.Controls.Add(this.competitionListBox);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(18, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 284);
            this.groupBox2.TabIndex = 85;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Competition Info";
            // 
            // viewCompVenuelbl
            // 
            this.viewCompVenuelbl.AutoSize = true;
            this.viewCompVenuelbl.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCompVenuelbl.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.viewCompVenuelbl.Location = new System.Drawing.Point(180, 245);
            this.viewCompVenuelbl.Name = "viewCompVenuelbl";
            this.viewCompVenuelbl.Size = new System.Drawing.Size(0, 18);
            this.viewCompVenuelbl.TabIndex = 79;
            // 
            // viewCompDatelbl
            // 
            this.viewCompDatelbl.AutoSize = true;
            this.viewCompDatelbl.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCompDatelbl.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.viewCompDatelbl.Location = new System.Drawing.Point(171, 212);
            this.viewCompDatelbl.Name = "viewCompDatelbl";
            this.viewCompDatelbl.Size = new System.Drawing.Size(0, 18);
            this.viewCompDatelbl.TabIndex = 78;
            // 
            // viewComNamelbl
            // 
            this.viewComNamelbl.AutoSize = true;
            this.viewComNamelbl.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewComNamelbl.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.viewComNamelbl.Location = new System.Drawing.Point(171, 177);
            this.viewComNamelbl.Name = "viewComNamelbl";
            this.viewComNamelbl.Size = new System.Drawing.Size(0, 18);
            this.viewComNamelbl.TabIndex = 77;
            // 
            // viewCompIdlbl
            // 
            this.viewCompIdlbl.AutoSize = true;
            this.viewCompIdlbl.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCompIdlbl.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.viewCompIdlbl.Location = new System.Drawing.Point(156, 144);
            this.viewCompIdlbl.Name = "viewCompIdlbl";
            this.viewCompIdlbl.Size = new System.Drawing.Size(0, 18);
            this.viewCompIdlbl.TabIndex = 76;
            // 
            // assignMembAgelbl
            // 
            this.assignMembAgelbl.AutoSize = true;
            this.assignMembAgelbl.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignMembAgelbl.Location = new System.Drawing.Point(657, 360);
            this.assignMembAgelbl.Name = "assignMembAgelbl";
            this.assignMembAgelbl.Size = new System.Drawing.Size(0, 18);
            this.assignMembAgelbl.TabIndex = 88;
            // 
            // assignMembLevellbl
            // 
            this.assignMembLevellbl.AutoSize = true;
            this.assignMembLevellbl.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignMembLevellbl.Location = new System.Drawing.Point(673, 327);
            this.assignMembLevellbl.Name = "assignMembLevellbl";
            this.assignMembLevellbl.Size = new System.Drawing.Size(0, 18);
            this.assignMembLevellbl.TabIndex = 87;
            // 
            // assignMembNamelbl
            // 
            this.assignMembNamelbl.AutoSize = true;
            this.assignMembNamelbl.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignMembNamelbl.Location = new System.Drawing.Point(662, 292);
            this.assignMembNamelbl.Name = "assignMembNamelbl";
            this.assignMembNamelbl.Size = new System.Drawing.Size(0, 18);
            this.assignMembNamelbl.TabIndex = 86;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.viewCompMemberRank);
            this.groupBox1.Controls.Add(this.viewCompMemberAge);
            this.groupBox1.Controls.Add(this.viewCompMemberName);
            this.groupBox1.Controls.Add(this.label45);
            this.groupBox1.Controls.Add(this.label35);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.compMemberListBox);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(422, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 284);
            this.groupBox1.TabIndex = 92;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Member Info";
            // 
            // viewCompMemberRank
            // 
            this.viewCompMemberRank.AutoSize = true;
            this.viewCompMemberRank.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCompMemberRank.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.viewCompMemberRank.Location = new System.Drawing.Point(112, 245);
            this.viewCompMemberRank.Name = "viewCompMemberRank";
            this.viewCompMemberRank.Size = new System.Drawing.Size(0, 18);
            this.viewCompMemberRank.TabIndex = 99;
            // 
            // viewCompMemberName
            // 
            this.viewCompMemberName.AutoSize = true;
            this.viewCompMemberName.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCompMemberName.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.viewCompMemberName.Location = new System.Drawing.Point(144, 144);
            this.viewCompMemberName.Name = "viewCompMemberName";
            this.viewCompMemberName.Size = new System.Drawing.Size(0, 18);
            this.viewCompMemberName.TabIndex = 96;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(34, 144);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(104, 18);
            this.label45.TabIndex = 95;
            this.label45.Text = "Member Name:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(32, 195);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(112, 18);
            this.label35.TabIndex = 93;
            this.label35.Text = "Member Level:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(34, 245);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 18);
            this.label15.TabIndex = 94;
            this.label15.Text = "Ranking:";
            // 
            // compMemberListBox
            // 
            this.compMemberListBox.BackColor = System.Drawing.Color.LightSkyBlue;
            this.compMemberListBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compMemberListBox.FormattingEnabled = true;
            this.compMemberListBox.ItemHeight = 18;
            this.compMemberListBox.Location = new System.Drawing.Point(34, 34);
            this.compMemberListBox.Name = "compMemberListBox";
            this.compMemberListBox.Size = new System.Drawing.Size(217, 94);
            this.compMemberListBox.TabIndex = 55;
            this.compMemberListBox.SelectedIndexChanged += new System.EventHandler(this.compMemberListBox_SelectedIndexChanged);
            // 
            // viewCompMemberAge
            // 
            this.viewCompMemberAge.AutoSize = true;
            this.viewCompMemberAge.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCompMemberAge.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.viewCompMemberAge.Location = new System.Drawing.Point(164, 191);
            this.viewCompMemberAge.Name = "viewCompMemberAge";
            this.viewCompMemberAge.Size = new System.Drawing.Size(0, 18);
            this.viewCompMemberAge.TabIndex = 98;
            // 
            // ViewCompetitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.assignMembAgelbl);
            this.Controls.Add(this.assignMembLevellbl);
            this.Controls.Add(this.assignMembNamelbl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.assignCompIdlbl);
            this.Controls.Add(this.assignCompVenuelbl);
            this.Controls.Add(this.assignCompDatelbl);
            this.Controls.Add(this.assignCompNamelbl);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Name = "ViewCompetitor";
            this.Text = "ViewCompetitor";
            this.Load += new System.EventHandler(this.RecordResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.competitionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swimmingclubdbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swimmingclubdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.competitionBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private swimmingclubdbDataSetTableAdapters.CompetitionTableAdapter competitionTableAdapter;
        private System.Windows.Forms.BindingSource competitionBindingSource1;
        private System.Windows.Forms.BindingSource swimmingclubdbDataSetBindingSource;
        private swimmingclubdbDataSet swimmingclubdbDataSet;
        private System.Windows.Forms.BindingSource competitionBindingSource;
        private System.Windows.Forms.Label Topic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bckBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label assignCompIdlbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label assignCompVenuelbl;
        private System.Windows.Forms.Label assignCompDatelbl;
        private System.Windows.Forms.Label assignCompNamelbl;
        private System.Windows.Forms.ListBox competitionListBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label assignMembAgelbl;
        private System.Windows.Forms.Label assignMembLevellbl;
        private System.Windows.Forms.Label assignMembNamelbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox compMemberListBox;
        private System.Windows.Forms.Label viewCompVenuelbl;
        private System.Windows.Forms.Label viewCompDatelbl;
        private System.Windows.Forms.Label viewComNamelbl;
        private System.Windows.Forms.Label viewCompIdlbl;
        private System.Windows.Forms.Label viewCompMemberRank;
        private System.Windows.Forms.Label viewCompMemberName;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label viewCompMemberAge;
    }
}