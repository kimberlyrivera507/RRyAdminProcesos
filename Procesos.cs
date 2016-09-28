using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Round_Robin
{
    class Procesos
    {
        public string GenerarColores(Random rnd)
        {
            string Color = "";
            if (rnd.Next(0, 9) == 0)
            {
                Color = "red";
            }
            else if (rnd.Next(0, 9) == 1)
            {
                Color = "blue";
            }
            else if (rnd.Next(0, 9) == 2)
            {
                Color = "teal";
            }
            else if (rnd.Next(0, 9) == 3)
            {
                Color = "orange";
            }
            else if (rnd.Next(0, 9) == 4)
            {
                Color = "violet";
            }
            else if (rnd.Next(0, 9) == 5)
            {
                Color = "olive";
            }
            else if (rnd.Next(0, 9) == 6)
            {
                Color = "seagreen";
            }
            else if (rnd.Next(0, 9) == 7)
            {
                Color = "gray";
            }
            else if (rnd.Next(0, 9) == 8)
            {
                Color = "green";
            }
            else 
            {
                Color = "cyan";
            }
            return Color;
        }


    }
}
