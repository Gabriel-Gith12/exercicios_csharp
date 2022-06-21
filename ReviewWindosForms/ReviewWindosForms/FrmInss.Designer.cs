
namespace ReviewWindosForms
{
    partial class FrmInss
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
            this.txtDescProduto = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.Inss = new System.Windows.Forms.ListBox();
            this.lblInss = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDescProduto
            // 
            this.txtDescProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescProduto.Location = new System.Drawing.Point(10, 58);
            this.txtDescProduto.Name = "txtDescProduto";
            this.txtDescProduto.Size = new System.Drawing.Size(204, 24);
            this.txtDescProduto.TabIndex = 19;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionar.Location = new System.Drawing.Point(222, 55);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(107, 27);
            this.btnAdicionar.TabIndex = 20;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // Inss
            // 
            this.Inss.FormattingEnabled = true;
            this.Inss.Location = new System.Drawing.Point(10, 99);
            this.Inss.Name = "Inss";
            this.Inss.Size = new System.Drawing.Size(319, 342);
            this.Inss.TabIndex = 21;
            // 
            // lblInss
            // 
            this.lblInss.AutoSize = true;
            this.lblInss.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInss.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblInss.Location = new System.Drawing.Point(7, 24);
            this.lblInss.Name = "lblInss";
            this.lblInss.Size = new System.Drawing.Size(35, 18);
            this.lblInss.TabIndex = 22;
            this.lblInss.Text = "Inss";
            // 
            // FrmInss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 450);
            this.Controls.Add(this.lblInss);
            this.Controls.Add(this.Inss);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtDescProduto);
            this.Name = "FrmInss";
            this.Text = "Inss";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescProduto;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ListBox Inss;
        private System.Windows.Forms.Label lblInss;
    }
}