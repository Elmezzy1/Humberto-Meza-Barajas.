using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados_nuevos
{
    class Empleado
    {
        private string nombre, puesto, lvl, dias, hrs;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Puesto
        {
            get { return puesto; }
            set { puesto = value; }
        }
        public string Lvl
        {
            get { return lvl; }
            set { lvl = value; }
        }
        public string Dias
        {
            get { return dias; }
            set { dias = value; }
        }
        public string Hrs
        {
            get { return hrs; }
            set { hrs = value; }
        }


    }
}
