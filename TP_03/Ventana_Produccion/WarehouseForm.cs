using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventana_Produccion
{
    public partial class WarehouseForm : Form
    {
        private Warehouse warehouse;

        public WarehouseForm()
        {
            this.warehouse = Warehouse.Get_Warehouse();
            InitializeComponent();
            cmb_Type_Bolt.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Type_Bolt.DataSource = new List<Bolt.HeadType>() { Bolt.HeadType.HEX, Bolt.HeadType.ALEM };
        }

        private void btn_MakeRequest_Click(object sender, EventArgs e)
        {
            List<CarPart> newRequest = new List<CarPart>();
            this.CheckBolts(newRequest);
            this.CheckNuts(newRequest);
            this.CheckAxles(newRequest);
            this.CheckCogs(newRequest);
            this.CheckBBs(newRequest);

            try
            {
                this.warehouse.ReceiveRequest(newRequest);
                this.UpdateTable();
                MessageBox.Show("Request saved succesfully!");
                this.ClearBoxes();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void ClearBoxes()
        {
            this.num_Qua_Axle.Value = 0;
            this.num_Qua_BB.Value = 0;
            this.num_Qua_Bolt.Value = 0;
            this.num_Qua_Nut.Value = 0;
            this.num_Qua_Cogs.Value = 0;

            this.num_Teeth_Cogs.Value = 0;

            this.txt_Diameter_Axle.Text = "";
            this.txt_Diameter_Nut.Text = "";
            this.txt_Diameter_BB.Text = "";
            this.txt_Diameter_Bolt.Text = "";

            this.txt_Length_Axle.Text = "";
            this.txt_Length_Bolt.Text = "";

        }

        private void CheckBBs(List<CarPart> l)
        {
            if(this.num_Qua_BB.Value > 0)
            {
                float.TryParse(this.txt_Diameter_BB.Text, out float diameter);

                if(diameter > 0)
                {
                    l.Add(new BallBearing(diameter, (int) this.num_Qua_BB.Value));
                }
            }
        }

        private void CheckAxles(List<CarPart> l)
        {
            if(this.num_Qua_Axle.Value > 0)
            {
                float.TryParse(this.txt_Diameter_Axle.Text, out float diameter);
                float.TryParse(this.txt_Length_Axle.Text, out float length);

                if(length != 0 && diameter != 0)
                {
                    l.Add(new Axle(length, diameter, (int) this.num_Qua_Axle.Value));
                }
            }
        }

        private void CheckCogs(List<CarPart> l)
        {
            if (this.num_Qua_Cogs.Value > 0 && this.num_Teeth_Cogs.Value > 5)
            {
                l.Add(new Cog((int) this.num_Teeth_Cogs.Value, (int) this.num_Qua_Cogs.Value));
            }
        }

        private void CheckNuts(List<CarPart> l)
        {
            if (this.num_Qua_Nut.Value > 0)
            {
                if (float.TryParse(this.txt_Diameter_Nut.Text, out float diameter))
                {
                    l.Add(new Nut(diameter, (int)this.num_Qua_Nut.Value));
                }
            }
        }

        private void CheckBolts(List<CarPart> l)
        {
            if (this.num_Qua_Bolt.Value > 0)
            {
                float.TryParse(this.txt_Diameter_Bolt.Text, out float diameter);
                float.TryParse(this.txt_Length_Bolt.Text, out float length);

                if (length != 0 && diameter != 0)
                {
                    l.Add(new Bolt(diameter, length, (Bolt.HeadType) this.cmb_Type_Bolt.SelectedItem , (int)this.num_Qua_Bolt.Value));
                }
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            List<CarPart> newParts = new List<CarPart>();

            this.CheckBolts(newParts);
            this.CheckNuts(newParts);
            this.CheckAxles(newParts);
            this.CheckCogs(newParts);
            this.CheckBBs(newParts);

            this.warehouse.AddParts(newParts);

            this.UpdateTable();
            this.ClearBoxes();
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
    }
}
