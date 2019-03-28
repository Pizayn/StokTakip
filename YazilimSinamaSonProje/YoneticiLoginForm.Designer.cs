namespace YazilimSinamaSonProje
{
    partial class YoneticiLoginForm
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.tbxYoneticiId = new System.Windows.Forms.TextBox();
            this.tbxYoneticiSifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnGirisYap);
            this.groupControl1.Controls.Add(this.tbxYoneticiId);
            this.groupControl1.Controls.Add(this.tbxYoneticiSifre);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(101, 104);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(346, 236);
            this.groupControl1.TabIndex = 0;
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Location = new System.Drawing.Point(158, 175);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(106, 43);
            this.btnGirisYap.TabIndex = 5;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // tbxYoneticiId
            // 
            this.tbxYoneticiId.Location = new System.Drawing.Point(119, 91);
            this.tbxYoneticiId.Name = "tbxYoneticiId";
            this.tbxYoneticiId.Size = new System.Drawing.Size(181, 23);
            this.tbxYoneticiId.TabIndex = 4;
            // 
            // tbxYoneticiSifre
            // 
            this.tbxYoneticiSifre.Location = new System.Drawing.Point(119, 135);
            this.tbxYoneticiSifre.Name = "tbxYoneticiSifre";
            this.tbxYoneticiSifre.Size = new System.Drawing.Size(181, 23);
            this.tbxYoneticiSifre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yonetici Id";
            // 
            // YoneticiLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 436);
            this.Controls.Add(this.groupControl1);
            this.MaximumSize = new System.Drawing.Size(552, 483);
            this.MinimumSize = new System.Drawing.Size(552, 483);
            this.Name = "YoneticiLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YoneticiLoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.TextBox tbxYoneticiId;
        private System.Windows.Forms.TextBox tbxYoneticiSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}