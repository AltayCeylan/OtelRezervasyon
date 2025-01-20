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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiKayıt));
            this.label2 = new System.Windows.Forms.Label();
            this.txtbilsi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtkula = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnalta = new System.Windows.Forms.Button();
            this.btncıkıs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(271, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Şifre:";
            // 
            // txtbilsi
            // 
            this.txtbilsi.Location = new System.Drawing.Point(340, 193);
            this.txtbilsi.Name = "txtbilsi";
            this.txtbilsi.Size = new System.Drawing.Size(157, 22);
            this.txtbilsi.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(212, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 28);
            this.label4.TabIndex = 11;
            this.label4.Text = "Kullanıcı Adı:";
            // 
            // txtkula
            // 
            this.txtkula.Location = new System.Drawing.Point(340, 142);
            this.txtkula.Name = "txtkula";
            this.txtkula.Size = new System.Drawing.Size(157, 22);
            this.txtkula.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(360, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 46);
            this.button1.TabIndex = 12;
            this.button1.Text = "Üye Ol";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnalta
            // 
            this.btnalta.BackColor = System.Drawing.Color.White;
            this.btnalta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnalta.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnalta.Location = new System.Drawing.Point(609, 2);
            this.btnalta.Name = "btnalta";
            this.btnalta.Size = new System.Drawing.Size(73, 36);
            this.btnalta.TabIndex = 28;
            this.btnalta.Text = "---";
            this.btnalta.UseVisualStyleBackColor = false;
            this.btnalta.Click += new System.EventHandler(this.btnalta_Click);
            this.btnalta.MouseLeave += new System.EventHandler(this.btnalta_MouseLeave);
            this.btnalta.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnalta_MouseMove);
            // 
            // btncıkıs
            // 
            this.btncıkıs.BackColor = System.Drawing.Color.White;
            this.btncıkıs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncıkıs.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncıkıs.Location = new System.Drawing.Point(688, 2);
            this.btncıkıs.Name = "btncıkıs";
            this.btncıkıs.Size = new System.Drawing.Size(78, 36);
            this.btncıkıs.TabIndex = 27;
            this.btncıkıs.Text = "X";
            this.btncıkıs.UseVisualStyleBackColor = false;
            this.btncıkıs.Click += new System.EventHandler(this.btncıkıs_Click);
            this.btncıkıs.MouseLeave += new System.EventHandler(this.btncıkıs_MouseLeave);
            this.btncıkıs.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btncıkıs_MouseMove);
            // 
            // YoneticiKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(775, 429);
            this.Controls.Add(this.btnalta);
            this.Controls.Add(this.btncıkıs);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtkula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbilsi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Button btnalta;
        private System.Windows.Forms.Button btncıkıs;
    }
}