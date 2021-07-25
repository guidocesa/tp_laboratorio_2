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

        /// <summary>
        /// Limpia los box de numeros, operador y el label de resultado.
        /// </summary>
        private void Limpiar()
        {
            this.boxOperando1.Text = "";
            this.boxOperando2.Text = "";
            this.comboOperador.Text = "";
            this.lblResultado.Text = "";
        }

        /// <summary>
        /// Cierra el form de calculadora.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        
        /// <summary>
        /// Llama a la funcion limpiar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            this.btnDecimalABinario.Enabled = false;
            this.btnBinarioADecimal.Enabled = false;
        }


        /// <summary>
        /// Recibe como parametro dos numeros y un operador y retorna el resultado como double.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param> 
        /// <param name="operador"></param>
        /// <returns></returns>
        private static double Operar(string n1, string n2, string operador)
        {
            Numero operando1 = new Numero(n1);
            Numero operando2 = new Numero(n2);

            return Calculadora.Operar(operando1, operando2, operador);
        }

        /// <summary>
        /// Llama a la funcion operar pasando los datos ingresados y luego muestra el resultado en un label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            if (this.boxOperando1.Text != "" && this.boxOperando2.Text != "" && this.comboOperador.Text != "")
            {
                this.lblResultado.Text = FormCalculadora.Operar(this.boxOperando1.Text, this.boxOperando2.Text, this.comboOperador.Text).ToString();

                this.btnDecimalABinario.Enabled = true;
                this.btnBinarioADecimal.Enabled = false;
            }
        }

        /// <summary>
        /// Convierte el resultado decimal a binario. Solo la parte entera y positiva.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDecimalABinario_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = Numero.DecimalBinario(this.lblResultado.Text);
            this.btnDecimalABinario.Enabled = false;
            this.btnBinarioADecimal.Enabled = true;
        }

        /// <summary>
        /// Convierte el resultado del label previamente convertido a binario hacia decimal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBinarioADecimal_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = Numero.BinarioDecimal(this.lblResultado.Text);
            this.btnDecimalABinario.Enabled = true;
            this.btnBinarioADecimal.Enabled = false;
        }

        /// <summary>
        /// Limpia los campos al comenzar la aplicacion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        /// <summary>
        /// Confirma la salida.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Seguro que desea salir?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
