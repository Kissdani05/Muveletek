using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Kifejezes
    {

        int szam1;
        string muvelet;
        int szam2;


            public Kifejezes(string sor)
            {
                string[] darabok = sor.Split(" ");
                this.szam1 = Convert.ToInt32(darabok[0]);
                this.muvelet = darabok[1];
                this.szam2 = Convert.ToInt32(darabok[2]);
            }

        public int Szam1 { get => szam1; }
        public string Muvelet { get => muvelet;  }
        public int Szam2 { get => szam2;  }
    }
    }

