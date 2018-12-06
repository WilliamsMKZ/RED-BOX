namespace RedBoxGames
{
    partial class CadFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadFornecedor));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtContato = new System.Windows.Forms.TextBox();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnIncluir = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BtnVoltar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(49, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "NOME:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(49, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "CPF/CNPJ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(49, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "CONTATO:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(173, 183);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(474, 20);
            this.txtNome.TabIndex = 5;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(173, 240);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(474, 20);
            this.txtCPF.TabIndex = 6;
            // 
            // txtContato
            // 
            this.txtContato.Location = new System.Drawing.Point(173, 298);
            this.txtContato.Name = "txtContato";
            this.txtContato.Size = new System.Drawing.Size(474, 20);
            this.txtContato.TabIndex = 7;
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
            this.BtnLimpar.Location = new System.Drawing.Point(565, 429);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(127, 57);
            this.BtnLimpar.TabIndex = 11;
            this.BtnLimpar.Text = "LIMPAR";
            this.BtnLimpar.UseVisualStyleBackColor = false;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnIncluir
            // 
            this.BtnIncluir.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnIncluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnIncluir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnIncluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.BtnIncluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.BtnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIncluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIncluir.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnIncluir.Location = new System.Drawing.Point(698, 429);
            this.BtnIncluir.MaximumSize = new System.Drawing.Size(127, 57);
            this.BtnIncluir.MinimumSize = new System.Drawing.Size(127, 57);
            this.BtnIncluir.Name = "BtnIncluir";
            this.BtnIncluir.Size = new System.Drawing.Size(127, 57);
            this.BtnIncluir.TabIndex = 12;
            this.BtnIncluir.Text = "Ok";
            this.BtnIncluir.UseVisualStyleBackColor = false;
            this.BtnIncluir.Click += new System.EventHandler(this.BtnIncluir_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnCancelar.Location = new System.Drawing.Point(432, 429);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnCancelar.Size = new System.Drawing.Size(127, 57);
            this.BtnCancelar.TabIndex = 13;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.BtnVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnVoltar.BackgroundImage")));
            this.BtnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnVoltar.Location = new System.Drawing.Point(769, 6);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(78, 39);
            this.BtnVoltar.TabIndex = 14;
            this.BtnVoltar.TabStop = false;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // CadFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(837, 498);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnIncluir);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.txtContato);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(853, 536);
            this.MinimumSize = new System.Drawing.Size(853, 536);
            this.Name = "CadFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INCLUIR FORNECEDOR - RED BOX";
            this.Load += new System.EventHandler(this.CadFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnVoltar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtContato;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnIncluir;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.PictureBox BtnVoltar;
    }
}