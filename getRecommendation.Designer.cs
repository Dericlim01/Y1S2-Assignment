﻿namespace Y1S2
{
    partial class getRecommendation
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.detailTxtBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.memberListBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.recommendMembNamelbl = new System.Windows.Forms.Label();
            this.recommendMembLevellbl = new System.Windows.Forms.Label();
            this.bckBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Topic = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.competitionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.swimmingclubdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.swimmingclubdbDataSet = new Y1S2.swimmingclubdbDataSet();
            this.competitionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.competitionTableAdapter = new Y1S2.swimmingclubdbDataSetTableAdapters.CompetitionTableAdapter();
            this.competitionListBox = new System.Windows.Forms.ListBox();
            this.recommendCompIdlbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.recommendCompNamelbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.competitionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swimmingclubdbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swimmingclubdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.competitionBindingSource1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.detailTxtBox);
            this.groupBox3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(514, 108);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(274, 337);
            this.groupBox3.TabIndex = 98;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " Details";
            // 
            // detailTxtBox
            // 
            this.detailTxtBox.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.detailTxtBox.Location = new System.Drawing.Point(26, 24);
            this.detailTxtBox.Name = "detailTxtBox";
            this.detailTxtBox.Size = new System.Drawing.Size(233, 296);
            this.detailTxtBox.TabIndex = 0;
            this.detailTxtBox.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.memberListBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.recommendMembNamelbl);
            this.groupBox1.Controls.Add(this.recommendMembLevellbl);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 287);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 158);
            this.groupBox1.TabIndex = 96;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Member Info";
            // 
            // memberListBox
            // 
            this.memberListBox.BackColor = System.Drawing.Color.LightSkyBlue;
            this.memberListBox.Font = new System.Drawing.Font("Consolas", 9.25F, System.Drawing.FontStyle.Bold);
            this.memberListBox.FormattingEnabled = true;
            this.memberListBox.ItemHeight = 14;
            this.memberListBox.Location = new System.Drawing.Point(6, 35);
            this.memberListBox.Name = "memberListBox";
            this.memberListBox.Size = new System.Drawing.Size(180, 102);
            this.memberListBox.TabIndex = 55;
            this.memberListBox.SelectedIndexChanged += new System.EventHandler(this.memberListBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(188, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 84;
            this.label5.Text = "Member Level:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(187, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 83;
            this.label4.Text = "Member Name:";
            // 
            // recommendMembNamelbl
            // 
            this.recommendMembNamelbl.AutoSize = true;
            this.recommendMembNamelbl.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recommendMembNamelbl.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.recommendMembNamelbl.Location = new System.Drawing.Point(280, 53);
            this.recommendMembNamelbl.Name = "recommendMembNamelbl";
            this.recommendMembNamelbl.Size = new System.Drawing.Size(0, 15);
            this.recommendMembNamelbl.TabIndex = 77;
            // 
            // recommendMembLevellbl
            // 
            this.recommendMembLevellbl.AutoSize = true;
            this.recommendMembLevellbl.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recommendMembLevellbl.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.recommendMembLevellbl.Location = new System.Drawing.Point(292, 98);
            this.recommendMembLevellbl.Name = "recommendMembLevellbl";
            this.recommendMembLevellbl.Size = new System.Drawing.Size(0, 15);
            this.recommendMembLevellbl.TabIndex = 78;
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
            this.bckBtn.Click += new System.EventHandler(this.bckBtn_Click);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.bckBtn);
            this.panel1.Controls.Add(this.Topic);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-11, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 96);
            this.panel1.TabIndex = 95;
            // 
            // Topic
            // 
            this.Topic.AutoSize = true;
            this.Topic.Font = new System.Drawing.Font("Consolas", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Topic.Location = new System.Drawing.Point(267, 38);
            this.Topic.Name = "Topic";
            this.Topic.Size = new System.Drawing.Size(299, 32);
            this.Topic.TabIndex = 16;
            this.Topic.Text = "Send Recommendation";
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
            this.competitionListBox.Font = new System.Drawing.Font("Consolas", 9.25F, System.Drawing.FontStyle.Bold);
            this.competitionListBox.FormattingEnabled = true;
            this.competitionListBox.ItemHeight = 14;
            this.competitionListBox.Location = new System.Drawing.Point(6, 25);
            this.competitionListBox.Name = "competitionListBox";
            this.competitionListBox.Size = new System.Drawing.Size(180, 102);
            this.competitionListBox.TabIndex = 56;
            this.competitionListBox.SelectedIndexChanged += new System.EventHandler(this.competitionListBox_SelectedIndexChanged);
            // 
            // recommendCompIdlbl
            // 
            this.recommendCompIdlbl.AutoSize = true;
            this.recommendCompIdlbl.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recommendCompIdlbl.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.recommendCompIdlbl.Location = new System.Drawing.Point(306, 56);
            this.recommendCompIdlbl.Name = "recommendCompIdlbl";
            this.recommendCompIdlbl.Size = new System.Drawing.Size(0, 15);
            this.recommendCompIdlbl.TabIndex = 90;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(185, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 15);
            this.label7.TabIndex = 86;
            this.label7.Text = "Competition Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(188, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 15);
            this.label10.TabIndex = 89;
            this.label10.Text = "Competition ID:";
            // 
            // recommendCompNamelbl
            // 
            this.recommendCompNamelbl.AutoSize = true;
            this.recommendCompNamelbl.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recommendCompNamelbl.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.recommendCompNamelbl.Location = new System.Drawing.Point(316, 96);
            this.recommendCompNamelbl.Name = "recommendCompNamelbl";
            this.recommendCompNamelbl.Size = new System.Drawing.Size(0, 15);
            this.recommendCompNamelbl.TabIndex = 80;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.competitionListBox);
            this.groupBox2.Controls.Add(this.recommendCompNamelbl);
            this.groupBox2.Controls.Add(this.recommendCompIdlbl);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(10, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(498, 159);
            this.groupBox2.TabIndex = 97;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Competition Info";
            // 
            // getRecommendation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Name = "getRecommendation";
            this.Text = "getRecommendation";
            this.Load += new System.EventHandler(this.getRecommendation_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.competitionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swimmingclubdbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swimmingclubdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.competitionBindingSource1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox memberListBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label recommendMembNamelbl;
        private System.Windows.Forms.Label recommendMembLevellbl;
        private System.Windows.Forms.Button bckBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Topic;
        private System.Windows.Forms.BindingSource competitionBindingSource;
        private System.Windows.Forms.BindingSource swimmingclubdbDataSetBindingSource;
        private swimmingclubdbDataSet swimmingclubdbDataSet;
        private System.Windows.Forms.BindingSource competitionBindingSource1;
        private swimmingclubdbDataSetTableAdapters.CompetitionTableAdapter competitionTableAdapter;
        private System.Windows.Forms.ListBox competitionListBox;
        private System.Windows.Forms.Label recommendCompIdlbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label recommendCompNamelbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox detailTxtBox;
    }
}