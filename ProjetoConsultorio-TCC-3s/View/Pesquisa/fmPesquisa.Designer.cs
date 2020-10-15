namespace ProjetoTCC2020.Pesquisa
{
    partial class fmPesquisa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmPesquisa));
            this.gridPesq = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridPesqCadastro = new System.Windows.Forms.DataGridView();
            this.btPesqCanc = new System.Windows.Forms.Button();
            this.rbPesqNome = new System.Windows.Forms.RadioButton();
            this.rbPesqCPF = new System.Windows.Forms.RadioButton();
            this.pnAgCalendario = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btPesqCadFunc = new System.Windows.Forms.Button();
            this.lbPesqCliNovoProfissional = new System.Windows.Forms.Label();
            this.lbPesqCliNovoCadastro = new System.Windows.Forms.Label();
            this.btPesqNovoPro = new System.Windows.Forms.Button();
            this.gbAgPesquisa = new System.Windows.Forms.GroupBox();
            this.cbInativo = new System.Windows.Forms.CheckBox();
            this.mkPesqNome = new System.Windows.Forms.MaskedTextBox();
            this.mkPesqCpf = new System.Windows.Forms.MaskedTextBox();
            this.cbPesq = new System.Windows.Forms.ComboBox();
            this.btPesqBuscar = new System.Windows.Forms.Button();
            this.btPesqNovoCliente = new System.Windows.Forms.Button();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridPesq)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPesqCadastro)).BeginInit();
            this.pnAgCalendario.SuspendLayout();
            this.gbAgPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridPesq
            // 
            this.gridPesq.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPesq.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridPesq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPesq.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridPesq.Location = new System.Drawing.Point(29, 27);
            this.gridPesq.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridPesq.Name = "gridPesq";
            this.gridPesq.Size = new System.Drawing.Size(911, 628);
            this.gridPesq.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.gridPesqCadastro);
            this.panel1.Controls.Add(this.btPesqCanc);
            this.panel1.Controls.Add(this.gridPesq);
            this.panel1.Location = new System.Drawing.Point(386, 17);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 721);
            this.panel1.TabIndex = 3;
            // 
            // gridPesqCadastro
            // 
            this.gridPesqCadastro.AllowUserToAddRows = false;
            this.gridPesqCadastro.AllowUserToDeleteRows = false;
            this.gridPesqCadastro.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.gridPesqCadastro.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridPesqCadastro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPesqCadastro.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPesqCadastro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridPesqCadastro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPesqCadastro.Location = new System.Drawing.Point(12, 13);
            this.gridPesqCadastro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridPesqCadastro.Name = "gridPesqCadastro";
            this.gridPesqCadastro.ReadOnly = true;
            this.gridPesqCadastro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPesqCadastro.Size = new System.Drawing.Size(943, 652);
            this.gridPesqCadastro.TabIndex = 43;
            this.gridPesqCadastro.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPesqCadastro_CellDoubleClick);
            // 
            // btPesqCanc
            // 
            this.btPesqCanc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btPesqCanc.BackColor = System.Drawing.Color.SteelBlue;
            this.btPesqCanc.BackgroundImage = global::ProjetoTCC2020.Properties.Resources.icons8_excluir_64;
            this.btPesqCanc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btPesqCanc.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btPesqCanc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPesqCanc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesqCanc.ForeColor = System.Drawing.Color.SteelBlue;
            this.btPesqCanc.Location = new System.Drawing.Point(907, 677);
            this.btPesqCanc.Margin = new System.Windows.Forms.Padding(0);
            this.btPesqCanc.Name = "btPesqCanc";
            this.btPesqCanc.Size = new System.Drawing.Size(53, 38);
            this.btPesqCanc.TabIndex = 42;
            this.btPesqCanc.UseVisualStyleBackColor = false;
            this.btPesqCanc.Click += new System.EventHandler(this.btPesqCanc_Click);
            // 
            // rbPesqNome
            // 
            this.rbPesqNome.AutoSize = true;
            this.rbPesqNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPesqNome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbPesqNome.Location = new System.Drawing.Point(136, 39);
            this.rbPesqNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbPesqNome.Name = "rbPesqNome";
            this.rbPesqNome.Size = new System.Drawing.Size(57, 17);
            this.rbPesqNome.TabIndex = 4;
            this.rbPesqNome.TabStop = true;
            this.rbPesqNome.Text = "Nome";
            this.rbPesqNome.UseVisualStyleBackColor = true;
            this.rbPesqNome.CheckedChanged += new System.EventHandler(this.rdNome_CheckedChanged);
            // 
            // rbPesqCPF
            // 
            this.rbPesqCPF.AutoSize = true;
            this.rbPesqCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPesqCPF.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbPesqCPF.Location = new System.Drawing.Point(28, 39);
            this.rbPesqCPF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbPesqCPF.Name = "rbPesqCPF";
            this.rbPesqCPF.Size = new System.Drawing.Size(48, 17);
            this.rbPesqCPF.TabIndex = 3;
            this.rbPesqCPF.TabStop = true;
            this.rbPesqCPF.Text = "CPF";
            this.rbPesqCPF.UseVisualStyleBackColor = true;
            this.rbPesqCPF.CheckedChanged += new System.EventHandler(this.rbPesqCPF_CheckedChanged);
            // 
            // pnAgCalendario
            // 
            this.pnAgCalendario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnAgCalendario.BackColor = System.Drawing.Color.SteelBlue;
            this.pnAgCalendario.Controls.Add(this.label1);
            this.pnAgCalendario.Controls.Add(this.btPesqCadFunc);
            this.pnAgCalendario.Controls.Add(this.lbPesqCliNovoProfissional);
            this.pnAgCalendario.Controls.Add(this.lbPesqCliNovoCadastro);
            this.pnAgCalendario.Controls.Add(this.btPesqNovoPro);
            this.pnAgCalendario.Controls.Add(this.gbAgPesquisa);
            this.pnAgCalendario.Controls.Add(this.btPesqNovoCliente);
            this.pnAgCalendario.Location = new System.Drawing.Point(15, 17);
            this.pnAgCalendario.Margin = new System.Windows.Forms.Padding(0);
            this.pnAgCalendario.Name = "pnAgCalendario";
            this.pnAgCalendario.Size = new System.Drawing.Size(355, 721);
            this.pnAgCalendario.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(203, 193);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Funcionario";
            // 
            // btPesqCadFunc
            // 
            this.btPesqCadFunc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btPesqCadFunc.BackColor = System.Drawing.Color.SteelBlue;
            this.btPesqCadFunc.BackgroundImage = global::ProjetoTCC2020.Properties.Resources.teste_3;
            this.btPesqCadFunc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btPesqCadFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPesqCadFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesqCadFunc.ForeColor = System.Drawing.Color.SteelBlue;
            this.btPesqCadFunc.Location = new System.Drawing.Point(192, 118);
            this.btPesqCadFunc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btPesqCadFunc.Name = "btPesqCadFunc";
            this.btPesqCadFunc.Size = new System.Drawing.Size(131, 73);
            this.btPesqCadFunc.TabIndex = 9;
            this.btPesqCadFunc.UseVisualStyleBackColor = false;
            this.btPesqCadFunc.Click += new System.EventHandler(this.btPesqCadFunc_Click);
            // 
            // lbPesqCliNovoProfissional
            // 
            this.lbPesqCliNovoProfissional.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPesqCliNovoProfissional.AutoSize = true;
            this.lbPesqCliNovoProfissional.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPesqCliNovoProfissional.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbPesqCliNovoProfissional.Location = new System.Drawing.Point(124, 89);
            this.lbPesqCliNovoProfissional.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPesqCliNovoProfissional.Name = "lbPesqCliNovoProfissional";
            this.lbPesqCliNovoProfissional.Size = new System.Drawing.Size(83, 15);
            this.lbPesqCliNovoProfissional.TabIndex = 8;
            this.lbPesqCliNovoProfissional.Text = "Profissional";
            this.lbPesqCliNovoProfissional.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbPesqCliNovoCadastro
            // 
            this.lbPesqCliNovoCadastro.AutoSize = true;
            this.lbPesqCliNovoCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPesqCliNovoCadastro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbPesqCliNovoCadastro.Location = new System.Drawing.Point(51, 192);
            this.lbPesqCliNovoCadastro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPesqCliNovoCadastro.Name = "lbPesqCliNovoCadastro";
            this.lbPesqCliNovoCadastro.Size = new System.Drawing.Size(52, 15);
            this.lbPesqCliNovoCadastro.TabIndex = 7;
            this.lbPesqCliNovoCadastro.Text = "Cliente";
            // 
            // btPesqNovoPro
            // 
            this.btPesqNovoPro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btPesqNovoPro.BackColor = System.Drawing.Color.SteelBlue;
            this.btPesqNovoPro.BackgroundImage = global::ProjetoTCC2020.Properties.Resources.teste_1;
            this.btPesqNovoPro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btPesqNovoPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPesqNovoPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesqNovoPro.ForeColor = System.Drawing.Color.SteelBlue;
            this.btPesqNovoPro.Location = new System.Drawing.Point(99, 4);
            this.btPesqNovoPro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btPesqNovoPro.Name = "btPesqNovoPro";
            this.btPesqNovoPro.Size = new System.Drawing.Size(155, 81);
            this.btPesqNovoPro.TabIndex = 5;
            this.btPesqNovoPro.UseVisualStyleBackColor = false;
            this.btPesqNovoPro.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbAgPesquisa
            // 
            this.gbAgPesquisa.Controls.Add(this.cbInativo);
            this.gbAgPesquisa.Controls.Add(this.mkPesqNome);
            this.gbAgPesquisa.Controls.Add(this.mkPesqCpf);
            this.gbAgPesquisa.Controls.Add(this.cbPesq);
            this.gbAgPesquisa.Controls.Add(this.btPesqBuscar);
            this.gbAgPesquisa.Controls.Add(this.rbPesqNome);
            this.gbAgPesquisa.Controls.Add(this.rbPesqCPF);
            this.gbAgPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAgPesquisa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbAgPesquisa.Location = new System.Drawing.Point(23, 252);
            this.gbAgPesquisa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbAgPesquisa.Name = "gbAgPesquisa";
            this.gbAgPesquisa.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbAgPesquisa.Size = new System.Drawing.Size(307, 348);
            this.gbAgPesquisa.TabIndex = 4;
            this.gbAgPesquisa.TabStop = false;
            this.gbAgPesquisa.Text = "Pesquisar";
            // 
            // cbInativo
            // 
            this.cbInativo.AutoSize = true;
            this.cbInativo.Location = new System.Drawing.Point(28, 80);
            this.cbInativo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbInativo.Name = "cbInativo";
            this.cbInativo.Size = new System.Drawing.Size(73, 20);
            this.cbInativo.TabIndex = 10;
            this.cbInativo.Text = "Inativo";
            this.cbInativo.UseVisualStyleBackColor = true;
            this.cbInativo.CheckedChanged += new System.EventHandler(this.cbInativo_CheckedChanged);
            // 
            // mkPesqNome
            // 
            this.mkPesqNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkPesqNome.Location = new System.Drawing.Point(28, 180);
            this.mkPesqNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mkPesqNome.Name = "mkPesqNome";
            this.mkPesqNome.Size = new System.Drawing.Size(260, 26);
            this.mkPesqNome.TabIndex = 9;
            this.mkPesqNome.Visible = false;
            // 
            // mkPesqCpf
            // 
            this.mkPesqCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkPesqCpf.Location = new System.Drawing.Point(28, 180);
            this.mkPesqCpf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mkPesqCpf.Mask = "999,999,999-99";
            this.mkPesqCpf.Name = "mkPesqCpf";
            this.mkPesqCpf.Size = new System.Drawing.Size(260, 26);
            this.mkPesqCpf.TabIndex = 8;
            this.mkPesqCpf.Visible = false;
            // 
            // cbPesq
            // 
            this.cbPesq.FormattingEnabled = true;
            this.cbPesq.Items.AddRange(new object[] {
            "Cliente",
            "Profissional",
            "Funcionario"});
            this.cbPesq.Location = new System.Drawing.Point(28, 126);
            this.cbPesq.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbPesq.Name = "cbPesq";
            this.cbPesq.Size = new System.Drawing.Size(260, 24);
            this.cbPesq.TabIndex = 7;
            // 
            // btPesqBuscar
            // 
            this.btPesqBuscar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btPesqBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPesqBuscar.Image = global::ProjetoTCC2020.Properties.Resources.icons8_pesquisar_64__1_;
            this.btPesqBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPesqBuscar.Location = new System.Drawing.Point(75, 236);
            this.btPesqBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btPesqBuscar.Name = "btPesqBuscar";
            this.btPesqBuscar.Size = new System.Drawing.Size(155, 68);
            this.btPesqBuscar.TabIndex = 2;
            this.btPesqBuscar.Text = "Buscar";
            this.btPesqBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btPesqBuscar.UseVisualStyleBackColor = true;
            this.btPesqBuscar.Click += new System.EventHandler(this.btPesqBuscar_Click);
            // 
            // btPesqNovoCliente
            // 
            this.btPesqNovoCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btPesqNovoCliente.BackColor = System.Drawing.Color.SteelBlue;
            this.btPesqNovoCliente.BackgroundImage = global::ProjetoTCC2020.Properties.Resources.teste_2__1_;
            this.btPesqNovoCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btPesqNovoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPesqNovoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesqNovoCliente.ForeColor = System.Drawing.Color.SteelBlue;
            this.btPesqNovoCliente.Location = new System.Drawing.Point(23, 118);
            this.btPesqNovoCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btPesqNovoCliente.Name = "btPesqNovoCliente";
            this.btPesqNovoCliente.Size = new System.Drawing.Size(131, 73);
            this.btPesqNovoCliente.TabIndex = 2;
            this.btPesqNovoCliente.UseVisualStyleBackColor = false;
            this.btPesqNovoCliente.Click += new System.EventHandler(this.btPesNovoCadastro_Click);
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.Width = 70;
            // 
            // cPFDataGridViewTextBoxColumn
            // 
            this.cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            this.cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
            this.cPFDataGridViewTextBoxColumn.Width = 70;
            // 
            // fmPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(96)))), ((int)(((byte)(145)))));
            this.ClientSize = new System.Drawing.Size(1371, 750);
            this.Controls.Add(this.pnAgCalendario);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmPesquisa";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar";
            this.Load += new System.EventHandler(this.fmPesquisa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPesq)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPesqCadastro)).EndInit();
            this.pnAgCalendario.ResumeLayout(false);
            this.pnAgCalendario.PerformLayout();
            this.gbAgPesquisa.ResumeLayout(false);
            this.gbAgPesquisa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView gridPesq;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbPesqNome;
        private System.Windows.Forms.RadioButton rbPesqCPF;
        private System.Windows.Forms.Panel pnAgCalendario;
        private System.Windows.Forms.GroupBox gbAgPesquisa;
        private System.Windows.Forms.Button btPesqBuscar;
        private System.Windows.Forms.Button btPesqNovoCliente;
        private System.Windows.Forms.ComboBox cbPesq;
        private System.Windows.Forms.Button btPesqNovoPro;
        private System.Windows.Forms.Button btPesqCanc;
        private System.Windows.Forms.MaskedTextBox mkPesqNome;
        private System.Windows.Forms.MaskedTextBox mkPesqCpf;
        private System.Windows.Forms.DataGridView gridPesqCadastro;
        //private CadastroDataSet cadastroDataSet;
        private System.Windows.Forms.Label lbPesqCliNovoProfissional;
        private System.Windows.Forms.Label lbPesqCliNovoCadastro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btPesqCadFunc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckBox cbInativo;
    }
}