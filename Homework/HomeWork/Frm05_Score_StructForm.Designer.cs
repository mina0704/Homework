namespace HomeWork
{
    partial class Frm05_Score_StructForm
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
            this.gpGrade = new System.Windows.Forms.GroupBox();
            this.txtHorLScore = new System.Windows.Forms.TextBox();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.labName = new System.Windows.Forms.Label();
            this.labScoreChi = new System.Windows.Forms.Label();
            this.labScoreMath = new System.Windows.Forms.Label();
            this.labScoreEng = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnHighestLowest = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtScoreChi = new System.Windows.Forms.TextBox();
            this.txtScoreMath = new System.Windows.Forms.TextBox();
            this.txtScoreEng = new System.Windows.Forms.TextBox();
            this.gpGrade.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpGrade
            // 
            this.gpGrade.Controls.Add(this.txtHorLScore);
            this.gpGrade.Controls.Add(this.txtScore);
            this.gpGrade.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpGrade.ForeColor = System.Drawing.Color.CadetBlue;
            this.gpGrade.Location = new System.Drawing.Point(428, 21);
            this.gpGrade.Name = "gpGrade";
            this.gpGrade.Size = new System.Drawing.Size(341, 349);
            this.gpGrade.TabIndex = 2;
            this.gpGrade.TabStop = false;
            this.gpGrade.Text = "成績";
            // 
            // txtHorLScore
            // 
            this.txtHorLScore.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtHorLScore.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtHorLScore.Location = new System.Drawing.Point(33, 231);
            this.txtHorLScore.Multiline = true;
            this.txtHorLScore.Name = "txtHorLScore";
            this.txtHorLScore.ReadOnly = true;
            this.txtHorLScore.Size = new System.Drawing.Size(256, 99);
            this.txtHorLScore.TabIndex = 1;
            // 
            // txtScore
            // 
            this.txtScore.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtScore.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtScore.Location = new System.Drawing.Point(33, 40);
            this.txtScore.Multiline = true;
            this.txtScore.Name = "txtScore";
            this.txtScore.ReadOnly = true;
            this.txtScore.Size = new System.Drawing.Size(256, 185);
            this.txtScore.TabIndex = 0;
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(68, 74);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(52, 25);
            this.labName.TabIndex = 3;
            this.labName.Text = "姓名";
            // 
            // labScoreChi
            // 
            this.labScoreChi.AutoSize = true;
            this.labScoreChi.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labScoreChi.Location = new System.Drawing.Point(68, 138);
            this.labScoreChi.Name = "labScoreChi";
            this.labScoreChi.Size = new System.Drawing.Size(52, 25);
            this.labScoreChi.TabIndex = 4;
            this.labScoreChi.Text = "國文";
            // 
            // labScoreMath
            // 
            this.labScoreMath.AutoSize = true;
            this.labScoreMath.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labScoreMath.Location = new System.Drawing.Point(68, 205);
            this.labScoreMath.Name = "labScoreMath";
            this.labScoreMath.Size = new System.Drawing.Size(52, 25);
            this.labScoreMath.TabIndex = 5;
            this.labScoreMath.Text = "數學";
            // 
            // labScoreEng
            // 
            this.labScoreEng.AutoSize = true;
            this.labScoreEng.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labScoreEng.Location = new System.Drawing.Point(68, 275);
            this.labScoreEng.Name = "labScoreEng";
            this.labScoreEng.Size = new System.Drawing.Size(52, 25);
            this.labScoreEng.TabIndex = 6;
            this.labScoreEng.Text = "英文";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnSave.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSave.Location = new System.Drawing.Point(43, 347);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 49);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "儲存";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnShow.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShow.Location = new System.Drawing.Point(210, 347);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(142, 49);
            this.btnShow.TabIndex = 8;
            this.btnShow.Text = "顯示儲存內容";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnHighestLowest
            // 
            this.btnHighestLowest.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnHighestLowest.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHighestLowest.Location = new System.Drawing.Point(479, 389);
            this.btnHighestLowest.Name = "btnHighestLowest";
            this.btnHighestLowest.Size = new System.Drawing.Size(216, 35);
            this.btnHighestLowest.TabIndex = 9;
            this.btnHighestLowest.Text = "最高分/最低分科目";
            this.btnHighestLowest.UseVisualStyleBackColor = false;
            this.btnHighestLowest.Click += new System.EventHandler(this.btnHighestLowest_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(226, 65);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(117, 34);
            this.txtName.TabIndex = 10;
            // 
            // txtScoreChi
            // 
            this.txtScoreChi.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtScoreChi.Location = new System.Drawing.Point(226, 129);
            this.txtScoreChi.Name = "txtScoreChi";
            this.txtScoreChi.Size = new System.Drawing.Size(117, 34);
            this.txtScoreChi.TabIndex = 11;
            // 
            // txtScoreMath
            // 
            this.txtScoreMath.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtScoreMath.Location = new System.Drawing.Point(226, 196);
            this.txtScoreMath.Name = "txtScoreMath";
            this.txtScoreMath.Size = new System.Drawing.Size(117, 34);
            this.txtScoreMath.TabIndex = 12;
            // 
            // txtScoreEng
            // 
            this.txtScoreEng.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtScoreEng.Location = new System.Drawing.Point(226, 266);
            this.txtScoreEng.Name = "txtScoreEng";
            this.txtScoreEng.Size = new System.Drawing.Size(117, 34);
            this.txtScoreEng.TabIndex = 13;
            // 
            // Frm05_Score_StructForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtScoreEng);
            this.Controls.Add(this.txtScoreMath);
            this.Controls.Add(this.txtScoreChi);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnHighestLowest);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labScoreEng);
            this.Controls.Add(this.labScoreMath);
            this.Controls.Add(this.labScoreChi);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.gpGrade);
            this.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.Name = "Frm05_Score_StructForm";
            this.Text = "StudentScore";
            this.gpGrade.ResumeLayout(false);
            this.gpGrade.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gpGrade;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labScoreChi;
        private System.Windows.Forms.Label labScoreMath;
        private System.Windows.Forms.Label labScoreEng;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnHighestLowest;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtScoreChi;
        private System.Windows.Forms.TextBox txtScoreMath;
        private System.Windows.Forms.TextBox txtScoreEng;
        private System.Windows.Forms.TextBox txtHorLScore;
        private System.Windows.Forms.TextBox txtScore;
    }
}