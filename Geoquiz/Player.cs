using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geoquiz
{
    public class Player
    {
        public int id
        {
            get;
            set;
        }
        public string pname
        {
            get;
            set;
        }
        public int highscore
        {
            get;
            set;
        }

        public Player(int id, string pname, int highscore)
        {
            this.id = id;
            this.pname = pname;
            this.highscore = highscore;
        }
    }
}
