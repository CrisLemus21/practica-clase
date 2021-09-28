using clase102.Entidades;
using clase102.Negocio;
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
    public partial class sumar : Form
    {
        public sumar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                operacion Nop = new operacion();
                Nop.Dato1 = double.Parse(textBox1.Text);
                Nop.Dato2 = double.Parse(textBox2.Text);

                ClsOperaciones op = new ClsOperaciones();
                label4.Text = op.suma(Nop).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error 01: No ha llenado todos los datos");
            }
        }
    }
}
