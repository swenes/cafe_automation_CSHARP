
namespace NtpFinallyProject
{
    partial class frmEmailKontrolGRCK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmailKontrolGRCK));
            this.btnDogrulamaKoduGonderici = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmailSifreYenileme = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdiSifreYenileme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDogrulamaKoduGonderici
            // 
            this.btnDogrulamaKoduGonderici.Font = new System.Drawing.Font("Snap ITC", 14F, System.Drawing.FontStyle.Bold);
            this.btnDogrulamaKoduGonderici.Location = new System.Drawing.Point(343, 270);
            this.btnDogrulamaKoduGonderici.Name = "btnDogrulamaKoduGonderici";
            this.btnDogrulamaKoduGonderici.Size = new System.Drawing.Size(247, 67);
            this.btnDogrulamaKoduGonderici.TabIndex = 17;
            this.btnDogrulamaKoduGonderici.Text = "DOĞRULA";
            this.btnDogrulamaKoduGonderici.UseVisualStyleBackColor = true;
            this.btnDogrulamaKoduGonderici.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Snap ITC", 19.2F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(249, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(377, 43);
            this.label5.TabIndex = 16;
            this.label5.Text = "ŞİFRE YENİLEME";
            // 
            // txtEmailSifreYenileme
            // 
            this.txtEmailSifreYenileme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEmailSifreYenileme.Location = new System.Drawing.Point(324, 207);
            this.txtEmailSifreYenileme.Name = "txtEmailSifreYenileme";
            this.txtEmailSifreYenileme.Size = new System.Drawing.Size(307, 24);
            this.txtEmailSifreYenileme.TabIndex = 15;
            this.txtEmailSifreYenileme.Tag = "";
            // 
            // txtKullaniciAdiSifreYenileme
            // 
            this.txtKullaniciAdiSifreYenileme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.txtKullaniciAdiSifreYenileme.Location = new System.Drawing.Point(324, 138);
            this.txtKullaniciAdiSifreYenileme.Name = "txtKullaniciAdiSifreYenileme";
            this.txtKullaniciAdiSifreYenileme.Size = new System.Drawing.Size(307, 24);
            this.txtKullaniciAdiSifreYenileme.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Snap ITC", 10.8F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(133, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "E-Mail Adresi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 10.8F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(142, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAnasayfa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAnasayfa.BackgroundImage")));
            this.btnAnasayfa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnasayfa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnasayfa.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnasayfa.Location = new System.Drawing.Point(772, 12);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(75, 62);
            this.btnAnasayfa.TabIndex = 186;
            this.btnAnasayfa.UseVisualStyleBackColor = false;
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click);
            // 
            // frmEmailKontrolGRCK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(859, 364);
            this.Controls.Add(this.btnAnasayfa);
            this.Controls.Add(this.btnDogrulamaKoduGonderici);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmailSifreYenileme);
            this.Controls.Add(this.txtKullaniciAdiSifreYenileme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEmailKontrolGRCK";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEmailKontrol";
            this.Load += new System.EventHandler(this.frmEmailKontrolGRCK_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDogrulamaKoduGonderici;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmailSifreYenileme;
        public System.Windows.Forms.TextBox txtKullaniciAdiSifreYenileme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnasayfa;
    }
}