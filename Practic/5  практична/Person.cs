using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic._5__практична
{
    public class Person : IComparable
    {
        string pib;
        string posada;
        double zarplata;
        double stage;

        public Person(string PIB, string posada, double zarplata, double stage)
        {
            this.pib = PIB;
            this.posada = posada;
            Zarplata = zarplata;
            this.stage = stage;
        }

        public Person()
        {
            var r = new Random();
            this.pib = "Денис";
            this.posada = "програміст";
            this.zarplata = r.Next(100, 3000);
            this.stage = r.Next(0, 10);
        }

        public string PIB { get { return this.pib; } set { this.pib = value; } }

        public string Posada { get { return this.posada; } set { this.posada = value; } }

        public double Zarplata { get { return zarplata; } 
            set
            {
                if(value >= 0)
                {
                    zarplata = value;
                }
                else throw new Exception("Зарплата не може бути від'ємною");
            } 
        }

        public double Stage { get { return stage; }
            set
            {
                if (value >= 0)
                {
                    stage = value;
                }
                else throw new Exception("Стаж не може бути від'ємним");
            }
        }

        public int CompareTo(object obj)
        {
            Person? p = obj as Person;
            if (p != null)
            {
                return this.zarplata.CompareTo(p.zarplata);
            }
            else
            {
                throw new Exception("Неможливо порівняти два об'єкти");
            }
        }
    }
}
