namespace Y1S2
{
    partial class ViewCompetition
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
            this.lblCompDetails = new System.Windows.Forms.Label();
            this.lblCompVenue = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.lblCompDate = new System.Windows.Forms.Label();
            this.lblCompName = new System.Windows.Forms.Label();
            this.lblCompId = new System.Windows.Forms.Label();
            this.competitionTableAdapter = new Y1S2.swimmingclubdbDataSetTableAdapters.CompetitionTableAdapter();
            this.swimmingclubdbDataSet = new Y1S2.swimmingclubdbDataSet();
            this.swimmingclubdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.competitionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.competitionView = new System.Windows.Forms.DataGridView();
            this.competitionidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.competitionnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duedateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.competitiondateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.competitionBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.swimmingclubdbDataSet1 = new Y1S2.swimmingclubdbDataSet1();
            this.bckBtn = new System.Windows.Forms.Button();
            this.Topic = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.competitionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.competitionBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.competitionBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.competitionTableAdapter1 = new Y1S2.swimmingclubdbDataSet1TableAdapters.CompetitionTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.swimmingclubdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swimmingclubdbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.competitionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.competitionView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.competitionBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swimmingclubdbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.competitionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.competitionBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.competitionBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCompDetails
            // 
            this.lblCompDetails.AutoSize = true;
            this.lblCompDetails.Font = new System.Drawing.Font("Consolas", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblCompDetails.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblCompDetails.Location = new System.Drawing.Point(106, 357);
            this.lblCompDetails.Name = "lblCompDetails";
            this.lblCompDetails.Size = new System.Drawing.Size(0, 20);
            this.lblCompDetails.TabIndex = 31;
            // 
            // lblCompVenue
            // 
            this.lblCompVenue.AutoSize = true;
            this.lblCompVenue.Font = new System.Drawing.Font("Consolas", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblCompVenue.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblCompVenue.Location = new System.Drawing.Point(94, 317);
            this.lblCompVenue.Name = "lblCompVenue";
            this.lblCompVenue.Size = new System.Drawing.Size(0, 20);
            this.lblCompVenue.TabIndex = 30;
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Consolas", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblDueDate.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblDueDate.Location = new System.Drawing.Point(114, 279);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(0, 20);
            this.lblDueDate.TabIndex = 29;
            // 
            // lblCompDate
            // 
            this.lblCompDate.AutoSize = true;
            this.lblCompDate.Font = new System.Drawing.Font("Consolas", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblCompDate.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblCompDate.Location = new System.Drawing.Point(193, 238);
            this.lblCompDate.Name = "lblCompDate";
            this.lblCompDate.Size = new System.Drawing.Size(0, 20);
            this.lblCompDate.TabIndex = 28;
            // 
            // lblCompName
            // 
            this.lblCompName.AutoSize = true;
            this.lblCompName.Font = new System.Drawing.Font("Consolas", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblCompName.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblCompName.Location = new System.Drawing.Point(187, 198);
            this.lblCompName.Name = "lblCompName";
            this.lblCompName.Size = new System.Drawing.Size(0, 20);
            this.lblCompName.TabIndex = 27;
            // 
            // lblCompId
            // 
            this.lblCompId.AutoSize = true;
            this.lblCompId.Font = new System.Drawing.Font("Consolas", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblCompId.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblCompId.Location = new System.Drawing.Point(175, 161);
            this.lblCompId.Name = "lblCompId";
            this.lblCompId.Size = new System.Drawing.Size(0, 20);
            this.lblCompId.TabIndex = 26;
            // 
            // competitionTableAdapter
            // 
            this.competitionTableAdapter.ClearBeforeFill = true;
            // 
            // swimmingclubdbDataSet
            // 
            this.swimmingclubdbDataSet.DataSetName = "swimmingclubdbDataSet";
            this.swimmingclubdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // swimmingclubdbDataSetBindingSource
            // 
            this.swimmingclubdbDataSetBindingSource.DataSource = this.swimmingclubdbDataSet;
            this.swimmingclubdbDataSetBindingSource.Position = 0;
            // 
            // competitionBindingSource
            // 
            this.competitionBindingSource.DataMember = "Competition";
            this.competitionBindingSource.DataSource = this.swimmingclubdbDataSetBindingSource;
            // 
            // competitionView
            // 
            this.competitionView.AutoGenerateColumns = false;
            this.competitionView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.competitionView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.competitionidDataGridViewTextBoxColumn,
            this.competitionnameDataGridViewTextBoxColumn,
            this.duedateDataGridViewTextBoxColumn,
            this.competitiondateDataGridViewTextBoxColumn,
            this.venueDataGridViewTextBoxColumn,
            this.detailsDataGridViewTextBoxColumn});
            this.competitionView.DataSource = this.competitionBindingSource4;
            this.competitionView.Location = new System.Drawing.Point(423, 130);
            this.competitionView.Name = "competitionView";
            this.competitionView.Size = new System.Drawing.Size(338, 290);
            this.competitionView.TabIndex = 23;
            this.competitionView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.competitionView_CellClick);
            this.competitionView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.competitionView_CellContentClick);
            // 
            // competitionidDataGridViewTextBoxColumn
            // 
            this.competitionidDataGridViewTextBoxColumn.DataPropertyName = "competition_id";
            this.competitionidDataGridViewTextBoxColumn.HeaderText = "competition_id";
            this.competitionidDataGridViewTextBoxColumn.Name = "competitionidDataGridViewTextBoxColumn";
            // 
            // competitionnameDataGridViewTextBoxColumn
            // 
            this.competitionnameDataGridViewTextBoxColumn.DataPropertyName = "competition_name";
            this.competitionnameDataGridViewTextBoxColumn.HeaderText = "competition_name";
            this.competitionnameDataGridViewTextBoxColumn.Name = "competitionnameDataGridViewTextBoxColumn";
            // 
            // duedateDataGridViewTextBoxColumn
            // 
            this.duedateDataGridViewTextBoxColumn.DataPropertyName = "due_date";
            this.duedateDataGridViewTextBoxColumn.HeaderText = "due_date";
            this.duedateDataGridViewTextBoxColumn.Name = "duedateDataGridViewTextBoxColumn";
            // 
            // competitiondateDataGridViewTextBoxColumn
            // 
            this.competitiondateDataGridViewTextBoxColumn.DataPropertyName = "competition_date";
            this.competitiondateDataGridViewTextBoxColumn.HeaderText = "competition_date";
            this.competitiondateDataGridViewTextBoxColumn.Name = "competitiondateDataGridViewTextBoxColumn";
            // 
            // venueDataGridViewTextBoxColumn
            // 
            this.venueDataGridViewTextBoxColumn.DataPropertyName = "venue";
            this.venueDataGridViewTextBoxColumn.HeaderText = "venue";
            this.venueDataGridViewTextBoxColumn.Name = "venueDataGridViewTextBoxColumn";
            // 
            // detailsDataGridViewTextBoxColumn
            // 
            this.detailsDataGridViewTextBoxColumn.DataPropertyName = "details";
            this.detailsDataGridViewTextBoxColumn.HeaderText = "details";
            this.detailsDataGridViewTextBoxColumn.Name = "detailsDataGridViewTextBoxColumn";
            // 
            // competitionBindingSource4
            // 
            this.competitionBindingSource4.DataMember = "Competition";
            this.competitionBindingSource4.DataSource = this.swimmingclubdbDataSet1;
            // 
            // swimmingclubdbDataSet1
            // 
            this.swimmingclubdbDataSet1.DataSetName = "swimmingclubdbDataSet1";
            this.swimmingclubdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bckBtn
            // 
            this.bckBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bckBtn.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold);
            this.bckBtn.Location = new System.Drawing.Point(682, 30);
            this.bckBtn.Name = "bckBtn";
            this.bckBtn.Size = new System.Drawing.Size(89, 37);
            this.bckBtn.TabIndex = 22;
            this.bckBtn.Text = "Back";
            this.bckBtn.UseVisualStyleBackColor = false;
            // 
            // Topic
            // 
            this.Topic.AutoSize = true;
            this.Topic.Font = new System.Drawing.Font("Consolas", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Topic.Location = new System.Drawing.Point(263, 28);
            this.Topic.Name = "Topic";
            this.Topic.Size = new System.Drawing.Size(254, 32);
            this.Topic.TabIndex = 16;
            this.Topic.Text = "Competition Page";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.bckBtn);
            this.panel1.Controls.Add(this.Topic);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-10, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 90);
            this.panel1.TabIndex = 22;
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
            // competitionBindingSource1
            // 
            this.competitionBindingSource1.DataMember = "Competition";
            this.competitionBindingSource1.DataSource = this.swimmingclubdbDataSetBindingSource;
            // 
            // competitionBindingSource2
            // 
            this.competitionBindingSource2.DataMember = "Competition";
            this.competitionBindingSource2.DataSource = this.swimmingclubdbDataSetBindingSource;
            // 
            // competitionBindingSource3
            // 
            this.competitionBindingSource3.DataMember = "Competition";
            this.competitionBindingSource3.DataSource = this.swimmingclubdbDataSet;
            // 
            // competitionTableAdapter1
            // 
            this.competitionTableAdapter1.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 37;
            this.label2.Text = "Details:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 36;
            this.label3.Text = "Venue:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 35;
            this.label4.Text = "Due Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 19);
            this.label5.TabIndex = 34;
            this.label5.Text = "Competition Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 19);
            this.label6.TabIndex = 33;
            this.label6.Text = "Competition Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 19);
            this.label7.TabIndex = 32;
            this.label7.Text = "Competition ID:";
            // 
            // ViewCompetition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblCompDetails);
            this.Controls.Add(this.lblCompVenue);
            this.Controls.Add(this.lblDueDate);
            this.Controls.Add(this.lblCompDate);
            this.Controls.Add(this.lblCompName);
            this.Controls.Add(this.lblCompId);
            this.Controls.Add(this.competitionView);
            this.Controls.Add(this.panel1);
            this.Name = "ViewCompetition";
            this.Text = "ViewCompetition";
            this.Load += new System.EventHandler(this.ViewCompetition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.swimmingclubdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swimmingclubdbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.competitionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.competitionView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.competitionBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swimmingclubdbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.competitionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.competitionBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.competitionBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCompDetails;
        private System.Windows.Forms.Label lblCompVenue;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Label lblCompDate;
        private System.Windows.Forms.Label lblCompName;
        private System.Windows.Forms.Label lblCompId;
        private swimmingclubdbDataSetTableAdapters.CompetitionTableAdapter competitionTableAdapter;
        private swimmingclubdbDataSet swimmingclubdbDataSet;
        private System.Windows.Forms.BindingSource swimmingclubdbDataSetBindingSource;
        private System.Windows.Forms.BindingSource competitionBindingSource;
        private System.Windows.Forms.DataGridView competitionView;
        private System.Windows.Forms.Button bckBtn;
        private System.Windows.Forms.Label Topic;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource competitionBindingSource1;
        private System.Windows.Forms.BindingSource competitionBindingSource2;
        private System.Windows.Forms.BindingSource competitionBindingSource3;
        private swimmingclubdbDataSet1 swimmingclubdbDataSet1;
        private System.Windows.Forms.BindingSource competitionBindingSource4;
        private swimmingclubdbDataSet1TableAdapters.CompetitionTableAdapter competitionTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn competitionidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn competitionnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duedateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn competitiondateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn venueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}