using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_GeometriaAnalitica
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        float ox = 0;
        float oy = 0;
        int scala;

        Action toRender = null;

        Random rnd = new Random(100000);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            this.graphics = e.Graphics;
            ox = panel1.Width / 2;
            oy = panel1.Height / 2;
            scala = int.Parse(txtScala.Text);

            render();
        }

        private void render()
        {
            render_assicartesiani();
            render_scala();

            if (toRender != null)
            {
                toRender();
            }
        }

        private void render_assicartesiani()
        { 
            int w = panel1.Width;
            int h = panel1.Height;

            #region render assi
            Pen p = new Pen(Color.Black, 1);
            graphics.DrawLine(p, ox, 0, ox, h);
            graphics.DrawLine(p, 0, oy , w, oy);
            #endregion

            SolidBrush blueBrush = new SolidBrush(Color.Black);
            #region render ordinata arrow

            // Create points that define polygon.
            Point point1 = new Point((int)ox, 0);
            Point point2 = new Point((int)ox + 10, 10);
            Point point3 = new Point((int)ox - 10, 10);
            Point[] curvePoints = { point1, point2, point3 };

            graphics.FillPolygon(blueBrush, curvePoints);

            #endregion

            #region render ascissa arrow
            Point point4 = new Point(w, (int)oy);
            Point point5 = new Point(w-10, (int)oy + 10);
            Point point6 = new Point(w-10, (int)oy - 10);
            Point[] curvePoints1 = { point4, point5, point6 };

            graphics.FillPolygon(blueBrush, curvePoints1);
            #endregion
        }

        private void render_scala()
        {
            int w = panel1.Width;
            int h = panel1.Height;

            Pen p = new Pen(Color.Red, 1);

            int spessore = scala / 3;

            #region scala ascisse

            for (float x = ox; x < panel1.Width; x = x + scala)
            { 
                graphics.DrawLine(p, x, oy, x, oy + spessore);
            }

            for (float x = ox; x >0; x = x - scala)
            {
                graphics.DrawLine(p, x, oy, x, oy + spessore);
            }

            #endregion

            #region scala ordinate
            for (float y = oy; y < panel1.Height; y = y + scala)
            {
                graphics.DrawLine(p, ox- spessore, y, ox, y);
            }
            for (float y = oy; y > 0; y = y - scala)
            {
                graphics.DrawLine(p, ox - spessore, y, ox, y);
            }
            #endregion
        }

        private void test_cerchio_centrato()
        {


            //Graphics r = graphics;
            //Pen s = new Pen(Color.Orange, 5);
            //g.DrawLine(s, 10, 20, 300, 404);


            Pen p = new Pen(Color.Black, 1);
            graphics.DrawEllipse(p, ox-35, oy-35, 70, 70);
        }

        private void btn_puntoM_2p_Click(object sender, EventArgs e)
        {
            FormDuePunti f = new FormDuePunti();
            f.ShowDialog();
            //Calcolo punto medio
            float Xm = (f.P1.x + f.P2.x) / 2;
            float Ym = (f.P1.y + f.P2.y) / 2;

            txt_ris.Text = $"PM ({Xm},{Ym})";

            POINT PM = new POINT(Xm, Ym);



            toRender = delegate ()
            {
                

                var p1monitor = cartToVideo(f.P1, scala);
                var p2monitor = cartToVideo(f.P2, scala);
                var pmmonitor = cartToVideo(PM, scala);

                Pen b = new Pen(Color.Black, 5);
                Pen r = new Pen(Color.LightGreen, 5);

                float puntoW = scala / 3;
                float offset = puntoW / 2;
                graphics.DrawLine(b, p1monitor, p2monitor);
                graphics.DrawEllipse(r, pmmonitor.X-offset, pmmonitor.Y-offset, puntoW, puntoW);
                //graphics.DrawLine(s, f.P1.x, f.P1.y, f.P2.x, f.P2.y);
                //calcola il punto medio

            };

            panel1.Refresh();
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            panel1.Refresh();
        }

        private void btn_distanza_2p_Click(object sender, EventArgs e)

        {
            //Dim point1X As Double;
            //Dim point1Y As Double;
            //Dim point2X As Double;
            //Dim point2Y As Double;
            //Dim distanza As Double;

            //point1X = Convert.ToDouble(txt_x1.Text);
            //point1Y = Convert.ToDouble(txt_y1.Text);
            //point2X = Convert.ToDouble(txt_x2.Text);
            //point2Y = Convert.ToDouble(txt_y2.Text);

            //distanza = Math.Sqrt(Math.Pow(point2X - point1X, 2.0) + Math.Pow(point2Y - point1Y, 2.0));
            //txt_ris.Text = "La distanza tra (" & Convert.ToString(point1X) & " , " & Convert.ToString(point1Y) & ") e (" & Convert.ToString(point2X) & " , " & Convert.ToString(point2Y) & ") è " & distanza;
        }

        private void btn_distanzaRettaPunto_Click(object sender, EventArgs e)
        {

            
        }

        private void txtGrandezza_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_rettaPassante_2p_Click(object sender, EventArgs e)
        {

        }

        private PointF cartToVideo(POINT p, int scala)
        {
            float Xmonitor = panel1.Width / 2 + (p.x * scala);
            float Ymonitor = panel1.Height / 2 - (p.y * scala);

            PointF ret = new PointF(Xmonitor, Ymonitor);

            return ret;
        }

        private void lblAggiorna_Click(object sender, EventArgs e)
        {
            panel1.Refresh();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int val = ((TrackBar)sender).Value;

            txtScala.Text = ((val*10)+10).ToString();
            panel1.Refresh();
        }
    }

   
}
