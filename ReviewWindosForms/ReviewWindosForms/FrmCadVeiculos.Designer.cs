
namespace ReviewWindosForms
{
    partial class FrmCadVeiculos
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
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Skyline",
            "Nissan",
            "Não",
            "Ar Dual"}, -1);
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lstVeiculos = new System.Windows.Forms.ListBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkTeto = new System.Windows.Forms.CheckBox();
            this.chkBanco = new System.Windows.Forms.CheckBox();
            this.chkDual = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.optNao = new System.Windows.Forms.RadioButton();
            this.optSim = new System.Windows.Forms.RadioButton();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lvlVeiculos = new System.Windows.Forms.ListView();
            this.clhNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhMarca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhAutomatico = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhEquipamentos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(9, 36);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(53, 18);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(12, 57);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(428, 24);
            this.txtNome.TabIndex = 2;
            this.txtNome.Validated += new System.EventHandler(this.txtNome_Validated);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCadastrar.Location = new System.Drawing.Point(457, 56);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(96, 25);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnLimpar.Location = new System.Drawing.Point(571, 56);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(96, 25);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lstVeiculos
            // 
            this.lstVeiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstVeiculos.FormattingEnabled = true;
            this.lstVeiculos.ItemHeight = 18;
            this.lstVeiculos.Location = new System.Drawing.Point(12, 479);
            this.lstVeiculos.Name = "lstVeiculos";
            this.lstVeiculos.Size = new System.Drawing.Size(831, 22);
            this.lstVeiculos.TabIndex = 5;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnExcluir.Location = new System.Drawing.Point(761, 507);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(82, 23);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(12, 454);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(25, 13);
            this.lblMsg.TabIndex = 7;
            this.lblMsg.Text = "......";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkTeto);
            this.groupBox1.Controls.Add(this.chkBanco);
            this.groupBox1.Controls.Add(this.chkDual);
            this.groupBox1.Location = new System.Drawing.Point(12, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(110, 139);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Equipamentos";
            // 
            // chkTeto
            // 
            this.chkTeto.AutoSize = true;
            this.chkTeto.Location = new System.Drawing.Point(6, 75);
            this.chkTeto.Name = "chkTeto";
            this.chkTeto.Size = new System.Drawing.Size(73, 17);
            this.chkTeto.TabIndex = 2;
            this.chkTeto.Text = "Teto solar";
            this.chkTeto.UseVisualStyleBackColor = true;
            this.chkTeto.CheckedChanged += new System.EventHandler(this.chkTeto_CheckedChanged);
            // 
            // chkBanco
            // 
            this.chkBanco.AutoSize = true;
            this.chkBanco.Location = new System.Drawing.Point(6, 52);
            this.chkBanco.Name = "chkBanco";
            this.chkBanco.Size = new System.Drawing.Size(91, 17);
            this.chkBanco.TabIndex = 1;
            this.chkBanco.Text = "Aquec Banco";
            this.chkBanco.UseVisualStyleBackColor = true;
            this.chkBanco.CheckedChanged += new System.EventHandler(this.chkBanco_CheckedChanged);
            // 
            // chkDual
            // 
            this.chkDual.AutoSize = true;
            this.chkDual.Location = new System.Drawing.Point(6, 29);
            this.chkDual.Name = "chkDual";
            this.chkDual.Size = new System.Drawing.Size(61, 17);
            this.chkDual.TabIndex = 0;
            this.chkDual.Text = "Ar Dual";
            this.chkDual.UseVisualStyleBackColor = true;
            this.chkDual.CheckedChanged += new System.EventHandler(this.chkDual_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.optNao);
            this.groupBox2.Controls.Add(this.optSim);
            this.groupBox2.Location = new System.Drawing.Point(138, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 139);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Automático";
            // 
            // optNao
            // 
            this.optNao.AutoSize = true;
            this.optNao.Location = new System.Drawing.Point(97, 20);
            this.optNao.Name = "optNao";
            this.optNao.Size = new System.Drawing.Size(45, 17);
            this.optNao.TabIndex = 1;
            this.optNao.TabStop = true;
            this.optNao.Text = "Não";
            this.optNao.UseVisualStyleBackColor = true;
            // 
            // optSim
            // 
            this.optSim.AutoSize = true;
            this.optSim.Location = new System.Drawing.Point(6, 20);
            this.optSim.Name = "optSim";
            this.optSim.Size = new System.Drawing.Size(42, 17);
            this.optSim.TabIndex = 0;
            this.optSim.TabStop = true;
            this.optSim.Text = "Sim";
            this.optSim.UseVisualStyleBackColor = true;
            // 
            // cbxMarca
            // 
            this.cbxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Items.AddRange(new object[] {
            "Nissan",
            "Toyota",
            "Fiat",
            "Volvo",
            "Lexus",
            "Bmw",
            "Mazda",
            "Ford",
            "Porshe",
            "Honda",
            "Acura"});
            this.cbxMarca.Location = new System.Drawing.Point(381, 137);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(286, 26);
            this.cbxMarca.TabIndex = 10;
            this.cbxMarca.SelectedIndexChanged += new System.EventHandler(this.cbxMarca_SelectedIndexChanged);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(378, 107);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 11;
            this.lblMarca.Text = "Marca";
            // 
            // lvlVeiculos
            // 
            this.lvlVeiculos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhNome,
            this.clhMarca,
            this.clhAutomatico,
            this.clhEquipamentos});
            this.lvlVeiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlVeiculos.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lvlVeiculos.FullRowSelect = true;
            this.lvlVeiculos.GridLines = true;
            this.lvlVeiculos.HideSelection = false;
            this.lvlVeiculos.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3});
            this.lvlVeiculos.Location = new System.Drawing.Point(12, 248);
            this.lvlVeiculos.MultiSelect = false;
            this.lvlVeiculos.Name = "lvlVeiculos";
            this.lvlVeiculos.Size = new System.Drawing.Size(831, 203);
            this.lvlVeiculos.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvlVeiculos.TabIndex = 12;
            this.lvlVeiculos.UseCompatibleStateImageBehavior = false;
            this.lvlVeiculos.View = System.Windows.Forms.View.Details;
            // 
            // clhNome
            // 
            this.clhNome.Text = "Nome";
            this.clhNome.Width = 149;
            // 
            // clhMarca
            // 
            this.clhMarca.Text = "Marca";
            this.clhMarca.Width = 172;
            // 
            // clhAutomatico
            // 
            this.clhAutomatico.Text = "Automático";
            this.clhAutomatico.Width = 158;
            // 
            // clhEquipamentos
            // 
            this.clhEquipamentos.Text = "Equipamentos";
            this.clhEquipamentos.Width = 321;
            // 
            // FrmCadVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 542);
            this.Controls.Add(this.lvlVeiculos);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.cbxMarca);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.lstVeiculos);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadVeiculos";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Veiculos";
            this.Load += new System.EventHandler(this.frmCadVeiculos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ListBox lstVeiculos;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkTeto;
        private System.Windows.Forms.CheckBox chkBanco;
        private System.Windows.Forms.CheckBox chkDual;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton optNao;
        private System.Windows.Forms.RadioButton optSim;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ListView lvlVeiculos;
        private System.Windows.Forms.ColumnHeader clhNome;
        private System.Windows.Forms.ColumnHeader clhMarca;
        private System.Windows.Forms.ColumnHeader clhAutomatico;
        private System.Windows.Forms.ColumnHeader clhEquipamentos;
    }
}

