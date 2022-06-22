
namespace InterfaceUsuario.Pessoas
{
    partial class FrmCadUsuarios
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtCodigoUsuario = new System.Windows.Forms.TextBox();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.txtCodigoTipoUsuario = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtLoginUsuario = new System.Windows.Forms.TextBox();
            this.txtSenhaUsuario = new System.Windows.Forms.TextBox();
            this.lblMstTipoUsuario = new System.Windows.Forms.Label();
            this.btnBscTipoUsuario = new System.Windows.Forms.Button();
            this.btnBscUsuario = new System.Windows.Forms.Button();
            this.ucSituacao1 = new InterfaceUsuario.UserControls.ucSituacao();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCancelar);
            this.flowLayoutPanel1.Controls.Add(this.btnExcluir);
            this.flowLayoutPanel1.Controls.Add(this.btnConfirmar);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(286, 264);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(442, 51);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::InterfaceUsuario.Properties.Resources.cancelar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(334, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 45);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = global::InterfaceUsuario.Properties.Resources.excluir;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.Location = new System.Drawing.Point(223, 3);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(105, 45);
            this.btnExcluir.TabIndex = 1;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Image = global::InterfaceUsuario.Properties.Resources.confirmar;
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConfirmar.Location = new System.Drawing.Point(112, 3);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(105, 45);
            this.btnConfirmar.TabIndex = 0;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(13, 9);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(215, 13);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.Location = new System.Drawing.Point(13, 125);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(83, 13);
            this.lblTipoUsuario.TabIndex = 3;
            this.lblTipoUsuario.Text = "Tipo de usuário:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(215, 74);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(36, 13);
            this.lblLogin.TabIndex = 4;
            this.lblLogin.Text = "Login:";
            // 
            // txtCodigoUsuario
            // 
            this.txtCodigoUsuario.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCodigoUsuario.Location = new System.Drawing.Point(16, 30);
            this.txtCodigoUsuario.Name = "txtCodigoUsuario";
            this.txtCodigoUsuario.Size = new System.Drawing.Size(127, 20);
            this.txtCodigoUsuario.TabIndex = 7;
            this.txtCodigoUsuario.Validating += new System.ComponentModel.CancelEventHandler(this.txtCodigoUsuario_Validating);
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNomeUsuario.Location = new System.Drawing.Point(218, 30);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(507, 20);
            this.txtNomeUsuario.TabIndex = 8;
            // 
            // txtCodigoTipoUsuario
            // 
            this.txtCodigoTipoUsuario.Location = new System.Drawing.Point(14, 142);
            this.txtCodigoTipoUsuario.Name = "txtCodigoTipoUsuario";
            this.txtCodigoTipoUsuario.Size = new System.Drawing.Size(129, 20);
            this.txtCodigoTipoUsuario.TabIndex = 9;
            this.txtCodigoTipoUsuario.Validating += new System.ComponentModel.CancelEventHandler(this.txtCodigoTipoUsuario_Validating);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(440, 74);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 12;
            this.lblSenha.Text = "Senha:";
            // 
            // txtLoginUsuario
            // 
            this.txtLoginUsuario.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtLoginUsuario.Location = new System.Drawing.Point(218, 90);
            this.txtLoginUsuario.Name = "txtLoginUsuario";
            this.txtLoginUsuario.Size = new System.Drawing.Size(204, 20);
            this.txtLoginUsuario.TabIndex = 13;
            // 
            // txtSenhaUsuario
            // 
            this.txtSenhaUsuario.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtSenhaUsuario.Location = new System.Drawing.Point(442, 90);
            this.txtSenhaUsuario.Name = "txtSenhaUsuario";
            this.txtSenhaUsuario.Size = new System.Drawing.Size(283, 20);
            this.txtSenhaUsuario.TabIndex = 14;
            // 
            // lblMstTipoUsuario
            // 
            this.lblMstTipoUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMstTipoUsuario.Location = new System.Drawing.Point(215, 139);
            this.lblMstTipoUsuario.Name = "lblMstTipoUsuario";
            this.lblMstTipoUsuario.Size = new System.Drawing.Size(510, 23);
            this.lblMstTipoUsuario.TabIndex = 15;
            // 
            // btnBscTipoUsuario
            // 
            this.btnBscTipoUsuario.Image = global::InterfaceUsuario.Properties.Resources.busca;
            this.btnBscTipoUsuario.Location = new System.Drawing.Point(149, 139);
            this.btnBscTipoUsuario.Name = "btnBscTipoUsuario";
            this.btnBscTipoUsuario.Size = new System.Drawing.Size(29, 23);
            this.btnBscTipoUsuario.TabIndex = 11;
            this.btnBscTipoUsuario.UseVisualStyleBackColor = true;
            this.btnBscTipoUsuario.Click += new System.EventHandler(this.btnBscTipoUsuario_Click);
            // 
            // btnBscUsuario
            // 
            this.btnBscUsuario.Image = global::InterfaceUsuario.Properties.Resources.busca;
            this.btnBscUsuario.Location = new System.Drawing.Point(149, 28);
            this.btnBscUsuario.Name = "btnBscUsuario";
            this.btnBscUsuario.Size = new System.Drawing.Size(29, 23);
            this.btnBscUsuario.TabIndex = 10;
            this.btnBscUsuario.UseVisualStyleBackColor = true;
            this.btnBscUsuario.Click += new System.EventHandler(this.btnBscUsuario_Click);
            // 
            // ucSituacao1
            // 
            this.ucSituacao1.Location = new System.Drawing.Point(528, 165);
            this.ucSituacao1.Name = "ucSituacao1";
            this.ucSituacao1.Size = new System.Drawing.Size(200, 70);
            this.ucSituacao1.status = Entidades.Enumeradores.Status.Inativo;
            this.ucSituacao1.TabIndex = 16;
            // 
            // FrmCadUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 327);
            this.Controls.Add(this.ucSituacao1);
            this.Controls.Add(this.lblMstTipoUsuario);
            this.Controls.Add(this.txtSenhaUsuario);
            this.Controls.Add(this.txtLoginUsuario);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.btnBscTipoUsuario);
            this.Controls.Add(this.btnBscUsuario);
            this.Controls.Add(this.txtCodigoTipoUsuario);
            this.Controls.Add(this.txtNomeUsuario);
            this.Controls.Add(this.txtCodigoUsuario);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblTipoUsuario);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadUsuarios";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FrmCadUsuarios";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtCodigoUsuario;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.TextBox txtCodigoTipoUsuario;
        private System.Windows.Forms.Button btnBscUsuario;
        private System.Windows.Forms.Button btnBscTipoUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtLoginUsuario;
        private System.Windows.Forms.TextBox txtSenhaUsuario;
        private System.Windows.Forms.Label lblMstTipoUsuario;
        private UserControls.ucSituacao ucSituacao1;
    }
}