using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMaker
{
    class Event
    {
        private List<Worker> _workerList = new List<Worker>();
        private List<Tasks> _taskList = new List<Tasks>();
        private List<EventDay> _eventHorizont = new List<EventDay>();
        private string _eventName;

        Event(string eventName)
        {
            this._eventName = eventName;
        }

        Event(string eventName, List<EventDay> eventHorizont)
        : this(eventName)
        {
            this._eventHorizont = eventHorizont;
        }

        public string eventName
        {
            get { return this._eventName; }
        }

        public List<EventDay> eventHorizont
        {
            get { return this._eventHorizont; }
        }

        public Boolean addEventDay(EventDay dayToAdd)
        {
            if (!_eventHorizont.Contains(dayToAdd))
            {
                _eventHorizont.Add(dayToAdd);
                return true;
            }

            return false;
        }

        public List<Worker> workerList
        {
            get { return this._workerList; }
        }

        public Boolean addWorker(Worker workerToAdd)
        {
            if (!_workerList.Contains(workerToAdd))
            {
                _workerList.Add(workerToAdd);
                return true;
            }

            return false;
        }

        public List<Tasks> taskList
        {
            get { return this._taskList; }
        }

        public Boolean addTask(Tasks taskToAdd)
        {
            if (!_taskList.Contains(taskToAdd))
            {
                _taskList.Add(taskToAdd);
                return true;
            }

            return false;
        }
    }
}
