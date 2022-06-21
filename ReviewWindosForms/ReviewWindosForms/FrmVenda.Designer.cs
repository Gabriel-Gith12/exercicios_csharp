
namespace ReviewWindosForms
{
    partial class FrmVenda
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Bolacha",
            "6,50"}, -1);
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtDescProduto = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lvlVeiculos = new System.Windows.Forms.ListView();
            this.clhProduto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhPreco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblProduto.Location = new System.Drawing.Point(12, 19);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(61, 18);
            this.lblProduto.TabIndex = 0;
            this.lblProduto.Text = "Produto";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPreco.Location = new System.Drawing.Point(12, 83);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(48, 18);
            this.lblPreco.TabIndex = 1;
            this.lblPreco.Text = "Preço";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(572, 369);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(107, 27);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar Vendas";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionar.Location = new System.Drawing.Point(572, 47);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(107, 27);
            this.btnAdicionar.TabIndex = 3;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // txtDescProduto
            // 
            this.txtDescProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescProduto.Location = new System.Drawing.Point(15, 47);
            this.txtDescProduto.Name = "txtDescProduto";
            this.txtDescProduto.Size = new System.Drawing.Size(551, 24);
            this.txtDescProduto.TabIndex = 4;
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(12, 113);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(332, 24);
            this.txtValor.TabIndex = 5;
            // 
            // lvlVeiculos
            // 
            this.lvlVeiculos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhProduto,
            this.clhPreco});
            this.lvlVeiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlVeiculos.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lvlVeiculos.FullRowSelect = true;
            this.lvlVeiculos.GridLines = true;
            this.lvlVeiculos.HideSelection = false;
            this.lvlVeiculos.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.lvlVeiculos.Location = new System.Drawing.Point(12, 160);
            this.lvlVeiculos.MultiSelect = false;
            this.lvlVeiculos.Name = "lvlVeiculos";
            this.lvlVeiculos.Size = new System.Drawing.Size(667, 190);
            this.lvlVeiculos.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvlVeiculos.TabIndex = 13;
            this.lvlVeiculos.UseCompatibleStateImageBehavior = false;
            this.lvlVeiculos.View = System.Windows.Forms.View.Details;
            // 
            // clhProduto
            // 
            this.clhProduto.Text = "Produto";
            this.clhProduto.Width = 149;
            // 
            // clhPreco
            // 
            this.clhPreco.Text = "Preço";
            this.clhPreco.Width = 172;
            // 
            // FrmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 408);
            this.Controls.Add(this.lvlVeiculos);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtDescProduto);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblProduto);
            this.Name = "FrmVenda";
            this.Text = "Venda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox txtDescProduto;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.ListView lvlVeiculos;
        private System.Windows.Forms.ColumnHeader clhProduto;
        private System.Windows.Forms.ColumnHeader clhPreco;
    }
}