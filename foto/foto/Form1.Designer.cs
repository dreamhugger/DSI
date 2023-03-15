
namespace foto
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.checkBoxVisivel = new System.Windows.Forms.CheckBox();
            this.radioButtonSNES = new System.Windows.Forms.RadioButton();
            this.radioButtonGenesis = new System.Windows.Forms.RadioButton();
            this.radioButtonNone = new System.Windows.Forms.RadioButton();
            this.radioButtonNoB = new System.Windows.Forms.RadioButton();
            this.radioButton2DB = new System.Windows.Forms.RadioButton();
            this.radioButton3DB = new System.Windows.Forms.RadioButton();
            this.groupBoxImage = new System.Windows.Forms.GroupBox();
            this.groupBoxB = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBoxImage.SuspendLayout();
            this.groupBoxB.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(697, 469);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // checkBoxVisivel
            // 
            this.checkBoxVisivel.AutoSize = true;
            this.checkBoxVisivel.Location = new System.Drawing.Point(211, 487);
            this.checkBoxVisivel.Name = "checkBoxVisivel";
            this.checkBoxVisivel.Size = new System.Drawing.Size(109, 17);
            this.checkBoxVisivel.TabIndex = 3;
            this.checkBoxVisivel.Text = "Visível / Invisível";
            this.checkBoxVisivel.UseVisualStyleBackColor = true;
            this.checkBoxVisivel.CheckedChanged += new System.EventHandler(this.checkBoxVisivel_CheckedChanged);
            // 
            // radioButtonSNES
            // 
            this.radioButtonSNES.AutoSize = true;
            this.radioButtonSNES.Location = new System.Drawing.Point(17, 19);
            this.radioButtonSNES.Name = "radioButtonSNES";
            this.radioButtonSNES.Size = new System.Drawing.Size(54, 17);
            this.radioButtonSNES.TabIndex = 4;
            this.radioButtonSNES.TabStop = true;
            this.radioButtonSNES.Text = "SNES";
            this.radioButtonSNES.UseVisualStyleBackColor = true;
            this.radioButtonSNES.CheckedChanged += new System.EventHandler(this.radioButtonSNES_CheckedChanged);
            // 
            // radioButtonGenesis
            // 
            this.radioButtonGenesis.AutoSize = true;
            this.radioButtonGenesis.Location = new System.Drawing.Point(17, 42);
            this.radioButtonGenesis.Name = "radioButtonGenesis";
            this.radioButtonGenesis.Size = new System.Drawing.Size(63, 17);
            this.radioButtonGenesis.TabIndex = 4;
            this.radioButtonGenesis.TabStop = true;
            this.radioButtonGenesis.Text = "Genesis";
            this.radioButtonGenesis.UseVisualStyleBackColor = true;
            this.radioButtonGenesis.CheckedChanged += new System.EventHandler(this.radioButtonGenesis_CheckedChanged);
            // 
            // radioButtonNone
            // 
            this.radioButtonNone.AutoSize = true;
            this.radioButtonNone.Location = new System.Drawing.Point(17, 65);
            this.radioButtonNone.Name = "radioButtonNone";
            this.radioButtonNone.Size = new System.Drawing.Size(65, 17);
            this.radioButtonNone.TabIndex = 4;
            this.radioButtonNone.TabStop = true;
            this.radioButtonNone.Text = "Nenhum";
            this.radioButtonNone.UseVisualStyleBackColor = true;
            this.radioButtonNone.CheckedChanged += new System.EventHandler(this.radioButtonNone_CheckedChanged);
            // 
            // radioButtonNoB
            // 
            this.radioButtonNoB.AutoSize = true;
            this.radioButtonNoB.Location = new System.Drawing.Point(9, 19);
            this.radioButtonNoB.Name = "radioButtonNoB";
            this.radioButtonNoB.Size = new System.Drawing.Size(76, 17);
            this.radioButtonNoB.TabIndex = 4;
            this.radioButtonNoB.TabStop = true;
            this.radioButtonNoB.Text = "Sem borda";
            this.radioButtonNoB.UseVisualStyleBackColor = true;
            this.radioButtonNoB.CheckedChanged += new System.EventHandler(this.radioButtonNoB_CheckedChanged);
            // 
            // radioButton2DB
            // 
            this.radioButton2DB.AutoSize = true;
            this.radioButton2DB.Location = new System.Drawing.Point(9, 42);
            this.radioButton2DB.Name = "radioButton2DB";
            this.radioButton2DB.Size = new System.Drawing.Size(70, 17);
            this.radioButton2DB.TabIndex = 4;
            this.radioButton2DB.TabStop = true;
            this.radioButton2DB.Text = "Borda 2D";
            this.radioButton2DB.UseVisualStyleBackColor = true;
            this.radioButton2DB.CheckedChanged += new System.EventHandler(this.radioButton2DB_CheckedChanged);
            // 
            // radioButton3DB
            // 
            this.radioButton3DB.AutoSize = true;
            this.radioButton3DB.Location = new System.Drawing.Point(9, 65);
            this.radioButton3DB.Name = "radioButton3DB";
            this.radioButton3DB.Size = new System.Drawing.Size(70, 17);
            this.radioButton3DB.TabIndex = 4;
            this.radioButton3DB.TabStop = true;
            this.radioButton3DB.Text = "Borda 3D";
            this.radioButton3DB.UseVisualStyleBackColor = true;
            this.radioButton3DB.CheckedChanged += new System.EventHandler(this.radioButton3DB_CheckedChanged);
            // 
            // groupBoxImage
            // 
            this.groupBoxImage.Controls.Add(this.radioButtonSNES);
            this.groupBoxImage.Controls.Add(this.radioButtonGenesis);
            this.groupBoxImage.Controls.Add(this.radioButtonNone);
            this.groupBoxImage.Location = new System.Drawing.Point(18, 487);
            this.groupBoxImage.Name = "groupBoxImage";
            this.groupBoxImage.Size = new System.Drawing.Size(85, 95);
            this.groupBoxImage.TabIndex = 5;
            this.groupBoxImage.TabStop = false;
            this.groupBoxImage.Text = "Imagem";
            // 
            // groupBoxB
            // 
            this.groupBoxB.Controls.Add(this.radioButtonNoB);
            this.groupBoxB.Controls.Add(this.radioButton2DB);
            this.groupBoxB.Controls.Add(this.radioButton3DB);
            this.groupBoxB.Location = new System.Drawing.Point(120, 487);
            this.groupBoxB.Name = "groupBoxB";
            this.groupBoxB.Size = new System.Drawing.Size(85, 95);
            this.groupBoxB.TabIndex = 5;
            this.groupBoxB.TabStop = false;
            this.groupBoxB.Text = "Borda";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 597);
            this.Controls.Add(this.groupBoxB);
            this.Controls.Add(this.groupBoxImage);
            this.Controls.Add(this.checkBoxVisivel);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBoxImage.ResumeLayout(false);
            this.groupBoxImage.PerformLayout();
            this.groupBoxB.ResumeLayout(false);
            this.groupBoxB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.CheckBox checkBoxVisivel;
        private System.Windows.Forms.RadioButton radioButtonSNES;
        private System.Windows.Forms.RadioButton radioButtonGenesis;
        private System.Windows.Forms.RadioButton radioButtonNone;
        private System.Windows.Forms.RadioButton radioButtonNoB;
        private System.Windows.Forms.RadioButton radioButton2DB;
        private System.Windows.Forms.RadioButton radioButton3DB;
        private System.Windows.Forms.GroupBox groupBoxImage;
        private System.Windows.Forms.GroupBox groupBoxB;
    }
}

