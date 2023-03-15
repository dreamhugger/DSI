
namespace signos
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
            this.labelOrdem = new System.Windows.Forms.Label();
            this.DateTimeBox = new System.Windows.Forms.MaskedTextBox();
            this.buttonExibir = new System.Windows.Forms.Button();
            this.labelSigno = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelOrdem
            // 
            this.labelOrdem.AutoSize = true;
            this.labelOrdem.Location = new System.Drawing.Point(12, 9);
            this.labelOrdem.Name = "labelOrdem";
            this.labelOrdem.Size = new System.Drawing.Size(153, 13);
            this.labelOrdem.TabIndex = 0;
            this.labelOrdem.Text = "Digite sua data de nascimento:";
            // 
            // DateTimeBox
            // 
            this.DateTimeBox.Location = new System.Drawing.Point(162, 6);
            this.DateTimeBox.Mask = "00/00/0000";
            this.DateTimeBox.Name = "DateTimeBox";
            this.DateTimeBox.Size = new System.Drawing.Size(66, 20);
            this.DateTimeBox.TabIndex = 1;
            this.DateTimeBox.ValidatingType = typeof(System.DateTime);
            // 
            // buttonExibir
            // 
            this.buttonExibir.Location = new System.Drawing.Point(234, 6);
            this.buttonExibir.Name = "buttonExibir";
            this.buttonExibir.Size = new System.Drawing.Size(75, 23);
            this.buttonExibir.TabIndex = 2;
            this.buttonExibir.Text = "Exibir";
            this.buttonExibir.UseVisualStyleBackColor = true;
            this.buttonExibir.Click += new System.EventHandler(this.buttonExibir_Click);
            // 
            // labelSigno
            // 
            this.labelSigno.AutoSize = true;
            this.labelSigno.Location = new System.Drawing.Point(12, 34);
            this.labelSigno.Name = "labelSigno";
            this.labelSigno.Size = new System.Drawing.Size(0, 13);
            this.labelSigno.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 97);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(234, 35);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpar.TabIndex = 5;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 160);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelSigno);
            this.Controls.Add(this.buttonExibir);
            this.Controls.Add(this.DateTimeBox);
            this.Controls.Add(this.labelOrdem);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOrdem;
        private System.Windows.Forms.MaskedTextBox DateTimeBox;
        private System.Windows.Forms.Button buttonExibir;
        private System.Windows.Forms.Label labelSigno;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonLimpar;
    }
}

