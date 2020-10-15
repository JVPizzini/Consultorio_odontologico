namespace ProjetoTCC2020.Pesquisa
{
    partial class fmPesquisaServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmPesquisaServico));
            this.gridServ = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btPesqCanc = new System.Windows.Forms.Button();
            this.pnAgCalendario = new System.Windows.Forms.Panel();
            this.lbPesqCliNovoProfissional = new System.Windows.Forms.Label();
            this.btServNovoServ = new System.Windows.Forms.Button();
            this.gbAgPesquisa = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mkPesqServNome = new System.Windows.Forms.MaskedTextBox();
            this.btServBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridServ)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnAgCalendario.SuspendLayout();
            this.gbAgPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridServ
            // 
            this.gridServ.AllowUserToAddRows = false;
            this.gridServ.AllowUserToDeleteRows = false;
            this.gridServ.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.gridServ.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridServ.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridServ.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridServ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridServ.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.gridServ.Location = new System.Drawing.Point(17, 16);
            this.gridServ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridServ.Name = "gridServ";
            this.gridServ.ReadOnly = true;
            this.gridServ.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridServ.Size = new System.Drawing.Size(916, 650);
            this.gridServ.TabIndex = 1;
            this.gridServ.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridServ_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btPesqCanc);
            this.panel1.Controls.Add(this.gridServ);
            this.panel1.Location = new System.Drawing.Point(402, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 721);
            this.panel1.TabIndex = 3;
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
            this.btPesqCanc.Location = new System.Drawing.Point(884, 677);
            this.btPesqCanc.Margin = new System.Windows.Forms.Padding(0);
            this.btPesqCanc.Name = "btPesqCanc";
            this.btPesqCanc.Size = new System.Drawing.Size(48, 38);
            this.btPesqCanc.TabIndex = 43;
            this.btPesqCanc.UseVisualStyleBackColor = false;
            this.btPesqCanc.Click += new System.EventHandler(this.btPesqCanc_Click);
            // 
            // pnAgCalendario
            // 
            this.pnAgCalendario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnAgCalendario.BackColor = System.Drawing.Color.SteelBlue;
            this.pnAgCalendario.Controls.Add(this.lbPesqCliNovoProfissional);
            this.pnAgCalendario.Controls.Add(this.btServNovoServ);
            this.pnAgCalendario.Controls.Add(this.gbAgPesquisa);
            this.pnAgCalendario.Location = new System.Drawing.Point(17, 14);
            this.pnAgCalendario.Margin = new System.Windows.Forms.Padding(0);
            this.pnAgCalendario.Name = "pnAgCalendario";
            this.pnAgCalendario.Size = new System.Drawing.Size(367, 722);
            this.pnAgCalendario.TabIndex = 5;
            // 
            // lbPesqCliNovoProfissional
            // 
            this.lbPesqCliNovoProfissional.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPesqCliNovoProfissional.AutoSize = true;
            this.lbPesqCliNovoProfissional.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPesqCliNovoProfissional.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbPesqCliNovoProfissional.Location = new System.Drawing.Point(104, 180);
            this.lbPesqCliNovoProfissional.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPesqCliNovoProfissional.Name = "lbPesqCliNovoProfissional";
            this.lbPesqCliNovoProfissional.Size = new System.Drawing.Size(113, 20);
            this.lbPesqCliNovoProfissional.TabIndex = 9;
            this.lbPesqCliNovoProfissional.Text = "Novo Serviço";
            // 
            // btServNovoServ
            // 
            this.btServNovoServ.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btServNovoServ.BackColor = System.Drawing.Color.SteelBlue;
            this.btServNovoServ.BackgroundImage = global::ProjetoTCC2020.Properties.Resources.dente;
            this.btServNovoServ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btServNovoServ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btServNovoServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btServNovoServ.ForeColor = System.Drawing.Color.SteelBlue;
            this.btServNovoServ.Location = new System.Drawing.Point(109, 46);
            this.btServNovoServ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btServNovoServ.Name = "btServNovoServ";
            this.btServNovoServ.Size = new System.Drawing.Size(141, 130);
            this.btServNovoServ.TabIndex = 7;
            this.btServNovoServ.UseVisualStyleBackColor = false;
            this.btServNovoServ.Click += new System.EventHandler(this.button3_Click);
            // 
            // gbAgPesquisa
            // 
            this.gbAgPesquisa.Controls.Add(this.label1);
            this.gbAgPesquisa.Controls.Add(this.mkPesqServNome);
            this.gbAgPesquisa.Controls.Add(this.btServBuscar);
            this.gbAgPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAgPesquisa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbAgPesquisa.Location = new System.Drawing.Point(23, 252);
            this.gbAgPesquisa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbAgPesquisa.Name = "gbAgPesquisa";
            this.gbAgPesquisa.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbAgPesquisa.Size = new System.Drawing.Size(307, 274);
            this.gbAgPesquisa.TabIndex = 4;
            this.gbAgPesquisa.TabStop = false;
            this.gbAgPesquisa.Text = "Pesquisar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nome do Serviço";
            // 
            // mkPesqServNome
            // 
            this.mkPesqServNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkPesqServNome.Location = new System.Drawing.Point(23, 80);
            this.mkPesqServNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mkPesqServNome.Name = "mkPesqServNome";
            this.mkPesqServNome.Size = new System.Drawing.Size(260, 26);
            this.mkPesqServNome.TabIndex = 11;
            // 
            // btServBuscar
            // 
            this.btServBuscar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btServBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btServBuscar.Image = global::ProjetoTCC2020.Properties.Resources.icons8_pesquisar_64__1_;
            this.btServBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btServBuscar.Location = new System.Drawing.Point(72, 159);
            this.btServBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btServBuscar.Name = "btServBuscar";
            this.btServBuscar.Size = new System.Drawing.Size(155, 68);
            this.btServBuscar.TabIndex = 2;
            this.btServBuscar.Text = "Buscar";
            this.btServBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btServBuscar.UseVisualStyleBackColor = true;
            this.btServBuscar.Click += new System.EventHandler(this.btServBuscar_Click);
            // 
            // fmPesquisaServico
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
            this.Name = "fmPesquisaServico";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar";
            this.Load += new System.EventHandler(this.fmPesquisaServico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridServ)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnAgCalendario.ResumeLayout(false);
            this.pnAgCalendario.PerformLayout();
            this.gbAgPesquisa.ResumeLayout(false);
            this.gbAgPesquisa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView gridServ;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnAgCalendario;
        private System.Windows.Forms.GroupBox gbAgPesquisa;
        private System.Windows.Forms.Button btServBuscar;
        private System.Windows.Forms.Button btServNovoServ;
        private System.Windows.Forms.Button btPesqCanc;
        private System.Windows.Forms.MaskedTextBox mkPesqServNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPesqCliNovoProfissional;
    }
}