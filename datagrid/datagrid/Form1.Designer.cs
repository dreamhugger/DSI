
namespace datagrid
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.textProduto = new System.Windows.Forms.TextBox();
            this.textValor = new System.Windows.Forms.TextBox();
            this.textQtd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.ColumnProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produto";
            // 
            // textProduto
            // 
            this.textProduto.Location = new System.Drawing.Point(15, 30);
            this.textProduto.Name = "textProduto";
            this.textProduto.Size = new System.Drawing.Size(100, 20);
            this.textProduto.TabIndex = 1;
            // 
            // textValor
            // 
            this.textValor.Location = new System.Drawing.Point(137, 30);
            this.textValor.Name = "textValor";
            this.textValor.Size = new System.Drawing.Size(100, 20);
            this.textValor.TabIndex = 2;
            // 
            // textQtd
            // 
            this.textQtd.Location = new System.Drawing.Point(255, 30);
            this.textQtd.Name = "textQtd";
            this.textQtd.Size = new System.Drawing.Size(100, 20);
            this.textQtd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor Unitário";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantidade";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(381, 27);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Adicionar";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnProduto,
            this.ColumnValor,
            this.ColumnQtd,
            this.ColumnTotal});
            this.dataGridView1.Location = new System.Drawing.Point(12, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 183);
            this.dataGridView1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total";
            // 
            // textTotal
            // 
            this.textTotal.Location = new System.Drawing.Point(356, 244);
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(100, 20);
            this.textTotal.TabIndex = 9;
            // 
            // ColumnProduto
            // 
            this.ColumnProduto.HeaderText = "Produto";
            this.ColumnProduto.Name = "ColumnProduto";
            this.ColumnProduto.ReadOnly = true;
            // 
            // ColumnValor
            // 
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.ColumnValor.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColumnValor.HeaderText = "Valor Unitário";
            this.ColumnValor.Name = "ColumnValor";
            this.ColumnValor.ReadOnly = true;
            // 
            // ColumnQtd
            // 
            this.ColumnQtd.HeaderText = "Quantidade";
            this.ColumnQtd.Name = "ColumnQtd";
            this.ColumnQtd.ReadOnly = true;
            // 
            // ColumnTotal
            // 
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.ColumnTotal.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnTotal.HeaderText = "Total";
            this.ColumnTotal.Name = "ColumnTotal";
            this.ColumnTotal.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 276);
            this.Controls.Add(this.textTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textQtd);
            this.Controls.Add(this.textValor);
            this.Controls.Add(this.textProduto);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Pedido";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textProduto;
        private System.Windows.Forms.TextBox textValor;
        private System.Windows.Forms.TextBox textQtd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTotal;
    }
}

