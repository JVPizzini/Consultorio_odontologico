using System;

namespace ProjetoTCC2020.Cadastro
{
    partial class fmCadastroProfissional
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmCadastroProfissional));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbCadastroCli = new System.Windows.Forms.Label();
            this.lbCadNome = new System.Windows.Forms.Label();
            this.tbCadProNome = new System.Windows.Forms.TextBox();
            this.lbCadCpfCli = new System.Windows.Forms.Label();
            this.tbCadProEmail = new System.Windows.Forms.TextBox();
            this.lbCadEmail = new System.Windows.Forms.Label();
            this.lbCadCep = new System.Windows.Forms.Label();
            this.lbCadCidade = new System.Windows.Forms.Label();
            this.tbCadProBairro = new System.Windows.Forms.TextBox();
            this.lbCadBairro = new System.Windows.Forms.Label();
            this.tbCadProEnd = new System.Windows.Forms.TextBox();
            this.lbCadEnd = new System.Windows.Forms.Label();
            this.cbCadProUf = new System.Windows.Forms.ComboBox();
            this.lbCadUf = new System.Windows.Forms.Label();
            this.cbCadProCidade = new System.Windows.Forms.ComboBox();
            this.tbCadProNum = new System.Windows.Forms.TextBox();
            this.lbCadNumero = new System.Windows.Forms.Label();
            this.lbCadTel1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbCadDataNasc = new System.Windows.Forms.Label();
            this.tbCadProObs = new System.Windows.Forms.TextBox();
            this.lbCadObs = new System.Windows.Forms.Label();
            this.btCadProCanc = new System.Windows.Forms.Button();
            this.btCadProInserir = new System.Windows.Forms.Button();
            this.btCadProLimpar = new System.Windows.Forms.Button();
            this.tbCadProComp = new System.Windows.Forms.TextBox();
            this.lbComplemento = new System.Windows.Forms.Label();
            this.lbCadMsgErro = new System.Windows.Forms.Label();
            this.mkCadProCpf = new System.Windows.Forms.MaskedTextBox();
            this.mkCadProTel1 = new System.Windows.Forms.MaskedTextBox();
            this.mkCadProTel2 = new System.Windows.Forms.MaskedTextBox();
            this.mkCadProDtNasc = new System.Windows.Forms.MaskedTextBox();
            this.mkCadProCep = new System.Windows.Forms.MaskedTextBox();
            this.pbCadCpfErrado = new System.Windows.Forms.PictureBox();
            this.pbCadCpfCorreto = new System.Windows.Forms.PictureBox();
            this.lbCadCliEmail = new System.Windows.Forms.Label();
            this.pbCadCliEmailErrado = new System.Windows.Forms.PictureBox();
            this.pbCadCliEmailCorreto = new System.Windows.Forms.PictureBox();
            this.gbCadProStatus = new System.Windows.Forms.GroupBox();
            this.rdCadProDesativado = new System.Windows.Forms.RadioButton();
            this.rdCadProAtivo = new System.Windows.Forms.RadioButton();
            this.tbCadProCro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btCadProAlterar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCadCpfErrado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCadCpfCorreto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCadCliEmailErrado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCadCliEmailCorreto)).BeginInit();
            this.gbCadProStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbCadastroCli);
            this.panel1.Location = new System.Drawing.Point(23, 17);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 123);
            this.panel1.TabIndex = 0;
            // 
            // lbCadastroCli
            // 
            this.lbCadastroCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadastroCli.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCadastroCli.Location = new System.Drawing.Point(39, 11);
            this.lbCadastroCli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCadastroCli.Name = "lbCadastroCli";
            this.lbCadastroCli.Size = new System.Drawing.Size(813, 98);
            this.lbCadastroCli.TabIndex = 0;
            this.lbCadastroCli.Text = "Cadastro de Profissional";
            this.lbCadastroCli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCadNome
            // 
            this.lbCadNome.AutoSize = true;
            this.lbCadNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadNome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCadNome.Location = new System.Drawing.Point(188, 220);
            this.lbCadNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCadNome.Name = "lbCadNome";
            this.lbCadNome.Size = new System.Drawing.Size(49, 17);
            this.lbCadNome.TabIndex = 1;
            this.lbCadNome.Text = "Nome";
            // 
            // tbCadProNome
            // 
            this.tbCadProNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCadProNome.Location = new System.Drawing.Point(188, 240);
            this.tbCadProNome.Margin = new System.Windows.Forms.Padding(4);
            this.tbCadProNome.Name = "tbCadProNome";
            this.tbCadProNome.Size = new System.Drawing.Size(719, 26);
            this.tbCadProNome.TabIndex = 4;
            // 
            // lbCadCpfCli
            // 
            this.lbCadCpfCli.AutoSize = true;
            this.lbCadCpfCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadCpfCli.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCadCpfCli.Location = new System.Drawing.Point(188, 137);
            this.lbCadCpfCli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCadCpfCli.Name = "lbCadCpfCli";
            this.lbCadCpfCli.Size = new System.Drawing.Size(42, 17);
            this.lbCadCpfCli.TabIndex = 7;
            this.lbCadCpfCli.Text = "CPF ";
            // 
            // tbCadProEmail
            // 
            this.tbCadProEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCadProEmail.Location = new System.Drawing.Point(23, 458);
            this.tbCadProEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbCadProEmail.Name = "tbCadProEmail";
            this.tbCadProEmail.Size = new System.Drawing.Size(765, 26);
            this.tbCadProEmail.TabIndex = 12;
            this.tbCadProEmail.Leave += new System.EventHandler(this.tbCadEmail_Leave);
            // 
            // lbCadEmail
            // 
            this.lbCadEmail.AutoSize = true;
            this.lbCadEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCadEmail.Location = new System.Drawing.Point(20, 438);
            this.lbCadEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCadEmail.Name = "lbCadEmail";
            this.lbCadEmail.Size = new System.Drawing.Size(47, 17);
            this.lbCadEmail.TabIndex = 9;
            this.lbCadEmail.Text = "Email";
            // 
            // lbCadCep
            // 
            this.lbCadCep.AutoSize = true;
            this.lbCadCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadCep.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCadCep.Location = new System.Drawing.Point(20, 282);
            this.lbCadCep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCadCep.Name = "lbCadCep";
            this.lbCadCep.Size = new System.Drawing.Size(38, 17);
            this.lbCadCep.TabIndex = 11;
            this.lbCadCep.Text = "CEP";
            // 
            // lbCadCidade
            // 
            this.lbCadCidade.AutoSize = true;
            this.lbCadCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadCidade.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCadCidade.Location = new System.Drawing.Point(188, 281);
            this.lbCadCidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCadCidade.Name = "lbCadCidade";
            this.lbCadCidade.Size = new System.Drawing.Size(58, 17);
            this.lbCadCidade.TabIndex = 13;
            this.lbCadCidade.Text = "Cidade";
            // 
            // tbCadProBairro
            // 
            this.tbCadProBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCadProBairro.Location = new System.Drawing.Point(23, 404);
            this.tbCadProBairro.Margin = new System.Windows.Forms.Padding(4);
            this.tbCadProBairro.Name = "tbCadProBairro";
            this.tbCadProBairro.Size = new System.Drawing.Size(764, 26);
            this.tbCadProBairro.TabIndex = 10;
            // 
            // lbCadBairro
            // 
            this.lbCadBairro.AutoSize = true;
            this.lbCadBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadBairro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCadBairro.Location = new System.Drawing.Point(20, 384);
            this.lbCadBairro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCadBairro.Name = "lbCadBairro";
            this.lbCadBairro.Size = new System.Drawing.Size(52, 17);
            this.lbCadBairro.TabIndex = 15;
            this.lbCadBairro.Text = "Bairro";
            // 
            // tbCadProEnd
            // 
            this.tbCadProEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCadProEnd.Location = new System.Drawing.Point(23, 352);
            this.tbCadProEnd.Margin = new System.Windows.Forms.Padding(4);
            this.tbCadProEnd.Name = "tbCadProEnd";
            this.tbCadProEnd.Size = new System.Drawing.Size(765, 26);
            this.tbCadProEnd.TabIndex = 8;
            // 
            // lbCadEnd
            // 
            this.lbCadEnd.AutoSize = true;
            this.lbCadEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadEnd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCadEnd.Location = new System.Drawing.Point(19, 332);
            this.lbCadEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCadEnd.Name = "lbCadEnd";
            this.lbCadEnd.Size = new System.Drawing.Size(37, 17);
            this.lbCadEnd.TabIndex = 17;
            this.lbCadEnd.Text = "Rua";
            // 
            // cbCadProUf
            // 
            this.cbCadProUf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCadProUf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCadProUf.FormattingEnabled = true;
            this.cbCadProUf.Items.AddRange(new object[] {
            "SP",
            "MT",
            "GO"});
            this.cbCadProUf.Location = new System.Drawing.Point(820, 302);
            this.cbCadProUf.Margin = new System.Windows.Forms.Padding(4);
            this.cbCadProUf.Name = "cbCadProUf";
            this.cbCadProUf.Size = new System.Drawing.Size(88, 26);
            this.cbCadProUf.TabIndex = 6;
            this.cbCadProUf.SelectedIndexChanged += new System.EventHandler(this.cbCadProUf_SelectedIndexChanged);
            // 
            // lbCadUf
            // 
            this.lbCadUf.AutoSize = true;
            this.lbCadUf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadUf.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCadUf.Location = new System.Drawing.Point(817, 282);
            this.lbCadUf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCadUf.Name = "lbCadUf";
            this.lbCadUf.Size = new System.Drawing.Size(28, 17);
            this.lbCadUf.TabIndex = 22;
            this.lbCadUf.Text = "UF";
            this.lbCadUf.Click += new System.EventHandler(this.lbCadUf_Click);
            // 
            // cbCadProCidade
            // 
            this.cbCadProCidade.DropDownHeight = 270;
            this.cbCadProCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCadProCidade.Enabled = false;
            this.cbCadProCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCadProCidade.FormattingEnabled = true;
            this.cbCadProCidade.IntegralHeight = false;
            this.cbCadProCidade.Items.AddRange(new object[] {
            "Araçatuba",
            "Bilac",
            "Birigui",
            "Piacatu"});
            this.cbCadProCidade.Location = new System.Drawing.Point(188, 302);
            this.cbCadProCidade.Margin = new System.Windows.Forms.Padding(4);
            this.cbCadProCidade.Name = "cbCadProCidade";
            this.cbCadProCidade.Size = new System.Drawing.Size(599, 26);
            this.cbCadProCidade.Sorted = true;
            this.cbCadProCidade.TabIndex = 7;
            this.cbCadProCidade.SelectedIndexChanged += new System.EventHandler(this.cbCadCliCidade_SelectedIndexChanged);
            // 
            // tbCadProNum
            // 
            this.tbCadProNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCadProNum.Location = new System.Drawing.Point(820, 352);
            this.tbCadProNum.Margin = new System.Windows.Forms.Padding(4);
            this.tbCadProNum.Name = "tbCadProNum";
            this.tbCadProNum.Size = new System.Drawing.Size(88, 26);
            this.tbCadProNum.TabIndex = 9;
            this.tbCadProNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCadProNum_KeyPress);
            // 
            // lbCadNumero
            // 
            this.lbCadNumero.AutoSize = true;
            this.lbCadNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadNumero.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCadNumero.Location = new System.Drawing.Point(820, 332);
            this.lbCadNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCadNumero.Name = "lbCadNumero";
            this.lbCadNumero.Size = new System.Drawing.Size(25, 17);
            this.lbCadNumero.TabIndex = 25;
            this.lbCadNumero.Text = "Nº";
            // 
            // lbCadTel1
            // 
            this.lbCadTel1.AutoSize = true;
            this.lbCadTel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadTel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCadTel1.Location = new System.Drawing.Point(20, 495);
            this.lbCadTel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCadTel1.Name = "lbCadTel1";
            this.lbCadTel1.Size = new System.Drawing.Size(103, 17);
            this.lbCadTel1.TabIndex = 26;
            this.lbCadTel1.Text = "1º - Telefone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(273, 495);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "2º - Telefone";
            // 
            // lbCadDataNasc
            // 
            this.lbCadDataNasc.AutoSize = true;
            this.lbCadDataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadDataNasc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCadDataNasc.Location = new System.Drawing.Point(19, 220);
            this.lbCadDataNasc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCadDataNasc.Name = "lbCadDataNasc";
            this.lbCadDataNasc.Size = new System.Drawing.Size(106, 17);
            this.lbCadDataNasc.TabIndex = 30;
            this.lbCadDataNasc.Text = "Data de Nasc";
            // 
            // tbCadProObs
            // 
            this.tbCadProObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCadProObs.Location = new System.Drawing.Point(23, 576);
            this.tbCadProObs.Margin = new System.Windows.Forms.Padding(4);
            this.tbCadProObs.Multiline = true;
            this.tbCadProObs.Name = "tbCadProObs";
            this.tbCadProObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbCadProObs.Size = new System.Drawing.Size(885, 110);
            this.tbCadProObs.TabIndex = 15;
            // 
            // lbCadObs
            // 
            this.lbCadObs.AutoSize = true;
            this.lbCadObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadObs.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCadObs.Location = new System.Drawing.Point(21, 556);
            this.lbCadObs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCadObs.Name = "lbCadObs";
            this.lbCadObs.Size = new System.Drawing.Size(89, 17);
            this.lbCadObs.TabIndex = 36;
            this.lbCadObs.Text = "Obsevação";
            // 
            // btCadProCanc
            // 
            this.btCadProCanc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btCadProCanc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(96)))), ((int)(((byte)(145)))));
            this.btCadProCanc.BackgroundImage = global::ProjetoTCC2020.Properties.Resources.icons8_excluir_64;
            this.btCadProCanc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btCadProCanc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(96)))), ((int)(((byte)(145)))));
            this.btCadProCanc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadProCanc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadProCanc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(96)))), ((int)(((byte)(145)))));
            this.btCadProCanc.Location = new System.Drawing.Point(848, 700);
            this.btCadProCanc.Margin = new System.Windows.Forms.Padding(0);
            this.btCadProCanc.Name = "btCadProCanc";
            this.btCadProCanc.Size = new System.Drawing.Size(60, 38);
            this.btCadProCanc.TabIndex = 18;
            this.btCadProCanc.UseVisualStyleBackColor = false;
            this.btCadProCanc.Click += new System.EventHandler(this.btCadCanc_Click);
            // 
            // btCadProInserir
            // 
            this.btCadProInserir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btCadProInserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(96)))), ((int)(((byte)(145)))));
            this.btCadProInserir.BackgroundImage = global::ProjetoTCC2020.Properties.Resources.icons8_selecionado_64;
            this.btCadProInserir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btCadProInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadProInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadProInserir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(96)))), ((int)(((byte)(145)))));
            this.btCadProInserir.Location = new System.Drawing.Point(21, 702);
            this.btCadProInserir.Margin = new System.Windows.Forms.Padding(4);
            this.btCadProInserir.Name = "btCadProInserir";
            this.btCadProInserir.Size = new System.Drawing.Size(51, 38);
            this.btCadProInserir.TabIndex = 16;
            this.btCadProInserir.UseVisualStyleBackColor = false;
            this.btCadProInserir.Click += new System.EventHandler(this.btCadInserir_Click);
            // 
            // btCadProLimpar
            // 
            this.btCadProLimpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btCadProLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(96)))), ((int)(((byte)(145)))));
            this.btCadProLimpar.BackgroundImage = global::ProjetoTCC2020.Properties.Resources.Actions_draw_eraser_icon;
            this.btCadProLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btCadProLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadProLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadProLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(96)))), ((int)(((byte)(145)))));
            this.btCadProLimpar.Location = new System.Drawing.Point(569, 702);
            this.btCadProLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btCadProLimpar.Name = "btCadProLimpar";
            this.btCadProLimpar.Size = new System.Drawing.Size(57, 38);
            this.btCadProLimpar.TabIndex = 17;
            this.btCadProLimpar.UseVisualStyleBackColor = false;
            this.btCadProLimpar.Click += new System.EventHandler(this.btCadLimpar_Click);
            // 
            // tbCadProComp
            // 
            this.tbCadProComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCadProComp.Location = new System.Drawing.Point(820, 404);
            this.tbCadProComp.Margin = new System.Windows.Forms.Padding(4);
            this.tbCadProComp.Name = "tbCadProComp";
            this.tbCadProComp.Size = new System.Drawing.Size(88, 26);
            this.tbCadProComp.TabIndex = 11;
            // 
            // lbComplemento
            // 
            this.lbComplemento.AutoSize = true;
            this.lbComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComplemento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbComplemento.Location = new System.Drawing.Point(817, 384);
            this.lbComplemento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbComplemento.Name = "lbComplemento";
            this.lbComplemento.Size = new System.Drawing.Size(53, 17);
            this.lbComplemento.TabIndex = 44;
            this.lbComplemento.Text = "Comp.";
            // 
            // lbCadMsgErro
            // 
            this.lbCadMsgErro.AutoSize = true;
            this.lbCadMsgErro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadMsgErro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCadMsgErro.Location = new System.Drawing.Point(191, 194);
            this.lbCadMsgErro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCadMsgErro.Name = "lbCadMsgErro";
            this.lbCadMsgErro.Size = new System.Drawing.Size(51, 15);
            this.lbCadMsgErro.TabIndex = 48;
            this.lbCadMsgErro.Text = "           ";
            // 
            // mkCadProCpf
            // 
            this.mkCadProCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkCadProCpf.Location = new System.Drawing.Point(188, 160);
            this.mkCadProCpf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mkCadProCpf.Mask = "000,000,000-00";
            this.mkCadProCpf.Name = "mkCadProCpf";
            this.mkCadProCpf.Size = new System.Drawing.Size(204, 26);
            this.mkCadProCpf.TabIndex = 1;
            this.mkCadProCpf.Leave += new System.EventHandler(this.mkCadCpf_Leave);
            // 
            // mkCadProTel1
            // 
            this.mkCadProTel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkCadProTel1.Location = new System.Drawing.Point(27, 518);
            this.mkCadProTel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mkCadProTel1.Mask = "(99) 99999-9999";
            this.mkCadProTel1.Name = "mkCadProTel1";
            this.mkCadProTel1.Size = new System.Drawing.Size(179, 26);
            this.mkCadProTel1.TabIndex = 13;
            // 
            // mkCadProTel2
            // 
            this.mkCadProTel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkCadProTel2.Location = new System.Drawing.Point(277, 518);
            this.mkCadProTel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mkCadProTel2.Mask = "(99) 99999-9999";
            this.mkCadProTel2.Name = "mkCadProTel2";
            this.mkCadProTel2.Size = new System.Drawing.Size(179, 26);
            this.mkCadProTel2.TabIndex = 14;
            // 
            // mkCadProDtNasc
            // 
            this.mkCadProDtNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkCadProDtNasc.Location = new System.Drawing.Point(23, 240);
            this.mkCadProDtNasc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mkCadProDtNasc.Mask = "00/00/0000";
            this.mkCadProDtNasc.Name = "mkCadProDtNasc";
            this.mkCadProDtNasc.Size = new System.Drawing.Size(133, 26);
            this.mkCadProDtNasc.TabIndex = 3;
            this.mkCadProDtNasc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mkCadProDtNasc.ValidatingType = typeof(System.DateTime);
            this.mkCadProDtNasc.Leave += new System.EventHandler(this.mkCadProDtNasc_Leave);
            // 
            // mkCadProCep
            // 
            this.mkCadProCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkCadProCep.Location = new System.Drawing.Point(23, 302);
            this.mkCadProCep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mkCadProCep.Mask = "99999-999";
            this.mkCadProCep.Name = "mkCadProCep";
            this.mkCadProCep.Size = new System.Drawing.Size(133, 26);
            this.mkCadProCep.TabIndex = 5;
            this.mkCadProCep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mkCadProCep.ValidatingType = typeof(System.DateTime);
            // 
            // pbCadCpfErrado
            // 
            this.pbCadCpfErrado.Enabled = false;
            this.pbCadCpfErrado.Image = global::ProjetoTCC2020.Properties.Resources.icons8_excluir_64;
            this.pbCadCpfErrado.Location = new System.Drawing.Point(399, 160);
            this.pbCadCpfErrado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbCadCpfErrado.Name = "pbCadCpfErrado";
            this.pbCadCpfErrado.Size = new System.Drawing.Size(27, 27);
            this.pbCadCpfErrado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCadCpfErrado.TabIndex = 47;
            this.pbCadCpfErrado.TabStop = false;
            this.pbCadCpfErrado.Visible = false;
            // 
            // pbCadCpfCorreto
            // 
            this.pbCadCpfCorreto.Image = global::ProjetoTCC2020.Properties.Resources.icons8_selecionado_64;
            this.pbCadCpfCorreto.Location = new System.Drawing.Point(399, 160);
            this.pbCadCpfCorreto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbCadCpfCorreto.Name = "pbCadCpfCorreto";
            this.pbCadCpfCorreto.Size = new System.Drawing.Size(27, 27);
            this.pbCadCpfCorreto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCadCpfCorreto.TabIndex = 46;
            this.pbCadCpfCorreto.TabStop = false;
            this.pbCadCpfCorreto.Visible = false;
            // 
            // lbCadCliEmail
            // 
            this.lbCadCliEmail.AutoSize = true;
            this.lbCadCliEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadCliEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCadCliEmail.Location = new System.Drawing.Point(829, 461);
            this.lbCadCliEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCadCliEmail.Name = "lbCadCliEmail";
            this.lbCadCliEmail.Size = new System.Drawing.Size(51, 15);
            this.lbCadCliEmail.TabIndex = 60;
            this.lbCadCliEmail.Text = "           ";
            // 
            // pbCadCliEmailErrado
            // 
            this.pbCadCliEmailErrado.Enabled = false;
            this.pbCadCliEmailErrado.Image = global::ProjetoTCC2020.Properties.Resources.icons8_excluir_64;
            this.pbCadCliEmailErrado.Location = new System.Drawing.Point(793, 458);
            this.pbCadCliEmailErrado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbCadCliEmailErrado.Name = "pbCadCliEmailErrado";
            this.pbCadCliEmailErrado.Size = new System.Drawing.Size(27, 27);
            this.pbCadCliEmailErrado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCadCliEmailErrado.TabIndex = 59;
            this.pbCadCliEmailErrado.TabStop = false;
            this.pbCadCliEmailErrado.Visible = false;
            // 
            // pbCadCliEmailCorreto
            // 
            this.pbCadCliEmailCorreto.Image = global::ProjetoTCC2020.Properties.Resources.icons8_selecionado_64;
            this.pbCadCliEmailCorreto.Location = new System.Drawing.Point(793, 458);
            this.pbCadCliEmailCorreto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbCadCliEmailCorreto.Name = "pbCadCliEmailCorreto";
            this.pbCadCliEmailCorreto.Size = new System.Drawing.Size(27, 27);
            this.pbCadCliEmailCorreto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCadCliEmailCorreto.TabIndex = 58;
            this.pbCadCliEmailCorreto.TabStop = false;
            this.pbCadCliEmailCorreto.Visible = false;
            // 
            // gbCadProStatus
            // 
            this.gbCadProStatus.Controls.Add(this.rdCadProDesativado);
            this.gbCadProStatus.Controls.Add(this.rdCadProAtivo);
            this.gbCadProStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbCadProStatus.Location = new System.Drawing.Point(23, 138);
            this.gbCadProStatus.Margin = new System.Windows.Forms.Padding(4);
            this.gbCadProStatus.Name = "gbCadProStatus";
            this.gbCadProStatus.Padding = new System.Windows.Forms.Padding(4);
            this.gbCadProStatus.Size = new System.Drawing.Size(129, 58);
            this.gbCadProStatus.TabIndex = 61;
            this.gbCadProStatus.TabStop = false;
            this.gbCadProStatus.Text = "Status";
            // 
            // rdCadProDesativado
            // 
            this.rdCadProDesativado.AutoSize = true;
            this.rdCadProDesativado.BackColor = System.Drawing.Color.Transparent;
            this.rdCadProDesativado.Enabled = false;
            this.rdCadProDesativado.Location = new System.Drawing.Point(8, 34);
            this.rdCadProDesativado.Margin = new System.Windows.Forms.Padding(4);
            this.rdCadProDesativado.Name = "rdCadProDesativado";
            this.rdCadProDesativado.Size = new System.Drawing.Size(65, 20);
            this.rdCadProDesativado.TabIndex = 1;
            this.rdCadProDesativado.TabStop = true;
            this.rdCadProDesativado.Text = "Inativo";
            this.rdCadProDesativado.UseVisualStyleBackColor = false;
            // 
            // rdCadProAtivo
            // 
            this.rdCadProAtivo.AutoSize = true;
            this.rdCadProAtivo.BackColor = System.Drawing.Color.Transparent;
            this.rdCadProAtivo.Enabled = false;
            this.rdCadProAtivo.Location = new System.Drawing.Point(8, 14);
            this.rdCadProAtivo.Margin = new System.Windows.Forms.Padding(4);
            this.rdCadProAtivo.Name = "rdCadProAtivo";
            this.rdCadProAtivo.Size = new System.Drawing.Size(56, 20);
            this.rdCadProAtivo.TabIndex = 0;
            this.rdCadProAtivo.TabStop = true;
            this.rdCadProAtivo.Text = "Ativo";
            this.rdCadProAtivo.UseVisualStyleBackColor = false;
            // 
            // tbCadProCro
            // 
            this.tbCadProCro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCadProCro.Location = new System.Drawing.Point(469, 162);
            this.tbCadProCro.Margin = new System.Windows.Forms.Padding(4);
            this.tbCadProCro.Name = "tbCadProCro";
            this.tbCadProCro.Size = new System.Drawing.Size(187, 24);
            this.tbCadProCro.TabIndex = 2;
            this.tbCadProCro.Leave += new System.EventHandler(this.tbCadProCro_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(471, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 62;
            this.label1.Text = "CRO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(533, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 64;
            this.label2.Text = "Ex: 123456-UF";
            // 
            // btCadProAlterar
            // 
            this.btCadProAlterar.BackgroundImage = global::ProjetoTCC2020.Properties.Resources.icons8_editar_vários_40;
            this.btCadProAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btCadProAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadProAlterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(96)))), ((int)(((byte)(145)))));
            this.btCadProAlterar.Location = new System.Drawing.Point(277, 702);
            this.btCadProAlterar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCadProAlterar.Name = "btCadProAlterar";
            this.btCadProAlterar.Size = new System.Drawing.Size(47, 39);
            this.btCadProAlterar.TabIndex = 19;
            this.btCadProAlterar.UseVisualStyleBackColor = true;
            this.btCadProAlterar.Click += new System.EventHandler(this.btCadProAlterar_Click);
            // 
            // fmCadastroProfissional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(96)))), ((int)(((byte)(145)))));
            this.ClientSize = new System.Drawing.Size(932, 752);
            this.Controls.Add(this.btCadProAlterar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCadProCro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbCadProStatus);
            this.Controls.Add(this.lbCadCliEmail);
            this.Controls.Add(this.pbCadCliEmailErrado);
            this.Controls.Add(this.pbCadCliEmailCorreto);
            this.Controls.Add(this.mkCadProCep);
            this.Controls.Add(this.mkCadProDtNasc);
            this.Controls.Add(this.mkCadProTel2);
            this.Controls.Add(this.mkCadProTel1);
            this.Controls.Add(this.mkCadProCpf);
            this.Controls.Add(this.lbCadMsgErro);
            this.Controls.Add(this.pbCadCpfErrado);
            this.Controls.Add(this.pbCadCpfCorreto);
            this.Controls.Add(this.tbCadProComp);
            this.Controls.Add(this.lbComplemento);
            this.Controls.Add(this.btCadProLimpar);
            this.Controls.Add(this.btCadProInserir);
            this.Controls.Add(this.btCadProCanc);
            this.Controls.Add(this.lbCadObs);
            this.Controls.Add(this.tbCadProObs);
            this.Controls.Add(this.lbCadDataNasc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbCadTel1);
            this.Controls.Add(this.lbCadNumero);
            this.Controls.Add(this.tbCadProNum);
            this.Controls.Add(this.cbCadProCidade);
            this.Controls.Add(this.lbCadUf);
            this.Controls.Add(this.cbCadProUf);
            this.Controls.Add(this.tbCadProEnd);
            this.Controls.Add(this.lbCadEnd);
            this.Controls.Add(this.tbCadProBairro);
            this.Controls.Add(this.lbCadBairro);
            this.Controls.Add(this.lbCadCidade);
            this.Controls.Add(this.lbCadCep);
            this.Controls.Add(this.tbCadProEmail);
            this.Controls.Add(this.lbCadEmail);
            this.Controls.Add(this.lbCadCpfCli);
            this.Controls.Add(this.tbCadProNome);
            this.Controls.Add(this.lbCadNome);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmCadastroProfissional";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de  Profissional";
            this.Load += new System.EventHandler(this.fmCadastroFuncionario_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCadCpfErrado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCadCpfCorreto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCadCliEmailErrado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCadCliEmailCorreto)).EndInit();
            this.gbCadProStatus.ResumeLayout(false);
            this.gbCadProStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbCadastroCli;
        private System.Windows.Forms.Label lbCadNome;
        private System.Windows.Forms.TextBox tbCadProNome;
        private System.Windows.Forms.Label lbCadCpfCli;
        private System.Windows.Forms.TextBox tbCadProEmail;
        private System.Windows.Forms.Label lbCadEmail;
        private System.Windows.Forms.Label lbCadCep;
        private System.Windows.Forms.Label lbCadCidade;
        private System.Windows.Forms.TextBox tbCadProBairro;
        private System.Windows.Forms.Label lbCadBairro;
        private System.Windows.Forms.TextBox tbCadProEnd;
        private System.Windows.Forms.Label lbCadEnd;
        private System.Windows.Forms.ComboBox cbCadProUf;
        private System.Windows.Forms.Label lbCadUf;
        private System.Windows.Forms.ComboBox cbCadProCidade;
        private System.Windows.Forms.TextBox tbCadProNum;
        private System.Windows.Forms.Label lbCadNumero;
        private System.Windows.Forms.Label lbCadTel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbCadDataNasc;
        private System.Windows.Forms.TextBox tbCadProObs;
        private System.Windows.Forms.Label lbCadObs;
        private System.Windows.Forms.Button btCadProInserir;
        private System.Windows.Forms.Button btCadProLimpar;
        private System.Windows.Forms.Button btCadProCanc;
        private System.Windows.Forms.TextBox tbCadProComp;
        private System.Windows.Forms.Label lbComplemento;
        private System.Windows.Forms.PictureBox pbCadCpfCorreto;
        private System.Windows.Forms.PictureBox pbCadCpfErrado;
        private System.Windows.Forms.Label lbCadMsgErro;
        private System.Windows.Forms.MaskedTextBox mkCadProCpf;
        private System.Windows.Forms.MaskedTextBox mkCadProTel1;
        private System.Windows.Forms.MaskedTextBox mkCadProTel2;
        private System.Windows.Forms.MaskedTextBox mkCadProDtNasc;
        private System.Windows.Forms.MaskedTextBox mkCadProCep;
        private System.Windows.Forms.Label lbCadCliEmail;
        private System.Windows.Forms.PictureBox pbCadCliEmailErrado;
        private System.Windows.Forms.PictureBox pbCadCliEmailCorreto;
        private System.Windows.Forms.GroupBox gbCadProStatus;
        private System.Windows.Forms.RadioButton rdCadProDesativado;
        private System.Windows.Forms.RadioButton rdCadProAtivo;
        private System.Windows.Forms.TextBox tbCadProCro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btCadProAlterar;
    }
}