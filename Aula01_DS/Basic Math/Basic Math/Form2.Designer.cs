
namespace Basic_Math
{
    partial class Form2
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
            this.AlertButton = new System.Windows.Forms.Button();
            this.Pergunta2 = new System.Windows.Forms.Button();
            this.QuestionButton = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AlertButton
            // 
            this.AlertButton.Location = new System.Drawing.Point(35, 173);
            this.AlertButton.Name = "AlertButton";
            this.AlertButton.Size = new System.Drawing.Size(75, 23);
            this.AlertButton.TabIndex = 0;
            this.AlertButton.Text = "Exemplo 1";
            this.AlertButton.UseVisualStyleBackColor = true;
            this.AlertButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pergunta2
            // 
            this.Pergunta2.Location = new System.Drawing.Point(239, 173);
            this.Pergunta2.Name = "Pergunta2";
            this.Pergunta2.Size = new System.Drawing.Size(75, 23);
            this.Pergunta2.TabIndex = 1;
            this.Pergunta2.Text = "Exemplo 3";
            this.Pergunta2.UseVisualStyleBackColor = true;
            this.Pergunta2.Click += new System.EventHandler(this.Pergunta2_Click);
            // 
            // QuestionButton
            // 
            this.QuestionButton.Location = new System.Drawing.Point(137, 173);
            this.QuestionButton.Name = "QuestionButton";
            this.QuestionButton.Size = new System.Drawing.Size(75, 23);
            this.QuestionButton.TabIndex = 2;
            this.QuestionButton.Text = "Exemplo 2";
            this.QuestionButton.UseVisualStyleBackColor = true;
            this.QuestionButton.Click += new System.EventHandler(this.QuestionButton_Click);
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(30, 56);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(298, 29);
            this.Title.TabIndex = 3;
            this.Title.Text = "Exemplo de message box.";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 244);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.QuestionButton);
            this.Controls.Add(this.Pergunta2);
            this.Controls.Add(this.AlertButton);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AlertButton;
        private System.Windows.Forms.Button Pergunta2;
        private System.Windows.Forms.Button QuestionButton;
        private System.Windows.Forms.Label Title;
    }
}