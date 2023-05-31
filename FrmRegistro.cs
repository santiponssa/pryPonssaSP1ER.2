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
            StreamWriter sw = new StreamWriter("Especialidades.txt", true);
            ClsEspecialidades especialidad = new ClsEspecialidades();
            especialidad.NumeroEsp = int.Parse(txtNumeroEsp.Text);
            especialidad.Nombre = txtNombreEsp.Text;
            sw.WriteLine(especialidad.NumeroEsp + "," + especialidad.Nombre);
            sw.Close();
            sw.Dispose();
        }
        public void RegistrarMedico()
        {
            StreamWriter sw = new StreamWriter("Medicos.txt", true);
            ClsMedicos medico = new ClsMedicos();
            medico.Matricula = int.Parse(txtMatricula.Text);
            medico.Nombre = txtNombreMed.Text;
            medico.NumeroEsp = int.Parse(txtCodEspMed.Text);
            sw.WriteLine(medico.Matricula + "," + medico.Nombre + "," + medico.NumeroEsp);
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
                MessageBox.Show("Médico registrado");
                txtNombreMed.Text = "";
                txtMatricula.Text = "";
                txtCodEspMed.Text = "";
                txtMatricula.Focus();
            }
            else
            {
                MessageBox.Show("Datos incorrectos", "Error");
            }
        }

        private void txtNombreMed_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreMed_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo se pueden ingresar letras
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (int)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo se pueden ingresar numeros
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != (int)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtCodEspMed_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo se pueden ingresar numeros
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != (int)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtNombreEsp_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo se pueden ingresar letras
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (int)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtNumeroEsp_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo se pueden ingresar numeros
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != (int)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {

        }
    }
}
