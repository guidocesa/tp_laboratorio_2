using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventana_Produccion
{
    public partial class RequestForm : Form
    {
        List<CarPart> carParts;

        /// <summary>
        /// Sets the displayed table
        /// </summary>
        /// <param name="carParts"></param>
        public RequestForm(List<CarPart> carParts)
        {
            InitializeComponent();
            this.carParts = carParts;
            List<string> aux = new List<string>();

            foreach (CarPart item in this.carParts)
            {
                for(int i = 0; i < 100; i++)
                {
                    aux.Add((i + 1).ToString());
                }

                this.dataGrid_PartsTable.Rows.Add(item.Id, item.CheckStock());
            }

            ((DataGridViewComboBoxColumn)this.dataGrid_PartsTable.Columns[2]).DataSource = aux;
        }

        /// <summary>
        /// Reads the selected numbers from the table. Checks if they are correct and if so, generates the new request.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_MakeRequest_Click(object sender, EventArgs e)
        {
            try
            {
                List<CarPart> newRequest = new List<CarPart>();
                int i = 1;

                foreach (DataGridViewRow item in this.dataGrid_PartsTable.Rows)
                {
                    if(i == this.dataGrid_PartsTable.Rows.Count)
                    {
                        break;
                        //No pude encontrar una solucion a que no tome la ultima fila vacia, la cual no puede ser borrada tampoco.
                        //La mejor solucion seria implementar un for en vez de foreach pero me parecia mas complicado.
                    }
                    if( Convert.ToInt32(item.Cells[2].Value) > Convert.ToInt32(item.Cells[1].Value))
                    {
                        throw new Exception("You are requesting more than available. Please correct the values.");
                    }
                    else
                    {
                        if(Convert.ToInt32(item.Cells[2].Value) > 0)
                        {
                            newRequest.Add(carParts.Find(x => x.Id == (string) item.Cells[0].Value).GetCopy());
                            newRequest.Last().Stock = Convert.ToInt32(item.Cells[2].Value);
                        }
                    }

                    i++;
                }

                if(newRequest.Count > 0)
                {
                    Warehouse.Get_Warehouse().ReceiveRequest(newRequest);

                    this.DialogResult = DialogResult.Yes;
                }

                this.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        /// <summary>
        /// Closes the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
