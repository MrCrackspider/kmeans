using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kmeans
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Graphics g;
        Points pts;

        private void bt_draw_Click(object sender, EventArgs e)
        {
            pts = new Points(pb);
            pb.Image = new Bitmap(pb.Width, pb.Height);
            g = Graphics.FromImage(pb.Image);
            DrawAll();

        }

        private void DrawAll()
        {
            g.Clear(Color.White);
            pts.draw(g);
            pb.Refresh();
        }

        private void bt_init_Click(object sender, EventArgs e)
        {
            pts.initKMeans((int)nud_clasters.Value, pb);
            DrawAll();
        }

        private void bt_step_Click(object sender, EventArgs e)
        {
            pts.FindNearestCenters();
            DrawAll();
        }
    }
}
