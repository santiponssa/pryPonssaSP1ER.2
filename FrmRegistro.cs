using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPonssaSP1ER._2
{
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void lblCodigo_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Hide();
            FrmConsulta frm = new FrmConsulta();
            frm.Show();
        }
        public bool VerificarDatosEsp()
        {
            bool resultado;
            resultado = false;
            if (txtNumeroEsp.Text != "")
                if (txtNombreEsp.Text != "")
                {
                    resultado = true;
                }
            return resultado;
        }
        public bool VerificarDatosMed()
        {
            bool resultado;
            resultado = false;
            if (txtMatricula.Text != "")
                if (txtNombreMed.Text != "")
                    if (txtCodEspMed.Text != "")
                    {
                        resultado = true;
                    }
            return resultado;
        }

        public void RegistrarEspecialidad()
        {
            StreamWriter sw = new StreamWriter("EspecialidadesMedicos.txt");
            ClsEspecialidades especialidad = new ClsEspecialidades();
            especialidad.NumeroEsp = int.Parse(txtNumeroEsp.Text);
            especialidad.Nombre = txtNombreEsp.Text;
            sw.WriteLine();
            sw.Close();
            sw.Dispose();
        }
        public void RegistrarMedico()
        {
            StreamWriter sw = new StreamWriter("EspecialidadesMedicos.txt");
            ClsMedicos medico = new ClsMedicos();
            medico.Matricula = int.Parse(txtMatricula.Text);
            medico.Nombre = txtNombreMed.Text;
            medico.NumeroEsp = int.Parse(txtCodEspMed.Text);
            sw.Close();
            sw.Dispose();
        }
        private void btnRegistrarEsp_Click(object sender, EventArgs e)
        {
            if (VerificarDatosEsp()) 
            {
                RegistrarEspecialidad();
                MessageBox.Show("Especialidad registrada");
                txtNumeroEsp.Text = "";
                txtNombreEsp.Text = "";
                txtNumeroEsp.Focus();
            }
            else
            {
                MessageBox.Show("Datos incorrectos", "Error");
            }
        }

        private void btnRegistrarMed_Click(object sender, EventArgs e)
        {
            if (VerificarDatosMed())
            {
                RegistrarMedico();
            }
            else
            {
                MessageBox.Show("Datos incorrectos", "Error");
            }
        }
    }
}
