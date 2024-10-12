namespace HangMan
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblAdam = new System.Windows.Forms.Label();
            this.txtGirilenHarf = new System.Windows.Forms.TextBox();
            this.btnHarfAl = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.lstCikanHarf = new System.Windows.Forms.ListBox();
            this.lblSayac = new System.Windows.Forms.Label();
            this.lblSifreliSehir = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAdam
            // 
            this.lblAdam.AutoSize = true;
            this.lblAdam.Image = ((System.Drawing.Image)(resources.GetObject("lblAdam.Image")));
            this.lblAdam.Location = new System.Drawing.Point(28, 29);
            this.lblAdam.MaximumSize = new System.Drawing.Size(150, 150);
            this.lblAdam.MinimumSize = new System.Drawing.Size(200, 350);
            this.lblAdam.Name = "lblAdam";
            this.lblAdam.Size = new System.Drawing.Size(200, 350);
            this.lblAdam.TabIndex = 1;
            // 
            // txtGirilenHarf
            // 
            this.txtGirilenHarf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGirilenHarf.Location = new System.Drawing.Point(345, 94);
            this.txtGirilenHarf.MinimumSize = new System.Drawing.Size(200, 4);
            this.txtGirilenHarf.Name = "txtGirilenHarf";
            this.txtGirilenHarf.Size = new System.Drawing.Size(200, 27);
            this.txtGirilenHarf.TabIndex = 7;
            this.txtGirilenHarf.TextChanged += new System.EventHandler(this.txtGirilenHarf_TextChanged);
            // 
            // btnHarfAl
            // 
            this.btnHarfAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHarfAl.Location = new System.Drawing.Point(609, 90);
            this.btnHarfAl.MinimumSize = new System.Drawing.Size(80, 40);
            this.btnHarfAl.Name = "btnHarfAl";
            this.btnHarfAl.Size = new System.Drawing.Size(80, 59);
            this.btnHarfAl.TabIndex = 8;
            this.btnHarfAl.Text = "Harf Al";
            this.btnHarfAl.UseVisualStyleBackColor = true;
            this.btnHarfAl.Click += new System.EventHandler(this.btnHarfAl_Click_1);
            // 
            // btnRestart
            // 
            this.btnRestart.Image = ((System.Drawing.Image)(resources.GetObject("btnRestart.Image")));
            this.btnRestart.Location = new System.Drawing.Point(695, 90);
            this.btnRestart.MinimumSize = new System.Drawing.Size(80, 40);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(80, 58);
            this.btnRestart.TabIndex = 9;
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click_1);
            // 
            // lstCikanHarf
            // 
            this.lstCikanHarf.BackColor = System.Drawing.Color.Salmon;
            this.lstCikanHarf.FormattingEnabled = true;
            this.lstCikanHarf.ItemHeight = 16;
            this.lstCikanHarf.Location = new System.Drawing.Point(647, 215);
            this.lstCikanHarf.Name = "lstCikanHarf";
            this.lstCikanHarf.Size = new System.Drawing.Size(251, 164);
            this.lstCikanHarf.TabIndex = 10;
            // 
            // lblSayac
            // 
            this.lblSayac.AutoSize = true;
            this.lblSayac.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayac.Location = new System.Drawing.Point(437, 292);
            this.lblSayac.Name = "lblSayac";
            this.lblSayac.Size = new System.Drawing.Size(55, 38);
            this.lblSayac.TabIndex = 11;
            this.lblSayac.Text = "10";
            // 
            // lblSifreliSehir
            // 
            this.lblSifreliSehir.AutoSize = true;
            this.lblSifreliSehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifreliSehir.Location = new System.Drawing.Point(286, 406);
            this.lblSifreliSehir.MinimumSize = new System.Drawing.Size(300, 30);
            this.lblSifreliSehir.Name = "lblSifreliSehir";
            this.lblSifreliSehir.Size = new System.Drawing.Size(300, 69);
            this.lblSifreliSehir.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(1003, 531);
            this.Controls.Add(this.lblSifreliSehir);
            this.Controls.Add(this.lblSayac);
            this.Controls.Add(this.lstCikanHarf);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnHarfAl);
            this.Controls.Add(this.txtGirilenHarf);
            this.Controls.Add(this.lblAdam);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdam;
        private System.Windows.Forms.TextBox txtGirilenHarf;
        private System.Windows.Forms.Button btnHarfAl;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.ListBox lstCikanHarf;
        private System.Windows.Forms.Label lblSayac;
        private System.Windows.Forms.Label lblSifreliSehir;
    }
}

