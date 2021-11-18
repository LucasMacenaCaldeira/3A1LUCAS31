
namespace SavassiGames
{
    partial class FrmJogos
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
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.btnalterar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.dtgjogos = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtjogo = new System.Windows.Forms.TextBox();
            this.txtvendedor = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgjogos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcodigo
            // 
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Location = new System.Drawing.Point(135, 7);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(116, 23);
            this.txtcodigo.TabIndex = 14;
            this.txtcodigo.TextChanged += new System.EventHandler(this.txtcodigo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Código do jogo";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btncadastrar);
            this.panel1.Controls.Add(this.btnalterar);
            this.panel1.Controls.Add(this.btnexcluir);
            this.panel1.Location = new System.Drawing.Point(18, 172);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 65);
            this.panel1.TabIndex = 21;
            // 
            // btncadastrar
            // 
            this.btncadastrar.Location = new System.Drawing.Point(31, 15);
            this.btncadastrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(105, 35);
            this.btncadastrar.TabIndex = 6;
            this.btncadastrar.Text = "CADASTRAR ";
            this.btncadastrar.UseVisualStyleBackColor = true;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // btnalterar
            // 
            this.btnalterar.Location = new System.Drawing.Point(199, 15);
            this.btnalterar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(105, 35);
            this.btnalterar.TabIndex = 7;
            this.btnalterar.Text = "ALTERAR";
            this.btnalterar.UseVisualStyleBackColor = true;
            this.btnalterar.Click += new System.EventHandler(this.btnalterar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(363, 15);
            this.btnexcluir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(105, 35);
            this.btnexcluir.TabIndex = 8;
            this.btnexcluir.Text = "EXCLUIR";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // dtgjogos
            // 
            this.dtgjogos.BackgroundColor = System.Drawing.Color.White;
            this.dtgjogos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgjogos.Location = new System.Drawing.Point(18, 263);
            this.dtgjogos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtgjogos.Name = "dtgjogos";
            this.dtgjogos.Size = new System.Drawing.Size(504, 173);
            this.dtgjogos.TabIndex = 22;
            this.dtgjogos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(365, 7);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 15);
            this.label6.TabIndex = 25;
            this.label6.Text = "Jogo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(194, 80);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 15);
            this.label7.TabIndex = 27;
            this.label7.Text = "Vendedor";
            // 
            // txtjogo
            // 
            this.txtjogo.Location = new System.Drawing.Point(413, 7);
            this.txtjogo.Name = "txtjogo";
            this.txtjogo.Size = new System.Drawing.Size(100, 23);
            this.txtjogo.TabIndex = 29;
            // 
            // txtvendedor
            // 
            this.txtvendedor.Location = new System.Drawing.Point(258, 77);
            this.txtvendedor.Name = "txtvendedor";
            this.txtvendedor.Size = new System.Drawing.Size(100, 23);
            this.txtvendedor.TabIndex = 30;
            // 
            // FrmJogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(537, 455);
            this.Controls.Add(this.txtvendedor);
            this.Controls.Add(this.txtjogo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtgjogos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmJogos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Savassi Games";
            this.Load += new System.EventHandler(this.FrmJogos_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgjogos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.Button btnalterar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.DataGridView dtgjogos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtjogo;
        private System.Windows.Forms.TextBox txtvendedor;
    }
}