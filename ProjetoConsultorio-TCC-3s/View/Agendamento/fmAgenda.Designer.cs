namespace ProjetoTCC2020.Agendamento
{
    partial class fmAgenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmAgenda));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnAgCalendario = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btAgHorariosDisp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbAgCalendario = new System.Windows.Forms.Label();
            this.gbAgPesquisa = new System.Windows.Forms.GroupBox();
            this.dtAgIni = new System.Windows.Forms.DateTimePicker();
            this.dtAgFinal = new System.Windows.Forms.DateTimePicker();
            this.lbAgDtIni = new System.Windows.Forms.Label();
            this.lbAgDtFim = new System.Windows.Forms.Label();
            this.btAgBuscar = new System.Windows.Forms.Button();
            this.btAgInserir = new System.Windows.Forms.Button();
            this.CalendarioAg = new System.Windows.Forms.MonthCalendar();
            this.pbAgPesquisa = new System.Windows.Forms.Panel();
            this.pnPb = new System.Windows.Forms.Panel();
            this.ProgressBarAg = new System.Windows.Forms.Label();
            this.pbAg = new System.Windows.Forms.ProgressBar();
            this.btAgCanc = new System.Windows.Forms.Button();
            this.lbAgData = new System.Windows.Forms.Label();
            this.gridAg = new System.Windows.Forms.DataGridView();
            this.lbAgTitulo = new System.Windows.Forms.Label();
            this.pnAgCalendario.SuspendLayout();
            this.gbAgPesquisa.SuspendLayout();
            this.pbAgPesquisa.SuspendLayout();
            this.pnPb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAg)).BeginInit();
            this.SuspendLayout();
            // 
            // pnAgCalendario
            // 
            this.pnAgCalendario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnAgCalendario.BackColor = System.Drawing.Color.SteelBlue;
            this.pnAgCalendario.Controls.Add(this.label2);
            this.pnAgCalendario.Controls.Add(this.btAgHorariosDisp);
            this.pnAgCalendario.Controls.Add(this.label1);
            this.pnAgCalendario.Controls.Add(this.lbAgCalendario);
            this.pnAgCalendario.Controls.Add(this.gbAgPesquisa);
            this.pnAgCalendario.Controls.Add(this.btAgInserir);
            this.pnAgCalendario.Controls.Add(this.CalendarioAg);
            this.pnAgCalendario.Location = new System.Drawing.Point(10, 10);
            this.pnAgCalendario.Margin = new System.Windows.Forms.Padding(0);
            this.pnAgCalendario.Name = "pnAgCalendario";
            this.pnAgCalendario.Size = new System.Drawing.Size(284, 644);
            this.pnAgCalendario.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(174, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 33);
            this.label2.TabIndex = 11;
            this.label2.Text = "Horários Disponíveis";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btAgHorariosDisp
            // 
            this.btAgHorariosDisp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btAgHorariosDisp.BackgroundImage")));
            this.btAgHorariosDisp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btAgHorariosDisp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAgHorariosDisp.ForeColor = System.Drawing.Color.SteelBlue;
            this.btAgHorariosDisp.Location = new System.Drawing.Point(179, 27);
            this.btAgHorariosDisp.Name = "btAgHorariosDisp";
            this.btAgHorariosDisp.Size = new System.Drawing.Size(78, 85);
            this.btAgHorariosDisp.TabIndex = 10;
            this.btAgHorariosDisp.UseVisualStyleBackColor = true;
            this.btAgHorariosDisp.Click += new System.EventHandler(this.btAgHorariosDisp_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(23, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "Novo Agendamento";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbAgCalendario
            // 
            this.lbAgCalendario.AutoSize = true;
            this.lbAgCalendario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAgCalendario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbAgCalendario.Location = new System.Drawing.Point(56, 154);
            this.lbAgCalendario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAgCalendario.Name = "lbAgCalendario";
            this.lbAgCalendario.Size = new System.Drawing.Size(174, 16);
            this.lbAgCalendario.TabIndex = 8;
            this.lbAgCalendario.Text = "Pesquisa agenda diária";
            // 
            // gbAgPesquisa
            // 
            this.gbAgPesquisa.Controls.Add(this.dtAgIni);
            this.gbAgPesquisa.Controls.Add(this.dtAgFinal);
            this.gbAgPesquisa.Controls.Add(this.lbAgDtIni);
            this.gbAgPesquisa.Controls.Add(this.lbAgDtFim);
            this.gbAgPesquisa.Controls.Add(this.btAgBuscar);
            this.gbAgPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAgPesquisa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbAgPesquisa.Location = new System.Drawing.Point(29, 359);
            this.gbAgPesquisa.Margin = new System.Windows.Forms.Padding(2);
            this.gbAgPesquisa.Name = "gbAgPesquisa";
            this.gbAgPesquisa.Padding = new System.Windows.Forms.Padding(2);
            this.gbAgPesquisa.Size = new System.Drawing.Size(228, 252);
            this.gbAgPesquisa.TabIndex = 4;
            this.gbAgPesquisa.TabStop = false;
            this.gbAgPesquisa.Text = "Pesquisar";
            this.gbAgPesquisa.Enter += new System.EventHandler(this.gbAgPesquisa_Enter);
            // 
            // dtAgIni
            // 
            this.dtAgIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtAgIni.Location = new System.Drawing.Point(47, 50);
            this.dtAgIni.Margin = new System.Windows.Forms.Padding(2);
            this.dtAgIni.Name = "dtAgIni";
            this.dtAgIni.Size = new System.Drawing.Size(138, 22);
            this.dtAgIni.TabIndex = 12;
            // 
            // dtAgFinal
            // 
            this.dtAgFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtAgFinal.Location = new System.Drawing.Point(46, 115);
            this.dtAgFinal.Margin = new System.Windows.Forms.Padding(2);
            this.dtAgFinal.Name = "dtAgFinal";
            this.dtAgFinal.Size = new System.Drawing.Size(138, 22);
            this.dtAgFinal.TabIndex = 13;
            // 
            // lbAgDtIni
            // 
            this.lbAgDtIni.AutoSize = true;
            this.lbAgDtIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAgDtIni.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbAgDtIni.Location = new System.Drawing.Point(82, 31);
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
            this.lbAgDtFim.Location = new System.Drawing.Point(85, 96);
            this.lbAgDtFim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAgDtFim.Name = "lbAgDtFim";
            this.lbAgDtFim.Size = new System.Drawing.Size(70, 16);
            this.lbAgDtFim.TabIndex = 6;
            this.lbAgDtFim.Text = "Data Fim";
            // 
            // btAgBuscar
            // 
            this.btAgBuscar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btAgBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAgBuscar.Image = global::ProjetoTCC2020.Properties.Resources.icons8_pesquisar_64__1_;
            this.btAgBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAgBuscar.Location = new System.Drawing.Point(54, 165);
            this.btAgBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btAgBuscar.Name = "btAgBuscar";
            this.btAgBuscar.Size = new System.Drawing.Size(122, 57);
            this.btAgBuscar.TabIndex = 2;
            this.btAgBuscar.Text = "Buscar";
            this.btAgBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAgBuscar.UseVisualStyleBackColor = true;
            this.btAgBuscar.Click += new System.EventHandler(this.btAgBuscar_Click);
            // 
            // btAgInserir
            // 
            this.btAgInserir.BackColor = System.Drawing.Color.SteelBlue;
            this.btAgInserir.BackgroundImage = global::ProjetoTCC2020.Properties.Resources.icons8_mais_calendário_64;
            this.btAgInserir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btAgInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAgInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgInserir.ForeColor = System.Drawing.Color.SteelBlue;
            this.btAgInserir.Location = new System.Drawing.Point(32, 36);
            this.btAgInserir.Margin = new System.Windows.Forms.Padding(2);
            this.btAgInserir.Name = "btAgInserir";
            this.btAgInserir.Size = new System.Drawing.Size(86, 67);
            this.btAgInserir.TabIndex = 2;
            this.btAgInserir.UseVisualStyleBackColor = false;
            this.btAgInserir.Click += new System.EventHandler(this.btAgInserir_Click);
            // 
            // CalendarioAg
            // 
            this.CalendarioAg.Location = new System.Drawing.Point(32, 173);
            this.CalendarioAg.Margin = new System.Windows.Forms.Padding(7);
            this.CalendarioAg.Name = "CalendarioAg";
            this.CalendarioAg.TabIndex = 0;
            this.CalendarioAg.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.AgCalendario_DateChanged);
            // 
            // pbAgPesquisa
            // 
            this.pbAgPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbAgPesquisa.BackColor = System.Drawing.Color.SteelBlue;
            this.pbAgPesquisa.BackgroundImage = global::ProjetoTCC2020.Properties.Resources.WhatsApp_Image_2020_04_29_at_22_301;
            this.pbAgPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbAgPesquisa.Controls.Add(this.pnPb);
            this.pbAgPesquisa.Controls.Add(this.btAgCanc);
            this.pbAgPesquisa.Controls.Add(this.lbAgData);
            this.pbAgPesquisa.Controls.Add(this.gridAg);
            this.pbAgPesquisa.Controls.Add(this.lbAgTitulo);
            this.pbAgPesquisa.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbAgPesquisa.Location = new System.Drawing.Point(306, 10);
            this.pbAgPesquisa.Margin = new System.Windows.Forms.Padding(2);
            this.pbAgPesquisa.Name = "pbAgPesquisa";
            this.pbAgPesquisa.Size = new System.Drawing.Size(1045, 644);
            this.pbAgPesquisa.TabIndex = 1;
            // 
            // pnPb
            // 
            this.pnPb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnPb.BackColor = System.Drawing.Color.SteelBlue;
            this.pnPb.Controls.Add(this.ProgressBarAg);
            this.pnPb.Controls.Add(this.pbAg);
            this.pnPb.Location = new System.Drawing.Point(438, 294);
            this.pnPb.Margin = new System.Windows.Forms.Padding(2);
            this.pnPb.Name = "pnPb";
            this.pnPb.Size = new System.Drawing.Size(177, 73);
            this.pnPb.TabIndex = 46;
            this.pnPb.Visible = false;
            // 
            // ProgressBarAg
            // 
            this.ProgressBarAg.AutoSize = true;
            this.ProgressBarAg.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ProgressBarAg.Location = new System.Drawing.Point(55, 17);
            this.ProgressBarAg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProgressBarAg.Name = "ProgressBarAg";
            this.ProgressBarAg.Size = new System.Drawing.Size(70, 13);
            this.ProgressBarAg.TabIndex = 1;
            this.ProgressBarAg.Text = "Exportando...";
            // 
            // pbAg
            // 
            this.pbAg.Location = new System.Drawing.Point(22, 32);
            this.pbAg.Margin = new System.Windows.Forms.Padding(2);
            this.pbAg.Name = "pbAg";
            this.pbAg.Size = new System.Drawing.Size(138, 18);
            this.pbAg.TabIndex = 0;
            // 
            // btAgCanc
            // 
            this.btAgCanc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btAgCanc.BackColor = System.Drawing.Color.SteelBlue;
            this.btAgCanc.BackgroundImage = global::ProjetoTCC2020.Properties.Resources.icons8_excluir_64;
            this.btAgCanc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btAgCanc.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btAgCanc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAgCanc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgCanc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btAgCanc.Location = new System.Drawing.Point(984, 592);
            this.btAgCanc.Margin = new System.Windows.Forms.Padding(0);
            this.btAgCanc.Name = "btAgCanc";
            this.btAgCanc.Size = new System.Drawing.Size(50, 38);
            this.btAgCanc.TabIndex = 44;
            this.btAgCanc.UseVisualStyleBackColor = false;
            this.btAgCanc.Click += new System.EventHandler(this.btAgCanc_Click);
            // 
            // lbAgData
            // 
            this.lbAgData.AutoSize = true;
            this.lbAgData.BackColor = System.Drawing.Color.Transparent;
            this.lbAgData.Font = new System.Drawing.Font("Myanmar Text", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAgData.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbAgData.Location = new System.Drawing.Point(338, 60);
            this.lbAgData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAgData.Name = "lbAgData";
            this.lbAgData.Size = new System.Drawing.Size(169, 106);
            this.lbAgData.TabIndex = 12;
            this.lbAgData.Text = "data";
            // 
            // gridAg
            // 
            this.gridAg.AllowUserToAddRows = false;
            this.gridAg.AllowUserToDeleteRows = false;
            this.gridAg.AllowUserToOrderColumns = true;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            this.gridAg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gridAg.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridAg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridAg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAg.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gridAg.Location = new System.Drawing.Point(145, 185);
            this.gridAg.Margin = new System.Windows.Forms.Padding(2);
            this.gridAg.MultiSelect = false;
            this.gridAg.Name = "gridAg";
            this.gridAg.ReadOnly = true;
            this.gridAg.RowHeadersWidth = 51;
            this.gridAg.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gridAg.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.gridAg.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gridAg.RowTemplate.Height = 24;
            this.gridAg.RowTemplate.ReadOnly = true;
            this.gridAg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAg.Size = new System.Drawing.Size(761, 379);
            this.gridAg.TabIndex = 10;
            this.gridAg.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAg_CellDoubleClick);
            // 
            // lbAgTitulo
            // 
            this.lbAgTitulo.AutoSize = true;
            this.lbAgTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbAgTitulo.Font = new System.Drawing.Font("Myanmar Text", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAgTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbAgTitulo.Location = new System.Drawing.Point(345, 8);
            this.lbAgTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAgTitulo.Name = "lbAgTitulo";
            this.lbAgTitulo.Size = new System.Drawing.Size(350, 71);
            this.lbAgTitulo.TabIndex = 9;
            this.lbAgTitulo.Text = "AGENDA DO DIA";
            // 
            // fmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(96)))), ((int)(((byte)(145)))));
            this.ClientSize = new System.Drawing.Size(1360, 663);
            this.Controls.Add(this.pbAgPesquisa);
            this.Controls.Add(this.pnAgCalendario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "fmAgenda";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.fmAgenda_Load);
            this.pnAgCalendario.ResumeLayout(false);
            this.pnAgCalendario.PerformLayout();
            this.gbAgPesquisa.ResumeLayout(false);
            this.gbAgPesquisa.PerformLayout();
            this.pbAgPesquisa.ResumeLayout(false);
            this.pbAgPesquisa.PerformLayout();
            this.pnPb.ResumeLayout(false);
            this.pnPb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnAgCalendario;
        private System.Windows.Forms.MonthCalendar CalendarioAg;
        private System.Windows.Forms.GroupBox gbAgPesquisa;
        private System.Windows.Forms.Button btAgBuscar;
        private System.Windows.Forms.Button btAgInserir;
        private System.Windows.Forms.Label lbAgCalendario;
        private System.Windows.Forms.Label lbAgDtIni;
        private System.Windows.Forms.Label lbAgDtFim;
        private System.Windows.Forms.DateTimePicker dtAgIni;
        private System.Windows.Forms.DateTimePicker dtAgFinal;
        private System.Windows.Forms.DataGridView gridAg;
        private System.Windows.Forms.Label lbAgData;
        private System.Windows.Forms.Label lbAgTitulo;
        private System.Windows.Forms.Button btAgCanc;
        private System.Windows.Forms.Panel pbAgPesquisa;
        private System.Windows.Forms.Panel pnPb;
        private System.Windows.Forms.Label ProgressBarAg;
        private System.Windows.Forms.ProgressBar pbAg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btAgHorariosDisp;
    }
}