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

        }

        private void FrmConsulta_Load(object sender, EventArgs e)
        {
            string especialidad;
            string linea;
            StreamReader sr = new StreamReader("Especialidades.txt");
            linea = sr.ReadLine();
            especialidad = linea.Split(',')[1];
            lstEspecialidades.Items.Add(especialidad);
            sr.Close();
            sr.Dispose();
        }
    }
}
