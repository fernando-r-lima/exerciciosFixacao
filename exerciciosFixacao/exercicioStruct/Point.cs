using System;
using System.Collections.Generic;
using System.Text;

namespace exerciciosFixacao.exercicioStruct
{
    struct Point
    {
        public double X;
        public double Y;

        public override string ToString()
        {
            return "(" + X + ", " + Y + ")";
        }
    }
}
