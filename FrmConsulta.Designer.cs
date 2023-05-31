namespace pryPonssaSP1ER._2
{
    partial class FrmConsulta
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
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.lstEspecialidades = new System.Windows.Forms.ComboBox();
            this.dgvMedicos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(34, 46);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(99, 20);
            this.lblEspecialidad.TabIndex = 0;
            this.lblEspecialidad.Text = "Especialidad";
            // 
            // lstEspecialidades
            // 
            this.lstEspecialidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstEspecialidades.FormattingEnabled = true;
            this.lstEspecialidades.Location = new System.Drawing.Point(148, 43);
            this.lstEspecialidades.Name = "lstEspecialidades";
            this.lstEspecialidades.Size = new System.Drawing.Size(159, 28);
            this.lstEspecialidades.TabIndex = 1;
            this.lstEspecialidades.SelectedIndexChanged += new System.EventHandler(this.lstEspecialidades_SelectedIndexChanged);
            // 
            // dgvMedicos
            // 
            this.dgvMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvMedicos.Location = new System.Drawing.Point(22, 99);
            this.dgvMedicos.Name = "dgvMedicos";
            this.dgvMedicos.ReadOnly = true;
            this.dgvMedicos.RowHeadersWidth = 62;
            this.dgvMedicos.RowTemplate.Height = 28;
            this.dgvMedicos.Size = new System.Drawing.Size(544, 339);
            this.dgvMedicos.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Matricula";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // FrmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 450);
            this.Controls.Add(this.dgvMedicos);
            this.Controls.Add(this.lstEspecialidades);
            this.Controls.Add(this.lblEspecialidad);
            this.Name = "FrmConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de médicos por especialidad";
            this.Load += new System.EventHandler(this.FrmConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.ComboBox lstEspecialidades;
        private System.Windows.Forms.DataGridView dgvMedicos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}