using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication9
{
    class Class_Izd
    {
        private string name;
        private int id;
        private int god;
        public Class_Izd(string name, int id, int god)
        {
            this.name = name;
            this.id = id;
            this.god = god;
        }
        public Class_Izd()
        {
            name = "Ящик";
            id = 0;
            god = 1991;
        }
        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public int GetId()
        {
            return id;
        }
        public void SetId(int id)
        {
            this.id = id;
        }
        public int GetGod()
        {
            return god;
        }
        public void SetGod(int god)
        {
            this.god = god;
        }
    }
    class Strana : Class_Izd
    {
        string strana;
        public Strana(string strana, string name, int id, int god) 
        : base(name, id, god)
        {
            this.strana = strana;
        }
        public Strana()
        {
            strana = "Unknow";
        }
        public string GetStrana()
        {
            return strana;
        }
        public void SetStrana(string strana)
        {
            this.strana = strana;
        }
    }
    class Eks : Class_Izd
    {
        int kol;
        public Eks(int kol, string name, int id, int god)
        : base(name, id, god)
        {
            this.kol = kol;
        }
        public Eks()
        {
            kol = 0;
        }
        public int GetKol()
        {
            return kol;
        }
        public void SetKol(int kol)
        {
            this.kol = kol;
        }
    }
    class Tema : Class_Izd
    {
        string tema;
        public Tema(string tema, string name, int id, int god)
        : base(name, id, god)
        {
            this.tema = tema;
        }
        public Tema()
        {
            tema = "Unknow";
        }
        public string GetTema()
        {
            return tema;
        }
        public void SetTema(string tema)
        {
            this.tema = tema;
        }
    }
}
