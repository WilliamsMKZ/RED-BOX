namespace RedBoxGames
{
    partial class Lista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lista));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mskData = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnExibir = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdStatus = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnVoltar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 226);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(813, 260);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "FORNECEDOR:";
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Location = new System.Drawing.Point(176, 85);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(132, 20);
            this.txtFornecedor.TabIndex = 6;
            this.txtFornecedor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "DATA DA EMISSÃO:";
            // 
            // mskData
            // 
            this.mskData.Location = new System.Drawing.Point(177, 120);
            this.mskData.Mask = "00/00/0000";
            this.mskData.Name = "mskData";
            this.mskData.Size = new System.Drawing.Size(131, 20);
            this.mskData.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(12, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "STATUS:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(177, 154);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(131, 20);
            this.txtStatus.TabIndex = 10;
            this.txtStatus.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.BtnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.BtnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlterar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnAlterar.Location = new System.Drawing.Point(698, 163);
            this.BtnAlterar.MaximumSize = new System.Drawing.Size(127, 57);
            this.BtnAlterar.MinimumSize = new System.Drawing.Size(127, 57);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(127, 57);
            this.BtnAlterar.TabIndex = 11;
            this.BtnAlterar.Text = "ALTERAR";
            this.BtnAlterar.UseVisualStyleBackColor = false;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.BtnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnLimpar.Location = new System.Drawing.Point(333, 120);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(96, 33);
            this.BtnLimpar.TabIndex = 12;
            this.BtnLimpar.Text = "LIMPAR";
            this.BtnLimpar.UseVisualStyleBackColor = false;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.BtnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnExcluir.Location = new System.Drawing.Point(432, 163);
            this.BtnExcluir.MaximumSize = new System.Drawing.Size(127, 57);
            this.BtnExcluir.MinimumSize = new System.Drawing.Size(127, 57);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(127, 57);
            this.BtnExcluir.TabIndex = 13;
            this.BtnExcluir.Text = "EXCLUIR";
            this.BtnExcluir.UseVisualStyleBackColor = false;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnExibir
            // 
            this.BtnExibir.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnExibir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnExibir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnExibir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.BtnExibir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.BtnExibir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExibir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExibir.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnExibir.Location = new System.Drawing.Point(565, 163);
            this.BtnExibir.MaximumSize = new System.Drawing.Size(127, 57);
            this.BtnExibir.MinimumSize = new System.Drawing.Size(127, 57);
            this.BtnExibir.Name = "BtnExibir";
            this.BtnExibir.Size = new System.Drawing.Size(127, 57);
            this.BtnExibir.TabIndex = 14;
            this.BtnExibir.Text = "EXIBIR";
            this.BtnExibir.UseVisualStyleBackColor = false;
            this.BtnExibir.Click += new System.EventHandler(this.BtnExibir_Click);
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.BtnVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnVoltar.BackgroundImage")));
            this.BtnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnVoltar.Location = new System.Drawing.Point(769, 6);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(78, 39);
            this.BtnVoltar.TabIndex = 15;
            this.BtnVoltar.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(12, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "IDSTATUS:";
            // 
            // txtIdStatus
            // 
            this.txtIdStatus.Location = new System.Drawing.Point(176, 187);
            this.txtIdStatus.Name = "txtIdStatus";
            this.txtIdStatus.Size = new System.Drawing.Size(132, 20);
            this.txtIdStatus.TabIndex = 17;
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(837, 498);
            this.Controls.Add(this.txtIdStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.BtnExibir);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mskData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(853, 536);
            this.MinimumSize = new System.Drawing.Size(853, 536);
            this.Name = "Lista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LISTA DOS JOGOS - RED BOX";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnVoltar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnExibir;
        private System.Windows.Forms.PictureBox BtnVoltar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdStatus;
    }
}