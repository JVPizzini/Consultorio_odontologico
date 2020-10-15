namespace ProjetoTCC2020.Cadastro
{
    partial class fmCadatroDeConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmCadatroDeConsulta));
            this.cbCcSelecDoc = new System.Windows.Forms.ComboBox();
            this.dtCcDtConsulta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCcNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCcSelecServ = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbCcDtFinal = new System.Windows.Forms.ComboBox();
            this.cbCcDtIni = new System.Windows.Forms.ComboBox();
            this.lbAgDtIni = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btCcInserir = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btCcCancelar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mkCcCpf = new System.Windows.Forms.MaskedTextBox();
            this.btnSearchCPF = new System.Windows.Forms.Button();
            this.cbCcStatus = new System.Windows.Forms.ComboBox();
            this.lbCcStatus = new System.Windows.Forms.Label();
            this.btAlterar = new System.Windows.Forms.Button();
            this.pnMovitoCancelamento = new System.Windows.Forms.Panel();
            this.btCancMotivoCancelar = new System.Windows.Forms.Button();
            this.tbMotivoCancelamento = new System.Windows.Forms.TextBox();
            this.btInserirMotivoCancelamento = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.pnMovitoCancelamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbCcSelecDoc
            // 
            this.cbCcSelecDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCcSelecDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCcSelecDoc.FormattingEnabled = true;
            this.cbCcSelecDoc.Location = new System.Drawing.Point(43, 198);
            this.cbCcSelecDoc.Margin = new System.Windows.Forms.Padding(4);
            this.cbCcSelecDoc.Name = "cbCcSelecDoc";
            this.cbCcSelecDoc.Size = new System.Drawing.Size(595, 26);
            this.cbCcSelecDoc.TabIndex = 0;
            // 
            // dtCcDtConsulta
            // 
            this.dtCcDtConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtCcDtConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCcDtConsulta.Location = new System.Drawing.Point(21, 63);
            this.dtCcDtConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.dtCcDtConsulta.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtCcDtConsulta.Name = "dtCcDtConsulta";
            this.dtCcDtConsulta.Size = new System.Drawing.Size(160, 26);
            this.dtCcDtConsulta.TabIndex = 12;
            this.dtCcDtConsulta.Value = new System.DateTime(2020, 5, 27, 23, 53, 9, 0);
            this.dtCcDtConsulta.ValueChanged += new System.EventHandler(this.dtCcDtConsulta_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(215, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Hora Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(405, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Hora Final";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(39, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Selecionar o Dr.";
            // 
            // tbCcNome
            // 
            this.tbCcNome.Enabled = false;
            this.tbCcNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCcNome.Location = new System.Drawing.Point(43, 139);
            this.tbCcNome.Margin = new System.Windows.Forms.Padding(4);
            this.tbCcNome.Name = "tbCcNome";
            this.tbCcNome.ReadOnly = true;
            this.tbCcNome.Size = new System.Drawing.Size(595, 26);
            this.tbCcNome.TabIndex = 18;
            this.tbCcNome.TextChanged += new System.EventHandler(this.tbCcNome_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(39, 116);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Nome do Cliente";
            // 
            // cbCcSelecServ
            // 
            this.cbCcSelecServ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCcSelecServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCcSelecServ.FormattingEnabled = true;
            this.cbCcSelecServ.Items.AddRange(new object[] {
            "teste",
            "teste2"});
            this.cbCcSelecServ.Location = new System.Drawing.Point(43, 257);
            this.cbCcSelecServ.Margin = new System.Windows.Forms.Padding(4);
            this.cbCcSelecServ.Name = "cbCcSelecServ";
            this.cbCcSelecServ.Size = new System.Drawing.Size(595, 26);
            this.cbCcSelecServ.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbCcDtFinal);
            this.groupBox1.Controls.Add(this.cbCcDtIni);
            this.groupBox1.Controls.Add(this.dtCcDtConsulta);
            this.groupBox1.Controls.Add(this.lbAgDtIni);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(43, 298);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(595, 130);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta";
            // 
            // cbCcDtFinal
            // 
            this.cbCcDtFinal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCcDtFinal.FormattingEnabled = true;
            this.cbCcDtFinal.Location = new System.Drawing.Point(408, 62);
            this.cbCcDtFinal.Margin = new System.Windows.Forms.Padding(4);
            this.cbCcDtFinal.Name = "cbCcDtFinal";
            this.cbCcDtFinal.Size = new System.Drawing.Size(160, 28);
            this.cbCcDtFinal.TabIndex = 17;
            // 
            // cbCcDtIni
            // 
            this.cbCcDtIni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCcDtIni.FormattingEnabled = true;
            this.cbCcDtIni.Location = new System.Drawing.Point(224, 62);
            this.cbCcDtIni.Margin = new System.Windows.Forms.Padding(4);
            this.cbCcDtIni.Name = "cbCcDtIni";
            this.cbCcDtIni.Size = new System.Drawing.Size(160, 28);
            this.cbCcDtIni.TabIndex = 16;
            this.cbCcDtIni.SelectedIndexChanged += new System.EventHandler(this.cbCcDtIni_SelectedIndexChanged);
            // 
            // lbAgDtIni
            // 
            this.lbAgDtIni.AutoSize = true;
            this.lbAgDtIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAgDtIni.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbAgDtIni.Location = new System.Drawing.Point(19, 41);
            this.lbAgDtIni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAgDtIni.Name = "lbAgDtIni";
            this.lbAgDtIni.Size = new System.Drawing.Size(127, 16);
            this.lbAgDtIni.TabIndex = 7;
            this.lbAgDtIni.Text = "Data da Consulta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(39, 234);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 16);
            this.label9.TabIndex = 28;
            this.label9.Text = "Nome do Serviço";
            // 
            // btCcInserir
            // 
            this.btCcInserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(96)))), ((int)(((byte)(145)))));
            this.btCcInserir.BackgroundImage = global::ProjetoTCC2020.Properties.Resources.icons8_selecionado_64;
            this.btCcInserir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btCcInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCcInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCcInserir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(96)))), ((int)(((byte)(145)))));
            this.btCcInserir.Location = new System.Drawing.Point(43, 446);
            this.btCcInserir.Margin = new System.Windows.Forms.Padding(4);
            this.btCcInserir.Name = "btCcInserir";
            this.btCcInserir.Size = new System.Drawing.Size(60, 44);
            this.btCcInserir.TabIndex = 30;
            this.btCcInserir.UseVisualStyleBackColor = false;
            this.btCcInserir.Click += new System.EventHandler(this.btCcInserir_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(96)))), ((int)(((byte)(145)))));
            this.btLimpar.BackgroundImage = global::ProjetoTCC2020.Properties.Resources.Actions_draw_eraser_icon;
            this.btLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(96)))), ((int)(((byte)(145)))));
            this.btLimpar.Location = new System.Drawing.Point(396, 446);
            this.btLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(61, 44);
            this.btLimpar.TabIndex = 31;
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Visible = false;
            this.btLimpar.Click += new System.EventHandler(this.btCcLimpar_Click);
            // 
            // btCcCancelar
            // 
            this.btCcCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(96)))), ((int)(((byte)(145)))));
            this.btCcCancelar.BackgroundImage = global::ProjetoTCC2020.Properties.Resources.icons8_excluir_64;
            this.btCcCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btCcCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCcCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCcCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(96)))), ((int)(((byte)(145)))));
            this.btCcCancelar.Location = new System.Drawing.Point(584, 446);
            this.btCcCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btCcCancelar.Name = "btCcCancelar";
            this.btCcCancelar.Size = new System.Drawing.Size(55, 44);
            this.btCcCancelar.TabIndex = 32;
            this.btCcCancelar.UseVisualStyleBackColor = false;
            this.btCcCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(193, 18);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(264, 29);
            this.label10.TabIndex = 33;
            this.label10.Text = "Cadastro de Consulta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(435, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 35;
            this.label4.Text = "CPF";
            // 
            // mkCcCpf
            // 
            this.mkCcCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkCcCpf.Location = new System.Drawing.Point(437, 79);
            this.mkCcCpf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mkCcCpf.Mask = "000,000,000-00";
            this.mkCcCpf.Name = "mkCcCpf";
            this.mkCcCpf.Size = new System.Drawing.Size(160, 26);
            this.mkCcCpf.TabIndex = 50;
            this.mkCcCpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mkCadConsCpf_MaskInputRejected);
            // 
            // btnSearchCPF
            // 
            this.btnSearchCPF.BackgroundImage = global::ProjetoTCC2020.Properties.Resources.icons8_pesquisar_64__1_;
            this.btnSearchCPF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchCPF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCPF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(96)))), ((int)(((byte)(145)))));
            this.btnSearchCPF.Location = new System.Drawing.Point(604, 78);
            this.btnSearchCPF.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchCPF.Name = "btnSearchCPF";
            this.btnSearchCPF.Size = new System.Drawing.Size(35, 28);
            this.btnSearchCPF.TabIndex = 51;
            this.btnSearchCPF.UseVisualStyleBackColor = true;
            this.btnSearchCPF.Click += new System.EventHandler(this.btnSearchCPF_Click);
            // 
            // cbCcStatus
            // 
            this.cbCcStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCcStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCcStatus.FormattingEnabled = true;
            this.cbCcStatus.Items.AddRange(new object[] {
            "A Consultar",
            "Consultado",
            "Cancelado"});
            this.cbCcStatus.Location = new System.Drawing.Point(43, 80);
            this.cbCcStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cbCcStatus.Name = "cbCcStatus";
            this.cbCcStatus.Size = new System.Drawing.Size(165, 26);
            this.cbCcStatus.TabIndex = 52;
            this.cbCcStatus.SelectedIndexChanged += new System.EventHandler(this.cbCcStatus_SelectedIndexChanged);
            // 
            // lbCcStatus
            // 
            this.lbCcStatus.AutoSize = true;
            this.lbCcStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCcStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCcStatus.Location = new System.Drawing.Point(40, 62);
            this.lbCcStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCcStatus.Name = "lbCcStatus";
            this.lbCcStatus.Size = new System.Drawing.Size(135, 16);
            this.lbCcStatus.TabIndex = 53;
            this.lbCcStatus.Text = "Status da consulta";
            // 
            // btAlterar
            // 
            this.btAlterar.BackgroundImage = global::ProjetoTCC2020.Properties.Resources.icons8_editar_vários_40;
            this.btAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAlterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(96)))), ((int)(((byte)(145)))));
            this.btAlterar.Location = new System.Drawing.Point(320, 446);
            this.btAlterar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(53, 44);
            this.btAlterar.TabIndex = 65;
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // pnMovitoCancelamento
            // 
            this.pnMovitoCancelamento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnMovitoCancelamento.Controls.Add(this.btCancMotivoCancelar);
            this.pnMovitoCancelamento.Controls.Add(this.tbMotivoCancelamento);
            this.pnMovitoCancelamento.Controls.Add(this.btInserirMotivoCancelamento);
            this.pnMovitoCancelamento.Controls.Add(this.label7);
            this.pnMovitoCancelamento.Controls.Add(this.label6);
            this.pnMovitoCancelamento.Location = new System.Drawing.Point(8, 62);
            this.pnMovitoCancelamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnMovitoCancelamento.Name = "pnMovitoCancelamento";
            this.pnMovitoCancelamento.Size = new System.Drawing.Size(667, 427);
            this.pnMovitoCancelamento.TabIndex = 66;
            this.pnMovitoCancelamento.Visible = false;
            // 
            // btCancMotivoCancelar
            // 
            this.btCancMotivoCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancMotivoCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(96)))), ((int)(((byte)(145)))));
            this.btCancMotivoCancelar.BackgroundImage = global::ProjetoTCC2020.Properties.Resources.icons8_excluir_64;
            this.btCancMotivoCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btCancMotivoCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancMotivoCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancMotivoCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(96)))), ((int)(((byte)(145)))));
            this.btCancMotivoCancelar.Location = new System.Drawing.Point(563, 361);
            this.btCancMotivoCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btCancMotivoCancelar.Name = "btCancMotivoCancelar";
            this.btCancMotivoCancelar.Size = new System.Drawing.Size(49, 44);
            this.btCancMotivoCancelar.TabIndex = 67;
            this.btCancMotivoCancelar.UseVisualStyleBackColor = false;
            this.btCancMotivoCancelar.Click += new System.EventHandler(this.btCancMotivoCancelar_Click);
            // 
            // tbMotivoCancelamento
            // 
            this.tbMotivoCancelamento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMotivoCancelamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMotivoCancelamento.Location = new System.Drawing.Point(56, 59);
            this.tbMotivoCancelamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMotivoCancelamento.Multiline = true;
            this.tbMotivoCancelamento.Name = "tbMotivoCancelamento";
            this.tbMotivoCancelamento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMotivoCancelamento.Size = new System.Drawing.Size(556, 294);
            this.tbMotivoCancelamento.TabIndex = 69;
            // 
            // btInserirMotivoCancelamento
            // 
            this.btInserirMotivoCancelamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(96)))), ((int)(((byte)(145)))));
            this.btInserirMotivoCancelamento.BackgroundImage = global::ProjetoTCC2020.Properties.Resources.icons8_selecionado_64;
            this.btInserirMotivoCancelamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btInserirMotivoCancelamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInserirMotivoCancelamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInserirMotivoCancelamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(96)))), ((int)(((byte)(145)))));
            this.btInserirMotivoCancelamento.Location = new System.Drawing.Point(56, 359);
            this.btInserirMotivoCancelamento.Margin = new System.Windows.Forms.Padding(4);
            this.btInserirMotivoCancelamento.Name = "btInserirMotivoCancelamento";
            this.btInserirMotivoCancelamento.Size = new System.Drawing.Size(57, 46);
            this.btInserirMotivoCancelamento.TabIndex = 67;
            this.btInserirMotivoCancelamento.UseVisualStyleBackColor = false;
            this.btInserirMotivoCancelamento.Click += new System.EventHandler(this.btMotivoCancelamento_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label7.Location = new System.Drawing.Point(373, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 20);
            this.label7.TabIndex = 68;
            this.label7.Text = "CANCELAMENTO";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(69, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(231, 20);
            this.label6.TabIndex = 67;
            this.label6.Text = "Por favor, insira o motivo do";
            // 
            // fmCadatroDeConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(96)))), ((int)(((byte)(145)))));
            this.ClientSize = new System.Drawing.Size(683, 510);
            this.Controls.Add(this.pnMovitoCancelamento);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.lbCcStatus);
            this.Controls.Add(this.btnSearchCPF);
            this.Controls.Add(this.cbCcStatus);
            this.Controls.Add(this.mkCcCpf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btCcCancelar);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btCcInserir);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbCcSelecServ);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbCcNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbCcSelecDoc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmCadatroDeConsulta";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Consulta";
            this.Load += new System.EventHandler(this.CadatroDeConsulta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnMovitoCancelamento.ResumeLayout(false);
            this.pnMovitoCancelamento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbCcSelecDoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbCcDtFinal;
        private System.Windows.Forms.ComboBox cbCcDtIni;
        public System.Windows.Forms.DateTimePicker dtCcDtConsulta;
        private System.Windows.Forms.Label lbAgDtIni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCcSelecServ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCcNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btCcCancelar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btCcInserir;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mkCcCpf;
        private System.Windows.Forms.Button btnSearchCPF;
        private System.Windows.Forms.Label lbCcStatus;
        private System.Windows.Forms.ComboBox cbCcStatus;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Panel pnMovitoCancelamento;
        private System.Windows.Forms.Button btInserirMotivoCancelamento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMotivoCancelamento;
        private System.Windows.Forms.Button btCancMotivoCancelar;
    }
}