namespace ZgadnijLiczbe
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtLiczba = new System.Windows.Forms.TextBox();
            this.btnSprawdz = new System.Windows.Forms.Button();
            this.lblWynik = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLiczba
            // 
            this.txtLiczba.Location = new System.Drawing.Point(64, 370);
            this.txtLiczba.Name = "txtLiczba";
            this.txtLiczba.Size = new System.Drawing.Size(100, 22);
            this.txtLiczba.TabIndex = 0;
            this.txtLiczba.Text = "txtLiczba";
            this.txtLiczba.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnSprawdz
            // 
            this.btnSprawdz.Location = new System.Drawing.Point(253, 369);
            this.btnSprawdz.Name = "btnSprawdz";
            this.btnSprawdz.Size = new System.Drawing.Size(75, 23);
            this.btnSprawdz.TabIndex = 1;
            this.btnSprawdz.Text = "Sprawdz";
            this.btnSprawdz.UseVisualStyleBackColor = true;
            this.btnSprawdz.Click += new System.EventHandler(this.btnSprawdz_Click);
            // 
            // lblWynik
            // 
            this.lblWynik.AutoSize = true;
            this.lblWynik.Location = new System.Drawing.Point(431, 373);
            this.lblWynik.Name = "lblWynik";
            this.lblWynik.Size = new System.Drawing.Size(94, 16);
            this.lblWynik.TabIndex = 2;
            this.lblWynik.Text = "Zgadnij Liczbe";
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(581, 369);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 23);
            this.btnRestart.TabIndex = 3;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblWynik);
            this.Controls.Add(this.btnSprawdz);
            this.Controls.Add(this.txtLiczba);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLiczba;
        private System.Windows.Forms.Button btnSprawdz;
        private System.Windows.Forms.Label lblWynik;
        private System.Windows.Forms.Button btnRestart;
    }
}

