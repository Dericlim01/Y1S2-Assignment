namespace Y1S2
{
    partial class ManagerCompetition
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bckBtn = new System.Windows.Forms.Button();
            this.Topic = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.competitionView = new System.Windows.Forms.DataGridView();
            this.competitionidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.competitionnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duedateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.competitiondateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.competitionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.swimmingclubdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.swimmingclubdbDataSet = new Y1S2.swimmingclubdbDataSet();
            this.competitionTableAdapter = new Y1S2.swimmingclubdbDataSetTableAdapters.CompetitionTableAdapter();
            this.dltBtn = new System.Windows.Forms.Button();
            this.lblCompId = new System.Windows.Forms.Label();
            this.lblCompName = new System.Windows.Forms.Label();
            this.lblCompDate = new System.Windows.Forms.Label();
            this.lblCompDetails = new System.Windows.Forms.Label();
            this.lblCompVenue = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.competitionView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.competitionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swimmingclubdbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swimmingclubdbDataSet)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(-9, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 90);
            this.panel1.TabIndex = 11;
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
            this.bckBtn.Click += new System.EventHandler(this.bckBtn_Click);
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
            this.competitionView.DataSource = this.competitionBindingSource;
            this.competitionView.Location = new System.Drawing.Point(424, 115);
            this.competitionView.Name = "competitionView";
            this.competitionView.Size = new System.Drawing.Size(338, 290);
            this.competitionView.TabIndex = 12;
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
            // competitionTableAdapter
            // 
            this.competitionTableAdapter.ClearBeforeFill = true;
            // 
            // dltBtn
            // 
            this.dltBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.dltBtn.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.dltBtn.Location = new System.Drawing.Point(283, 368);
            this.dltBtn.Name = "dltBtn";
            this.dltBtn.Size = new System.Drawing.Size(109, 50);
            this.dltBtn.TabIndex = 14;
            this.dltBtn.Text = "Delete";
            this.dltBtn.UseVisualStyleBackColor = false;
            this.dltBtn.Click += new System.EventHandler(this.dltBtn_Click);
            // 
            // lblCompId
            // 
            this.lblCompId.AutoSize = true;
            this.lblCompId.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblCompId.Location = new System.Drawing.Point(81, 149);
            this.lblCompId.Name = "lblCompId";
            this.lblCompId.Size = new System.Drawing.Size(128, 17);
            this.lblCompId.TabIndex = 15;
            this.lblCompId.Text = "Competition ID:";
            // 
            // lblCompName
            // 
            this.lblCompName.AutoSize = true;
            this.lblCompName.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblCompName.Location = new System.Drawing.Point(81, 181);
            this.lblCompName.Name = "lblCompName";
            this.lblCompName.Size = new System.Drawing.Size(144, 17);
            this.lblCompName.TabIndex = 16;
            this.lblCompName.Text = "Competition Name:";
            // 
            // lblCompDate
            // 
            this.lblCompDate.AutoSize = true;
            this.lblCompDate.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblCompDate.Location = new System.Drawing.Point(81, 212);
            this.lblCompDate.Name = "lblCompDate";
            this.lblCompDate.Size = new System.Drawing.Size(144, 17);
            this.lblCompDate.TabIndex = 17;
            this.lblCompDate.Text = "Competition Date:";
            // 
            // lblCompDetails
            // 
            this.lblCompDetails.AutoSize = true;
            this.lblCompDetails.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblCompDetails.Location = new System.Drawing.Point(81, 303);
            this.lblCompDetails.Name = "lblCompDetails";
            this.lblCompDetails.Size = new System.Drawing.Size(72, 17);
            this.lblCompDetails.TabIndex = 20;
            this.lblCompDetails.Text = "Details:";
            // 
            // lblCompVenue
            // 
            this.lblCompVenue.AutoSize = true;
            this.lblCompVenue.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblCompVenue.Location = new System.Drawing.Point(81, 272);
            this.lblCompVenue.Name = "lblCompVenue";
            this.lblCompVenue.Size = new System.Drawing.Size(56, 17);
            this.lblCompVenue.TabIndex = 19;
            this.lblCompVenue.Text = "Venue:";
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblDueDate.Location = new System.Drawing.Point(81, 240);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(80, 17);
            this.lblDueDate.TabIndex = 18;
            this.lblDueDate.Text = "Due Date:";
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.AddBtn.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Location = new System.Drawing.Point(33, 368);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(109, 50);
            this.AddBtn.TabIndex = 13;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.editBtn.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.editBtn.Location = new System.Drawing.Point(159, 368);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(109, 50);
            this.editBtn.TabIndex = 21;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // ManagerCompetition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.lblCompDetails);
            this.Controls.Add(this.lblCompVenue);
            this.Controls.Add(this.lblDueDate);
            this.Controls.Add(this.lblCompDate);
            this.Controls.Add(this.lblCompName);
            this.Controls.Add(this.lblCompId);
            this.Controls.Add(this.dltBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.competitionView);
            this.Controls.Add(this.panel1);
            this.Name = "ManagerCompetition";
            this.Text = "AddCompetition";
            this.Load += new System.EventHandler(this.AddCompetition_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.competitionView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.competitionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swimmingclubdbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swimmingclubdbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView competitionView;
        private System.Windows.Forms.BindingSource swimmingclubdbDataSetBindingSource;
        private swimmingclubdbDataSet swimmingclubdbDataSet;
        private System.Windows.Forms.BindingSource competitionBindingSource;
        private swimmingclubdbDataSetTableAdapters.CompetitionTableAdapter competitionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn competitionidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn competitionnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duedateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn competitiondateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn venueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button dltBtn;
        private System.Windows.Forms.Label lblCompId;
        private System.Windows.Forms.Label lblCompName;
        private System.Windows.Forms.Label lblCompDate;
        private System.Windows.Forms.Label Topic;
        private System.Windows.Forms.Label lblCompDetails;
        private System.Windows.Forms.Label lblCompVenue;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button bckBtn;
    }
}