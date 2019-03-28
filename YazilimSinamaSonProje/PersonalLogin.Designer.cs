namespace YazilimSinamaSonProje
{
    partial class PersonalLogin
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
            this.tbxPersonalId = new System.Windows.Forms.TextBox();
            this.tbxPersonalSifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgwPersonalZimmet = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPersonalZimmet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnGirisYap);
            this.groupControl1.Controls.Add(this.tbxPersonalId);
            this.groupControl1.Controls.Add(this.tbxPersonalSifre);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(44, 85);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(346, 236);
            this.groupControl1.TabIndex = 1;
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Location = new System.Drawing.Point(151, 174);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(106, 43);
            this.btnGirisYap.TabIndex = 5;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // tbxPersonalId
            // 
            this.tbxPersonalId.Location = new System.Drawing.Point(119, 91);
            this.tbxPersonalId.Name = "tbxPersonalId";
            this.tbxPersonalId.Size = new System.Drawing.Size(181, 23);
            this.tbxPersonalId.TabIndex = 4;
            // 
            // tbxPersonalSifre
            // 
            this.tbxPersonalSifre.Location = new System.Drawing.Point(119, 135);
            this.tbxPersonalSifre.Name = "tbxPersonalSifre";
            this.tbxPersonalSifre.Size = new System.Drawing.Size(181, 23);
            this.tbxPersonalSifre.TabIndex = 3;
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
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personal Id";
            // 
            // dgwPersonalZimmet
            // 
            this.dgwPersonalZimmet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPersonalZimmet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwPersonalZimmet.Location = new System.Drawing.Point(0, 0);
            this.dgwPersonalZimmet.Name = "dgwPersonalZimmet";
            this.dgwPersonalZimmet.ReadOnly = true;
            this.dgwPersonalZimmet.RowTemplate.Height = 24;
            this.dgwPersonalZimmet.Size = new System.Drawing.Size(434, 407);
            this.dgwPersonalZimmet.TabIndex = 2;
            this.dgwPersonalZimmet.Visible = false;
            // 
            // PersonalLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 407);
            this.Controls.Add(this.dgwPersonalZimmet);
            this.Controls.Add(this.groupControl1);
            this.MaximumSize = new System.Drawing.Size(452, 454);
            this.MinimumSize = new System.Drawing.Size(452, 454);
            this.Name = "PersonalLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonalLogin";
            this.Load += new System.EventHandler(this.PersonalLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPersonalZimmet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.TextBox tbxPersonalId;
        private System.Windows.Forms.TextBox tbxPersonalSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwPersonalZimmet;
    }
}