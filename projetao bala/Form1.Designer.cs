namespace projetao_bala
{
    partial class Form1
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
            this.btnSalve = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtComida = new System.Windows.Forms.TextBox();
            this.cboComidas = new System.Windows.Forms.ComboBox();
            this.btnFecharPedido = new System.Windows.Forms.Button();
            this.lstBebidas = new System.Windows.Forms.ListBox();
            this.chkViagem = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlPeao = new System.Windows.Forms.Panel();
            this.btnMover = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.tmrMover2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalve
            // 
            this.btnSalve.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalve.Location = new System.Drawing.Point(72, 46);
            this.btnSalve.Name = "btnSalve";
            this.btnSalve.Size = new System.Drawing.Size(126, 57);
            this.btnSalve.TabIndex = 0;
            this.btnSalve.Text = "falar";
            this.btnSalve.UseVisualStyleBackColor = true;
            this.btnSalve.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(91, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // txtComida
            // 
            this.txtComida.Location = new System.Drawing.Point(72, 131);
            this.txtComida.Name = "txtComida";
            this.txtComida.Size = new System.Drawing.Size(100, 20);
            this.txtComida.TabIndex = 2;
            // 
            // cboComidas
            // 
            this.cboComidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboComidas.FormattingEnabled = true;
            this.cboComidas.Items.AddRange(new object[] {
            "Lasanha",
            "Feijoada",
            "Pizza"});
            this.cboComidas.Location = new System.Drawing.Point(275, 170);
            this.cboComidas.Name = "cboComidas";
            this.cboComidas.Size = new System.Drawing.Size(297, 21);
            this.cboComidas.TabIndex = 3;
            // 
            // btnFecharPedido
            // 
            this.btnFecharPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFecharPedido.Location = new System.Drawing.Point(657, 372);
            this.btnFecharPedido.Name = "btnFecharPedido";
            this.btnFecharPedido.Size = new System.Drawing.Size(121, 57);
            this.btnFecharPedido.TabIndex = 4;
            this.btnFecharPedido.Text = "fechar";
            this.btnFecharPedido.UseVisualStyleBackColor = true;
            this.btnFecharPedido.Click += new System.EventHandler(this.btnFecharPedido_Click);
            // 
            // lstBebidas
            // 
            this.lstBebidas.FormattingEnabled = true;
            this.lstBebidas.Items.AddRange(new object[] {
            "caipirinha",
            "cerveja",
            "coca"});
            this.lstBebidas.Location = new System.Drawing.Point(622, 157);
            this.lstBebidas.Name = "lstBebidas";
            this.lstBebidas.Size = new System.Drawing.Size(120, 95);
            this.lstBebidas.TabIndex = 5;
            // 
            // chkViagem
            // 
            this.chkViagem.AutoSize = true;
            this.chkViagem.BackColor = System.Drawing.Color.Transparent;
            this.chkViagem.Location = new System.Drawing.Point(275, 212);
            this.chkViagem.Name = "chkViagem";
            this.chkViagem.Size = new System.Drawing.Size(42, 17);
            this.chkViagem.TabIndex = 6;
            this.chkViagem.Text = "vaij";
            this.chkViagem.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(77, 27);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(38, 17);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "pix";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(77, 63);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(57, 17);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.Text = "credito";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(77, 103);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(54, 17);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.Text = "debito";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(275, 266);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 147);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "pagamento";
            // 
            // pnlPeao
            // 
            this.pnlPeao.BackgroundImage = global::projetao_bala.Properties.Resources.taca;
            this.pnlPeao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPeao.Location = new System.Drawing.Point(24, 232);
            this.pnlPeao.Name = "pnlPeao";
            this.pnlPeao.Size = new System.Drawing.Size(66, 94);
            this.pnlPeao.TabIndex = 11;
            // 
            // btnMover
            // 
            this.btnMover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMover.Location = new System.Drawing.Point(657, 329);
            this.btnMover.Name = "btnMover";
            this.btnMover.Size = new System.Drawing.Size(121, 30);
            this.btnMover.TabIndex = 12;
            this.btnMover.Text = "mover";
            this.btnMover.UseVisualStyleBackColor = true;
            this.btnMover.Click += new System.EventHandler(this.btnMover_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(674, 66);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 13;
            this.btnAbrir.Text = "abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // tmrMover2
            // 
            this.tmrMover2.Interval = 3000;
            this.tmrMover2.Tick += new System.EventHandler(this.tmrMover2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::projetao_bala.Properties.Resources.ney;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.btnMover);
            this.Controls.Add(this.pnlPeao);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkViagem);
            this.Controls.Add(this.lstBebidas);
            this.Controls.Add(this.btnFecharPedido);
            this.Controls.Add(this.cboComidas);
            this.Controls.Add(this.txtComida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalve);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalve;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtComida;
        private System.Windows.Forms.ComboBox cboComidas;
        private System.Windows.Forms.Button btnFecharPedido;
        private System.Windows.Forms.ListBox lstBebidas;
        private System.Windows.Forms.CheckBox chkViagem;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlPeao;
        private System.Windows.Forms.Button btnMover;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Timer tmrMover2;
    }
}

