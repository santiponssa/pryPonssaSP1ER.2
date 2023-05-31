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
            string nombreEsp;
            string lineaEsp;
            StreamReader srEsp = new StreamReader("Especialidades.txt");
            lineaEsp = srEsp.ReadLine();
            nombreEsp = lineaEsp.Split(',')[1];
            while (lstEspecialidades.Text != nombreEsp)
            {
                srEsp.ReadLine();
            }
            while (lstEspecialidades.Text == nombreEsp)
            {
                string codEsp;
                codEsp = lineaEsp.Split(',')[0];
                string codMed;
                string lineaMed;
                StreamReader srMed = new StreamReader("Medicos.txt");
                lineaMed = srMed.ReadLine();
                codMed = lineaMed.Split(',')[2];
                if (codEsp == codMed)
                {
                    dgvMedicos.Rows.Add(lineaMed.Split(',')[0], lineaMed.Split(',')[1]);
                }
                srMed.Close();
                srMed.Dispose();
            }
            srEsp.Close();
            srEsp.Dispose();            
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
