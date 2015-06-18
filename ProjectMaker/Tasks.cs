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
        private string _taskLocation;
        private string _description;
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
        public string TaskLocation
        {
            get
            {
                return _taskLocation;
            }
            set
            {
                _taskLocation = value;
            }
        }
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }
        public TaskTime taskTime
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
