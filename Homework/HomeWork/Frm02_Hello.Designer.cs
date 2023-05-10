namespace HomeWork
{
    partial class Frm02_Hello
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm02_Hello));
            this.BtnSayHello = new System.Windows.Forms.Button();
            this.btnSayHi = new System.Windows.Forms.Button();
            this.LabName = new System.Windows.Forms.Label();
            this.LabEnglishName = new System.Windows.Forms.Label();
            this.LabSex = new System.Windows.Forms.Label();
            this.LabSigns = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEnglishName = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.txtSigns = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnSayHello
            // 
            this.BtnSayHello.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnSayHello.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSayHello.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnSayHello.ForeColor = System.Drawing.Color.LavenderBlush;
            this.BtnSayHello.Location = new System.Drawing.Point(39, 368);
            this.BtnSayHello.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSayHello.Name = "BtnSayHello";
            this.BtnSayHello.Size = new System.Drawing.Size(256, 60);
            this.BtnSayHello.TabIndex = 0;
            this.BtnSayHello.Text = "Say Hello !";
            this.BtnSayHello.UseVisualStyleBackColor = false;
            this.BtnSayHello.Click += new System.EventHandler(this.btnSayHello_Click);
            // 
            // btnSayHi
            // 
            this.btnSayHi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSayHi.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSayHi.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnSayHi.Location = new System.Drawing.Point(361, 368);
            this.btnSayHi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSayHi.Name = "btnSayHi";
            this.btnSayHi.Size = new System.Drawing.Size(249, 60);
            this.btnSayHi.TabIndex = 1;
            this.btnSayHi.Text = "Say Hi !";
            this.btnSayHi.UseVisualStyleBackColor = false;
            this.btnSayHi.Click += new System.EventHandler(this.btnSayHi_Click);
            // 
            // LabName
            // 
            this.LabName.AutoSize = true;
            this.LabName.BackColor = System.Drawing.Color.LightCyan;
            this.LabName.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LabName.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LabName.Location = new System.Drawing.Point(33, 39);
            this.LabName.Name = "LabName";
            this.LabName.Size = new System.Drawing.Size(82, 29);
            this.LabName.TabIndex = 2;
            this.LabName.Text = "姓名：";
            this.LabName.Click += new System.EventHandler(this.LabName_Click);
            // 
            // LabEnglishName
            // 
            this.LabEnglishName.AutoSize = true;
            this.LabEnglishName.BackColor = System.Drawing.Color.LightCyan;
            this.LabEnglishName.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LabEnglishName.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LabEnglishName.Location = new System.Drawing.Point(33, 112);
            this.LabEnglishName.Name = "LabEnglishName";
            this.LabEnglishName.Size = new System.Drawing.Size(180, 29);
            this.LabEnglishName.TabIndex = 3;
            this.LabEnglishName.Text = "EnglishName：";
            this.LabEnglishName.Click += new System.EventHandler(this.label2_Click);
            // 
            // LabSex
            // 
            this.LabSex.AutoSize = true;
            this.LabSex.BackColor = System.Drawing.Color.LightCyan;
            this.LabSex.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LabSex.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LabSex.Location = new System.Drawing.Point(33, 205);
            this.LabSex.Name = "LabSex";
            this.LabSex.Size = new System.Drawing.Size(82, 29);
            this.LabSex.TabIndex = 4;
            this.LabSex.Text = "性別：";
            this.LabSex.Click += new System.EventHandler(this.LabSex_Click);
            // 
            // LabSigns
            // 
            this.LabSigns.AutoSize = true;
            this.LabSigns.BackColor = System.Drawing.Color.LightCyan;
            this.LabSigns.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LabSigns.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LabSigns.Location = new System.Drawing.Point(33, 286);
            this.LabSigns.Name = "LabSigns";
            this.LabSigns.Size = new System.Drawing.Size(82, 29);
            this.LabSigns.TabIndex = 5;
            this.LabSigns.Text = "星座：";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(291, 28);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(169, 38);
            this.txtName.TabIndex = 6;
            // 
            // txtEnglishName
            // 
            this.txtEnglishName.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEnglishName.Location = new System.Drawing.Point(291, 109);
            this.txtEnglishName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEnglishName.Name = "txtEnglishName";
            this.txtEnglishName.Size = new System.Drawing.Size(231, 38);
            this.txtEnglishName.TabIndex = 7;
            // 
            // txtSex
            // 
            this.txtSex.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSex.Location = new System.Drawing.Point(291, 194);
            this.txtSex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(100, 38);
            this.txtSex.TabIndex = 8;
            // 
            // txtSigns
            // 
            this.txtSigns.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSigns.Location = new System.Drawing.Point(291, 275);
            this.txtSigns.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSigns.Name = "txtSigns";
            this.txtSigns.Size = new System.Drawing.Size(125, 38);
            this.txtSigns.TabIndex = 9;
            // 
            // Frm_F01_Hello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(892, 620);
            this.Controls.Add(this.txtSigns);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.txtEnglishName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.LabSigns);
            this.Controls.Add(this.LabSex);
            this.Controls.Add(this.LabEnglishName);
            this.Controls.Add(this.LabName);
            this.Controls.Add(this.btnSayHi);
            this.Controls.Add(this.BtnSayHello);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_F01_Hello";
            this.Text = "個人資料";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSayHello;
        private System.Windows.Forms.Button btnSayHi;
        private System.Windows.Forms.Label LabName;
        private System.Windows.Forms.Label LabEnglishName;
        private System.Windows.Forms.Label LabSex;
        private System.Windows.Forms.Label LabSigns;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEnglishName;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.TextBox txtSigns;
    }
}

