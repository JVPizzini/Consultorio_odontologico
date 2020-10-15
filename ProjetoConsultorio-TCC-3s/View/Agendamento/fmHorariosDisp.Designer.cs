namespace ProjetoTCC2020.View.Agendamento
{
    partial class fmHorariosDisp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmHorariosDisp));
            this.dtPesqData = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dgHorarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgHorarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dtPesqData
            // 
            this.dtPesqData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPesqData.Location = new System.Drawing.Point(12, 29);
            this.dtPesqData.Name = "dtPesqData";
            this.dtPesqData.Size = new System.Drawing.Size(107, 20);
            this.dtPesqData.TabIndex = 0;
            this.dtPesqData.ValueChanged += new System.EventHandler(this.dtPesqData_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data pesquisa";
            // 
            // dgHorarios
            // 
            this.dgHorarios.AllowUserToAddRows = false;
            this.dgHorarios.AllowUserToDeleteRows = false;
            this.dgHorarios.AllowUserToOrderColumns = true;
            this.dgHorarios.BackgroundColor = System.Drawing.Color.White;
            this.dgHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHorarios.Location = new System.Drawing.Point(12, 73);
            this.dgHorarios.Name = "dgHorarios";
            this.dgHorarios.ReadOnly = true;
            this.dgHorarios.Size = new System.Drawing.Size(442, 313);
            this.dgHorarios.TabIndex = 2;
            // 
            // fmHorariosDisp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(96)))), ((int)(((byte)(145)))));
            this.ClientSize = new System.Drawing.Size(466, 398);
            this.Controls.Add(this.dgHorarios);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtPesqData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmHorariosDisp";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horários Disponíveis";
            this.Load += new System.EventHandler(this.fmHorariosDisp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgHorarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtPesqData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgHorarios;
    }
}