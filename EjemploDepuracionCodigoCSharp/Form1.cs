using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploDepuracionCodigoCSharp
{
    public partial class Form1 : Form
    {
        FuncionesRelleno funcionesRelleno = new FuncionesRelleno();
        FuncionesFibonacci funcionesFibonacci = new FuncionesFibonacci();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnrellenar_Click(object sender, EventArgs e)

      
         {
            lbvalores.Items.Clear();
            lvnumeros.Clear();
          funcionesRelleno.setNumero(int.Parse(txtnumero.Text));

            for (int i = 0; i < int.Parse(txtnumero.Text); i++)
            {
                lvnumeros.Items.Add(funcionesRelleno.rellenar()[i].ToString());
            }



            foreach (int valores in funcionesRelleno.rellenar())
            {

                lbvalores.Items.Add(valores.ToString());
                txtnumero.Text = "";
                txtnumero.Focus();
            }

        }

        private void btnfibonacci_Click(object sender, EventArgs e)
        {
            funcionesFibonacci.setNumero(int.Parse(txtnumero.Text));
            lbvalores.Items.Clear();
            lvnumeros.Clear();


            foreach (int valores in funcionesFibonacci.fibonacci())
            
            {
                lvnumeros.Items.Add(valores.ToString());
                lbvalores.Items.Add(valores.ToString());
            }
        }
    }
}
