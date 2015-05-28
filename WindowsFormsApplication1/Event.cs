using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProjectMaker
{

    [Serializable()]
    class Event
    {
        private LinkedList<Worker> _workerList = new LinkedList<Worker>();
        private LinkedList<Tasks> _taskList = new LinkedList<Tasks>();
        private List<EventDay> _eventHorizont = new List<EventDay>();
        private string _eventName;
        private string _eventDescription;

        public Event(string eventName, List<EventDay> eventHorizont)
        : this(eventName)
        {
            this._eventHorizont = eventHorizont;
        }

        public Event(string eventName)
        {
            this._eventName = eventName;
        }

        public string eventDescription
        {
            get { return this._eventDescription; }
            set { this._eventDescription = value; }
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

        public LinkedList<Worker> workerList
        {
            get { return this._workerList; }
        }

        public Boolean addWorker(Worker workerToAdd)
        {
            if (!_workerList.Contains(workerToAdd))
            {
                _workerList.AddLast(workerToAdd);
                return true;
            }

            return false;
        }

        public LinkedList<Tasks> taskList
        {
            get { return this._taskList; }
        }

        public Boolean addTask(Tasks taskToAdd)
        {
            if (!_taskList.Contains(taskToAdd))
            {
                _taskList.AddLast(taskToAdd);
                return true;
            }

            return false;
        }

        /*Save the object*/
        public void SaveData()
        {

            IFormatter form = new BinaryFormatter();
            Stream stream = new FileStream(this._eventName + ".bin", FileMode.Create, FileAccess.Write, FileShare.None);

            form.Serialize(stream, this);
            stream.Close();


        }

        /*Load the object*/
        public void LoadData(string name)
        {
            IFormatter form = new BinaryFormatter();
            Stream stream = new FileStream(name + ".bin", FileMode.Open, FileAccess.Read, FileShare.None);
            Event data = (Event)form.Deserialize(stream);
            stream.Close();

            this._workerList = data.workerList;

            this._taskList = data._taskList;

        }

        public void DeleteData()
        {
            File.Delete(_eventName + ".bin");
        }

    }
}
