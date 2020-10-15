using System;

namespace ProjetoTCC2020.Cadastro
{
    partial class CadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroCliente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbCadastroCli = new System.Windows.Forms.Label();
            this.lbCadNome = new System.Windows.Forms.Label();
            this.tbCadCliNome = new System.Windows.Forms.TextBox();
            this.lbCadCpfCli = new System.Windows.Forms.Label();
            this.tbCadCliEmail = new System.Windows.Forms.TextBox();
            this.lbCadEmail = new System.Windows.Forms.Label();
            this.lbCadCep = new System.Windows.Forms.Label();
            this.lbCadCidade = new System.Windows.Forms.Label();
            this.tbCadCliBairro = new System.Windows.Forms.TextBox();
            this.lbCadBairro = new System.Windows.Forms.Label();
            this.tbCadCliEnd = new System.Windows.Forms.TextBox();
            this.lbCadEnd = new System.Windows.Forms.Label();
            this.cbCadCliUf = new System.Windows.Forms.ComboBox();
            this.lbCadUf = new System.Windows.Forms.Label();
            this.cbCadCliCidade = new System.Windows.Forms.ComboBox();
            this.tbCadCliNum = new System.Windows.Forms.TextBox();
            this.lbCadNumero = new System.Windows.Forms.Label();
            this.lbCadTel1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbCadDataNasc = new System.Windows.Forms.Label();
            this.tbCadCliObs = new System.Windows.Forms.TextBox();
            this.lbCadObs = new System.Windows.Forms.Label();
            this.tbCadCliComplemento = new System.Windows.Forms.TextBox();
            this.lbComplemento = new System.Windows.Forms.Label();
            this.lbCadMsgErro = new System.Windows.Forms.Label();
            this.mkCadCpf = new System.Windows.Forms.MaskedTextBox();
            this.mkCadCliTel1 = new System.Windows.Forms.MaskedTextBox();
            this.mkCadCliTel2 = new System.Windows.Forms.MaskedTextBox();
            this.mkCadDtNasc = new System.Windows.Forms.MaskedTextBox();
            this.mkCadCliCep = new System.Windows.Forms.MaskedTextBox();
            this.lbCadCliEmail = new System.Windows.Forms.Label();
            this.gbCadCliStatus = new System.Windows.Forms.GroupBox();
            this.rdCadCliDesativado = new System.Windows.Forms.RadioButton();
            this.rdCadCliAtivo = new System.Windows.Forms.RadioButton();
            this.btCadAlterar = new System.Windows.Forms.Button();
            this.pbCadCliEmailErrado = new System.Windows.Forms.PictureBox();
            this.pbCadCliEmailCorreto = new System.Windows.Forms.PictureBox();
            this.pbCadCpfErrado = new System.Windows.Forms.PictureBox();
            this.pbCadCpfCorreto = new System.Windows.Forms.PictureBox();
            this.btCadLimpar = new System.Windows.Forms.Button();
            this.btCadInserir = new System.Windows.Forms.Button();
            this.btCadCanc = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gbCadCliStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCadCliEmailErrado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCadCliEmailCorreto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCadCpfErrado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCadCpfCorreto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbCadastroCli);
            this.panel1.Location = new System.Drawing.Point(23, 17);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 113);
            this.panel1.TabIndex = 0;
            // 
            // lbCadastroCli
            // 
            this.lbCadastroCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadastroCli.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCadastroCli.Location = new System.Drawing.Point(43, 7);
            this.lbCadastroCli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCadastroCli.Name = "lbCadastroCli";
            this.lbCadastroCli.Size = new System.Drawing.Size(813, 98);
            this.lbCadastroCli.TabIndex = 0;
            this.lbCadastroCli.Text = "Cadastro de Clientes";
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
            this.lbCadNome.TabIndex = 5;
            this.lbCadNome.Text = "Nome";
            // 
            // tbCadCliNome
            // 
            this.tbCadCliNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCadCliNome.Location = new System.Drawing.Point(188, 240);
            this.tbCadCliNome.Margin = new System.Windows.Forms.Padding(4);
            this.tbCadCliNome.Name = "tbCadCliNome";
            this.tbCadCliNome.Size = new System.Drawing.Size(719, 26);
            this.tbCadCliNome.TabIndex = 4;
            // 
            // lbCadCpfCli
            // 
            this.lbCadCpfCli.AutoSize = true;
            this.lbCadCpfCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadCpfCli.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCadCpfCli.Location = new System.Drawing.Point(187, 143);
            this.lbCadCpfCli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCadCpfCli.Name = "lbCadCpfCli";
            this.lbCadCpfCli.Size = new System.Drawing.Size(42, 17);
            this.lbCadCpfCli.TabIndex = 1;
            this.lbCadCpfCli.Text = "CPF ";
            // 
            // tbCadCliEmail
            // 
            this.tbCadCliEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCadCliEmail.Location = new System.Drawing.Point(23, 458);
            this.tbCadCliEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbCadCliEmail.Name = "tbCadCliEmail";
            this.tbCadCliEmail.Size = new System.Drawing.Size(765, 26);
            this.tbCadCliEmail.TabIndex = 12;
            this.tbCadCliEmail.TextChanged += new System.EventHandler(this.tbCadCliEmail_TextChanged);
            this.tbCadCliEmail.Leave += new System.EventHandler(this.tbCadEmail_Leave);
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
            this.lbCadEmail.TabIndex = 21;
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
            this.lbCadCep.TabIndex = 7;
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
            this.lbCadCidade.TabIndex = 11;
            this.lbCadCidade.Text = "Cidade";
            // 
            // tbCadCliBairro
            // 
            this.tbCadCliBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCadCliBairro.Location = new System.Drawing.Point(23, 404);
            this.tbCadCliBairro.Margin = new System.Windows.Forms.Padding(4);
            this.tbCadCliBairro.Name = "tbCadCliBairro";
            this.tbCadCliBairro.Size = new System.Drawing.Size(764, 26);
            this.tbCadCliBairro.TabIndex = 10;
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
            this.lbCadBairro.TabIndex = 17;
            this.lbCadBairro.Text = "Bairro";
            // 
            // tbCadCliEnd
            // 
            this.tbCadCliEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCadCliEnd.Location = new System.Drawing.Point(23, 352);
            this.tbCadCliEnd.Margin = new System.Windows.Forms.Padding(4);
            this.tbCadCliEnd.Name = "tbCadCliEnd";
            this.tbCadCliEnd.Size = new System.Drawing.Size(765, 26);
            this.tbCadCliEnd.TabIndex = 8;
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
            this.lbCadEnd.TabIndex = 13;
            this.lbCadEnd.Text = "Rua";
            // 
            // cbCadCliUf
            // 
            this.cbCadCliUf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCadCliUf.Enabled = false;
            this.cbCadCliUf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCadCliUf.FormattingEnabled = true;
            this.cbCadCliUf.Items.AddRange(new object[] {
            "GO",
            "MT",
            "SP"});
            this.cbCadCliUf.Location = new System.Drawing.Point(820, 302);
            this.cbCadCliUf.Margin = new System.Windows.Forms.Padding(4);
            this.cbCadCliUf.Name = "cbCadCliUf";
            this.cbCadCliUf.Size = new System.Drawing.Size(88, 26);
            this.cbCadCliUf.TabIndex = 6;
            this.cbCadCliUf.SelectedIndexChanged += new System.EventHandler(this.cbCadCliUf_SelectedIndexChanged);
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
            this.lbCadUf.TabIndex = 9;
            this.lbCadUf.Text = "UF";
            // 
            // cbCadCliCidade
            // 
            this.cbCadCliCidade.DropDownHeight = 270;
            this.cbCadCliCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCadCliCidade.Enabled = false;
            this.cbCadCliCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCadCliCidade.FormattingEnabled = true;
            this.cbCadCliCidade.IntegralHeight = false;
            this.cbCadCliCidade.ItemHeight = 18;
            this.cbCadCliCidade.Items.AddRange(new object[] {
            "Araçatuba",
            "Bilac",
            "Birigui",
            "Piacatu"});
            this.cbCadCliCidade.Location = new System.Drawing.Point(188, 302);
            this.cbCadCliCidade.Margin = new System.Windows.Forms.Padding(4);
            this.cbCadCliCidade.Name = "cbCadCliCidade";
            this.cbCadCliCidade.Size = new System.Drawing.Size(599, 26);
            this.cbCadCliCidade.Sorted = true;
            this.cbCadCliCidade.TabIndex = 7;
            this.cbCadCliCidade.SelectedIndexChanged += new System.EventHandler(this.cbCadCliCidade_SelectedIndexChanged);
            // 
            // tbCadCliNum
            // 
            this.tbCadCliNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCadCliNum.Location = new System.Drawing.Point(820, 352);
            this.tbCadCliNum.Margin = new System.Windows.Forms.Padding(4);
            this.tbCadCliNum.Name = "tbCadCliNum";
            this.tbCadCliNum.Size = new System.Drawing.Size(88, 26);
            this.tbCadCliNum.TabIndex = 9;
            this.tbCadCliNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCadCliNum_KeyPress);
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
            this.lbCadNumero.TabIndex = 15;
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
            this.lbCadTel1.TabIndex = 23;
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
            this.label5.TabIndex = 25;
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
            this.lbCadDataNasc.TabIndex = 3;
            this.lbCadDataNasc.Text = "Data de Nasc";
            // 
            // tbCadCliObs
            // 
            this.tbCadCliObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCadCliObs.Location = new System.Drawing.Point(23, 576);
            this.tbCadCliObs.Margin = new System.Windows.Forms.Padding(4);
            this.tbCadCliObs.Multiline = true;
            this.tbCadCliObs.Name = "tbCadCliObs";
            this.tbCadCliObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbCadCliObs.Size = new System.Drawing.Size(885, 110);
            this.tbCadCliObs.TabIndex = 15;
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
            this.lbCadObs.TabIndex = 27;
            this.lbCadObs.Text = "Obsevação";
            // 
            // tbCadCliComplemento
            // 
            this.tbCadCliComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCadCliComplemento.Location = new System.Drawing.Point(820, 404);
            this.tbCadCliComplemento.Margin = new System.Windows.Forms.Padding(4);
            this.tbCadCliComplemento.Name = "tbCadCliComplemento";
            this.tbCadCliComplemento.Size = new System.Drawing.Size(88, 26);
            this.tbCadCliComplemento.TabIndex = 11;
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
            this.lbComplemento.TabIndex = 19;
            this.lbComplemento.Text = "Comp.";
            // 
            // lbCadMsgErro
            // 
            this.lbCadMsgErro.AutoSize = true;
            this.lbCadMsgErro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadMsgErro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCadMsgErro.Location = new System.Drawing.Point(188, 195);
            this.lbCadMsgErro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCadMsgErro.Name = "lbCadMsgErro";
            this.lbCadMsgErro.Size = new System.Drawing.Size(51, 15);
            this.lbCadMsgErro.TabIndex = 48;
            this.lbCadMsgErro.Text = "           ";
            // 
            // mkCadCpf
            // 
            this.mkCadCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkCadCpf.Location = new System.Drawing.Point(188, 162);
            this.mkCadCpf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mkCadCpf.Mask = "000,000,000-00";
            this.mkCadCpf.Name = "mkCadCpf";
            this.mkCadCpf.Size = new System.Drawing.Size(161, 26);
            this.mkCadCpf.TabIndex = 2;
            this.mkCadCpf.Leave += new System.EventHandler(this.mkCadCpf_Leave);
            // 
            // mkCadCliTel1
            // 
            this.mkCadCliTel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkCadCliTel1.Location = new System.Drawing.Point(27, 518);
            this.mkCadCliTel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mkCadCliTel1.Mask = "(99) 99999-9999";
            this.mkCadCliTel1.Name = "mkCadCliTel1";
            this.mkCadCliTel1.Size = new System.Drawing.Size(179, 26);
            this.mkCadCliTel1.TabIndex = 13;
            // 
            // mkCadCliTel2
            // 
            this.mkCadCliTel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkCadCliTel2.Location = new System.Drawing.Point(277, 518);
            this.mkCadCliTel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mkCadCliTel2.Mask = "(99) 99999-9999";
            this.mkCadCliTel2.Name = "mkCadCliTel2";
            this.mkCadCliTel2.Size = new System.Drawing.Size(179, 26);
            this.mkCadCliTel2.TabIndex = 14;
            // 
            // mkCadDtNasc
            // 
            this.mkCadDtNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkCadDtNasc.Location = new System.Drawing.Point(23, 240);
            this.mkCadDtNasc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mkCadDtNasc.Mask = "00/00/0000";
            this.mkCadDtNasc.Name = "mkCadDtNasc";
            this.mkCadDtNasc.Size = new System.Drawing.Size(133, 26);
            this.mkCadDtNasc.TabIndex = 3;
            this.mkCadDtNasc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mkCadDtNasc.ValidatingType = typeof(System.DateTime);
            this.mkCadDtNasc.Leave += new System.EventHandler(this.mkCadDtNasc_Leave);
            // 
            // mkCadCliCep
            // 
            this.mkCadCliCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkCadCliCep.Location = new System.Drawing.Point(23, 302);
            this.mkCadCliCep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mkCadCliCep.Mask = "99999-999";
            this.mkCadCliCep.Name = "mkCadCliCep";
            this.mkCadCliCep.Size = new System.Drawing.Size(133, 26);
            this.mkCadCliCep.TabIndex = 5;
            this.mkCadCliCep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mkCadCliCep.ValidatingType = typeof(System.DateTime);
            this.mkCadCliCep.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mkCadCliCep_MaskInputRejected);
            // 
            // lbCadCliEmail
            // 
            this.lbCadCliEmail.AutoSize = true;
            this.lbCadCliEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadCliEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCadCliEmail.Location = new System.Drawing.Point(829, 462);
            this.lbCadCliEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCadCliEmail.Name = "lbCadCliEmail";
            this.lbCadCliEmail.Size = new System.Drawing.Size(51, 15);
            this.lbCadCliEmail.TabIndex = 60;
            this.lbCadCliEmail.Text = "           ";
            // 
            // gbCadCliStatus
            // 
            this.gbCadCliStatus.Controls.Add(this.rdCadCliDesativado);
            this.gbCadCliStatus.Controls.Add(this.rdCadCliAtivo);
            this.gbCadCliStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbCadCliStatus.Location = new System.Drawing.Point(23, 138);
            this.gbCadCliStatus.Margin = new System.Windows.Forms.Padding(4);
            this.gbCadCliStatus.Name = "gbCadCliStatus";
            this.gbCadCliStatus.Padding = new System.Windows.Forms.Padding(4);
            this.gbCadCliStatus.Size = new System.Drawing.Size(129, 58);
            this.gbCadCliStatus.TabIndex = 31;
            this.gbCadCliStatus.TabStop = false;
            this.gbCadCliStatus.Text = "Status";
            // 
            // rdCadCliDesativado
            // 
            this.rdCadCliDesativado.AutoSize = true;
            this.rdCadCliDesativado.BackColor = System.Drawing.Color.Transparent;
            this.rdCadCliDesativado.Enabled = false;
            this.rdCadCliDesativado.Location = new System.Drawing.Point(8, 34);
            this.rdCadCliDesativado.Margin = new System.Windows.Forms.Padding(4);
            this.rdCadCliDesativado.Name = "rdCadCliDesativado";
            this.rdCadCliDesativado.Size = new System.Drawing.Size(65, 20);
            this.rdCadCliDesativado.TabIndex = 1;
            this.rdCadCliDesativado.TabStop = true;
            this.rdCadCliDesativado.Text = "Inativo";
            this.rdCadCliDesativado.UseVisualStyleBackColor = false;
            // 
            // rdCadCliAtivo
            // 
            this.rdCadCliAtivo.AutoSize = true;
            this.rdCadCliAtivo.BackColor = System.Drawing.Color.Transparent;
            this.rdCadCliAtivo.Enabled = false;
            this.rdCadCliAtivo.Location = new System.Drawing.Point(8, 14);
            this.rdCadCliAtivo.Margin = new System.Windows.Forms.Padding(4);
            this.rdCadCliAtivo.Name = "rdCadCliAtivo";
            this.rdCadCliAtivo.Size = new System.Drawing.Size(56, 20);
            this.rdCadCliAtivo.TabIndex = 0;
            this.rdCadCliAtivo.TabStop = true;
            this.rdCadCliAtivo.Text = "Ativo";
            this.rdCadCliAtivo.UseVisualStyleBackColor = false;
            // 
            // btCadAlterar
            // 
            this.btCadAlterar.BackgroundImage = global::ProjetoTCC2020.Properties.Resources.icons8_editar_vários_40;
            this.btCadAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btCadAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadAlterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(96)))), ((int)(((byte)(145)))));
            this.btCadAlterar.Location = new System.Drawing.Point(291, 700);
            this.btCadAlterar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCadAlterar.Name = "btCadAlterar";
            this.btCadAlterar.Size = new System.Drawing.Size(47, 39);
            this.btCadAlterar.TabIndex = 64;
            this.btCadAlterar.UseVisualStyleBackColor = true;
            this.btCadAlterar.Click += new System.EventHandler(this.btCadAlterar_Click);
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
            // pbCadCpfErrado
            // 
            this.pbCadCpfErrado.Enabled = false;
            this.pbCadCpfErrado.Image = global::ProjetoTCC2020.Properties.Resources.icons8_excluir_64;
            this.pbCadCpfErrado.Location = new System.Drawing.Point(355, 162);
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
            this.pbCadCpfCorreto.Location = new System.Drawing.Point(355, 162);
            this.pbCadCpfCorreto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbCadCpfCorreto.Name = "pbCadCpfCorreto";
            this.pbCadCpfCorreto.Size = new System.Drawing.Size(27, 27);
            this.pbCadCpfCorreto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCadCpfCorreto.TabIndex = 46;
            this.pbCadCpfCorreto.TabStop = false;
            this.pbCadCpfCorreto.Visible = false;
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
            this.btCadLimpar.Location = new System.Drawing.Point(571, 702);
            this.btCadLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btCadLimpar.Name = "btCadLimpar";
            this.btCadLimpar.Size = new System.Drawing.Size(53, 38);
            this.btCadLimpar.TabIndex = 17;
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
            this.btCadInserir.Location = new System.Drawing.Point(21, 702);
            this.btCadInserir.Margin = new System.Windows.Forms.Padding(4);
            this.btCadInserir.Name = "btCadInserir";
            this.btCadInserir.Size = new System.Drawing.Size(51, 38);
            this.btCadInserir.TabIndex = 16;
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
            this.btCadCanc.Location = new System.Drawing.Point(855, 702);
            this.btCadCanc.Margin = new System.Windows.Forms.Padding(0);
            this.btCadCanc.Name = "btCadCanc";
            this.btCadCanc.Size = new System.Drawing.Size(52, 38);
            this.btCadCanc.TabIndex = 18;
            this.btCadCanc.UseVisualStyleBackColor = false;
            this.btCadCanc.Click += new System.EventHandler(this.btCadCanc_Click);
            // 
            // CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(96)))), ((int)(((byte)(145)))));
            this.ClientSize = new System.Drawing.Size(932, 750);
            this.Controls.Add(this.btCadAlterar);
            this.Controls.Add(this.gbCadCliStatus);
            this.Controls.Add(this.lbCadCliEmail);
            this.Controls.Add(this.pbCadCliEmailErrado);
            this.Controls.Add(this.pbCadCliEmailCorreto);
            this.Controls.Add(this.mkCadCliCep);
            this.Controls.Add(this.mkCadDtNasc);
            this.Controls.Add(this.mkCadCliTel2);
            this.Controls.Add(this.mkCadCliTel1);
            this.Controls.Add(this.mkCadCpf);
            this.Controls.Add(this.lbCadMsgErro);
            this.Controls.Add(this.pbCadCpfErrado);
            this.Controls.Add(this.pbCadCpfCorreto);
            this.Controls.Add(this.tbCadCliComplemento);
            this.Controls.Add(this.lbComplemento);
            this.Controls.Add(this.btCadLimpar);
            this.Controls.Add(this.btCadInserir);
            this.Controls.Add(this.btCadCanc);
            this.Controls.Add(this.lbCadObs);
            this.Controls.Add(this.tbCadCliObs);
            this.Controls.Add(this.lbCadDataNasc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbCadTel1);
            this.Controls.Add(this.lbCadNumero);
            this.Controls.Add(this.tbCadCliNum);
            this.Controls.Add(this.cbCadCliCidade);
            this.Controls.Add(this.lbCadUf);
            this.Controls.Add(this.cbCadCliUf);
            this.Controls.Add(this.tbCadCliEnd);
            this.Controls.Add(this.lbCadEnd);
            this.Controls.Add(this.tbCadCliBairro);
            this.Controls.Add(this.lbCadBairro);
            this.Controls.Add(this.lbCadCidade);
            this.Controls.Add(this.lbCadCep);
            this.Controls.Add(this.tbCadCliEmail);
            this.Controls.Add(this.lbCadEmail);
            this.Controls.Add(this.lbCadCpfCli);
            this.Controls.Add(this.tbCadCliNome);
            this.Controls.Add(this.lbCadNome);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroCliente";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cliente";
            this.Load += new System.EventHandler(this.fmCadastroCliente_Load);
            this.panel1.ResumeLayout(false);
            this.gbCadCliStatus.ResumeLayout(false);
            this.gbCadCliStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCadCliEmailErrado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCadCliEmailCorreto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCadCpfErrado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCadCpfCorreto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbCadastroCli;
        private System.Windows.Forms.Label lbCadNome;
        private System.Windows.Forms.TextBox tbCadCliNome;
        private System.Windows.Forms.Label lbCadCpfCli;
        private System.Windows.Forms.TextBox tbCadCliEmail;
        private System.Windows.Forms.Label lbCadEmail;
        private System.Windows.Forms.Label lbCadCep;
        private System.Windows.Forms.Label lbCadCidade;
        private System.Windows.Forms.TextBox tbCadCliBairro;
        private System.Windows.Forms.Label lbCadBairro;
        private System.Windows.Forms.TextBox tbCadCliEnd;
        private System.Windows.Forms.Label lbCadEnd;
        private System.Windows.Forms.ComboBox cbCadCliUf;
        private System.Windows.Forms.Label lbCadUf;
        private System.Windows.Forms.ComboBox cbCadCliCidade;
        private System.Windows.Forms.TextBox tbCadCliNum;
        private System.Windows.Forms.Label lbCadNumero;
        private System.Windows.Forms.Label lbCadTel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbCadDataNasc;
        private System.Windows.Forms.TextBox tbCadCliObs;
        private System.Windows.Forms.Label lbCadObs;
        private System.Windows.Forms.Button btCadLimpar;
        private System.Windows.Forms.TextBox tbCadCliComplemento;
        private System.Windows.Forms.Label lbComplemento;
        private System.Windows.Forms.PictureBox pbCadCpfCorreto;
        private System.Windows.Forms.PictureBox pbCadCpfErrado;
        private System.Windows.Forms.Label lbCadMsgErro;
        private System.Windows.Forms.MaskedTextBox mkCadCpf;
        private System.Windows.Forms.MaskedTextBox mkCadCliTel1;
        private System.Windows.Forms.MaskedTextBox mkCadCliTel2;
        private System.Windows.Forms.MaskedTextBox mkCadDtNasc;
        private System.Windows.Forms.MaskedTextBox mkCadCliCep;
        private System.Windows.Forms.Label lbCadCliEmail;
        private System.Windows.Forms.PictureBox pbCadCliEmailErrado;
        private System.Windows.Forms.PictureBox pbCadCliEmailCorreto;
        private System.Windows.Forms.GroupBox gbCadCliStatus;
        private System.Windows.Forms.RadioButton rdCadCliDesativado;
        private System.Windows.Forms.RadioButton rdCadCliAtivo;
        private System.Windows.Forms.Button btCadAlterar;
        private System.Windows.Forms.Button btCadInserir;
        private System.Windows.Forms.Button btCadCanc;
    }
}