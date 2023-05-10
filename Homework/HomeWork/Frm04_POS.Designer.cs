namespace HomeWork
{
    partial class Frm04_POS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm04_POS));
            this.gpbMenu = new System.Windows.Forms.GroupBox();
            this.btnMille = new System.Windows.Forms.Button();
            this.btnPudding = new System.Windows.Forms.Button();
            this.btnPasta = new System.Windows.Forms.Button();
            this.btnLatte = new System.Windows.Forms.Button();
            this.gpbTatal = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.gpbPayMethod = new System.Windows.Forms.GroupBox();
            this.txtCreditCard = new System.Windows.Forms.TextBox();
            this.btnCreditCard = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.gpbBuyList = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtOrderList = new System.Windows.Forms.TextBox();
            this.gpbMenu.SuspendLayout();
            this.gpbTatal.SuspendLayout();
            this.gpbPayMethod.SuspendLayout();
            this.gpbBuyList.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbMenu
            // 
            this.gpbMenu.BackColor = System.Drawing.Color.SeaShell;
            this.gpbMenu.Controls.Add(this.btnMille);
            this.gpbMenu.Controls.Add(this.btnPudding);
            this.gpbMenu.Controls.Add(this.btnPasta);
            this.gpbMenu.Controls.Add(this.btnLatte);
            this.gpbMenu.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpbMenu.Location = new System.Drawing.Point(14, 36);
            this.gpbMenu.Name = "gpbMenu";
            this.gpbMenu.Size = new System.Drawing.Size(291, 391);
            this.gpbMenu.TabIndex = 0;
            this.gpbMenu.TabStop = false;
            this.gpbMenu.Text = "菜單 Menu";
            // 
            // btnMille
            // 
            this.btnMille.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMille.BackgroundImage")));
            this.btnMille.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMille.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMille.ForeColor = System.Drawing.Color.Black;
            this.btnMille.Location = new System.Drawing.Point(145, 225);
            this.btnMille.Name = "btnMille";
            this.btnMille.Size = new System.Drawing.Size(115, 112);
            this.btnMille.TabIndex = 3;
            this.btnMille.Text = "千層派\r\nNT $ 100";
            this.btnMille.UseVisualStyleBackColor = true;
            this.btnMille.Click += new System.EventHandler(this.btnMille_Click);
            // 
            // btnPudding
            // 
            this.btnPudding.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPudding.BackgroundImage")));
            this.btnPudding.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPudding.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPudding.ForeColor = System.Drawing.Color.Black;
            this.btnPudding.Location = new System.Drawing.Point(22, 225);
            this.btnPudding.Name = "btnPudding";
            this.btnPudding.Size = new System.Drawing.Size(113, 112);
            this.btnPudding.TabIndex = 2;
            this.btnPudding.Text = "烤布蕾\r\nNT $ 80";
            this.btnPudding.UseVisualStyleBackColor = true;
            this.btnPudding.Click += new System.EventHandler(this.btnPudding_Click);
            // 
            // btnPasta
            // 
            this.btnPasta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPasta.BackgroundImage")));
            this.btnPasta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPasta.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPasta.ForeColor = System.Drawing.Color.Black;
            this.btnPasta.Location = new System.Drawing.Point(145, 88);
            this.btnPasta.Name = "btnPasta";
            this.btnPasta.Size = new System.Drawing.Size(115, 117);
            this.btnPasta.TabIndex = 1;
            this.btnPasta.Text = "義大利麵\r\nNT $ 150";
            this.btnPasta.UseVisualStyleBackColor = true;
            this.btnPasta.Click += new System.EventHandler(this.btnPasta_Click);
            // 
            // btnLatte
            // 
            this.btnLatte.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLatte.BackgroundImage")));
            this.btnLatte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLatte.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLatte.ForeColor = System.Drawing.Color.Black;
            this.btnLatte.Location = new System.Drawing.Point(22, 88);
            this.btnLatte.Name = "btnLatte";
            this.btnLatte.Size = new System.Drawing.Size(113, 117);
            this.btnLatte.TabIndex = 0;
            this.btnLatte.Text = "抹茶拿鐵\r\nNT $ 120";
            this.btnLatte.UseVisualStyleBackColor = true;
            this.btnLatte.Click += new System.EventHandler(this.btnLatte_Click);
            // 
            // gpbTatal
            // 
            this.gpbTatal.BackColor = System.Drawing.Color.SeaShell;
            this.gpbTatal.Controls.Add(this.txtTotal);
            this.gpbTatal.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpbTatal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gpbTatal.Location = new System.Drawing.Point(339, 43);
            this.gpbTatal.Name = "gpbTatal";
            this.gpbTatal.Size = new System.Drawing.Size(276, 127);
            this.gpbTatal.TabIndex = 1;
            this.gpbTatal.TabStop = false;
            this.gpbTatal.Text = "總金額 Total Price";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtTotal.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTotal.ForeColor = System.Drawing.SystemColors.Window;
            this.txtTotal.Location = new System.Drawing.Point(19, 81);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(239, 43);
            this.txtTotal.TabIndex = 0;
            this.txtTotal.Text = "0 元";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gpbPayMethod
            // 
            this.gpbPayMethod.BackColor = System.Drawing.Color.SeaShell;
            this.gpbPayMethod.Controls.Add(this.txtCreditCard);
            this.gpbPayMethod.Controls.Add(this.btnCreditCard);
            this.gpbPayMethod.Controls.Add(this.btnCash);
            this.gpbPayMethod.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpbPayMethod.Location = new System.Drawing.Point(339, 216);
            this.gpbPayMethod.Name = "gpbPayMethod";
            this.gpbPayMethod.Size = new System.Drawing.Size(276, 157);
            this.gpbPayMethod.TabIndex = 2;
            this.gpbPayMethod.TabStop = false;
            this.gpbPayMethod.Text = "付款方式";
            // 
            // txtCreditCard
            // 
            this.txtCreditCard.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtCreditCard.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCreditCard.ForeColor = System.Drawing.Color.IndianRed;
            this.txtCreditCard.Location = new System.Drawing.Point(153, 120);
            this.txtCreditCard.Name = "txtCreditCard";
            this.txtCreditCard.ReadOnly = true;
            this.txtCreditCard.Size = new System.Drawing.Size(117, 31);
            this.txtCreditCard.TabIndex = 2;
            this.txtCreditCard.Text = "信用卡享九折!";
            // 
            // btnCreditCard
            // 
            this.btnCreditCard.BackColor = System.Drawing.Color.Beige;
            this.btnCreditCard.Location = new System.Drawing.Point(145, 54);
            this.btnCreditCard.Name = "btnCreditCard";
            this.btnCreditCard.Size = new System.Drawing.Size(123, 51);
            this.btnCreditCard.TabIndex = 1;
            this.btnCreditCard.Text = "信用卡";
            this.btnCreditCard.UseVisualStyleBackColor = false;
            this.btnCreditCard.Click += new System.EventHandler(this.btnCreditCard_Click);
            // 
            // btnCash
            // 
            this.btnCash.BackColor = System.Drawing.Color.Beige;
            this.btnCash.Location = new System.Drawing.Point(6, 54);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(123, 51);
            this.btnCash.TabIndex = 0;
            this.btnCash.Text = "現金";
            this.btnCash.UseVisualStyleBackColor = false;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // gpbBuyList
            // 
            this.gpbBuyList.BackColor = System.Drawing.Color.SeaShell;
            this.gpbBuyList.Controls.Add(this.btnCancel);
            this.gpbBuyList.Controls.Add(this.txtOrderList);
            this.gpbBuyList.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpbBuyList.Location = new System.Drawing.Point(647, 43);
            this.gpbBuyList.Name = "gpbBuyList";
            this.gpbBuyList.Size = new System.Drawing.Size(298, 384);
            this.gpbBuyList.TabIndex = 3;
            this.gpbBuyList.TabStop = false;
            this.gpbBuyList.Text = "購物清單";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Beige;
            this.btnCancel.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancel.Location = new System.Drawing.Point(88, 323);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 43);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "清除清單";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtOrderList
            // 
            this.txtOrderList.BackColor = System.Drawing.Color.SeaShell;
            this.txtOrderList.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtOrderList.Location = new System.Drawing.Point(23, 37);
            this.txtOrderList.Multiline = true;
            this.txtOrderList.Name = "txtOrderList";
            this.txtOrderList.ReadOnly = true;
            this.txtOrderList.Size = new System.Drawing.Size(254, 268);
            this.txtOrderList.TabIndex = 0;
            this.txtOrderList.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Frm_F03_POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1007, 533);
            this.Controls.Add(this.gpbBuyList);
            this.Controls.Add(this.gpbPayMethod);
            this.Controls.Add(this.gpbTatal);
            this.Controls.Add(this.gpbMenu);
            this.ForeColor = System.Drawing.Color.IndianRed;
            this.Name = "Frm_F03_POS";
            this.Text = "POS";
            this.gpbMenu.ResumeLayout(false);
            this.gpbTatal.ResumeLayout(false);
            this.gpbTatal.PerformLayout();
            this.gpbPayMethod.ResumeLayout(false);
            this.gpbPayMethod.PerformLayout();
            this.gpbBuyList.ResumeLayout(false);
            this.gpbBuyList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbMenu;
        private System.Windows.Forms.Button btnMille;
        private System.Windows.Forms.Button btnPudding;
        private System.Windows.Forms.Button btnPasta;
        private System.Windows.Forms.Button btnLatte;
        private System.Windows.Forms.GroupBox gpbTatal;
        private System.Windows.Forms.GroupBox gpbPayMethod;
        private System.Windows.Forms.GroupBox gpbBuyList;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCreditCard;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.TextBox txtCreditCard;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtOrderList;
    }
}