﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace ProjectMaker
{
    public partial class EventManager : Form
    {
        /**/
        private Event currentEvent;

        public EventManager(string name)
        {
            InitializeComponent();

            currentEvent = new Event(name);
            currentEvent.LoadData(name);
            foreach (Worker w in currentEvent.workerList)
            {
                this.WorkerBox.Items.Add(w.Name);
            }

            foreach (Tasks t in currentEvent.taskList)
            {
                this.TaskBox.Items.Add(t.Name);
            }
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            addWorker();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void workerView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            generatePlan();
        }

        private void AddTask_Click(object sender, EventArgs e)
        {
            addTask();
        }

        /*Display the times that is stated the worker can work or the task requires staff*/
        private void WorkerBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*Clears the appropriate screens*/
            this.TaskBox.ClearSelected();
            TimeBox.Items.Clear();

            /*Variables*/
            ListBox lb = (ListBox)sender;

            /*Displays the name in the textfield if more times are to be added to the list*/
            this.Navn.Text = (string)lb.SelectedItem;

            /*Adds to the TimeBox*/
            foreach (Worker w in currentEvent.workerList)
            {
                if (w.Name == (string)lb.SelectedItem)
                {
                    foreach (UpperClass.TaskTime t in w.WorkTime)
                    {
                        TimeBox.Items.Add(t.TaskStart.ToString("dd/MM"));
                        TimeBox.Items.Add("   " + t.TaskStart.ToString("HH:mm"));
                        TimeBox.Items.Add("   " + t.TaskEnd.ToString("HH:mm"));
                    }

                }
            }
        }

        /*Displays the times the tasks must be staffed*/
        private void TaskBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*Clears the appropriate fieds*/
            this.WorkerBox.ClearSelected();
            TimeBox.Items.Clear();

            /*Variables*/
            ListBox lb = (ListBox)sender;

            /*Writes the text in the field */
            this.TaskName.Text = (string)lb.SelectedItem;

            /*Displays the times and dates in the TimeBox*/
            foreach (Tasks t in currentEvent.taskList)
            {
                if (t.Name == (string)lb.SelectedItem)
                {
                    TimeBox.Items.Add(t.taskTime.TaskStart.ToString("dd/MM"));
                    TimeBox.Items.Add(" " + t.taskTime.TaskStart.ToString("HH:mm"));
                    TimeBox.Items.Add(" " + t.taskTime.TaskEnd.ToString("HH:mm"));

                }
            }
        }

        /*When a worker is added*/
        public void addWorker()
        {

            /*Variables*/
            UpperClass.TaskTime Timen = new UpperClass.TaskTime();

            /*Check to see if there are zero or some in it...*/
            if (!string.IsNullOrWhiteSpace(this.Navn.Text) && !string.IsNullOrWhiteSpace(this.TidFra.Text) && !string.IsNullOrWhiteSpace(this.TidTil.Text))
            {
                /*Clears the view so there is no dublicates*/
                WorkerBox.Items.Clear();

                /*Worker instances*/
                Worker worker = new Worker(this.Navn.Text);
                Worker tempWorker = new Worker(this.Navn.Text);



                /*Checks if there is a date added to when the worker can work*/
                foreach (Worker m in currentEvent.workerList)
                {
                    if (this.Navn.Text == m.Name)
                    {
                        worker = m;
                        tempWorker = m;

                    }

                }

                /*Parses the date and adds it to the Task type*/
                Timen.TaskStart = DateTime.Parse(this.TidFra.Text);
                Timen.TaskEnd = DateTime.Parse(this.TidTil.Text);

                /*Adds the work hours to the worker*/
                worker.WorkTime.AddLast(Timen);


                /*Replaces or adds a worker to the list*/
                if (currentEvent.workerList.Find(tempWorker) != null)
                {
                    currentEvent.workerList.AddAfter(currentEvent.workerList.Find(tempWorker), worker);
                    currentEvent.workerList.Remove(tempWorker);
                }
                else
                {
                    currentEvent.workerList.AddLast(worker);
                }


                /*Adds the workers to the ListBox in the Form*/
                this.WorkerBox.Items.Clear();
                foreach (Worker w in currentEvent.workerList)
                {
                    this.WorkerBox.Items.Add(w.Name);
                }

                /*Clears the text fields*/
                this.Navn.Clear();
                this.TidFra.Clear();
                this.TidTil.Clear();

                currentEvent.SaveData();
            }
        }

        /*When a plan is generated*/
        public void generatePlan()
        {

            PlanGenerator form = new PlanGenerator();
            form.Show();
            LinkedList<DateTime> StartTimeList = new LinkedList<DateTime>();
            LinkedList<DateTime> EndTimeList = new LinkedList<DateTime>();

            foreach (Tasks t in currentEvent.taskList)
            {
                foreach (Worker w in currentEvent.workerList)
                {
                    foreach (ProjectMaker.UpperClass.TaskTime m in w.WorkTime)
                    {
                        if (m.TaskStart >= t.taskTime.TaskStart)
                        {

                        }


                    }
                }
            }
        }

        /*When a task is added*/
        public void addTask()
        {


            /*Variables*/
            Tasks task = new Tasks();
            Tasks tempTask = new Tasks();
            UpperClass.TaskTime Timen = new UpperClass.TaskTime();


            /*Checks if the task is already in the list and creates temporary instance for replacing*/
            foreach (Tasks t in currentEvent.taskList)
            {
                if (this.TaskName.Text == t.Name)
                {
                    task = t;
                    tempTask = t;
                }
            }


            /*Adding the values to the task*/
            task.Name = this.TaskName.Text;
            Timen.TaskStart = DateTime.Parse(this.TaskTimeStart.Text);
            Timen.TaskEnd = DateTime.Parse(this.TaskTimeEnd.Text);
            task.taskTime = Timen;


            /*Checks if there is need to replace or add to the list*/
            if (currentEvent.taskList.Find(tempTask) != null)
            {
                currentEvent.taskList.AddAfter(currentEvent.taskList.Find(tempTask), task);
                currentEvent.taskList.Remove(tempTask);

            }
            else
            {
                currentEvent.taskList.AddLast(task);
            }

            currentEvent.SaveData();


            /*Inserts the tasks in the TaskBox*/
            this.TaskBox.Items.Clear();
            foreach (Tasks t in currentEvent.taskList)
            {
                this.TaskBox.Items.Add(t.Name);
            }

            /*Clears the text fields*/
            this.TaskName.Clear();
            this.TaskTimeStart.Clear();
            this.TaskTimeEnd.Clear();





        }

        /*Erase Data*/
        private void DeleteData_Click(object sender, EventArgs e)
        {

            currentEvent.DeleteData();
            this.WorkerBox.Items.Clear();
            this.TaskBox.Items.Clear();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            currentEvent.SaveData();
            Close();
        }
    }


}


