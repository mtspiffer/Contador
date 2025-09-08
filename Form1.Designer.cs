namespace Contador
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAumentar = new System.Windows.Forms.Button();
            this.btnDiminuir = new System.Windows.Forms.Button();
            this.lblContador = new System.Windows.Forms.Label();
            this.btnZerar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAumentar
            // 
            this.btnAumentar.Location = new System.Drawing.Point(132, 186);
            this.btnAumentar.Name = "btnAumentar";
            this.btnAumentar.Size = new System.Drawing.Size(75, 23);
            this.btnAumentar.TabIndex = 0;
            this.btnAumentar.Text = "Aumentar";
            this.btnAumentar.UseVisualStyleBackColor = true;
            this.btnAumentar.Click += new System.EventHandler(this.btnAumentar_Click);
            // 
            // btnDiminuir
            // 
            this.btnDiminuir.Location = new System.Drawing.Point(584, 186);
            this.btnDiminuir.Name = "btnDiminuir";
            this.btnDiminuir.Size = new System.Drawing.Size(75, 23);
            this.btnDiminuir.TabIndex = 1;
            this.btnDiminuir.Text = "Diminuir";
            this.btnDiminuir.UseVisualStyleBackColor = true;
            this.btnDiminuir.Click += new System.EventHandler(this.btnDiminuir_Click);
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Location = new System.Drawing.Point(375, 186);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(13, 13);
            this.lblContador.TabIndex = 2;
            this.lblContador.Text = "0";
            // 
            // btnZerar
            // 
            this.btnZerar.Location = new System.Drawing.Point(345, 318);
            this.btnZerar.Name = "btnZerar";
            this.btnZerar.Size = new System.Drawing.Size(75, 23);
            this.btnZerar.TabIndex = 3;
            this.btnZerar.Text = "Zerar";
            this.btnZerar.UseVisualStyleBackColor = true;
            this.btnZerar.Click += new System.EventHandler(this.btnZerar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnZerar);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.btnDiminuir);
            this.Controls.Add(this.btnAumentar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAumentar;
        private System.Windows.Forms.Button btnDiminuir;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Button btnZerar;
    }
}

