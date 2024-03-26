namespace Y1S2
{
    partial class ViewSuggestion
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
            this.suggestion_lxBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.name_lbl = new System.Windows.Forms.Label();
            this.suggestion_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Suggestion";
            // 
            // suggestion_lxBox
            // 
            this.suggestion_lxBox.FormattingEnabled = true;
            this.suggestion_lxBox.Location = new System.Drawing.Point(169, 135);
            this.suggestion_lxBox.Name = "suggestion_lxBox";
            this.suggestion_lxBox.Size = new System.Drawing.Size(120, 95);
            this.suggestion_lxBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Suggestion :";
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Location = new System.Drawing.Point(476, 135);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(13, 13);
            this.name_lbl.TabIndex = 4;
            this.name_lbl.Text = "_";
            // 
            // suggestion_lbl
            // 
            this.suggestion_lbl.AutoSize = true;
            this.suggestion_lbl.Location = new System.Drawing.Point(476, 174);
            this.suggestion_lbl.Name = "suggestion_lbl";
            this.suggestion_lbl.Size = new System.Drawing.Size(13, 13);
            this.suggestion_lbl.TabIndex = 5;
            this.suggestion_lbl.Text = "_";
            // 
            // ViewSuggestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.suggestion_lbl);
            this.Controls.Add(this.name_lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.suggestion_lxBox);
            this.Controls.Add(this.label1);
            this.Name = "ViewSuggestion";
            this.Text = "ViewSuggestion";
            this.Load += new System.EventHandler(this.ViewSuggestion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox suggestion_lxBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Label suggestion_lbl;
    }
}