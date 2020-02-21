using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EloadasProject01
{
    public class Eloadas
    {
        private bool[,] foglalasok;

        public Eloadas(int sorokSzama, int helyekSzama)
        {
            if (sorokSzama < 1 || helyekSzama < 1)
            {
                throw new ArgumentException("Hibás paraméter, a sorok és a helyek száma legalább 1 kell, hogy legyen.");
            }
            foglalasok = new bool[sorokSzama, helyekSzama];
        }

        public bool Lefoglal()
        {
            for (int i = 0; i < foglalasok.GetLength(0); i++)
            {
                for (int j = 0; j < foglalasok.GetLength(1); j++)
                {
                    if (foglalasok[i, j] == false)
                    {
                        foglalasok[i, j] = true;
                        return true;
                    }
                }
            }
            return false;
        }

        public int GetSzabadHelyek()
        {
            int seged = 0;
            for (int i = 0; i < foglalasok.GetLength(0); i++)
            {
                for (int j = 0; j < foglalasok.GetLength(1); j++)
                {
                    if (foglalasok[i, j] == false)
                    {
                        seged++;
                    }
                }
            }
            return seged;
        }

        public bool Teli()
        {
            int seged = 0;
            for (int i = 0; i < foglalasok.GetLength(0); i++)
            {
                for (int j = 0; j < foglalasok.GetLength(1); j++)
                {
                    if (foglalasok[i, j] == false)
                    {
                        seged++;
                    }
                }
            }
            if (seged == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Foglalt(int sor, int szek)
        {
            if (foglalasok[sor, szek] == true)
            {
                return false;
            }
            return true;
        }
    }
}
