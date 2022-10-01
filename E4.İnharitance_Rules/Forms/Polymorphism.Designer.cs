namespace E4.İnharitance_Rules.Forms
{
    partial class Polymorphism
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
            this.btnİnsan = new System.Windows.Forms.Button();
            this.btnHayvan = new System.Windows.Forms.Button();
            this.btnBitki = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnİnsan
            // 
            this.btnİnsan.Location = new System.Drawing.Point(92, 159);
            this.btnİnsan.Name = "btnİnsan";
            this.btnİnsan.Size = new System.Drawing.Size(147, 80);
            this.btnİnsan.TabIndex = 0;
            this.btnİnsan.Text = "İnsan";
            this.btnİnsan.UseVisualStyleBackColor = true;
            this.btnİnsan.Click += new System.EventHandler(this.btnİnsan_Click);
            // 
            // btnHayvan
            // 
            this.btnHayvan.Location = new System.Drawing.Point(333, 159);
            this.btnHayvan.Name = "btnHayvan";
            this.btnHayvan.Size = new System.Drawing.Size(147, 80);
            this.btnHayvan.TabIndex = 0;
            this.btnHayvan.Text = "Hayvan";
            this.btnHayvan.UseVisualStyleBackColor = true;
            this.btnHayvan.Click += new System.EventHandler(this.btnHayvan_Click);
            // 
            // btnBitki
            // 
            this.btnBitki.Location = new System.Drawing.Point(551, 159);
            this.btnBitki.Name = "btnBitki";
            this.btnBitki.Size = new System.Drawing.Size(147, 80);
            this.btnBitki.TabIndex = 0;
            this.btnBitki.Text = "Bitki";
            this.btnBitki.UseVisualStyleBackColor = true;
            this.btnBitki.Click += new System.EventHandler(this.btnBitki_Click);
            // 
            // Polymorphism
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBitki);
            this.Controls.Add(this.btnHayvan);
            this.Controls.Add(this.btnİnsan);
            this.Name = "Polymorphism";
            this.Text = "Polymorphism";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnİnsan;
        private System.Windows.Forms.Button btnHayvan;
        private System.Windows.Forms.Button btnBitki;
    }
}