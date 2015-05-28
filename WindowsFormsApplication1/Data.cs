using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace ProjectMaker
{

    [Serializable()]
    class Data
    {

        public LinkedList<Worker> workerList = new LinkedList<Worker>();
        public LinkedList<Tasks> TaskList = new LinkedList<Tasks>();


        public void AddWorker(Worker worker)
        {
            workerList.AddLast(worker);
        }

        public void AddTask(Tasks task)
        {
            TaskList.AddLast(task);
        }


        /*Save the object*/
        public void SaveData()
        {

            IFormatter form = new BinaryFormatter();
            Stream stream = new FileStream("Dataset.bin", FileMode.Create, FileAccess.Write, FileShare.None);

            form.Serialize(stream, this);
            stream.Close();


        }

        /*Load the object*/
        public void LoadData()
        {
            IFormatter form = new BinaryFormatter();
            Stream stream = new FileStream("Dataset.bin", FileMode.Open, FileAccess.Read, FileShare.None);
            Data data = (Data)form.Deserialize(stream);
            stream.Close();

            this.workerList = data.workerList;

            this.TaskList = data.TaskList;

        }

        public void DeleteData()
        {
            Data data = new Data();
            IFormatter form = new BinaryFormatter();
            Stream stream = new FileStream("Dataset.bin", FileMode.Create, FileAccess.Write, FileShare.None);

            form.Serialize(stream, data);
            stream.Close();
        }

    }
}
