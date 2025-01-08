namespace Otel
{
    partial class YoneticiKayıt
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtbilsi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtkula = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(271, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Şifre:";
            // 
            // txtbilsi
            // 
            this.txtbilsi.Location = new System.Drawing.Point(353, 217);
            this.txtbilsi.Name = "txtbilsi";
            this.txtbilsi.Size = new System.Drawing.Size(146, 22);
            this.txtbilsi.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(208, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Kullanıcı Adı:";
            // 
            // txtkula
            // 
            this.txtkula.Location = new System.Drawing.Point(353, 166);
            this.txtkula.Name = "txtkula";
            this.txtkula.Size = new System.Drawing.Size(146, 22);
            this.txtkula.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(367, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 46);
            this.button1.TabIndex = 12;
            this.button1.Text = "Üye Ol";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // YoneticiKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 511);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtkula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbilsi);
            this.Name = "YoneticiKayıt";
            this.Text = "MusteriKayıt";
            this.Load += new System.EventHandler(this.MusteriKayıt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbilsi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtkula;
        private System.Windows.Forms.Button button1;
    }
}