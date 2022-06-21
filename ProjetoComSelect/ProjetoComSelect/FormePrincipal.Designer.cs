
namespace ProjetoComSelect
{
    partial class FormePrincipal
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
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.groupBoxConsulta = new System.Windows.Forms.GroupBox();
            this.groupBoxInclusão = new System.Windows.Forms.GroupBox();
            this.textBoxInserir = new System.Windows.Forms.TextBox();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.groupBoxAlteraçao = new System.Windows.Forms.GroupBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.groupBoxExclusão = new System.Windows.Forms.GroupBox();
            this.textBoxExclusão = new System.Windows.Forms.TextBox();
            this.textBoxExcluir = new System.Windows.Forms.TextBox();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.textBoxIdConsulta = new System.Windows.Forms.TextBox();
            this.groupBoxConsulta.SuspendLayout();
            this.groupBoxInclusão.SuspendLayout();
            this.groupBoxAlteraçao.SuspendLayout();
            this.groupBoxExclusão.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonConsultar.Location = new System.Drawing.Point(309, 31);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(75, 23);
            this.buttonConsultar.TabIndex = 0;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = false;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // groupBoxConsulta
            // 
            this.groupBoxConsulta.BackColor = System.Drawing.Color.MediumTurquoise;
            this.groupBoxConsulta.Controls.Add(this.textBoxIdConsulta);
            this.groupBoxConsulta.Controls.Add(this.buttonConsultar);
            this.groupBoxConsulta.Location = new System.Drawing.Point(12, 12);
            this.groupBoxConsulta.Name = "groupBoxConsulta";
            this.groupBoxConsulta.Size = new System.Drawing.Size(390, 73);
            this.groupBoxConsulta.TabIndex = 1;
            this.groupBoxConsulta.TabStop = false;
            this.groupBoxConsulta.Text = "Consulta";
            // 
            // groupBoxInclusão
            // 
            this.groupBoxInclusão.Controls.Add(this.textBoxInserir);
            this.groupBoxInclusão.Controls.Add(this.buttonInserir);
            this.groupBoxInclusão.Location = new System.Drawing.Point(12, 104);
            this.groupBoxInclusão.Name = "groupBoxInclusão";
            this.groupBoxInclusão.Size = new System.Drawing.Size(390, 73);
            this.groupBoxInclusão.TabIndex = 2;
            this.groupBoxInclusão.TabStop = false;
            this.groupBoxInclusão.Text = "Inclusão";
            // 
            // textBoxInserir
            // 
            this.textBoxInserir.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBoxInserir.Location = new System.Drawing.Point(6, 32);
            this.textBoxInserir.Name = "textBoxInserir";
            this.textBoxInserir.Size = new System.Drawing.Size(291, 20);
            this.textBoxInserir.TabIndex = 1;
            // 
            // buttonInserir
            // 
            this.buttonInserir.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonInserir.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.buttonInserir.Location = new System.Drawing.Point(309, 30);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(75, 23);
            this.buttonInserir.TabIndex = 0;
            this.buttonInserir.Text = "Inserir";
            this.buttonInserir.UseVisualStyleBackColor = false;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // groupBoxAlteraçao
            // 
            this.groupBoxAlteraçao.Controls.Add(this.textBoxId);
            this.groupBoxAlteraçao.Controls.Add(this.textBoxNome);
            this.groupBoxAlteraçao.Controls.Add(this.buttonAlterar);
            this.groupBoxAlteraçao.Location = new System.Drawing.Point(13, 205);
            this.groupBoxAlteraçao.Name = "groupBoxAlteraçao";
            this.groupBoxAlteraçao.Size = new System.Drawing.Size(390, 73);
            this.groupBoxAlteraçao.TabIndex = 3;
            this.groupBoxAlteraçao.TabStop = false;
            this.groupBoxAlteraçao.Text = "Alteração";
            // 
            // textBoxId
            // 
            this.textBoxId.BackColor = System.Drawing.Color.LightSlateGray;
            this.textBoxId.Location = new System.Drawing.Point(5, 32);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(64, 20);
            this.textBoxId.TabIndex = 2;
            // 
            // textBoxNome
            // 
            this.textBoxNome.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBoxNome.Location = new System.Drawing.Point(75, 32);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(221, 20);
            this.textBoxNome.TabIndex = 1;
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonAlterar.Location = new System.Drawing.Point(308, 30);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterar.TabIndex = 0;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = false;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // groupBoxExclusão
            // 
            this.groupBoxExclusão.Controls.Add(this.textBoxExclusão);
            this.groupBoxExclusão.Controls.Add(this.textBoxExcluir);
            this.groupBoxExclusão.Controls.Add(this.buttonExcluir);
            this.groupBoxExclusão.Location = new System.Drawing.Point(13, 297);
            this.groupBoxExclusão.Name = "groupBoxExclusão";
            this.groupBoxExclusão.Size = new System.Drawing.Size(390, 73);
            this.groupBoxExclusão.TabIndex = 4;
            this.groupBoxExclusão.TabStop = false;
            this.groupBoxExclusão.Text = "Exclusão";
            // 
            // textBoxExclusão
            // 
            this.textBoxExclusão.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBoxExclusão.Location = new System.Drawing.Point(75, 32);
            this.textBoxExclusão.Name = "textBoxExclusão";
            this.textBoxExclusão.Size = new System.Drawing.Size(221, 20);
            this.textBoxExclusão.TabIndex = 2;
            // 
            // textBoxExcluir
            // 
            this.textBoxExcluir.BackColor = System.Drawing.Color.LightSlateGray;
            this.textBoxExcluir.Location = new System.Drawing.Point(5, 32);
            this.textBoxExcluir.Name = "textBoxExcluir";
            this.textBoxExcluir.Size = new System.Drawing.Size(64, 20);
            this.textBoxExcluir.TabIndex = 1;
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonExcluir.Location = new System.Drawing.Point(308, 30);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluir.TabIndex = 0;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = false;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // textBoxIdConsulta
            // 
            this.textBoxIdConsulta.BackColor = System.Drawing.Color.LightSlateGray;
            this.textBoxIdConsulta.Location = new System.Drawing.Point(6, 32);
            this.textBoxIdConsulta.Name = "textBoxIdConsulta";
            this.textBoxIdConsulta.Size = new System.Drawing.Size(64, 20);
            this.textBoxIdConsulta.TabIndex = 1;
            // 
            // FormePrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(439, 383);
            this.Controls.Add(this.groupBoxExclusão);
            this.Controls.Add(this.groupBoxAlteraçao);
            this.Controls.Add(this.groupBoxInclusão);
            this.Controls.Add(this.groupBoxConsulta);
            this.Name = "FormePrincipal";
            this.Text = "Aplicativo";
            this.groupBoxConsulta.ResumeLayout(false);
            this.groupBoxConsulta.PerformLayout();
            this.groupBoxInclusão.ResumeLayout(false);
            this.groupBoxInclusão.PerformLayout();
            this.groupBoxAlteraçao.ResumeLayout(false);
            this.groupBoxAlteraçao.PerformLayout();
            this.groupBoxExclusão.ResumeLayout(false);
            this.groupBoxExclusão.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.GroupBox groupBoxConsulta;
        private System.Windows.Forms.GroupBox groupBoxInclusão;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.GroupBox groupBoxAlteraçao;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.TextBox textBoxInserir;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.GroupBox groupBoxExclusão;
        private System.Windows.Forms.TextBox textBoxExclusão;
        private System.Windows.Forms.TextBox textBoxExcluir;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.TextBox textBoxIdConsulta;
    }
}

