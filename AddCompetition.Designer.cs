namespace Y1S2
{
    partial class AddCompetition
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
            this.swimmingclubdbDataSet = new Y1S2.swimmingclubdbDataSet();
            this.swimmingclubdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.competitionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Topic = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.competitionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.addCompVenueTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addCompIdTB = new System.Windows.Forms.TextBox();
            this.unlabel = new System.Windows.Forms.Label();
            this.pwlabel = new System.Windows.Forms.Label();
            this.addCompDetailTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addCompNameTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addCompDate = new System.Windows.Forms.DateTimePicker();
            this.addDueDate = new System.Windows.Forms.DateTimePicker();
            this.addCompbtn = new System.Windows.Forms.Button();
            this.bckBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.swimmingclubdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swimmingclubdbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.competitionBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.competitionBindingSource1)).BeginInit();
            this.SuspendLayout();
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
            // Topic
            // 
            this.Topic.AutoSize = true;
            this.Topic.Font = new System.Drawing.Font("Consolas", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Topic.Location = new System.Drawing.Point(249, 40);
            this.Topic.Name = "Topic";
            this.Topic.Size = new System.Drawing.Size(314, 32);
            this.Topic.TabIndex = 16;
            this.Topic.Text = "Add Competition Page";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.bckBtn);
            this.panel1.Controls.Add(this.Topic);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-6, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 107);
            this.panel1.TabIndex = 22;
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
            // competitionBindingSource1
            // 
            this.competitionBindingSource1.DataMember = "Competition";
            this.competitionBindingSource1.DataSource = this.swimmingclubdbDataSetBindingSource;
            // 
            // addCompVenueTB
            // 
            this.addCompVenueTB.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCompVenueTB.Location = new System.Drawing.Point(167, 272);
            this.addCompVenueTB.Name = "addCompVenueTB";
            this.addCompVenueTB.Size = new System.Drawing.Size(200, 25);
            this.addCompVenueTB.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(95, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Venue:";
            // 
            // addCompIdTB
            // 
            this.addCompIdTB.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCompIdTB.Location = new System.Drawing.Point(162, 162);
            this.addCompIdTB.Name = "addCompIdTB";
            this.addCompIdTB.Size = new System.Drawing.Size(205, 25);
            this.addCompIdTB.TabIndex = 28;
            // 
            // unlabel
            // 
            this.unlabel.AutoSize = true;
            this.unlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Bold);
            this.unlabel.Location = new System.Drawing.Point(26, 162);
            this.unlabel.Name = "unlabel";
            this.unlabel.Size = new System.Drawing.Size(134, 20);
            this.unlabel.TabIndex = 27;
            this.unlabel.Text = "Competition ID:";
            // 
            // pwlabel
            // 
            this.pwlabel.AutoSize = true;
            this.pwlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Bold);
            this.pwlabel.Location = new System.Drawing.Point(6, 218);
            this.pwlabel.Name = "pwlabel";
            this.pwlabel.Size = new System.Drawing.Size(154, 20);
            this.pwlabel.TabIndex = 26;
            this.pwlabel.Text = "Competition Date:";
            // 
            // addCompDetailTB
            // 
            this.addCompDetailTB.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCompDetailTB.Location = new System.Drawing.Point(564, 275);
            this.addCompDetailTB.Name = "addCompDetailTB";
            this.addCompDetailTB.Size = new System.Drawing.Size(197, 25);
            this.addCompDetailTB.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(488, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Details:";
            // 
            // addCompNameTB
            // 
            this.addCompNameTB.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCompNameTB.Location = new System.Drawing.Point(564, 163);
            this.addCompNameTB.Name = "addCompNameTB";
            this.addCompNameTB.Size = new System.Drawing.Size(197, 25);
            this.addCompNameTB.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(397, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Competition Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(467, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Due Date:";
            // 
            // addCompDate
            // 
            this.addCompDate.Location = new System.Drawing.Point(167, 221);
            this.addCompDate.Name = "addCompDate";
            this.addCompDate.Size = new System.Drawing.Size(200, 20);
            this.addCompDate.TabIndex = 38;
            // 
            // addDueDate
            // 
            this.addDueDate.Location = new System.Drawing.Point(561, 221);
            this.addDueDate.Name = "addDueDate";
            this.addDueDate.Size = new System.Drawing.Size(200, 20);
            this.addDueDate.TabIndex = 39;
            // 
            // addCompbtn
            // 
            this.addCompbtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.addCompbtn.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.addCompbtn.FlatAppearance.BorderSize = 3;
            this.addCompbtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCompbtn.Location = new System.Drawing.Point(320, 347);
            this.addCompbtn.Name = "addCompbtn";
            this.addCompbtn.Size = new System.Drawing.Size(184, 58);
            this.addCompbtn.TabIndex = 40;
            this.addCompbtn.Text = "Add";
            this.addCompbtn.UseVisualStyleBackColor = false;
            this.addCompbtn.Click += new System.EventHandler(this.addCompbtn_Click);
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
            // AddCompetition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addCompbtn);
            this.Controls.Add(this.addDueDate);
            this.Controls.Add(this.addCompDate);
            this.Controls.Add(this.addCompDetailTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addCompNameTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addCompVenueTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addCompIdTB);
            this.Controls.Add(this.unlabel);
            this.Controls.Add(this.pwlabel);
            this.Controls.Add(this.panel1);
            this.Name = "AddCompetition";
            this.Text = "AddCompetition";
            ((System.ComponentModel.ISupportInitialize)(this.swimmingclubdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swimmingclubdbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.competitionBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.competitionBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private swimmingclubdbDataSetTableAdapters.CompetitionTableAdapter competitionTableAdapter;
        private swimmingclubdbDataSet swimmingclubdbDataSet;
        private System.Windows.Forms.BindingSource swimmingclubdbDataSetBindingSource;
        private System.Windows.Forms.BindingSource competitionBindingSource;
        private System.Windows.Forms.Label Topic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource competitionBindingSource1;
        private System.Windows.Forms.TextBox addCompVenueTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addCompIdTB;
        private System.Windows.Forms.Label unlabel;
        private System.Windows.Forms.Label pwlabel;
        private System.Windows.Forms.TextBox addCompDetailTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addCompNameTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker addCompDate;
        private System.Windows.Forms.DateTimePicker addDueDate;
        private System.Windows.Forms.Button addCompbtn;
        private System.Windows.Forms.Button bckBtn;
    }
}