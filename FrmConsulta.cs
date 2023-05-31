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
    public partial class FrmConsulta : Form
    {
        public FrmConsulta()
        {
            InitializeComponent();
        }

        private void lstEspecialidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            string codEsp;
            string lineaEsp;
            StreamReader srEsp = new StreamReader("Especialidades.txt");
            StreamReader srMed = new StreamReader("Medicos.txt");

            while (srEsp.EndOfStream == false)
            {
                lineaEsp = srEsp.ReadLine();
                codEsp = lineaEsp.Split(',')[0];
                if (lstEspecialidades.SelectedItem == codEsp)
                {

                    dgvMedicos.Rows.Add();
                }
            }
            srEsp.Close();
            srEsp.Dispose();
            //string linea;
            //int codEsp;
            //int codEspMed;
            //while (lstEspecialidades.SelectedItem != )
            //{

            //StreamReader srEsp = new StreamReader("Especialidades.txt");
            //linea = srEsp.ReadLine();
            //StreamReader srMed = new StreamReader("Medicos.txt");
            //srMed.ReadLine();

            //srEsp.Close();
            //srMed.Close();
            //srEsp.Dispose();
            //srMed.Dispose();
            //}
        }

        private void FrmConsulta_Load(object sender, EventArgs e)
        {
            string especialidad;
            string linea;
            StreamReader sr = new StreamReader("Especialidades.txt");
            while (sr.EndOfStream == false)
            {
                linea = sr.ReadLine();
                especialidad = linea.Split(',')[1];
                lstEspecialidades.Items.Add(especialidad);
            }
            sr.Close();
            sr.Dispose();
        }

    }
}
