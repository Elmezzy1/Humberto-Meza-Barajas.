using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_VG
{
    class Entidad
    {
        private int vida, mana, attk, dfns;

        private int Vida
        {
            get { return vida; }
            set
            {
                if (value >100)
                {
                    vida = 100;
                }
                else if (value <0)
                {
                    vida = 0;
                }
                else
                {
                    vida = value;
                }
            }

        }
        private int Mana
        {
            get { return mana; }
            set
            {
                if (value > 100)
                {
                    mana = 100;
                }
                else if (value < 0)
                {
                    mana = 0;
                }
                else
                {
                    mana = value;
                }
            }

        }

        private int Ataque
        {
            get { return attk; }
            set
            {
                if (value > 100)
                {
                    attk = 100;
                }
                else if (value < 0)
                {
                    attk = 0;
                }
                else
                {
                    attk = value;
                }
            }

        }
        private int Defensa
        {
            get { return dfns; }
            set
            {
                if (value > 100)
                {
                    dfns = 100;
                }
                else if (value < 0)
                {
                    dfns = 0;
                }
                else
                {
                    dfns = value;
                }
            }

        }

        public int atacar()
        {
            return 1;
        }

        public int mover()
        {
            return 1;
        }

        public int saltar()
        {
            return 1;
        }

        public int defender()
        {
            return 1;
        }
        public virtual string muerte()
        {
            return "1";
        }
    }
}
