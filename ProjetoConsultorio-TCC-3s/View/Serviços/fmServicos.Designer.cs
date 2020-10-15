namespace ProjetoTCC2020.Serviços
{
    partial class fmServicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmServicos));
            this.lbServTitulo = new System.Windows.Forms.Label();
            this.btServCanc = new System.Windows.Forms.Button();
            this.btServInserir = new System.Windows.Forms.Button();
            this.lbServCod = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lbServNome = new System.Windows.Forms.Label();
            this.tbServNome = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pnServCadastroCat = new System.Windows.Forms.Panel();
            this.btServPnFechar = new System.Windows.Forms.Button();
            this.btServPnAlterar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.lbServCodCat = new System.Windows.Forms.Label();
            this.btServPnInserir = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.btServInserirNovo = new System.Windows.Forms.Button();
            this.btServLimpar = new System.Windows.Forms.Button();
            this.btServAlterar = new System.Windows.Forms.Button();
            this.btServDelete = new System.Windows.Forms.Button();
            this.pnServCadastroCat.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbServTitulo
            // 
            this.lbServTitulo.AutoSize = true;
            this.lbServTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbServTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbServTitulo.Location = new System.Drawing.Point(189, 18);
            this.lbServTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbServTitulo.Name = "lbServTitulo";
            this.lbServTitulo.Size = new System.Drawing.Size(263, 29);
            this.lbServTitulo.TabIndex = 52;
            this.lbServTitulo.Text = "Cadastro de Serviços";
            // 
            // btServCanc
            // 
            this.btServCanc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(96)))), ((int)(((byte)(145)))));
            this.btServCanc.BackgroundImage = global::ProjetoTCC2020.Properties.Resources.icons8_excluir_64;
            this.btServCanc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btServCanc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btServCanc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btServCanc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(96)))), ((int)(((byte)(145)))));
            this.btServCanc.Location = new System.Drawing.Point(561, 169);
            this.btServCanc.Margin = new System.Windows.Forms.Padding(4);
            this.btServCanc.Name = "btServCanc";
            this.btServCanc.Size = new System.Drawing.Size(61, 47);
            this.btServCanc.TabIndex = 51;
            this.btServCanc.UseVisualStyleBackColor = false;
            this.btServCanc.Click += new System.EventHandler(this.button2_Click);
            // 
            // btServInserir
            // 
            this.btServInserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(96)))), ((int)(((byte)(145)))));
            this.btServInserir.BackgroundImage = global::ProjetoTCC2020.Properties.Resources.icons8_selecionado_64;
            this.btServInserir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btServInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btServInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btServInserir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(96)))), ((int)(((byte)(145)))));
            this.btServInserir.Location = new System.Drawing.Point(19, 169);
            this.btServInserir.Margin = new System.Windows.Forms.Padding(4);
            this.btServInserir.Name = "btServInserir";
            this.btServInserir.Size = new System.Drawing.Size(60, 47);
            this.btServInserir.TabIndex = 49;
            this.btServInserir.UseVisualStyleBackColor = false;
            this.btServInserir.Click += new System.EventHandler(this.btAgInserir_Click);
            // 
            // lbServCod
            // 
            this.lbServCod.AutoSize = true;
            this.lbServCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbServCod.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbServCod.Location = new System.Drawing.Point(15, 39);
            this.lbServCod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbServCod.Name = "lbServCod";
            this.lbServCod.Size = new System.Drawing.Size(93, 16);
            this.lbServCod.TabIndex = 45;
            this.lbServCod.Text = "Cod Serviço";
            this.lbServCod.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(17, 59);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(112, 26);
            this.textBox4.TabIndex = 44;
            this.textBox4.Visible = false;
            // 
            // lbServNome
            // 
            this.lbServNome.AutoSize = true;
            this.lbServNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbServNome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbServNome.Location = new System.Drawing.Point(12, 95);
            this.lbServNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbServNome.Name = "lbServNome";
            this.lbServNome.Size = new System.Drawing.Size(128, 16);
            this.lbServNome.TabIndex = 39;
            this.lbServNome.Text = "Nome do Serviço";
            // 
            // tbServNome
            // 
            this.tbServNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbServNome.Location = new System.Drawing.Point(15, 113);
            this.tbServNome.Margin = new System.Windows.Forms.Padding(4);
            this.tbServNome.Name = "tbServNome";
            this.tbServNome.Size = new System.Drawing.Size(604, 26);
            this.tbServNome.TabIndex = 38;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(17, 114);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(603, 26);
            this.comboBox1.TabIndex = 34;
            this.comboBox1.Visible = false;
            // 
            // pnServCadastroCat
            // 
            this.pnServCadastroCat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnServCadastroCat.Controls.Add(this.btServPnFechar);
            this.pnServCadastroCat.Controls.Add(this.btServPnAlterar);
            this.pnServCadastroCat.Controls.Add(this.label2);
            this.pnServCadastroCat.Controls.Add(this.textBox7);
            this.pnServCadastroCat.Controls.Add(this.lbServCodCat);
            this.pnServCadastroCat.Controls.Add(this.btServPnInserir);
            this.pnServCadastroCat.Controls.Add(this.textBox6);
            this.pnServCadastroCat.Location = new System.Drawing.Point(626, 113);
            this.pnServCadastroCat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnServCadastroCat.Name = "pnServCadastroCat";
            this.pnServCadastroCat.Size = new System.Drawing.Size(439, 100);
            this.pnServCadastroCat.TabIndex = 54;
            this.pnServCadastroCat.Visible = false;
            // 
            // btServPnFechar
            // 
            this.btServPnFechar.BackColor = System.Drawing.Color.IndianRed;
            this.btServPnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btServPnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btServPnFechar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btServPnFechar.Location = new System.Drawing.Point(345, 64);
            this.btServPnFechar.Margin = new System.Windows.Forms.Padding(4);
            this.btServPnFechar.Name = "btServPnFechar";
            this.btServPnFechar.Size = new System.Drawing.Size(75, 28);
            this.btServPnFechar.TabIndex = 56;
            this.btServPnFechar.Text = "Fechar";
            this.btServPnFechar.UseVisualStyleBackColor = false;
            this.btServPnFechar.Click += new System.EventHandler(this.button4_Click);
            // 
            // btServPnAlterar
            // 
            this.btServPnAlterar.BackColor = System.Drawing.Color.White;
            this.btServPnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btServPnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btServPnAlterar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btServPnAlterar.Location = new System.Drawing.Point(261, 64);
            this.btServPnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.btServPnAlterar.Name = "btServPnAlterar";
            this.btServPnAlterar.Size = new System.Drawing.Size(75, 28);
            this.btServPnAlterar.TabIndex = 55;
            this.btServPnAlterar.Text = "Alterar";
            this.btServPnAlterar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(87, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 58;
            this.label2.Text = "Nome Categoria";
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(89, 30);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(331, 26);
            this.textBox7.TabIndex = 57;
            // 
            // lbServCodCat
            // 
            this.lbServCodCat.AutoSize = true;
            this.lbServCodCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbServCodCat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbServCodCat.Location = new System.Drawing.Point(8, 11);
            this.lbServCodCat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbServCodCat.Name = "lbServCodCat";
            this.lbServCodCat.Size = new System.Drawing.Size(63, 16);
            this.lbServCodCat.TabIndex = 56;
            this.lbServCodCat.Text = "Cod Cat";
            // 
            // btServPnInserir
            // 
            this.btServPnInserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(219)))), ((int)(((byte)(112)))));
            this.btServPnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btServPnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btServPnInserir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btServPnInserir.Location = new System.Drawing.Point(13, 64);
            this.btServPnInserir.Margin = new System.Windows.Forms.Padding(4);
            this.btServPnInserir.Name = "btServPnInserir";
            this.btServPnInserir.Size = new System.Drawing.Size(75, 28);
            this.btServPnInserir.TabIndex = 55;
            this.btServPnInserir.Text = "Inserir";
            this.btServPnInserir.UseVisualStyleBackColor = false;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(13, 30);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(65, 26);
            this.textBox6.TabIndex = 55;
            // 
            // btServInserirNovo
            // 
            this.btServInserirNovo.BackColor = System.Drawing.Color.Transparent;
            this.btServInserirNovo.BackgroundImage = global::ProjetoTCC2020.Properties.Resources.icons8_mais_64;
            this.btServInserirNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btServInserirNovo.Enabled = false;
            this.btServInserirNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btServInserirNovo.Location = new System.Drawing.Point(569, 66);
            this.btServInserirNovo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btServInserirNovo.Name = "btServInserirNovo";
            this.btServInserirNovo.Size = new System.Drawing.Size(51, 44);
            this.btServInserirNovo.TabIndex = 53;
            this.btServInserirNovo.UseVisualStyleBackColor = false;
            this.btServInserirNovo.Visible = false;
            this.btServInserirNovo.Click += new System.EventHandler(this.btServInserir_Click);
            // 
            // btServLimpar
            // 
            this.btServLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(96)))), ((int)(((byte)(145)))));
            this.btServLimpar.BackgroundImage = global::ProjetoTCC2020.Properties.Resources.Actions_draw_eraser_icon;
            this.btServLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btServLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btServLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btServLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(96)))), ((int)(((byte)(145)))));
            this.btServLimpar.Location = new System.Drawing.Point(295, 167);
            this.btServLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btServLimpar.Name = "btServLimpar";
            this.btServLimpar.Size = new System.Drawing.Size(65, 47);
            this.btServLimpar.TabIndex = 50;
            this.btServLimpar.UseVisualStyleBackColor = false;
            this.btServLimpar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btServAlterar
            // 
            this.btServAlterar.BackgroundImage = global::ProjetoTCC2020.Properties.Resources.icons8_editar_vários_40;
            this.btServAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btServAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btServAlterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(96)))), ((int)(((byte)(145)))));
            this.btServAlterar.Location = new System.Drawing.Point(157, 167);
            this.btServAlterar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btServAlterar.Name = "btServAlterar";
            this.btServAlterar.Size = new System.Drawing.Size(59, 49);
            this.btServAlterar.TabIndex = 65;
            this.btServAlterar.UseVisualStyleBackColor = true;
            this.btServAlterar.Click += new System.EventHandler(this.btCadFunAlterar_Click);
            // 
            // btServDelete
            // 
            this.btServDelete.BackColor = System.Drawing.Color.Transparent;
            this.btServDelete.BackgroundImage = global::ProjetoTCC2020.Properties.Resources.icons8_excluir_64__2_;
            this.btServDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btServDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btServDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(96)))), ((int)(((byte)(145)))));
            this.btServDelete.Location = new System.Drawing.Point(440, 162);
            this.btServDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btServDelete.Name = "btServDelete";
            this.btServDelete.Size = new System.Drawing.Size(52, 53);
            this.btServDelete.TabIndex = 66;
            this.btServDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btServDelete.UseVisualStyleBackColor = false;
            this.btServDelete.Click += new System.EventHandler(this.btAgDelete_Click);
            // 
            // fmServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(96)))), ((int)(((byte)(145)))));
            this.ClientSize = new System.Drawing.Size(639, 231);
            this.Controls.Add(this.btServDelete);
            this.Controls.Add(this.btServAlterar);
            this.Controls.Add(this.pnServCadastroCat);
            this.Controls.Add(this.lbServTitulo);
            this.Controls.Add(this.btServInserirNovo);
            this.Controls.Add(this.btServCanc);
            this.Controls.Add(this.btServLimpar);
            this.Controls.Add(this.btServInserir);
            this.Controls.Add(this.lbServCod);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.lbServNome);
            this.Controls.Add(this.tbServNome);
            this.Controls.Add(this.comboBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmServicos";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serviços";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fmServicos_FormClosing);
            this.Load += new System.EventHandler(this.Serviços_Load);
            this.pnServCadastroCat.ResumeLayout(false);
            this.pnServCadastroCat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbServTitulo;
        private System.Windows.Forms.Button btServCanc;
        private System.Windows.Forms.Button btServInserir;
        private System.Windows.Forms.Label lbServCod;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lbServNome;
        private System.Windows.Forms.TextBox tbServNome;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btServInserirNovo;
        private System.Windows.Forms.Panel pnServCadastroCat;
        private System.Windows.Forms.Button btServPnFechar;
        private System.Windows.Forms.Button btServPnAlterar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label lbServCodCat;
        private System.Windows.Forms.Button btServPnInserir;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button btServLimpar;
        private System.Windows.Forms.Button btServAlterar;
        private System.Windows.Forms.Button btServDelete;
    }
}