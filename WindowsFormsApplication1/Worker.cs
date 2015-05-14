using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    [Serializable]
    class Worker : UpperClass
    {

        
        private LinkedList<Tasks> _myTasks = new LinkedList<Tasks>();
        private LinkedList<TaskTime> _occTime = new LinkedList<TaskTime>();
        private string _name;


        public LinkedList<TaskTime> WorkTime = new LinkedList<TaskTime>();

        /*Constructur*/
        public Worker(string name)
        {
            _name = name;
        }

        /*Get setters and functions*/
        public string Name
        {
            get
            {
                return _name;
            }
        }

        public LinkedList<TaskTime> OccupationTime
        {
            get
            {
                return _occTime;
            }
            set
            {
                _occTime = value;
            }
        }

        public void setWorkTime(TaskTime time)
        {
            WorkTime.AddLast(time);
        }

        public void setTask(Tasks task)
        {
            _myTasks.AddLast(task);
        }
        public LinkedList<Tasks> GetTaskList()
        {
            return _myTasks;
        }
    
   



    }
}
