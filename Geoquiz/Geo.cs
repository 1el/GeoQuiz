using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geoquiz
{
    public class Geo
    {
        public int id
        {
            get;
            set;
        }
        public string country
        {
            get;
            set;
        }
        public string capital
        {
            get;
            set;
        }
        public string flag
        {
            get;
            set;
        }

        public Geo(int id, string country, string capital, string flag)
        {
            this.id = id;
            this.country = country;
            this.capital = capital;
            this.flag = flag;
        }
    }
}
