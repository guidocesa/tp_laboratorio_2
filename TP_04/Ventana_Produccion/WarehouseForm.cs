using Clases;
using Serializer;
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
    public partial class WarehouseForm : Form
    {
        private Warehouse warehouse;
        public delegate void Callback();
        public event Callback truckFinished;

        public WarehouseForm()
        {
            this.warehouse = Warehouse.Get_Warehouse();
            InitializeComponent();
            this.truckFinished += ChangeButtons;
        }



        private void btn_MakeRequest_Click(object sender, EventArgs e)
        {
            RequestForm reqForm = new RequestForm(this.warehouse.GetParts());

            if(reqForm.ShowDialog() == DialogResult.Yes)
            {
                Thread truckThread = new Thread(this.ShowTruck);
                truckThread.Start();
                this.btn_MakeRequest.Enabled = false;
                this.btn_MakeRequest.Text = "Request in progress!";
            }
        }

        private void ChangeButtons()
        {
            if(this.InvokeRequired)
            {
                Callback callback = new Callback(ChangeButtons);
                this.Invoke(callback);
            }
            else
            {
                this.btn_MakeRequest.Enabled = true;
                this.btn_MakeRequest.Text = "Make Request";
                MessageBox.Show("Request Finished!");
                this.UpdateTable();
            }
        }

        private void ShowTruck()
        {
            Form windowTruck = new TruckWindow();
            windowTruck.ShowDialog();
            this.truckFinished.Invoke();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

            AddInventoryForm addInv = new AddInventoryForm();

            addInv.ShowDialog();

            this.UpdateTable();
        }

        private void UpdateTable()
        {
            this.dataGrid_PartsTable.Rows.Clear();

            foreach(CarPart item in this.warehouse.GetParts())
            {
                this.dataGrid_PartsTable.Rows.Add(item.Id, item.CheckStock());
            }
        }

        private void btn_LoadWare_Click(object sender, EventArgs e)
        {
            string path = Environment.CurrentDirectory + "\\Warehouse.xml";
            try
            {
                this.warehouse.Load(path);
                this.UpdateTable();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_SaveWarehouse_Click(object sender, EventArgs e)
        {
            string path = Environment.CurrentDirectory + "\\Warehouse.xml";
            try
            {
                this.warehouse.Save(path);
                MessageBox.Show("Warehouse saved succesfully!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_LoadSQL_Click(object sender, EventArgs e)
        {
            try
            {
                this.warehouse.LoadFromDatabase();
                this.UpdateTable();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_SaveSQL_Click(object sender, EventArgs e)
        {
            try
            {
                this.warehouse.SaveToDatabase();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
