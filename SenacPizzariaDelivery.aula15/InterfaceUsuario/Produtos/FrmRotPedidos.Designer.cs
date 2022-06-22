
namespace InterfaceUsuario.Produtos
{
    partial class FrmRotPedidos
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
            this.tbcPedidos = new System.Windows.Forms.TabControl();
            this.tbpRegistro = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancelarPedido = new System.Windows.Forms.Button();
            this.btnConfirmarPedido = new System.Windows.Forms.Button();
            this.gbItensdoPedido = new System.Windows.Forms.GroupBox();
            this.lblTotalPedido = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtValorTele = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.chkTele = new System.Windows.Forms.CheckBox();
            this.gbAdicionais = new System.Windows.Forms.GroupBox();
            this.btnRemoveAdicional = new System.Windows.Forms.Button();
            this.btnAddAdicional = new System.Windows.Forms.Button();
            this.lvlAdicionais = new System.Windows.Forms.ListView();
            this.gbPizzas = new System.Windows.Forms.GroupBox();
            this.btnRemovePizza = new System.Windows.Forms.Button();
            this.btnAddPizza = new System.Windows.Forms.Button();
            this.lvlPizzas = new System.Windows.Forms.ListView();
            this.gbIdentificacao = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCodEnderecoCliente = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnEditEndereco = new System.Windows.Forms.Button();
            this.txtMstCidade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMstBairro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMstComplemento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMstNumero = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMstRua = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblMstNomeCliente = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddCliente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditCliente = new System.Windows.Forms.Button();
            this.btnBscCliente = new System.Windows.Forms.Button();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mtxtContato = new System.Windows.Forms.MaskedTextBox();
            this.tbpAndamento = new System.Windows.Forms.TabPage();
            this.tbcPedidos.SuspendLayout();
            this.tbpRegistro.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.gbItensdoPedido.SuspendLayout();
            this.gbAdicionais.SuspendLayout();
            this.gbPizzas.SuspendLayout();
            this.gbIdentificacao.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcPedidos
            // 
            this.tbcPedidos.Controls.Add(this.tbpRegistro);
            this.tbcPedidos.Controls.Add(this.tbpAndamento);
            this.tbcPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcPedidos.Location = new System.Drawing.Point(0, 0);
            this.tbcPedidos.Name = "tbcPedidos";
            this.tbcPedidos.SelectedIndex = 0;
            this.tbcPedidos.Size = new System.Drawing.Size(1180, 647);
            this.tbcPedidos.TabIndex = 0;
            // 
            // tbpRegistro
            // 
            this.tbpRegistro.Controls.Add(this.flowLayoutPanel1);
            this.tbpRegistro.Controls.Add(this.gbItensdoPedido);
            this.tbpRegistro.Controls.Add(this.gbIdentificacao);
            this.tbpRegistro.Location = new System.Drawing.Point(4, 22);
            this.tbpRegistro.Name = "tbpRegistro";
            this.tbpRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRegistro.Size = new System.Drawing.Size(1172, 621);
            this.tbpRegistro.TabIndex = 0;
            this.tbpRegistro.Text = "Registro";
            this.tbpRegistro.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCancelarPedido);
            this.flowLayoutPanel1.Controls.Add(this.btnConfirmarPedido);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(711, 571);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(442, 51);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btnCancelarPedido
            // 
            this.btnCancelarPedido.Image = global::InterfaceUsuario.Properties.Resources.cancelar;
            this.btnCancelarPedido.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelarPedido.Location = new System.Drawing.Point(334, 3);
            this.btnCancelarPedido.Name = "btnCancelarPedido";
            this.btnCancelarPedido.Size = new System.Drawing.Size(105, 45);
            this.btnCancelarPedido.TabIndex = 2;
            this.btnCancelarPedido.Text = "Cancelar";
            this.btnCancelarPedido.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelarPedido.UseVisualStyleBackColor = true;
            this.btnCancelarPedido.Click += new System.EventHandler(this.btnCancelarPedido_Click);
            // 
            // btnConfirmarPedido
            // 
            this.btnConfirmarPedido.Image = global::InterfaceUsuario.Properties.Resources.confirmar;
            this.btnConfirmarPedido.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConfirmarPedido.Location = new System.Drawing.Point(223, 3);
            this.btnConfirmarPedido.Name = "btnConfirmarPedido";
            this.btnConfirmarPedido.Size = new System.Drawing.Size(105, 45);
            this.btnConfirmarPedido.TabIndex = 0;
            this.btnConfirmarPedido.Text = "Confirmar";
            this.btnConfirmarPedido.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConfirmarPedido.UseVisualStyleBackColor = true;
            // 
            // gbItensdoPedido
            // 
            this.gbItensdoPedido.Controls.Add(this.lblTotalPedido);
            this.gbItensdoPedido.Controls.Add(this.label12);
            this.gbItensdoPedido.Controls.Add(this.txtValorTele);
            this.gbItensdoPedido.Controls.Add(this.label11);
            this.gbItensdoPedido.Controls.Add(this.chkTele);
            this.gbItensdoPedido.Controls.Add(this.gbAdicionais);
            this.gbItensdoPedido.Controls.Add(this.gbPizzas);
            this.gbItensdoPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbItensdoPedido.Location = new System.Drawing.Point(8, 210);
            this.gbItensdoPedido.Name = "gbItensdoPedido";
            this.gbItensdoPedido.Size = new System.Drawing.Size(1145, 356);
            this.gbItensdoPedido.TabIndex = 1;
            this.gbItensdoPedido.TabStop = false;
            this.gbItensdoPedido.Text = "Itens do pedido";
            // 
            // lblTotalPedido
            // 
            this.lblTotalPedido.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalPedido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPedido.Location = new System.Drawing.Point(1000, 312);
            this.lblTotalPedido.Name = "lblTotalPedido";
            this.lblTotalPedido.Size = new System.Drawing.Size(137, 36);
            this.lblTotalPedido.TabIndex = 35;
            this.lblTotalPedido.Text = "R$ 0,00";
            this.lblTotalPedido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(860, 334);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "Valor Total do Pedido:";
            // 
            // txtValorTele
            // 
            this.txtValorTele.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtValorTele.Enabled = false;
            this.txtValorTele.Location = new System.Drawing.Point(13, 330);
            this.txtValorTele.Name = "txtValorTele";
            this.txtValorTele.Size = new System.Drawing.Size(88, 20);
            this.txtValorTele.TabIndex = 33;
            this.txtValorTele.Validating += new System.ComponentModel.CancelEventHandler(this.txtValorTele_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 314);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Valor Tele:";
            // 
            // chkTele
            // 
            this.chkTele.AutoSize = true;
            this.chkTele.Location = new System.Drawing.Point(13, 289);
            this.chkTele.Name = "chkTele";
            this.chkTele.Size = new System.Drawing.Size(99, 17);
            this.chkTele.TabIndex = 31;
            this.chkTele.Text = "Tele Entrega";
            this.chkTele.UseVisualStyleBackColor = true;
            this.chkTele.CheckedChanged += new System.EventHandler(this.chkTele_CheckedChanged);
            // 
            // gbAdicionais
            // 
            this.gbAdicionais.Controls.Add(this.btnRemoveAdicional);
            this.gbAdicionais.Controls.Add(this.btnAddAdicional);
            this.gbAdicionais.Controls.Add(this.lvlAdicionais);
            this.gbAdicionais.Location = new System.Drawing.Point(13, 154);
            this.gbAdicionais.Name = "gbAdicionais";
            this.gbAdicionais.Size = new System.Drawing.Size(1126, 129);
            this.gbAdicionais.TabIndex = 30;
            this.gbAdicionais.TabStop = false;
            this.gbAdicionais.Text = "Adicionais";
            // 
            // btnRemoveAdicional
            // 
            this.btnRemoveAdicional.Image = global::InterfaceUsuario.Properties.Resources.excluir;
            this.btnRemoveAdicional.Location = new System.Drawing.Point(1078, 49);
            this.btnRemoveAdicional.Name = "btnRemoveAdicional";
            this.btnRemoveAdicional.Size = new System.Drawing.Size(29, 23);
            this.btnRemoveAdicional.TabIndex = 29;
            this.btnRemoveAdicional.UseVisualStyleBackColor = true;
            this.btnRemoveAdicional.Click += new System.EventHandler(this.btnRemoveAdicional_Click);
            // 
            // btnAddAdicional
            // 
            this.btnAddAdicional.Image = global::InterfaceUsuario.Properties.Resources.adicionar;
            this.btnAddAdicional.Location = new System.Drawing.Point(1078, 20);
            this.btnAddAdicional.Name = "btnAddAdicional";
            this.btnAddAdicional.Size = new System.Drawing.Size(29, 23);
            this.btnAddAdicional.TabIndex = 28;
            this.btnAddAdicional.UseVisualStyleBackColor = true;
            this.btnAddAdicional.Click += new System.EventHandler(this.btnAddAdicional_Click);
            // 
            // lvlAdicionais
            // 
            this.lvlAdicionais.HideSelection = false;
            this.lvlAdicionais.Location = new System.Drawing.Point(7, 20);
            this.lvlAdicionais.MultiSelect = false;
            this.lvlAdicionais.Name = "lvlAdicionais";
            this.lvlAdicionais.Size = new System.Drawing.Size(1065, 97);
            this.lvlAdicionais.TabIndex = 0;
            this.lvlAdicionais.UseCompatibleStateImageBehavior = false;
            // 
            // gbPizzas
            // 
            this.gbPizzas.Controls.Add(this.btnRemovePizza);
            this.gbPizzas.Controls.Add(this.btnAddPizza);
            this.gbPizzas.Controls.Add(this.lvlPizzas);
            this.gbPizzas.Location = new System.Drawing.Point(13, 19);
            this.gbPizzas.Name = "gbPizzas";
            this.gbPizzas.Size = new System.Drawing.Size(1126, 129);
            this.gbPizzas.TabIndex = 0;
            this.gbPizzas.TabStop = false;
            this.gbPizzas.Text = "Pizzas";
            // 
            // btnRemovePizza
            // 
            this.btnRemovePizza.Image = global::InterfaceUsuario.Properties.Resources.excluir;
            this.btnRemovePizza.Location = new System.Drawing.Point(1078, 49);
            this.btnRemovePizza.Name = "btnRemovePizza";
            this.btnRemovePizza.Size = new System.Drawing.Size(29, 23);
            this.btnRemovePizza.TabIndex = 29;
            this.btnRemovePizza.UseVisualStyleBackColor = true;
            this.btnRemovePizza.Click += new System.EventHandler(this.btnRemovePizza_Click);
            // 
            // btnAddPizza
            // 
            this.btnAddPizza.Image = global::InterfaceUsuario.Properties.Resources.adicionar;
            this.btnAddPizza.Location = new System.Drawing.Point(1078, 20);
            this.btnAddPizza.Name = "btnAddPizza";
            this.btnAddPizza.Size = new System.Drawing.Size(29, 23);
            this.btnAddPizza.TabIndex = 28;
            this.btnAddPizza.UseVisualStyleBackColor = true;
            this.btnAddPizza.Click += new System.EventHandler(this.btnAddPizza_Click);
            // 
            // lvlPizzas
            // 
            this.lvlPizzas.HideSelection = false;
            this.lvlPizzas.Location = new System.Drawing.Point(7, 20);
            this.lvlPizzas.MultiSelect = false;
            this.lvlPizzas.Name = "lvlPizzas";
            this.lvlPizzas.Size = new System.Drawing.Size(1065, 97);
            this.lvlPizzas.TabIndex = 0;
            this.lvlPizzas.UseCompatibleStateImageBehavior = false;
            // 
            // gbIdentificacao
            // 
            this.gbIdentificacao.Controls.Add(this.groupBox1);
            this.gbIdentificacao.Controls.Add(this.lblMstNomeCliente);
            this.gbIdentificacao.Controls.Add(this.label3);
            this.gbIdentificacao.Controls.Add(this.btnAddCliente);
            this.gbIdentificacao.Controls.Add(this.label2);
            this.gbIdentificacao.Controls.Add(this.btnEditCliente);
            this.gbIdentificacao.Controls.Add(this.btnBscCliente);
            this.gbIdentificacao.Controls.Add(this.txtCodigoCliente);
            this.gbIdentificacao.Controls.Add(this.lblCodigo);
            this.gbIdentificacao.Controls.Add(this.label1);
            this.gbIdentificacao.Controls.Add(this.mtxtContato);
            this.gbIdentificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbIdentificacao.Location = new System.Drawing.Point(8, 6);
            this.gbIdentificacao.Name = "gbIdentificacao";
            this.gbIdentificacao.Size = new System.Drawing.Size(1145, 198);
            this.gbIdentificacao.TabIndex = 0;
            this.gbIdentificacao.TabStop = false;
            this.gbIdentificacao.Text = "Identificação do cliente";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCodEnderecoCliente);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnEditEndereco);
            this.groupBox1.Controls.Add(this.txtMstCidade);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtMstBairro);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtMstComplemento);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMstNumero);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtMstRua);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(435, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(704, 175);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço";
            // 
            // lblCodEnderecoCliente
            // 
            this.lblCodEnderecoCliente.Location = new System.Drawing.Point(42, 16);
            this.lblCodEnderecoCliente.Name = "lblCodEnderecoCliente";
            this.lblCodEnderecoCliente.Size = new System.Drawing.Size(30, 13);
            this.lblCodEnderecoCliente.TabIndex = 32;
            this.lblCodEnderecoCliente.Text = "...";
            this.lblCodEnderecoCliente.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(46, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Alterar Endereço de entrega";
            // 
            // btnEditEndereco
            // 
            this.btnEditEndereco.Enabled = false;
            this.btnEditEndereco.Image = global::InterfaceUsuario.Properties.Resources.editar;
            this.btnEditEndereco.Location = new System.Drawing.Point(9, 146);
            this.btnEditEndereco.Name = "btnEditEndereco";
            this.btnEditEndereco.Size = new System.Drawing.Size(29, 23);
            this.btnEditEndereco.TabIndex = 28;
            this.btnEditEndereco.UseVisualStyleBackColor = true;
            // 
            // txtMstCidade
            // 
            this.txtMstCidade.BackColor = System.Drawing.SystemColors.Control;
            this.txtMstCidade.Enabled = false;
            this.txtMstCidade.Location = new System.Drawing.Point(232, 117);
            this.txtMstCidade.Name = "txtMstCidade";
            this.txtMstCidade.Size = new System.Drawing.Size(212, 20);
            this.txtMstCidade.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(229, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Cidade:";
            // 
            // txtMstBairro
            // 
            this.txtMstBairro.BackColor = System.Drawing.SystemColors.Control;
            this.txtMstBairro.Enabled = false;
            this.txtMstBairro.Location = new System.Drawing.Point(9, 117);
            this.txtMstBairro.Name = "txtMstBairro";
            this.txtMstBairro.Size = new System.Drawing.Size(212, 20);
            this.txtMstBairro.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Bairro:";
            // 
            // txtMstComplemento
            // 
            this.txtMstComplemento.BackColor = System.Drawing.SystemColors.Control;
            this.txtMstComplemento.Enabled = false;
            this.txtMstComplemento.Location = new System.Drawing.Point(118, 73);
            this.txtMstComplemento.Name = "txtMstComplemento";
            this.txtMstComplemento.Size = new System.Drawing.Size(575, 20);
            this.txtMstComplemento.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Complemento:";
            // 
            // txtMstNumero
            // 
            this.txtMstNumero.BackColor = System.Drawing.SystemColors.Control;
            this.txtMstNumero.Enabled = false;
            this.txtMstNumero.Location = new System.Drawing.Point(9, 73);
            this.txtMstNumero.Name = "txtMstNumero";
            this.txtMstNumero.Size = new System.Drawing.Size(97, 20);
            this.txtMstNumero.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Número:";
            // 
            // txtMstRua
            // 
            this.txtMstRua.BackColor = System.Drawing.SystemColors.Control;
            this.txtMstRua.Enabled = false;
            this.txtMstRua.Location = new System.Drawing.Point(9, 36);
            this.txtMstRua.Name = "txtMstRua";
            this.txtMstRua.Size = new System.Drawing.Size(684, 20);
            this.txtMstRua.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Rua:";
            // 
            // lblMstNomeCliente
            // 
            this.lblMstNomeCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblMstNomeCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMstNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMstNomeCliente.Location = new System.Drawing.Point(13, 138);
            this.lblMstNomeCliente.Name = "lblMstNomeCliente";
            this.lblMstNomeCliente.Size = new System.Drawing.Size(398, 48);
            this.lblMstNomeCliente.TabIndex = 29;
            this.lblMstNomeCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Nome:";
            // 
            // btnAddCliente
            // 
            this.btnAddCliente.Image = global::InterfaceUsuario.Properties.Resources.adicionar;
            this.btnAddCliente.Location = new System.Drawing.Point(379, 80);
            this.btnAddCliente.Name = "btnAddCliente";
            this.btnAddCliente.Size = new System.Drawing.Size(29, 23);
            this.btnAddCliente.TabIndex = 27;
            this.btnAddCliente.UseVisualStyleBackColor = true;
            this.btnAddCliente.Click += new System.EventHandler(this.btnAddCliente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(313, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Adicionar";
            // 
            // btnEditCliente
            // 
            this.btnEditCliente.Enabled = false;
            this.btnEditCliente.Image = global::InterfaceUsuario.Properties.Resources.editar;
            this.btnEditCliente.Location = new System.Drawing.Point(125, 80);
            this.btnEditCliente.Name = "btnEditCliente";
            this.btnEditCliente.Size = new System.Drawing.Size(29, 23);
            this.btnEditCliente.TabIndex = 25;
            this.btnEditCliente.UseVisualStyleBackColor = true;
            this.btnEditCliente.Click += new System.EventHandler(this.btnEditCliente_Click);
            // 
            // btnBscCliente
            // 
            this.btnBscCliente.Image = global::InterfaceUsuario.Properties.Resources.busca;
            this.btnBscCliente.Location = new System.Drawing.Point(90, 80);
            this.btnBscCliente.Name = "btnBscCliente";
            this.btnBscCliente.Size = new System.Drawing.Size(29, 23);
            this.btnBscCliente.TabIndex = 24;
            this.btnBscCliente.UseVisualStyleBackColor = true;
            this.btnBscCliente.Click += new System.EventHandler(this.btnBscCliente_Click);
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCodigoCliente.Location = new System.Drawing.Point(13, 80);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(71, 20);
            this.txtCodigoCliente.TabIndex = 23;
            this.txtCodigoCliente.Validating += new System.ComponentModel.CancelEventHandler(this.txtCodigoCliente_Validating);
            this.txtCodigoCliente.Validated += new System.EventHandler(this.txtCodigoCliente_Validated);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(10, 64);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 22;
            this.lblCodigo.Text = "Código:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Contato:";
            // 
            // mtxtContato
            // 
            this.mtxtContato.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.mtxtContato.Location = new System.Drawing.Point(13, 33);
            this.mtxtContato.Mask = "(00) 0 0000-0000";
            this.mtxtContato.Name = "mtxtContato";
            this.mtxtContato.Size = new System.Drawing.Size(99, 20);
            this.mtxtContato.TabIndex = 20;
            this.mtxtContato.Validating += new System.ComponentModel.CancelEventHandler(this.mtxtContato_Validating);
            // 
            // tbpAndamento
            // 
            this.tbpAndamento.Location = new System.Drawing.Point(4, 22);
            this.tbpAndamento.Name = "tbpAndamento";
            this.tbpAndamento.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAndamento.Size = new System.Drawing.Size(1172, 621);
            this.tbpAndamento.TabIndex = 1;
            this.tbpAndamento.Text = "Andamento";
            this.tbpAndamento.UseVisualStyleBackColor = true;
            // 
            // FrmRotPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 647);
            this.Controls.Add(this.tbcPedidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRotPedidos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.FrmRotPedidos_Load);
            this.tbcPedidos.ResumeLayout(false);
            this.tbpRegistro.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.gbItensdoPedido.ResumeLayout(false);
            this.gbItensdoPedido.PerformLayout();
            this.gbAdicionais.ResumeLayout(false);
            this.gbPizzas.ResumeLayout(false);
            this.gbIdentificacao.ResumeLayout(false);
            this.gbIdentificacao.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcPedidos;
        private System.Windows.Forms.TabPage tbpRegistro;
        private System.Windows.Forms.TabPage tbpAndamento;
        private System.Windows.Forms.GroupBox gbItensdoPedido;
        private System.Windows.Forms.GroupBox gbIdentificacao;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCancelarPedido;
        private System.Windows.Forms.Button btnConfirmarPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtxtContato;
        private System.Windows.Forms.Button btnBscCliente;
        private System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnAddCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEditCliente;
        private System.Windows.Forms.Label lblMstNomeCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMstCidade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMstBairro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMstComplemento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMstNumero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMstRua;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnEditEndereco;
        private System.Windows.Forms.GroupBox gbAdicionais;
        private System.Windows.Forms.Button btnRemoveAdicional;
        private System.Windows.Forms.Button btnAddAdicional;
        private System.Windows.Forms.ListView lvlAdicionais;
        private System.Windows.Forms.GroupBox gbPizzas;
        private System.Windows.Forms.Button btnRemovePizza;
        private System.Windows.Forms.Button btnAddPizza;
        private System.Windows.Forms.ListView lvlPizzas;
        private System.Windows.Forms.Label lblTotalPedido;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtValorTele;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chkTele;
        private System.Windows.Forms.Label lblCodEnderecoCliente;
    }
}