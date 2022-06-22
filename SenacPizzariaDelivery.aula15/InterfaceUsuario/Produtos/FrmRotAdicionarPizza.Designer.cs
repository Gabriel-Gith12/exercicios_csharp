
namespace InterfaceUsuario.Produtos
{
    partial class FrmRotAdicionarPizza
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
            this.btnCancelarPizza = new System.Windows.Forms.Button();
            this.btnConfirmarPizza = new System.Windows.Forms.Button();
            this.lvlSabores = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQtdMaxSabor = new System.Windows.Forms.Label();
            this.lblQtdSaboresSelecionados = new System.Windows.Forms.Label();
            this.lblTotalSaborPizza = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lvlSaboresSelecionados = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMstValorBorda = new System.Windows.Forms.TextBox();
            this.txtMstDescricaoSabor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigoSaborBorda = new System.Windows.Forms.TextBox();
            this.btnBscSaborBorda = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.chkAddBorda = new System.Windows.Forms.CheckBox();
            this.lblTotalPizza = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigoTamanhoPizza = new System.Windows.Forms.TextBox();
            this.btnBscTamanhoPizza = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMstValorTamanho = new System.Windows.Forms.TextBox();
            this.txtMstDescricaoTamanho = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCancelarPizza);
            this.flowLayoutPanel1.Controls.Add(this.btnConfirmarPizza);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(164, 427);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(442, 52);
            this.flowLayoutPanel1.TabIndex = 33;
            // 
            // btnCancelarPizza
            // 
            this.btnCancelarPizza.Image = global::InterfaceUsuario.Properties.Resources.cancelar;
            this.btnCancelarPizza.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelarPizza.Location = new System.Drawing.Point(334, 3);
            this.btnCancelarPizza.Name = "btnCancelarPizza";
            this.btnCancelarPizza.Size = new System.Drawing.Size(105, 45);
            this.btnCancelarPizza.TabIndex = 2;
            this.btnCancelarPizza.Text = "Cancelar";
            this.btnCancelarPizza.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelarPizza.UseVisualStyleBackColor = true;
            this.btnCancelarPizza.Click += new System.EventHandler(this.btnCancelarPizza_Click);
            // 
            // btnConfirmarPizza
            // 
            this.btnConfirmarPizza.Image = global::InterfaceUsuario.Properties.Resources.confirmar;
            this.btnConfirmarPizza.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConfirmarPizza.Location = new System.Drawing.Point(223, 3);
            this.btnConfirmarPizza.Name = "btnConfirmarPizza";
            this.btnConfirmarPizza.Size = new System.Drawing.Size(105, 45);
            this.btnConfirmarPizza.TabIndex = 0;
            this.btnConfirmarPizza.Text = "Confirmar";
            this.btnConfirmarPizza.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConfirmarPizza.UseVisualStyleBackColor = true;
            this.btnConfirmarPizza.Click += new System.EventHandler(this.btnConfirmarPizza_Click);
            // 
            // lvlSabores
            // 
            this.lvlSabores.HideSelection = false;
            this.lvlSabores.Location = new System.Drawing.Point(6, 19);
            this.lvlSabores.MultiSelect = false;
            this.lvlSabores.Name = "lvlSabores";
            this.lvlSabores.Size = new System.Drawing.Size(369, 141);
            this.lvlSabores.TabIndex = 0;
            this.lvlSabores.UseCompatibleStateImageBehavior = false;
            this.lvlSabores.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvlSabores_ItemChecked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblQtdMaxSabor);
            this.groupBox1.Controls.Add(this.lblQtdSaboresSelecionados);
            this.groupBox1.Controls.Add(this.lblTotalSaborPizza);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lvlSaboresSelecionados);
            this.groupBox1.Controls.Add(this.lvlSabores);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 230);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sabores da Pizza";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = " /";
            // 
            // lblQtdMaxSabor
            // 
            this.lblQtdMaxSabor.AutoSize = true;
            this.lblQtdMaxSabor.Location = new System.Drawing.Point(89, 176);
            this.lblQtdMaxSabor.Name = "lblQtdMaxSabor";
            this.lblQtdMaxSabor.Size = new System.Drawing.Size(206, 13);
            this.lblQtdMaxSabor.TabIndex = 41;
            this.lblQtdMaxSabor.Text = "Quantidade Maxima de Sabores:  - ";
            // 
            // lblQtdSaboresSelecionados
            // 
            this.lblQtdSaboresSelecionados.AutoSize = true;
            this.lblQtdSaboresSelecionados.Location = new System.Drawing.Point(320, 176);
            this.lblQtdSaboresSelecionados.Name = "lblQtdSaboresSelecionados";
            this.lblQtdSaboresSelecionados.Size = new System.Drawing.Size(242, 13);
            this.lblQtdSaboresSelecionados.TabIndex = 40;
            this.lblQtdSaboresSelecionados.Text = "Quantidades de Sabores Selecionados: - ";
            // 
            // lblTotalSaborPizza
            // 
            this.lblTotalSaborPizza.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalSaborPizza.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalSaborPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSaborPizza.Location = new System.Drawing.Point(444, 202);
            this.lblTotalSaborPizza.Name = "lblTotalSaborPizza";
            this.lblTotalSaborPizza.Size = new System.Drawing.Size(137, 22);
            this.lblTotalSaborPizza.TabIndex = 39;
            this.lblTotalSaborPizza.Text = "R$ 0,00";
            this.lblTotalSaborPizza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(298, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Valor Total de Sabores:";
            // 
            // lvlSaboresSelecionados
            // 
            this.lvlSaboresSelecionados.HideSelection = false;
            this.lvlSaboresSelecionados.Location = new System.Drawing.Point(381, 19);
            this.lvlSaboresSelecionados.MultiSelect = false;
            this.lvlSaboresSelecionados.Name = "lvlSaboresSelecionados";
            this.lvlSaboresSelecionados.Size = new System.Drawing.Size(200, 141);
            this.lvlSaboresSelecionados.TabIndex = 1;
            this.lvlSaboresSelecionados.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMstValorBorda);
            this.groupBox2.Controls.Add(this.txtMstDescricaoSabor);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtCodigoSaborBorda);
            this.groupBox2.Controls.Add(this.btnBscSaborBorda);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.chkAddBorda);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 314);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(587, 71);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            // 
            // txtMstValorBorda
            // 
            this.txtMstValorBorda.BackColor = System.Drawing.SystemColors.Control;
            this.txtMstValorBorda.Enabled = false;
            this.txtMstValorBorda.Location = new System.Drawing.Point(463, 43);
            this.txtMstValorBorda.Name = "txtMstValorBorda";
            this.txtMstValorBorda.Size = new System.Drawing.Size(115, 20);
            this.txtMstValorBorda.TabIndex = 46;
            // 
            // txtMstDescricaoSabor
            // 
            this.txtMstDescricaoSabor.BackColor = System.Drawing.SystemColors.Control;
            this.txtMstDescricaoSabor.Enabled = false;
            this.txtMstDescricaoSabor.Location = new System.Drawing.Point(101, 43);
            this.txtMstDescricaoSabor.Name = "txtMstDescricaoSabor";
            this.txtMstDescricaoSabor.Size = new System.Drawing.Size(356, 20);
            this.txtMstDescricaoSabor.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Sabor da Borda:";
            // 
            // txtCodigoSaborBorda
            // 
            this.txtCodigoSaborBorda.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCodigoSaborBorda.Location = new System.Drawing.Point(4, 43);
            this.txtCodigoSaborBorda.Name = "txtCodigoSaborBorda";
            this.txtCodigoSaborBorda.Size = new System.Drawing.Size(56, 20);
            this.txtCodigoSaborBorda.TabIndex = 40;
            this.txtCodigoSaborBorda.Validating += new System.ComponentModel.CancelEventHandler(this.txtCodigoSaborBorda_Validating);
            // 
            // btnBscSaborBorda
            // 
            this.btnBscSaborBorda.Image = global::InterfaceUsuario.Properties.Resources.busca;
            this.btnBscSaborBorda.Location = new System.Drawing.Point(66, 43);
            this.btnBscSaborBorda.Name = "btnBscSaborBorda";
            this.btnBscSaborBorda.Size = new System.Drawing.Size(29, 20);
            this.btnBscSaborBorda.TabIndex = 41;
            this.btnBscSaborBorda.UseVisualStyleBackColor = true;
            this.btnBscSaborBorda.Click += new System.EventHandler(this.btnBscSaborBorda_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(470, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "Valor:";
            // 
            // chkAddBorda
            // 
            this.chkAddBorda.AutoSize = true;
            this.chkAddBorda.Location = new System.Drawing.Point(6, 0);
            this.chkAddBorda.Name = "chkAddBorda";
            this.chkAddBorda.Size = new System.Drawing.Size(116, 17);
            this.chkAddBorda.TabIndex = 32;
            this.chkAddBorda.Text = "Adicionar Borda";
            this.chkAddBorda.UseVisualStyleBackColor = true;
            this.chkAddBorda.CheckedChanged += new System.EventHandler(this.chkAddBorda_CheckedChanged);
            // 
            // lblTotalPizza
            // 
            this.lblTotalPizza.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalPizza.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPizza.Location = new System.Drawing.Point(465, 392);
            this.lblTotalPizza.Name = "lblTotalPizza";
            this.lblTotalPizza.Size = new System.Drawing.Size(137, 24);
            this.lblTotalPizza.TabIndex = 37;
            this.lblTotalPizza.Text = "R$ 0,00";
            this.lblTotalPizza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(329, 399);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "Valor Total da Pizza:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Tamanho da Pizza:";
            // 
            // txtCodigoTamanhoPizza
            // 
            this.txtCodigoTamanhoPizza.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCodigoTamanhoPizza.Location = new System.Drawing.Point(18, 40);
            this.txtCodigoTamanhoPizza.Name = "txtCodigoTamanhoPizza";
            this.txtCodigoTamanhoPizza.Size = new System.Drawing.Size(56, 20);
            this.txtCodigoTamanhoPizza.TabIndex = 34;
            this.txtCodigoTamanhoPizza.Validating += new System.ComponentModel.CancelEventHandler(this.txtCodigoTamanhoPizza_Validating);
            // 
            // btnBscTamanhoPizza
            // 
            this.btnBscTamanhoPizza.Image = global::InterfaceUsuario.Properties.Resources.busca;
            this.btnBscTamanhoPizza.Location = new System.Drawing.Point(80, 40);
            this.btnBscTamanhoPizza.Name = "btnBscTamanhoPizza";
            this.btnBscTamanhoPizza.Size = new System.Drawing.Size(29, 20);
            this.btnBscTamanhoPizza.TabIndex = 35;
            this.btnBscTamanhoPizza.UseVisualStyleBackColor = true;
            this.btnBscTamanhoPizza.Click += new System.EventHandler(this.btnBscTamanhoPizza_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(484, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Valor:";
            // 
            // txtMstValorTamanho
            // 
            this.txtMstValorTamanho.BackColor = System.Drawing.SystemColors.Control;
            this.txtMstValorTamanho.Enabled = false;
            this.txtMstValorTamanho.Location = new System.Drawing.Point(482, 40);
            this.txtMstValorTamanho.Name = "txtMstValorTamanho";
            this.txtMstValorTamanho.Size = new System.Drawing.Size(115, 20);
            this.txtMstValorTamanho.TabIndex = 39;
            // 
            // txtMstDescricaoTamanho
            // 
            this.txtMstDescricaoTamanho.BackColor = System.Drawing.SystemColors.Control;
            this.txtMstDescricaoTamanho.Enabled = false;
            this.txtMstDescricaoTamanho.Location = new System.Drawing.Point(115, 40);
            this.txtMstDescricaoTamanho.Name = "txtMstDescricaoTamanho";
            this.txtMstDescricaoTamanho.Size = new System.Drawing.Size(356, 20);
            this.txtMstDescricaoTamanho.TabIndex = 40;
            // 
            // FrmRotAdicionarPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 491);
            this.Controls.Add(this.txtMstDescricaoTamanho);
            this.Controls.Add(this.txtMstValorTamanho);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotalPizza);
            this.Controls.Add(this.txtCodigoTamanhoPizza);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnBscTamanhoPizza);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRotAdicionarPizza";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Adicionar Pizzas";
            this.Load += new System.EventHandler(this.FrmRotAdicionarPizza_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCancelarPizza;
        private System.Windows.Forms.Button btnConfirmarPizza;
        private System.Windows.Forms.ListView lvlSabores;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvlSaboresSelecionados;
        private System.Windows.Forms.Label lblTotalPizza;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox chkAddBorda;
        private System.Windows.Forms.Label lblQtdMaxSabor;
        private System.Windows.Forms.Label lblQtdSaboresSelecionados;
        private System.Windows.Forms.Label lblTotalSaborPizza;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigoSaborBorda;
        private System.Windows.Forms.Button btnBscSaborBorda;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigoTamanhoPizza;
        private System.Windows.Forms.Button btnBscTamanhoPizza;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMstValorBorda;
        private System.Windows.Forms.TextBox txtMstDescricaoSabor;
        private System.Windows.Forms.TextBox txtMstValorTamanho;
        private System.Windows.Forms.TextBox txtMstDescricaoTamanho;
        private System.Windows.Forms.Label label1;
    }
}