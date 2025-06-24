namespace Projekt
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
            this.lblHaslo = new System.Windows.Forms.Label();
            this.lblZycia = new System.Windows.Forms.Label();
            this.txtLitera = new System.Windows.Forms.TextBox();
            this.btnSprawdz = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblBledy = new System.Windows.Forms.Label();
            this.lblKoniecGry = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHaslo
            // 
            this.lblHaslo.AutoSize = true;
            this.lblHaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHaslo.Location = new System.Drawing.Point(273, 211);
            this.lblHaslo.Name = "lblHaslo";
            this.lblHaslo.Size = new System.Drawing.Size(64, 25);
            this.lblHaslo.TabIndex = 0;
            this.lblHaslo.Text = "label1";
            this.lblHaslo.Click += new System.EventHandler(this.lblHaslo_Click);
            // 
            // lblZycia
            // 
            this.lblZycia.AutoSize = true;
            this.lblZycia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblZycia.Location = new System.Drawing.Point(525, 107);
            this.lblZycia.Name = "lblZycia";
            this.lblZycia.Size = new System.Drawing.Size(64, 25);
            this.lblZycia.TabIndex = 1;
            this.lblZycia.Text = "label2";
            // 
            // txtLitera
            // 
            this.txtLitera.Location = new System.Drawing.Point(295, 251);
            this.txtLitera.Name = "txtLitera";
            this.txtLitera.Size = new System.Drawing.Size(177, 20);
            this.txtLitera.TabIndex = 2;
            // 
            // btnSprawdz
            // 
            this.btnSprawdz.Location = new System.Drawing.Point(259, 293);
            this.btnSprawdz.Name = "btnSprawdz";
            this.btnSprawdz.Size = new System.Drawing.Size(254, 59);
            this.btnSprawdz.TabIndex = 3;
            this.btnSprawdz.Text = "Sprawdź ";
            this.btnSprawdz.UseVisualStyleBackColor = true;
            this.btnSprawdz.Click += new System.EventHandler(this.btnSprawdz_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblInfo.Location = new System.Drawing.Point(308, 107);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(64, 25);
            this.lblInfo.TabIndex = 4;
            this.lblInfo.Text = "label3";
            // 
            // lblBledy
            // 
            this.lblBledy.AutoSize = true;
            this.lblBledy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBledy.Location = new System.Drawing.Point(71, 396);
            this.lblBledy.Name = "lblBledy";
            this.lblBledy.Size = new System.Drawing.Size(64, 25);
            this.lblBledy.TabIndex = 5;
            this.lblBledy.Text = "label1";
            // 
            // lblKoniecGry
            // 
            this.lblKoniecGry.AutoSize = true;
            this.lblKoniecGry.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKoniecGry.Location = new System.Drawing.Point(211, 199);
            this.lblKoniecGry.Name = "lblKoniecGry";
            this.lblKoniecGry.Size = new System.Drawing.Size(100, 37);
            this.lblKoniecGry.TabIndex = 6;
            this.lblKoniecGry.Text = "label1";
            this.lblKoniecGry.Click += new System.EventHandler(this.lblKoniecGry_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblKoniecGry);
            this.Controls.Add(this.lblBledy);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnSprawdz);
            this.Controls.Add(this.txtLitera);
            this.Controls.Add(this.lblZycia);
            this.Controls.Add(this.lblHaslo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHaslo;
        private System.Windows.Forms.Label lblZycia;
        private System.Windows.Forms.TextBox txtLitera;
        private System.Windows.Forms.Button btnSprawdz;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblBledy;
        private System.Windows.Forms.Label lblKoniecGry;
    }
}

