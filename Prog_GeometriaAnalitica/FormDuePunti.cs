using System;
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
    public partial class FormDuePunti : Form
    {
        public FormDuePunti()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float _xp1 = 0;
            float _yp1 = 0;
            float.TryParse(txt_x1.Text, out _xp1);
            float.TryParse(txt_y1.Text, out _yp1);
            this.P1 = new POINT(_xp1, _yp1);

            float _xp2 = 0;
            float _yp2 = 0;
            float.TryParse(txt_x2.Text, out _xp2);
            float.TryParse(txt_y2.Text, out _yp2);
            this.P2 = new POINT(_xp2, _yp2);

            this.Close();
        }

        //public decimal xP1 { get; set; }
        //public decimal yP1 { get; set; }
        //public decimal xP2 { get; set; }
        //public decimal yP2 { get; set; }

        public POINT P1 { get; set; }

        public POINT P2 { get; set; }

    }
}
