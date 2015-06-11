using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMaker
{
    [Serializable]
    class Tasks : UpperClass
    {

        private TaskTime _taskTime = new TaskTime();
        private LinkedList<Worker> _occupants = new LinkedList<Worker>();
        private string _name;
        private int _participants;


        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public TaskTime TaskTime
        {
            get
            {
                return _taskTime;
            }
            set
            {
                _taskTime = value;
            }
        }
        public int Participants
        {
            get
            {
                return _participants;
            }
            set
            {
                _participants = value;
            }
        }
    }
}
