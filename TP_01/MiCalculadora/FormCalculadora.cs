using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            this.boxOperando1.Text = "";
            this.boxOperando2.Text = "";
            this.comboOperador.Text = "";
            this.lblResultado.Text = "";
        }

        private void btnCerrar_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private static double Operar(string n1, string n2, string operador)
        {
            Numero operando1 = new Numero(n1);
            Numero operando2 = new Numero(n2);

            return Calculadora.Operar(operando1, operando2, operador);
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = FormCalculadora.Operar(this.boxOperando1.Text, this.boxOperando2.Text, this.comboOperador.Text).ToString();
        }

        private void btnDecimalABinario_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = Numero.DecimalBinario(this.lblResultado.Text);
        }

        private void btnBinarioADecimal_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = Numero.BinarioDecimal(this.lblResultado.Text);
        }
    }
}
