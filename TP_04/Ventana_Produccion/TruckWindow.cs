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
    public partial class TruckWindow : Form
    {
        private bool arrived;
        Point pos;
        int frameCount;
        Image truck;

        public TruckWindow()
        {
            InitializeComponent();
            this.arrived = false;
            pos = new Point(0, 0);
            frameCount = 0;
            truck = Image.FromFile("MovingTruck.png");
        }

        private void TruckWindow_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(truck, pos.X, pos.Y,new Rectangle(160 * frameCount, 0, 160 , 120), GraphicsUnit.Pixel);
            pos.X += 6;
            frameCount++;

            if (pos.X >= (this.Width - 225))
            {
                this.arrived = true;
            }
            if(frameCount == 4)
            {
                frameCount = 0;
            }
            if(arrived)
            {
                this.Close();
            }
            Thread.Sleep(50);

            this.Refresh();
        }
    }
}
