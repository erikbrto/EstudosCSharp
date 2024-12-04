namespace EstudosXML
{
    partial class frmAgenda
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lbxContatos = new System.Windows.Forms.ListBox();
            this.lblNovoId = new System.Windows.Forms.Label();
            this.txbNovoId = new System.Windows.Forms.TextBox();
            this.txbNovoNome = new System.Windows.Forms.TextBox();
            this.lblNovoNome = new System.Windows.Forms.Label();
            this.txbNovaIdade = new System.Windows.Forms.TextBox();
            this.lblNovaIdade = new System.Windows.Forms.Label();
            this.btnAddContato = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(92, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "label1";
            // 
            // lbxContatos
            // 
            this.lbxContatos.FormattingEnabled = true;
            this.lbxContatos.Location = new System.Drawing.Point(12, 43);
            this.lbxContatos.Name = "lbxContatos";
            this.lbxContatos.Size = new System.Drawing.Size(576, 381);
            this.lbxContatos.TabIndex = 1;
            // 
            // lblNovoId
            // 
            this.lblNovoId.AutoSize = true;
            this.lblNovoId.Location = new System.Drawing.Point(15, 440);
            this.lblNovoId.Name = "lblNovoId";
            this.lblNovoId.Size = new System.Drawing.Size(21, 13);
            this.lblNovoId.TabIndex = 2;
            this.lblNovoId.Text = "ID:";
            // 
            // txbNovoId
            // 
            this.txbNovoId.Location = new System.Drawing.Point(42, 437);
            this.txbNovoId.Name = "txbNovoId";
            this.txbNovoId.Size = new System.Drawing.Size(100, 20);
            this.txbNovoId.TabIndex = 3;
            // 
            // txbNovoNome
            // 
            this.txbNovoNome.Location = new System.Drawing.Point(199, 437);
            this.txbNovoNome.Name = "txbNovoNome";
            this.txbNovoNome.Size = new System.Drawing.Size(100, 20);
            this.txbNovoNome.TabIndex = 5;
            // 
            // lblNovoNome
            // 
            this.lblNovoNome.AutoSize = true;
            this.lblNovoNome.Location = new System.Drawing.Point(155, 440);
            this.lblNovoNome.Name = "lblNovoNome";
            this.lblNovoNome.Size = new System.Drawing.Size(38, 13);
            this.lblNovoNome.TabIndex = 4;
            this.lblNovoNome.Text = "Nome:";
            // 
            // txbNovaIdade
            // 
            this.txbNovaIdade.Location = new System.Drawing.Point(350, 437);
            this.txbNovaIdade.Name = "txbNovaIdade";
            this.txbNovaIdade.Size = new System.Drawing.Size(100, 20);
            this.txbNovaIdade.TabIndex = 7;
            // 
            // lblNovaIdade
            // 
            this.lblNovaIdade.AutoSize = true;
            this.lblNovaIdade.Location = new System.Drawing.Point(307, 440);
            this.lblNovaIdade.Name = "lblNovaIdade";
            this.lblNovaIdade.Size = new System.Drawing.Size(37, 13);
            this.lblNovaIdade.TabIndex = 6;
            this.lblNovaIdade.Text = "Idade:";
            // 
            // btnAddContato
            // 
            this.btnAddContato.Location = new System.Drawing.Point(456, 435);
            this.btnAddContato.Name = "btnAddContato";
            this.btnAddContato.Size = new System.Drawing.Size(132, 23);
            this.btnAddContato.TabIndex = 8;
            this.btnAddContato.Text = "Adicionar Contato";
            this.btnAddContato.UseVisualStyleBackColor = true;
            this.btnAddContato.Click += new System.EventHandler(this.btnAddContato_Click);
            // 
            // frmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 471);
            this.Controls.Add(this.btnAddContato);
            this.Controls.Add(this.txbNovaIdade);
            this.Controls.Add(this.lblNovaIdade);
            this.Controls.Add(this.txbNovoNome);
            this.Controls.Add(this.lblNovoNome);
            this.Controls.Add(this.txbNovoId);
            this.Controls.Add(this.lblNovoId);
            this.Controls.Add(this.lbxContatos);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmAgenda";
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ListBox lbxContatos;
        private System.Windows.Forms.Label lblNovoId;
        private System.Windows.Forms.TextBox txbNovoId;
        private System.Windows.Forms.TextBox txbNovoNome;
        private System.Windows.Forms.Label lblNovoNome;
        private System.Windows.Forms.TextBox txbNovaIdade;
        private System.Windows.Forms.Label lblNovaIdade;
        private System.Windows.Forms.Button btnAddContato;
    }
}

