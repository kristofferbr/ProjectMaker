using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Shift : UpperClass
    {
        private string _occupant;
        private TaskTime _time;

        public string Occpupant
        {
            get
            {
                return _occupant;
            }
            set
            {
                _occupant = value;
            }
        }

        public TaskTime Time
        {
            get
            {
                return _time;
            }
            set
            {
                _time = value;
            }
        }
    }
}
