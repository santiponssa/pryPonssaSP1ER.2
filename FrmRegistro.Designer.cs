namespace pryPonssaSP1ER._2
{
    partial class FrmRegistro
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNumeroEsp = new System.Windows.Forms.Label();
            this.lblNombreEsp = new System.Windows.Forms.Label();
            this.txtNombreEsp = new System.Windows.Forms.TextBox();
            this.txtNumeroEsp = new System.Windows.Forms.TextBox();
            this.btnRegistrarEsp = new System.Windows.Forms.Button();
            this.mrcEspecialidades = new System.Windows.Forms.GroupBox();
            this.mrcMedicos = new System.Windows.Forms.GroupBox();
            this.btnRegistrarMed = new System.Windows.Forms.Button();
            this.lblEspMedico = new System.Windows.Forms.Label();
            this.txtCodEspMed = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblNombreMed = new System.Windows.Forms.Label();
            this.txtNombreMed = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.mrcEspecialidades.SuspendLayout();
            this.mrcMedicos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumeroEsp
            // 
            this.lblNumeroEsp.AutoSize = true;
            this.lblNumeroEsp.Location = new System.Drawing.Point(17, 27);
            this.lblNumeroEsp.Name = "lblNumeroEsp";
            this.lblNumeroEsp.Size = new System.Drawing.Size(44, 13);
            this.lblNumeroEsp.TabIndex = 0;
            this.lblNumeroEsp.Text = "Número";
            this.lblNumeroEsp.Click += new System.EventHandler(this.lblCodigo_Click);
            // 
            // lblNombreEsp
            // 
            this.lblNombreEsp.AutoSize = true;
            this.lblNombreEsp.Location = new System.Drawing.Point(17, 62);
            this.lblNombreEsp.Name = "lblNombreEsp";
            this.lblNombreEsp.Size = new System.Drawing.Size(44, 13);
            this.lblNombreEsp.TabIndex = 1;
            this.lblNombreEsp.Text = "Nombre";
            // 
            // txtNombreEsp
            // 
            this.txtNombreEsp.Location = new System.Drawing.Point(68, 60);
            this.txtNombreEsp.Name = "txtNombreEsp";
            this.txtNombreEsp.Size = new System.Drawing.Size(100, 20);
            this.txtNombreEsp.TabIndex = 3;
            this.txtNombreEsp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreEsp_KeyPress);
            // 
            // txtNumeroEsp
            // 
            this.txtNumeroEsp.Location = new System.Drawing.Point(68, 25);
            this.txtNumeroEsp.Name = "txtNumeroEsp";
            this.txtNumeroEsp.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroEsp.TabIndex = 4;
            this.txtNumeroEsp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroEsp_KeyPress);
            // 
            // btnRegistrarEsp
            // 
            this.btnRegistrarEsp.Location = new System.Drawing.Point(55, 105);
            this.btnRegistrarEsp.Name = "btnRegistrarEsp";
            this.btnRegistrarEsp.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarEsp.TabIndex = 7;
            this.btnRegistrarEsp.Text = "Registrar";
            this.btnRegistrarEsp.UseVisualStyleBackColor = true;
            this.btnRegistrarEsp.Click += new System.EventHandler(this.btnRegistrarEsp_Click);
            // 
            // mrcEspecialidades
            // 
            this.mrcEspecialidades.Controls.Add(this.txtNumeroEsp);
            this.mrcEspecialidades.Controls.Add(this.lblNumeroEsp);
            this.mrcEspecialidades.Controls.Add(this.btnRegistrarEsp);
            this.mrcEspecialidades.Controls.Add(this.lblNombreEsp);
            this.mrcEspecialidades.Controls.Add(this.txtNombreEsp);
            this.mrcEspecialidades.Location = new System.Drawing.Point(8, 8);
            this.mrcEspecialidades.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mrcEspecialidades.Name = "mrcEspecialidades";
            this.mrcEspecialidades.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mrcEspecialidades.Size = new System.Drawing.Size(189, 165);
            this.mrcEspecialidades.TabIndex = 9;
            this.mrcEspecialidades.TabStop = false;
            this.mrcEspecialidades.Text = "Especialidades";
            // 
            // mrcMedicos
            // 
            this.mrcMedicos.Controls.Add(this.btnRegistrarMed);
            this.mrcMedicos.Controls.Add(this.lblEspMedico);
            this.mrcMedicos.Controls.Add(this.txtCodEspMed);
            this.mrcMedicos.Controls.Add(this.txtMatricula);
            this.mrcMedicos.Controls.Add(this.lblMatricula);
            this.mrcMedicos.Controls.Add(this.lblNombreMed);
            this.mrcMedicos.Controls.Add(this.txtNombreMed);
            this.mrcMedicos.Location = new System.Drawing.Point(215, 8);
            this.mrcMedicos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mrcMedicos.Name = "mrcMedicos";
            this.mrcMedicos.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mrcMedicos.Size = new System.Drawing.Size(227, 165);
            this.mrcMedicos.TabIndex = 10;
            this.mrcMedicos.TabStop = false;
            this.mrcMedicos.Text = "Médicos";
            // 
            // btnRegistrarMed
            // 
            this.btnRegistrarMed.Location = new System.Drawing.Point(71, 129);
            this.btnRegistrarMed.Name = "btnRegistrarMed";
            this.btnRegistrarMed.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarMed.TabIndex = 11;
            this.btnRegistrarMed.Text = "Registrar";
            this.btnRegistrarMed.UseVisualStyleBackColor = true;
            this.btnRegistrarMed.Click += new System.EventHandler(this.btnRegistrarMed_Click);
            // 
            // lblEspMedico
            // 
            this.lblEspMedico.AutoSize = true;
            this.lblEspMedico.Location = new System.Drawing.Point(17, 96);
            this.lblEspMedico.Name = "lblEspMedico";
            this.lblEspMedico.Size = new System.Drawing.Size(92, 13);
            this.lblEspMedico.TabIndex = 9;
            this.lblEspMedico.Text = "Cód. Especialidad";
            // 
            // txtCodEspMed
            // 
            this.txtCodEspMed.Location = new System.Drawing.Point(112, 94);
            this.txtCodEspMed.Name = "txtCodEspMed";
            this.txtCodEspMed.Size = new System.Drawing.Size(100, 20);
            this.txtCodEspMed.TabIndex = 10;
            this.txtCodEspMed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodEspMed_KeyPress);
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(112, 25);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtMatricula.TabIndex = 4;
            this.txtMatricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatricula_KeyPress);
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(17, 27);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(52, 13);
            this.lblMatricula.TabIndex = 0;
            this.lblMatricula.Text = "Matrícula";
            // 
            // lblNombreMed
            // 
            this.lblNombreMed.AutoSize = true;
            this.lblNombreMed.Location = new System.Drawing.Point(17, 62);
            this.lblNombreMed.Name = "lblNombreMed";
            this.lblNombreMed.Size = new System.Drawing.Size(44, 13);
            this.lblNombreMed.TabIndex = 1;
            this.lblNombreMed.Text = "Nombre";
            // 
            // txtNombreMed
            // 
            this.txtNombreMed.Location = new System.Drawing.Point(112, 60);
            this.txtNombreMed.Name = "txtNombreMed";
            this.txtNombreMed.Size = new System.Drawing.Size(100, 20);
            this.txtNombreMed.TabIndex = 3;
            this.txtNombreMed.TextChanged += new System.EventHandler(this.txtNombreMed_TextChanged);
            this.txtNombreMed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreMed_KeyPress);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(144, 184);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(124, 42);
            this.btnConsultar.TabIndex = 11;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 237);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.mrcMedicos);
            this.Controls.Add(this.mrcEspecialidades);
            this.Name = "FrmRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de especialidades y médicos";
            this.Load += new System.EventHandler(this.FrmRegistro_Load);
            this.mrcEspecialidades.ResumeLayout(false);
            this.mrcEspecialidades.PerformLayout();
            this.mrcMedicos.ResumeLayout(false);
            this.mrcMedicos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNumeroEsp;
        private System.Windows.Forms.Label lblNombreEsp;
        private System.Windows.Forms.TextBox txtNombreEsp;
        private System.Windows.Forms.TextBox txtNumeroEsp;
        private System.Windows.Forms.Button btnRegistrarEsp;
        private System.Windows.Forms.GroupBox mrcEspecialidades;
        private System.Windows.Forms.GroupBox mrcMedicos;
        private System.Windows.Forms.Label lblEspMedico;
        private System.Windows.Forms.TextBox txtCodEspMed;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblNombreMed;
        private System.Windows.Forms.TextBox txtNombreMed;
        private System.Windows.Forms.Button btnRegistrarMed;
        private System.Windows.Forms.Button btnConsultar;
    }
}

