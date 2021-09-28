using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clase102.vista
{
    public partial class menuAplicacion : Form
    {
        public menuAplicacion()
        {
            InitializeComponent();
        }
        estudianteSff estud = new estudianteSff();
        private void formularioEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            estud.MdiParent = this;
            estud.Show();
        }
        sumar sum = new sumar();
        private void sumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sumar sum = new sumar();
            sum.MdiParent = this;
            sum.Show();
            

        }

        private void restaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmResta rest = new FrmResta();
            rest.MdiParent = this;
            rest.Show();
        }

        private void multiplicasionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMultiplicacion mul = new FrmMultiplicacion();
            mul.MdiParent = this;
            mul.Show();
        }

        private void divicionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDivicion divi = new FrmDivicion();
            divi.MdiParent = this;
            divi.Show();
        }
    }
}
