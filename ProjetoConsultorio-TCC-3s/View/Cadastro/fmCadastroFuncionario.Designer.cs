using System;

namespace ProjetoTCC2020.Cadastro
{
    partial class fmCadastroFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmCadastroFuncionario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbCadastroCli = new System.Windows.Forms.Label();
            this.lbCadNome = new System.Windows.Forms.Label();
            this.tbCadFunNome = new System.Windows.Forms.TextBox();
            this.lbCadCep = new System.Windows.Forms.Label();
            this.tbCadFunBairro = new System.Windows.Forms.TextBox();
            this.lbCadBairro = new System.Windows.Forms.Label();
            this.tbCadFunEnd = new System.Windows.Forms.TextBox();
            this.lbCadEnd = new System.Windows.Forms.Label();
            this.tbCadFunNum = new System.Windows.Forms.TextBox();
            this.lbCadTel1 = new System.Windows.Forms.Label();
            this.tbCadFunComplemento = new System.Windows.Forms.TextBox();
            this.lbComplemento = new System.Windows.Forms.Label();
            this.mkCadFunTel1 = new System.Windows.Forms.MaskedTextBox();
            this.mkCadFunCep = new System.Windows.Forms.MaskedTextBox();
            this.gbCadFunStatus = new System.Windows.Forms.GroupBox();
            this.rdCadFunDesativado = new System.Windows.Forms.RadioButton();
            this.rdCadfunAtivo = new System.Windows.Forms.RadioButton();
            this.lbCadNumero = new System.Windows.Forms.Label();
            this.tbCadFunSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btCadFunAlterar = new System.Windows.Forms.Button();
            this.btCadLimpar = new System.Windows.Forms.Button();
            this.btCadInserir = new System.Windows.Forms.Button();
            this.btCadCanc = new System.Windows.Forms.Button();
            this.mkCadFunCpf = new System.Windows.Forms.MaskedTextBox();
            this.lbCadMsgErro = new System.Windows.Forms.Label();
            this.pbCadCpfErrado = new System.Windows.Forms.PictureBox();
            this.pbCadCpfCorreto = new System.Windows.Forms.PictureBox();
            this.lbCadCpfCli = new System.Windows.Forms.Label();
            this.cbCadFunCidade = new System.Windows.Forms.ComboBox();
            this.lbCadUf = new System.Windows.Forms.Label();
            this.cbCadFunUf = new System.Windows.Forms.ComboBox();
            this.lbCadCidade = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gbCadFunStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCadCpfErrado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCadCpfCorreto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbCadastroCli);
            this.panel1.Location = new System.Drawing.Point(23, 17);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 113);
            this.panel1.TabIndex = 0;
            // 
            // lbCadastroCli
            // 
            this.lbCadastroCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadastroCli.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCadastroCli.Location = new System.Drawing.Point(43, 7);
            this.lbCadastroCli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCadastroCli.Name = "lbCadastroCli";
            this.lbCadastroCli.Size = new System.Drawing.Size(813, 98);
            this.lbCadastroCli.TabIndex = 0;
            this.lbCadastroCli.Text = "Cadastro de Funcionario";
            this.lbCadastroCli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCadNome
            // 
            this.lbCadNome.AutoSize = true;
            this.lbCadNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadNome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCadNome.Location = new System.Drawing.Point(20, 203);
            this.lbCadNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCadNome.Name = "lbCadNome";
            this.lbCadNome.Size = new System.Drawing.Size(49, 17);
            this.lbCadNome.TabIndex = 5;
            this.lbCadNome.Text = "Nome";
            // 
            // tbCadFunNome
            // 
            this.tbCadFunNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCadFunNome.Location = new System.Drawing.Point(21, 225);
            this.tbCadFunNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCadFunNome.Name = "tbCadFunNome";
            this.tbCadFunNome.Size = new System.Drawing.Size(764, 26);
            this.tbCadFunNome.TabIndex = 2;
            // 
            // lbCadCep
            // 
            this.lbCadCep.AutoSize = true;
            this.lbCadCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadCep.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCadCep.Location = new System.Drawing.Point(20, 260);
            this.lbCadCep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCadCep.Name = "lbCadCep";
            this.lbCadCep.Size = new System.Drawing.Size(38, 17);
            this.lbCadCep.TabIndex = 7;
            this.lbCadCep.Text = "CEP";
            // 
            // tbCadFunBairro
            // 
            this.tbCadFunBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCadFunBairro.Location = new System.Drawing.Point(21, 386);
            this.tbCadFunBairro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCadFunBairro.Name = "tbCadFunBairro";
            this.tbCadFunBairro.Size = new System.Drawing.Size(764, 26);
            this.tbCadFunBairro.TabIndex = 8;
            // 
            // lbCadBairro
            // 
            this.lbCadBairro.AutoSize = true;
            this.lbCadBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadBairro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCadBairro.Location = new System.Drawing.Point(19, 366);
            this.lbCadBairro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCadBairro.Name = "lbCadBairro";
            this.lbCadBairro.Size = new System.Drawing.Size(52, 17);
            this.lbCadBairro.TabIndex = 17;
            this.lbCadBairro.Text = "Bairro";
            // 
            // tbCadFunEnd
            // 
            this.tbCadFunEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCadFunEnd.Location = new System.Drawing.Point(21, 336);
            this.tbCadFunEnd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCadFunEnd.Name = "tbCadFunEnd";
            this.tbCadFunEnd.Size = new System.Drawing.Size(764, 26);
            this.tbCadFunEnd.TabIndex = 6;
            // 
            // lbCadEnd
            // 
            this.lbCadEnd.AutoSize = true;
            this.lbCadEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadEnd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCadEnd.Location = new System.Drawing.Point(21, 315);
            this.lbCadEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCadEnd.Name = "lbCadEnd";
            this.lbCadEnd.Size = new System.Drawing.Size(37, 17);
            this.lbCadEnd.TabIndex = 13;
            this.lbCadEnd.Text = "Rua";
            // 
            // tbCadFunNum
            // 
            this.tbCadFunNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCadFunNum.Location = new System.Drawing.Point(816, 336);
            this.tbCadFunNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCadFunNum.Name = "tbCadFunNum";
            this.tbCadFunNum.Size = new System.Drawing.Size(88, 26);
            this.tbCadFunNum.TabIndex = 7;
            this.tbCadFunNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCadFunNum_KeyPress);
            // 
            // lbCadTel1
            // 
            this.lbCadTel1.AutoSize = true;
            this.lbCadTel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadTel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCadTel1.Location = new System.Drawing.Point(19, 423);
            this.lbCadTel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCadTel1.Name = "lbCadTel1";
            this.lbCadTel1.Size = new System.Drawing.Size(103, 17);
            this.lbCadTel1.TabIndex = 23;
            this.lbCadTel1.Text = "1º - Telefone";
            // 
            // tbCadFunComplemento
            // 
            this.tbCadFunComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCadFunComplemento.Location = new System.Drawing.Point(816, 388);
            this.tbCadFunComplemento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCadFunComplemento.Name = "tbCadFunComplemento";
            this.tbCadFunComplemento.Size = new System.Drawing.Size(88, 26);
            this.tbCadFunComplemento.TabIndex = 9;
            // 
            // lbComplemento
            // 
            this.lbComplemento.AutoSize = true;
            this.lbComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComplemento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbComplemento.Location = new System.Drawing.Point(813, 367);
            this.lbComplemento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbComplemento.Name = "lbComplemento";
            this.lbComplemento.Size = new System.Drawing.Size(53, 17);
            this.lbComplemento.TabIndex = 19;
            this.lbComplemento.Text = "Comp.";
            // 
            // mkCadFunTel1
            // 
            this.mkCadFunTel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkCadFunTel1.Location = new System.Drawing.Point(21, 446);
            this.mkCadFunTel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mkCadFunTel1.Mask = "(99) 99999-9999";
            this.mkCadFunTel1.Name = "mkCadFunTel1";
            this.mkCadFunTel1.Size = new System.Drawing.Size(179, 26);
            this.mkCadFunTel1.TabIndex = 10;
            // 
            // mkCadFunCep
            // 
            this.mkCadFunCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkCadFunCep.Location = new System.Drawing.Point(23, 281);
            this.mkCadFunCep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mkCadFunCep.Mask = "99999-999";
            this.mkCadFunCep.Name = "mkCadFunCep";
            this.mkCadFunCep.Size = new System.Drawing.Size(133, 26);
            this.mkCadFunCep.TabIndex = 3;
            this.mkCadFunCep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mkCadFunCep.ValidatingType = typeof(System.DateTime);
            // 
            // gbCadFunStatus
            // 
            this.gbCadFunStatus.Controls.Add(this.rdCadFunDesativado);
            this.gbCadFunStatus.Controls.Add(this.rdCadfunAtivo);
            this.gbCadFunStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbCadFunStatus.Location = new System.Drawing.Point(23, 138);
            this.gbCadFunStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbCadFunStatus.Name = "gbCadFunStatus";
            this.gbCadFunStatus.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbCadFunStatus.Size = new System.Drawing.Size(119, 58);
            this.gbCadFunStatus.TabIndex = 31;
            this.gbCadFunStatus.TabStop = false;
            this.gbCadFunStatus.Text = "Status";
            // 
            // rdCadFunDesativado
            // 
            this.rdCadFunDesativado.AutoSize = true;
            this.rdCadFunDesativado.BackColor = System.Drawing.Color.Transparent;
            this.rdCadFunDesativado.Enabled = false;
            this.rdCadFunDesativado.Location = new System.Drawing.Point(8, 34);
            this.rdCadFunDesativado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdCadFunDesativado.Name = "rdCadFunDesativado";
            this.rdCadFunDesativado.Size = new System.Drawing.Size(65, 20);
            this.rdCadFunDesativado.TabIndex = 1;
            this.rdCadFunDesativado.TabStop = true;
            this.rdCadFunDesativado.Text = "Inativo";
            this.rdCadFunDesativado.UseVisualStyleBackColor = false;
            // 
            // rdCadfunAtivo
            // 
            this.rdCadfunAtivo.AutoSize = true;
            this.rdCadfunAtivo.BackColor = System.Drawing.Color.Transparent;
            this.rdCadfunAtivo.Enabled = false;
            this.rdCadfunAtivo.Location = new System.Drawing.Point(8, 14);
            this.rdCadfunAtivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdCadfunAtivo.Name = "rdCadfunAtivo";
            this.rdCadfunAtivo.Size = new System.Drawing.Size(56, 20);
            this.rdCadfunAtivo.TabIndex = 0;
            this.rdCadfunAtivo.TabStop = true;
            this.rdCadfunAtivo.Text = "Ativo";
            this.rdCadfunAtivo.UseVisualStyleBackColor = false;
            // 
            // lbCadNumero
            // 
            this.lbCadNumero.AutoSize = true;
            this.lbCadNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadNumero.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCadNumero.Location = new System.Drawing.Point(816, 313);
            this.lbCadNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCadNumero.Name = "lbCadNumero";
            this.lbCadNumero.Size = new System.Drawing.Size(25, 17);
            this.lbCadNumero.TabIndex = 15;
            this.lbCadNumero.Text = "Nº";
            // 
            // tbCadFunSenha
            // 
            this.tbCadFunSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCadFunSenha.Location = new System.Drawing.Point(232, 446);
            this.tbCadFunSenha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCadFunSenha.Name = "tbCadFunSenha";
            this.tbCadFunSenha.Size = new System.Drawing.Size(232, 26);
            this.tbCadFunSenha.TabIndex = 11;
            this.tbCadFunSenha.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(229, 422);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 66;
            this.label1.Text = "Senha";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::ProjetoTCC2020.Properties.Resources.icons8_visível_80;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(96)))), ((int)(((byte)(145)))));
            this.button1.Location = new System.Drawing.Point(471, 446);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 26);
            this.button1.TabIndex = 67;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // btCadFunAlterar
            // 
            this.btCadFunAlterar.BackgroundImage = global::ProjetoTCC2020.Properties.Resources.icons8_editar_vários_40;
            this.btCadFunAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btCadFunAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadFunAlterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(96)))), ((int)(((byte)(145)))));
            this.btCadFunAlterar.Location = new System.Drawing.Point(293, 497);
            this.btCadFunAlterar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCadFunAlterar.Name = "btCadFunAlterar";
            this.btCadFunAlterar.Size = new System.Drawing.Size(47, 39);
            this.btCadFunAlterar.TabIndex = 15;
            this.btCadFunAlterar.UseVisualStyleBackColor = true;
            this.btCadFunAlterar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btCadLimpar
            // 
            this.btCadLimpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btCadLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(96)))), ((int)(((byte)(145)))));
            this.btCadLimpar.BackgroundImage = global::ProjetoTCC2020.Properties.Resources.Actions_draw_eraser_icon;
            this.btCadLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btCadLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(96)))), ((int)(((byte)(145)))));
            this.btCadLimpar.Location = new System.Drawing.Point(572, 497);
            this.btCadLimpar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCadLimpar.Name = "btCadLimpar";
            this.btCadLimpar.Size = new System.Drawing.Size(53, 38);
            this.btCadLimpar.TabIndex = 13;
            this.btCadLimpar.UseVisualStyleBackColor = false;
            this.btCadLimpar.Click += new System.EventHandler(this.btCadLimpar_Click);
            // 
            // btCadInserir
            // 
            this.btCadInserir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btCadInserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(96)))), ((int)(((byte)(145)))));
            this.btCadInserir.BackgroundImage = global::ProjetoTCC2020.Properties.Resources.icons8_selecionado_64;
            this.btCadInserir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btCadInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadInserir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(96)))), ((int)(((byte)(145)))));
            this.btCadInserir.Location = new System.Drawing.Point(23, 497);
            this.btCadInserir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCadInserir.Name = "btCadInserir";
            this.btCadInserir.Size = new System.Drawing.Size(51, 38);
            this.btCadInserir.TabIndex = 12;
            this.btCadInserir.UseVisualStyleBackColor = false;
            this.btCadInserir.Click += new System.EventHandler(this.btCadInserir_Click);
            // 
            // btCadCanc
            // 
            this.btCadCanc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btCadCanc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(96)))), ((int)(((byte)(145)))));
            this.btCadCanc.BackgroundImage = global::ProjetoTCC2020.Properties.Resources.icons8_excluir_64;
            this.btCadCanc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btCadCanc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(96)))), ((int)(((byte)(145)))));
            this.btCadCanc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadCanc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadCanc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(96)))), ((int)(((byte)(145)))));
            this.btCadCanc.Location = new System.Drawing.Point(852, 497);
            this.btCadCanc.Margin = new System.Windows.Forms.Padding(0);
            this.btCadCanc.Name = "btCadCanc";
            this.btCadCanc.Size = new System.Drawing.Size(52, 38);
            this.btCadCanc.TabIndex = 14;
            this.btCadCanc.UseVisualStyleBackColor = false;
            this.btCadCanc.Click += new System.EventHandler(this.btCadCanc_Click);
            // 
            // mkCadFunCpf
            // 
            this.mkCadFunCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkCadFunCpf.Location = new System.Drawing.Point(187, 164);
            this.mkCadFunCpf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mkCadFunCpf.Mask = "000,000,000-00";
            this.mkCadFunCpf.Name = "mkCadFunCpf";
            this.mkCadFunCpf.Size = new System.Drawing.Size(161, 26);
            this.mkCadFunCpf.TabIndex = 1;
            this.mkCadFunCpf.Leave += new System.EventHandler(this.mkCadFunCpf_Leave);
            // 
            // lbCadMsgErro
            // 
            this.lbCadMsgErro.AutoSize = true;
            this.lbCadMsgErro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadMsgErro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCadMsgErro.Location = new System.Drawing.Point(188, 196);
            this.lbCadMsgErro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCadMsgErro.Name = "lbCadMsgErro";
            this.lbCadMsgErro.Size = new System.Drawing.Size(51, 15);
            this.lbCadMsgErro.TabIndex = 72;
            this.lbCadMsgErro.Text = "           ";
            // 
            // pbCadCpfErrado
            // 
            this.pbCadCpfErrado.Enabled = false;
            this.pbCadCpfErrado.Image = global::ProjetoTCC2020.Properties.Resources.icons8_excluir_64;
            this.pbCadCpfErrado.Location = new System.Drawing.Point(357, 165);
            this.pbCadCpfErrado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbCadCpfErrado.Name = "pbCadCpfErrado";
            this.pbCadCpfErrado.Size = new System.Drawing.Size(27, 27);
            this.pbCadCpfErrado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCadCpfErrado.TabIndex = 71;
            this.pbCadCpfErrado.TabStop = false;
            this.pbCadCpfErrado.Visible = false;
            // 
            // pbCadCpfCorreto
            // 
            this.pbCadCpfCorreto.Image = global::ProjetoTCC2020.Properties.Resources.icons8_selecionado_64;
            this.pbCadCpfCorreto.Location = new System.Drawing.Point(356, 165);
            this.pbCadCpfCorreto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbCadCpfCorreto.Name = "pbCadCpfCorreto";
            this.pbCadCpfCorreto.Size = new System.Drawing.Size(27, 27);
            this.pbCadCpfCorreto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCadCpfCorreto.TabIndex = 70;
            this.pbCadCpfCorreto.TabStop = false;
            this.pbCadCpfCorreto.Visible = false;
            // 
            // lbCadCpfCli
            // 
            this.lbCadCpfCli.AutoSize = true;
            this.lbCadCpfCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadCpfCli.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCadCpfCli.Location = new System.Drawing.Point(185, 144);
            this.lbCadCpfCli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCadCpfCli.Name = "lbCadCpfCli";
            this.lbCadCpfCli.Size = new System.Drawing.Size(42, 17);
            this.lbCadCpfCli.TabIndex = 68;
            this.lbCadCpfCli.Text = "CPF ";
            // 
            // cbCadFunCidade
            // 
            this.cbCadFunCidade.DropDownHeight = 270;
            this.cbCadFunCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCadFunCidade.Enabled = false;
            this.cbCadFunCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCadFunCidade.FormattingEnabled = true;
            this.cbCadFunCidade.IntegralHeight = false;
            this.cbCadFunCidade.ItemHeight = 18;
            this.cbCadFunCidade.Items.AddRange(new object[] {
            "Araçatuba",
            "Bilac",
            "Birigui",
            "Piacatu"});
            this.cbCadFunCidade.Location = new System.Drawing.Point(187, 281);
            this.cbCadFunCidade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCadFunCidade.Name = "cbCadFunCidade";
            this.cbCadFunCidade.Size = new System.Drawing.Size(599, 26);
            this.cbCadFunCidade.Sorted = true;
            this.cbCadFunCidade.TabIndex = 5;
            // 
            // lbCadUf
            // 
            this.lbCadUf.AutoSize = true;
            this.lbCadUf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadUf.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCadUf.Location = new System.Drawing.Point(815, 257);
            this.lbCadUf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCadUf.Name = "lbCadUf";
            this.lbCadUf.Size = new System.Drawing.Size(28, 17);
            this.lbCadUf.TabIndex = 75;
            this.lbCadUf.Text = "UF";
            // 
            // cbCadFunUf
            // 
            this.cbCadFunUf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCadFunUf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCadFunUf.FormattingEnabled = true;
            this.cbCadFunUf.Items.AddRange(new object[] {
            "SP",
            "MT",
            "GO"});
            this.cbCadFunUf.Location = new System.Drawing.Point(816, 279);
            this.cbCadFunUf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCadFunUf.Name = "cbCadFunUf";
            this.cbCadFunUf.Size = new System.Drawing.Size(88, 26);
            this.cbCadFunUf.TabIndex = 4;
            this.cbCadFunUf.SelectedIndexChanged += new System.EventHandler(this.cbCadFunUf_SelectedIndexChanged);
            // 
            // lbCadCidade
            // 
            this.lbCadCidade.AutoSize = true;
            this.lbCadCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadCidade.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCadCidade.Location = new System.Drawing.Point(184, 258);
            this.lbCadCidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCadCidade.Name = "lbCadCidade";
            this.lbCadCidade.Size = new System.Drawing.Size(58, 17);
            this.lbCadCidade.TabIndex = 76;
            this.lbCadCidade.Text = "Cidade";
            // 
            // fmCadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(96)))), ((int)(((byte)(145)))));
            this.ClientSize = new System.Drawing.Size(932, 549);
            this.Controls.Add(this.cbCadFunCidade);
            this.Controls.Add(this.lbCadUf);
            this.Controls.Add(this.cbCadFunUf);
            this.Controls.Add(this.lbCadCidade);
            this.Controls.Add(this.mkCadFunCpf);
            this.Controls.Add(this.lbCadMsgErro);
            this.Controls.Add(this.pbCadCpfErrado);
            this.Controls.Add(this.pbCadCpfCorreto);
            this.Controls.Add(this.lbCadCpfCli);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCadFunSenha);
            this.Controls.Add(this.btCadFunAlterar);
            this.Controls.Add(this.gbCadFunStatus);
            this.Controls.Add(this.mkCadFunCep);
            this.Controls.Add(this.mkCadFunTel1);
            this.Controls.Add(this.tbCadFunComplemento);
            this.Controls.Add(this.lbComplemento);
            this.Controls.Add(this.btCadLimpar);
            this.Controls.Add(this.btCadInserir);
            this.Controls.Add(this.btCadCanc);
            this.Controls.Add(this.lbCadTel1);
            this.Controls.Add(this.lbCadNumero);
            this.Controls.Add(this.tbCadFunNum);
            this.Controls.Add(this.tbCadFunEnd);
            this.Controls.Add(this.lbCadEnd);
            this.Controls.Add(this.tbCadFunBairro);
            this.Controls.Add(this.lbCadBairro);
            this.Controls.Add(this.lbCadCep);
            this.Controls.Add(this.tbCadFunNome);
            this.Controls.Add(this.lbCadNome);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmCadastroFuncionario";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Funcionario";
            this.Load += new System.EventHandler(this.fmCadastroCliente_Load);
            this.panel1.ResumeLayout(false);
            this.gbCadFunStatus.ResumeLayout(false);
            this.gbCadFunStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCadCpfErrado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCadCpfCorreto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbCadastroCli;
        private System.Windows.Forms.Label lbCadNome;
        private System.Windows.Forms.TextBox tbCadFunNome;
        private System.Windows.Forms.Label lbCadCep;
        private System.Windows.Forms.TextBox tbCadFunBairro;
        private System.Windows.Forms.Label lbCadBairro;
        private System.Windows.Forms.TextBox tbCadFunEnd;
        private System.Windows.Forms.Label lbCadEnd;
        private System.Windows.Forms.TextBox tbCadFunNum;
        private System.Windows.Forms.Label lbCadTel1;
        private System.Windows.Forms.Button btCadLimpar;
        private System.Windows.Forms.TextBox tbCadFunComplemento;
        private System.Windows.Forms.Label lbComplemento;
        private System.Windows.Forms.MaskedTextBox mkCadFunTel1;
        private System.Windows.Forms.MaskedTextBox mkCadFunCep;
        private System.Windows.Forms.GroupBox gbCadFunStatus;
        private System.Windows.Forms.RadioButton rdCadFunDesativado;
        private System.Windows.Forms.RadioButton rdCadfunAtivo;
        private System.Windows.Forms.Button btCadFunAlterar;
        private System.Windows.Forms.Button btCadInserir;
        private System.Windows.Forms.Button btCadCanc;
        private System.Windows.Forms.Label lbCadNumero;
        private System.Windows.Forms.TextBox tbCadFunSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox mkCadFunCpf;
        private System.Windows.Forms.Label lbCadMsgErro;
        private System.Windows.Forms.PictureBox pbCadCpfErrado;
        private System.Windows.Forms.PictureBox pbCadCpfCorreto;
        private System.Windows.Forms.Label lbCadCpfCli;
        private System.Windows.Forms.ComboBox cbCadFunCidade;
        private System.Windows.Forms.Label lbCadUf;
        private System.Windows.Forms.ComboBox cbCadFunUf;
        private System.Windows.Forms.Label lbCadCidade;
    }
}