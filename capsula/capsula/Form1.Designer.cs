
namespace capsula
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
            this.rbEspecial = new System.Windows.Forms.RadioButton();
            this.rbPoupanca = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.btnSacar = new System.Windows.Forms.Button();
            this.lblSaldoCE = new System.Windows.Forms.Label();
            this.lblSaldoCP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbEspecial
            // 
            this.rbEspecial.AutoSize = true;
            this.rbEspecial.Location = new System.Drawing.Point(12, 12);
            this.rbEspecial.Name = "rbEspecial";
            this.rbEspecial.Size = new System.Drawing.Size(96, 17);
            this.rbEspecial.TabIndex = 0;
            this.rbEspecial.TabStop = true;
            this.rbEspecial.Text = "Conta Especial";
            this.rbEspecial.UseVisualStyleBackColor = true;
            // 
            // rbPoupanca
            // 
            this.rbPoupanca.AutoSize = true;
            this.rbPoupanca.Location = new System.Drawing.Point(114, 12);
            this.rbPoupanca.Name = "rbPoupanca";
            this.rbPoupanca.Size = new System.Drawing.Size(105, 17);
            this.rbPoupanca.TabIndex = 1;
            this.rbPoupanca.TabStop = true;
            this.rbPoupanca.Text = "Conta Poupança";
            this.rbPoupanca.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btnDepositar
            // 
            this.btnDepositar.Location = new System.Drawing.Point(12, 63);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(75, 23);
            this.btnDepositar.TabIndex = 3;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(114, 62);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(75, 23);
            this.btnSacar.TabIndex = 4;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // lblSaldoCE
            // 
            this.lblSaldoCE.AutoSize = true;
            this.lblSaldoCE.Location = new System.Drawing.Point(12, 93);
            this.lblSaldoCE.Name = "lblSaldoCE";
            this.lblSaldoCE.Size = new System.Drawing.Size(51, 13);
            this.lblSaldoCE.TabIndex = 5;
            this.lblSaldoCE.Text = "SaldoCE:";
            // 
            // lblSaldoCP
            // 
            this.lblSaldoCP.AutoSize = true;
            this.lblSaldoCP.Location = new System.Drawing.Point(114, 92);
            this.lblSaldoCP.Name = "lblSaldoCP";
            this.lblSaldoCP.Size = new System.Drawing.Size(51, 13);
            this.lblSaldoCP.TabIndex = 6;
            this.lblSaldoCP.Text = "SaldoCP:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 120);
            this.Controls.Add(this.lblSaldoCP);
            this.Controls.Add(this.lblSaldoCE);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.btnDepositar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rbPoupanca);
            this.Controls.Add(this.rbEspecial);
            this.Name = "Form1";
            this.Text = "Conta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbEspecial;
        private System.Windows.Forms.RadioButton rbPoupanca;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Label lblSaldoCE;
        private System.Windows.Forms.Label lblSaldoCP;
    }
}

