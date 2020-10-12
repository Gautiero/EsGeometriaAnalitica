using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_GeometriaAnalitica
{
    public struct POINT
    {
        public float x { get; }            //Ascissa
        public float y { get; }            //Ordinata

        public POINT(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
    }
    struct CIRCLE
    {
        POINT centro;
        double raggio;
    }

    struct LINE
    {
        double m;            //Coefficiente angolare
        double Intercetta;   //Intersezione con asse delle ordinate
    }
}
