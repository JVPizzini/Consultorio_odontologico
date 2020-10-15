namespace ProjetoTCC2020.Agendamento
{
    partial class fmRelatorio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmRelatorio));
            this.pnAgCalendario = new System.Windows.Forms.Panel();
            this.lbRelStatus = new System.Windows.Forms.Label();
            this.btRelExportar = new System.Windows.Forms.Button();
            this.gbAgPesquisa = new System.Windows.Forms.GroupBox();
            this.lbRelStatusConsulta = new System.Windows.Forms.Label();
            this.cbRelStatusConsulta = new System.Windows.Forms.ComboBox();
            this.dtRelIni = new System.Windows.Forms.DateTimePicker();
            this.dtRelFinal = new System.Windows.Forms.DateTimePicker();
            this.lbAgDtIni = new System.Windows.Forms.Label();
            this.lbAgDtFim = new System.Windows.Forms.Label();
            this.btRelBuscar = new System.Windows.Forms.Button();
            this.pbAgPesquisa = new System.Windows.Forms.Panel();
            this.pnPb = new System.Windows.Forms.Panel();
            this.ProgressBarRel = new System.Windows.Forms.Label();
            this.pbAg = new System.Windows.Forms.ProgressBar();
            this.btAgCanc = new System.Windows.Forms.Button();
            this.gridRel = new System.Windows.Forms.DataGridView();
            this.pnAgCalendario.SuspendLayout();
            this.gbAgPesquisa.SuspendLayout();
            this.pbAgPesquisa.SuspendLayout();
            this.pnPb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRel)).BeginInit();
            this.SuspendLayout();
            // 
            // pnAgCalendario
            // 
            this.pnAgCalendario.BackColor = System.Drawing.Color.SteelBlue;
            this.pnAgCalendario.Controls.Add(this.lbRelStatus);
            this.pnAgCalendario.Controls.Add(this.btRelExportar);
            this.pnAgCalendario.Controls.Add(this.gbAgPesquisa);
            this.pnAgCalendario.Location = new System.Drawing.Point(10, 10);
            this.pnAgCalendario.Margin = new System.Windows.Forms.Padding(0);
            this.pnAgCalendario.Name = "pnAgCalendario";
            this.pnAgCalendario.Size = new System.Drawing.Size(222, 576);
            this.pnAgCalendario.TabIndex = 0;
            // 
            // lbRelStatus
            // 
            this.lbRelStatus.AutoSize = true;
            this.lbRelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRelStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbRelStatus.Location = new System.Drawing.Point(39, 318);
            this.lbRelStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRelStatus.Name = "lbRelStatus";
            this.lbRelStatus.Size = new System.Drawing.Size(134, 16);
            this.lbRelStatus.TabIndex = 16;
            this.lbRelStatus.Text = "Exportar Relatório";
            // 
            // btRelExportar
            // 
            this.btRelExportar.BackColor = System.Drawing.Color.SteelBlue;
            this.btRelExportar.BackgroundImage = global::ProjetoTCC2020.Properties.Resources._116680860;
            this.btRelExportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btRelExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRelExportar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btRelExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btRelExportar.Location = new System.Drawing.Point(76, 338);
            this.btRelExportar.Margin = new System.Windows.Forms.Padding(2);
            this.btRelExportar.Name = "btRelExportar";
            this.btRelExportar.Size = new System.Drawing.Size(47, 47);
            this.btRelExportar.TabIndex = 46;
            this.btRelExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btRelExportar.UseVisualStyleBackColor = false;
            this.btRelExportar.Click += new System.EventHandler(this.btAgExportar_Click_1);
            // 
            // gbAgPesquisa
            // 
            this.gbAgPesquisa.Controls.Add(this.lbRelStatusConsulta);
            this.gbAgPesquisa.Controls.Add(this.cbRelStatusConsulta);
            this.gbAgPesquisa.Controls.Add(this.dtRelIni);
            this.gbAgPesquisa.Controls.Add(this.dtRelFinal);
            this.gbAgPesquisa.Controls.Add(this.lbAgDtIni);
            this.gbAgPesquisa.Controls.Add(this.lbAgDtFim);
            this.gbAgPesquisa.Controls.Add(this.btRelBuscar);
            this.gbAgPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAgPesquisa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbAgPesquisa.Location = new System.Drawing.Point(27, 23);
            this.gbAgPesquisa.Margin = new System.Windows.Forms.Padding(2);
            this.gbAgPesquisa.Name = "gbAgPesquisa";
            this.gbAgPesquisa.Padding = new System.Windows.Forms.Padding(2);
            this.gbAgPesquisa.Size = new System.Drawing.Size(166, 273);
            this.gbAgPesquisa.TabIndex = 4;
            this.gbAgPesquisa.TabStop = false;
            this.gbAgPesquisa.Text = "Pesquisar";
            this.gbAgPesquisa.Enter += new System.EventHandler(this.gbAgPesquisa_Enter);
            // 
            // lbRelStatusConsulta
            // 
            this.lbRelStatusConsulta.AutoSize = true;
            this.lbRelStatusConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRelStatusConsulta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbRelStatusConsulta.Location = new System.Drawing.Point(29, 23);
            this.lbRelStatusConsulta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRelStatusConsulta.Name = "lbRelStatusConsulta";
            this.lbRelStatusConsulta.Size = new System.Drawing.Size(115, 16);
            this.lbRelStatusConsulta.TabIndex = 15;
            this.lbRelStatusConsulta.Text = "Status Consulta";
            // 
            // cbRelStatusConsulta
            // 
            this.cbRelStatusConsulta.FormattingEnabled = true;
            this.cbRelStatusConsulta.Items.AddRange(new object[] {
            "Todos",
            "Consultados",
            "Cancelados",
            "A Consultar"});
            this.cbRelStatusConsulta.Location = new System.Drawing.Point(15, 39);
            this.cbRelStatusConsulta.Margin = new System.Windows.Forms.Padding(2);
            this.cbRelStatusConsulta.Name = "cbRelStatusConsulta";
            this.cbRelStatusConsulta.Size = new System.Drawing.Size(138, 24);
            this.cbRelStatusConsulta.TabIndex = 14;
            // 
            // dtRelIni
            // 
            this.dtRelIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtRelIni.Location = new System.Drawing.Point(13, 97);
            this.dtRelIni.Margin = new System.Windows.Forms.Padding(2);
            this.dtRelIni.Name = "dtRelIni";
            this.dtRelIni.Size = new System.Drawing.Size(138, 22);
            this.dtRelIni.TabIndex = 12;
            // 
            // dtRelFinal
            // 
            this.dtRelFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtRelFinal.Location = new System.Drawing.Point(13, 156);
            this.dtRelFinal.Margin = new System.Windows.Forms.Padding(2);
            this.dtRelFinal.Name = "dtRelFinal";
            this.dtRelFinal.Size = new System.Drawing.Size(138, 22);
            this.dtRelFinal.TabIndex = 13;
            // 
            // lbAgDtIni
            // 
            this.lbAgDtIni.AutoSize = true;
            this.lbAgDtIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAgDtIni.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbAgDtIni.Location = new System.Drawing.Point(39, 79);
            this.lbAgDtIni.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAgDtIni.Name = "lbAgDtIni";
            this.lbAgDtIni.Size = new System.Drawing.Size(82, 16);
            this.lbAgDtIni.TabIndex = 7;
            this.lbAgDtIni.Text = "Data inicio";
            // 
            // lbAgDtFim
            // 
            this.lbAgDtFim.AutoSize = true;
            this.lbAgDtFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAgDtFim.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbAgDtFim.Location = new System.Drawing.Point(44, 139);
            this.lbAgDtFim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAgDtFim.Name = "lbAgDtFim";
            this.lbAgDtFim.Size = new System.Drawing.Size(70, 16);
            this.lbAgDtFim.TabIndex = 6;
            this.lbAgDtFim.Text = "Data Fim";
            this.lbAgDtFim.Click += new System.EventHandler(this.lbAgDtFim_Click);
            // 
            // btRelBuscar
            // 
            this.btRelBuscar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btRelBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRelBuscar.Image = global::ProjetoTCC2020.Properties.Resources.icons8_pesquisar_64__1_;
            this.btRelBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRelBuscar.Location = new System.Drawing.Point(22, 203);
            this.btRelBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btRelBuscar.Name = "btRelBuscar";
            this.btRelBuscar.Size = new System.Drawing.Size(122, 57);
            this.btRelBuscar.TabIndex = 2;
            this.btRelBuscar.Text = "Buscar";
            this.btRelBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btRelBuscar.UseVisualStyleBackColor = true;
            this.btRelBuscar.Click += new System.EventHandler(this.btRelBuscar_Click);
            // 
            // pbAgPesquisa
            // 
            this.pbAgPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbAgPesquisa.BackColor = System.Drawing.Color.SteelBlue;
            this.pbAgPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbAgPesquisa.Controls.Add(this.pnPb);
            this.pbAgPesquisa.Controls.Add(this.btAgCanc);
            this.pbAgPesquisa.Controls.Add(this.gridRel);
            this.pbAgPesquisa.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbAgPesquisa.Location = new System.Drawing.Point(242, 10);
            this.pbAgPesquisa.Margin = new System.Windows.Forms.Padding(2);
            this.pbAgPesquisa.Name = "pbAgPesquisa";
            this.pbAgPesquisa.Size = new System.Drawing.Size(1048, 576);
            this.pbAgPesquisa.TabIndex = 1;
            // 
            // pnPb
            // 
            this.pnPb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnPb.BackColor = System.Drawing.Color.SteelBlue;
            this.pnPb.Controls.Add(this.ProgressBarRel);
            this.pnPb.Controls.Add(this.pbAg);
            this.pnPb.Location = new System.Drawing.Point(450, 236);
            this.pnPb.Margin = new System.Windows.Forms.Padding(2);
            this.pnPb.Name = "pnPb";
            this.pnPb.Size = new System.Drawing.Size(184, 60);
            this.pnPb.TabIndex = 46;
            this.pnPb.Visible = false;
            // 
            // ProgressBarRel
            // 
            this.ProgressBarRel.AutoSize = true;
            this.ProgressBarRel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ProgressBarRel.Location = new System.Drawing.Point(51, 8);
            this.ProgressBarRel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProgressBarRel.Name = "ProgressBarRel";
            this.ProgressBarRel.Size = new System.Drawing.Size(86, 16);
            this.ProgressBarRel.TabIndex = 1;
            this.ProgressBarRel.Text = "Exportando...";
            // 
            // pbAg
            // 
            this.pbAg.Location = new System.Drawing.Point(22, 26);
            this.pbAg.Margin = new System.Windows.Forms.Padding(2);
            this.pbAg.Name = "pbAg";
            this.pbAg.Size = new System.Drawing.Size(138, 18);
            this.pbAg.TabIndex = 0;
            // 
            // btAgCanc
            // 
            this.btAgCanc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btAgCanc.BackColor = System.Drawing.Color.SteelBlue;
            this.btAgCanc.BackgroundImage = global::ProjetoTCC2020.Properties.Resources.icons8_excluir_64;
            this.btAgCanc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btAgCanc.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btAgCanc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAgCanc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgCanc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btAgCanc.Location = new System.Drawing.Point(992, 539);
            this.btAgCanc.Margin = new System.Windows.Forms.Padding(0);
            this.btAgCanc.Name = "btAgCanc";
            this.btAgCanc.Size = new System.Drawing.Size(41, 30);
            this.btAgCanc.TabIndex = 44;
            this.btAgCanc.UseVisualStyleBackColor = false;
            this.btAgCanc.Click += new System.EventHandler(this.btAgCanc_Click);
            // 
            // gridRel
            // 
            this.gridRel.AllowUserToAddRows = false;
            this.gridRel.AllowUserToDeleteRows = false;
            this.gridRel.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.gridRel.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridRel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridRel.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridRel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridRel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridRel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRel.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gridRel.Location = new System.Drawing.Point(13, 12);
            this.gridRel.Margin = new System.Windows.Forms.Padding(2);
            this.gridRel.MultiSelect = false;
            this.gridRel.Name = "gridRel";
            this.gridRel.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridRel.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridRel.RowHeadersWidth = 51;
            this.gridRel.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gridRel.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.gridRel.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gridRel.RowTemplate.Height = 24;
            this.gridRel.RowTemplate.ReadOnly = true;
            this.gridRel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridRel.Size = new System.Drawing.Size(1022, 522);
            this.gridRel.TabIndex = 10;
            // 
            // fmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(96)))), ((int)(((byte)(145)))));
            this.ClientSize = new System.Drawing.Size(1300, 594);
            this.Controls.Add(this.pbAgPesquisa);
            this.Controls.Add(this.pnAgCalendario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmRelatorio";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório";
            this.pnAgCalendario.ResumeLayout(false);
            this.pnAgCalendario.PerformLayout();
            this.gbAgPesquisa.ResumeLayout(false);
            this.gbAgPesquisa.PerformLayout();
            this.pbAgPesquisa.ResumeLayout(false);
            this.pnPb.ResumeLayout(false);
            this.pnPb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnAgCalendario;
        private System.Windows.Forms.GroupBox gbAgPesquisa;
        private System.Windows.Forms.Button btRelBuscar;
        private System.Windows.Forms.Label lbAgDtIni;
        private System.Windows.Forms.Label lbAgDtFim;
        private System.Windows.Forms.DateTimePicker dtRelIni;
        private System.Windows.Forms.DateTimePicker dtRelFinal;
        private System.Windows.Forms.DataGridView gridRel;
        private System.Windows.Forms.Button btAgCanc;
        private System.Windows.Forms.Panel pbAgPesquisa;
        private System.Windows.Forms.Panel pnPb;
        private System.Windows.Forms.Label ProgressBarRel;
        private System.Windows.Forms.ProgressBar pbAg;
        private System.Windows.Forms.ComboBox cbRelStatusConsulta;
        private System.Windows.Forms.Label lbRelStatusConsulta;
        private System.Windows.Forms.Label lbRelStatus;
        private System.Windows.Forms.Button btRelExportar;
    }
}