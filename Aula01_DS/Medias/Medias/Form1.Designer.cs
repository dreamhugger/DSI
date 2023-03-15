
namespace Medias
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.nota1 = new System.Windows.Forms.Label();
            this.nota2 = new System.Windows.Forms.Label();
            this.media = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.eraseButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.equalsign = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(136, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(262, 87);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(422, 87);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // nota1
            // 
            this.nota1.AutoSize = true;
            this.nota1.Location = new System.Drawing.Point(136, 68);
            this.nota1.Name = "nota1";
            this.nota1.Size = new System.Drawing.Size(43, 13);
            this.nota1.TabIndex = 3;
            this.nota1.Text = "1° Nota";
            // 
            // nota2
            // 
            this.nota2.AutoSize = true;
            this.nota2.Location = new System.Drawing.Point(259, 71);
            this.nota2.Name = "nota2";
            this.nota2.Size = new System.Drawing.Size(43, 13);
            this.nota2.TabIndex = 4;
            this.nota2.Text = "2° Nota";
            // 
            // media
            // 
            this.media.AutoSize = true;
            this.media.Location = new System.Drawing.Point(419, 71);
            this.media.Name = "media";
            this.media.Size = new System.Drawing.Size(36, 13);
            this.media.TabIndex = 5;
            this.media.Text = "Média";
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(138, 164);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 6;
            this.calcButton.Text = "Calcular";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // eraseButton
            // 
            this.eraseButton.Location = new System.Drawing.Point(240, 164);
            this.eraseButton.Name = "eraseButton";
            this.eraseButton.Size = new System.Drawing.Size(75, 23);
            this.eraseButton.TabIndex = 7;
            this.eraseButton.Text = "Apagar";
            this.eraseButton.UseVisualStyleBackColor = true;
            this.eraseButton.Click += new System.EventHandler(this.eraseButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(447, 164);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Sair";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // equalsign
            // 
            this.equalsign.AutoSize = true;
            this.equalsign.Location = new System.Drawing.Point(385, 90);
            this.equalsign.Name = "equalsign";
            this.equalsign.Size = new System.Drawing.Size(13, 13);
            this.equalsign.TabIndex = 9;
            this.equalsign.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 418);
            this.Controls.Add(this.equalsign);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.eraseButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.media);
            this.Controls.Add(this.nota2);
            this.Controls.Add(this.nota1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label nota1;
        private System.Windows.Forms.Label nota2;
        private System.Windows.Forms.Label media;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button eraseButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label equalsign;
    }
}

