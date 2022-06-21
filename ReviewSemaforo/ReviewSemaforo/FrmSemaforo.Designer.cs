
namespace ReviewSemaforo
{
    partial class FrmSemaforo
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.picVermelho = new System.Windows.Forms.PictureBox();
            this.picAmarelo = new System.Windows.Forms.PictureBox();
            this.picVerde = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVermelho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAmarelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVerde)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.picVermelho, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.picAmarelo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.picVerde, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(25, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.47561F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.52439F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 143F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 447);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // picVermelho
            // 
            this.picVermelho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picVermelho.Location = new System.Drawing.Point(3, 3);
            this.picVermelho.Name = "picVermelho";
            this.picVermelho.Size = new System.Drawing.Size(194, 141);
            this.picVermelho.TabIndex = 0;
            this.picVermelho.TabStop = false;
            // 
            // picAmarelo
            // 
            this.picAmarelo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picAmarelo.Location = new System.Drawing.Point(3, 150);
            this.picAmarelo.Name = "picAmarelo";
            this.picAmarelo.Size = new System.Drawing.Size(194, 150);
            this.picAmarelo.TabIndex = 1;
            this.picAmarelo.TabStop = false;
            // 
            // picVerde
            // 
            this.picVerde.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picVerde.Location = new System.Drawing.Point(3, 306);
            this.picVerde.Name = "picVerde";
            this.picVerde.Size = new System.Drawing.Size(194, 138);
            this.picVerde.TabIndex = 2;
            this.picVerde.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 471);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Semáforo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picVermelho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAmarelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVerde)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox picVermelho;
        private System.Windows.Forms.PictureBox picAmarelo;
        private System.Windows.Forms.PictureBox picVerde;
        private System.Windows.Forms.Timer timer1;
    }
}

