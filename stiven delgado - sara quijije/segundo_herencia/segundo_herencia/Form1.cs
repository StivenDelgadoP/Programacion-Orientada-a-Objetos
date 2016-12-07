using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace segundo_herencia
{
    public partial class Form1 : Form
    {
         CLIENTE obj = new CLIENTE ();
         PRODUCTO objq = new PRODUCTO();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            obj.EncargoId= Convert.ToInt32(this.txtencargoID.Text);
            obj.Fecha = (this.txtfecha.Text);
            obj.Valor = Convert.ToInt32(this.txtvalor.Text);

            
            objq.consulta_producto1 = (this.txtidproducto.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(obj.EncargoId.ToString() + " " + obj.Fecha.ToString() +" "+ obj.Valor.ToString() );
        }
    }
}
