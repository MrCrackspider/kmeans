using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace kmeans
{
    public class Pt
    {
        public float x, y; // координаты
        public int type; // цвет / тип

        public static Color[] colors = new Color[] 
            { Color.Red, Color.Green, Color.Blue,
            Color.Orange, Color.Teal, Color.Violet };

        public void draw(Graphics g)
        {
            var brush = new SolidBrush(colors[type]);
            g.FillEllipse(brush, x-2, y-2, 4, 4);
        }

        internal void drawCenter(Graphics g)
        {
            g.FillEllipse(Brushes.Black, x - 2, y - 2, 4, 4);
        }
    }

    // множество точек
    public class Points
    {
        public List<Pt> points = new List<Pt>(); // точки
        public List<Pt> centers = new List<Pt>(); // центры кластеров
        public Points(PictureBox pb)
        {
            var rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                var x = rnd.Next(pb.Width);
                var y = rnd.Next(pb.Height);
                var pt = new Pt { x = x, y = y };
                points.Add(pt);
            }
        }

        public void draw(Graphics g)
        {
            for (int i = 0; i < points.Count; i++)
            {
                points[i].draw(g);
            }
            for (int i = 0; i < centers.Count; i++)
            {
                centers[i].drawCenter(g);
            }
        }

        public void initKMeans(int num_clust, PictureBox pb) // num - число кластеров; инициализация к-средних
        {
            var rnd = new Random();
            centers.Clear();
            for (int i = 0; i < num_clust; i++)
            {
                var x = rnd.Next(pb.Width);
                var y = rnd.Next(pb.Height);
                var pt = new Pt { x = x, y = y };
                centers.Add(pt);
            }   
        }

        public int GetPointType(Pt p)
        {
            float MinDist = float.MaxValue;
            int iMin = 0;
            for (int i = 0; i < centers.Count; i++)
            {
                var dx = centers[i].x - p.x;
                var dy = centers[i].y - p.y;
                var delta = dx * dx + dy * dy;

                if (delta < MinDist)
                {
                    MinDist = delta;
                    iMin = i;
                }
            }
            return iMin;
        }

        public void FindNearestCenters()
        {
            for (int i = 0; i < points.Count; i++)
            {
                points[i].type = GetPointType(points[i]);
            }
        }

    }
}
