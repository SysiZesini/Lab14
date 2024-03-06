using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    class ToDo
    {
        private string Name;
        private string DateDo;
        private string Discr;
        private bool Doing;
        public ToDo(string name, string dateDo, string discr, bool doing)
        {
            Name = name;
            DateDo = dateDo;
            Discr = discr;
            Doing = doing;
        }
        public string NameS
        {
            get { return Name; }
            set { Name = value; }
        }
        public string DateDoS
        {
            get { return DateDo; }
            set { DateDo = value; }
        }
        public string DiscrS
        {
            get { return Discr; }
            set { Discr = value; }
        }        
        public bool DoingS
        {
            get { return Doing; }
            set { Doing = value; }
        }

        static public List<ToDo> strList = new List<ToDo>();

    }
}
