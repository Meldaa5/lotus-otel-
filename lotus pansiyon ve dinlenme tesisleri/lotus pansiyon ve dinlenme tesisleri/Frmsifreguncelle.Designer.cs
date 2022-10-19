
namespace lotus_pansiyon_ve_dinlenme_tesisleri
{
    partial class Frmsifreguncelle
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxbaslik = new System.Windows.Forms.TextBox();
            this.textBoxmail = new System.Windows.Forms.TextBox();
            this.textBoxkonu = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(92, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mail :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(80, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Başlık :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(84, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Konu :";
            // 
            // textBoxbaslik
            // 
            this.textBoxbaslik.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxbaslik.Location = new System.Drawing.Point(163, 123);
            this.textBoxbaslik.Name = "textBoxbaslik";
            this.textBoxbaslik.Size = new System.Drawing.Size(291, 30);
            this.textBoxbaslik.TabIndex = 3;
            // 
            // textBoxmail
            // 
            this.textBoxmail.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxmail.Location = new System.Drawing.Point(163, 75);
            this.textBoxmail.Name = "textBoxmail";
            this.textBoxmail.Size = new System.Drawing.Size(178, 30);
            this.textBoxmail.TabIndex = 4;
            // 
            // textBoxkonu
            // 
            this.textBoxkonu.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxkonu.Location = new System.Drawing.Point(163, 177);
            this.textBoxkonu.Multiline = true;
            this.textBoxkonu.Name = "textBoxkonu";
            this.textBoxkonu.Size = new System.Drawing.Size(291, 185);
            this.textBoxkonu.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(234, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "Mail gönder";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(55, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(718, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Şifrenizi mi unuttunuz ! merak etmeyin size hesabınıza tekrar erişebileniz için b" +
    "ir bağlantı göndereceğiz.";
            // 
            // Frmsifreguncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxkonu);
            this.Controls.Add(this.textBoxmail);
            this.Controls.Add(this.textBoxbaslik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frmsifreguncelle";
            this.Text = "Frmsifreguncelle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxbaslik;
        private System.Windows.Forms.TextBox textBoxmail;
        private System.Windows.Forms.TextBox textBoxkonu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}