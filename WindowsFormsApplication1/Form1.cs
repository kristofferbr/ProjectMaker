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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        /**/
        new Data LoadList = new Data();
        
        public Form1()
        {
            InitializeComponent();

            LoadList = LoadList.LoadData();

            foreach (Worker w in LoadList.workerList)
            {
                this.WorkerBox.Items.Add(w.Name);
            }

            foreach (Tasks t in LoadList.TaskList)
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
            foreach (Worker w in LoadList.workerList)
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
            foreach (Tasks t in LoadList.TaskList)
            {
                if (t.Name == (string)lb.SelectedItem)
                {
                    TimeBox.Items.Add(t.TaskTime.TaskStart.ToString("dd/MM"));
                    TimeBox.Items.Add(" " + t.TaskTime.TaskStart.ToString("HH:mm"));
                    TimeBox.Items.Add(" " + t.TaskTime.TaskEnd.ToString("HH:mm"));
                    
                }
            }
        }
 
        /*When a worker is added*/
        public void addWorker()
        {

            /*Variables*/
            UpperClass.TaskTime Timen = new UpperClass.TaskTime(); 

            /*Check to see if there are zero or some in it...*/
            if (!string.IsNullOrWhiteSpace(this.Navn.Text) && !string.IsNullOrWhiteSpace(this.TidFra.Text) && !string.IsNullOrWhiteSpace(this.Tildil.Text))
            {
                /*Clears the view so there is no dublicates*/
                WorkerBox.Items.Clear();

                /*Worker instances*/
                Worker worker = new Worker(this.Navn.Text);
                Worker tw = new Worker(this.Navn.Text);

                

                /*Checks if there is a date added to when the worker can work*/
                foreach (Worker m in LoadList.workerList)
                {
                    if (this.Navn.Text == m.Name)
                    {
                        worker = m;
                        tw = m;

                    }

                }

                /*Parses the date and adds it to the Task type*/
                Timen.TaskStart = DateTime.Parse(this.TidFra.Text);
                Timen.TaskEnd = DateTime.Parse(this.Tildil.Text);

                /*Adds the work hours to the worker*/
                worker.WorkTime.AddLast(Timen);


                /*Replaces or adds a worker to the list*/
                if (LoadList.workerList.Find(tw) != null)
                {
                    LoadList.workerList.AddAfter(LoadList.workerList.Find(tw), worker);
                    LoadList.workerList.Remove(tw);
                }
                else
                {
                    LoadList.workerList.AddLast(worker);
                }


                /*Adds the workers to the ListBox in the Form*/
                this.WorkerBox.Items.Clear();
                foreach (Worker w in LoadList.workerList)
                {
                    this.WorkerBox.Items.Add(w.Name);
                }

                /*Clears the text fields*/
                this.Navn.Clear();
                this.TidFra.Clear();
                this.Tildil.Clear();

                LoadList.SaveData(LoadList);
            }
        }

        /*When a plan is generated*/
        public void generatePlan()
        {

            Form2 form = new Form2();
            form.Show();
            LinkedList<DateTime> StartTimeList = new LinkedList<DateTime>();
            LinkedList<DateTime> EndTimeList = new LinkedList<DateTime>();

            foreach(Tasks t in LoadList.TaskList)
            {
                foreach(Worker w in LoadList.workerList)
                {
                    foreach(WindowsFormsApplication1.UpperClass.TaskTime m in w.WorkTime)
                    {
                        if(m.TaskStart >= t.TaskTime.TaskStart)
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
            foreach(Tasks t in LoadList.TaskList)
            {
                if(this.TaskName.Text == t.Name)
                {
                    task = t;
                    tempTask = t;
                }
            }


            /*Adding the values to the task*/
            task.Name = this.TaskName.Text;
            Timen.TaskStart = DateTime.Parse(this.TaskTimeStart.Text);
            Timen.TaskEnd = DateTime.Parse(this.TaskTimeEnd.Text);
            task.TaskTime = Timen;


            /*Checks if there is need to replace or add to the list*/
            if(LoadList.TaskList.Find(tempTask) != null)
            {
                LoadList.TaskList.AddAfter(LoadList.TaskList.Find(tempTask), task);
                LoadList.TaskList.Remove(tempTask);

            }
            else
            {
                LoadList.TaskList.AddLast(task);
            }

            LoadList.SaveData(LoadList);


            /*Inserts the tasks in the TaskBox*/
            this.TaskBox.Items.Clear();
            foreach(Tasks t in LoadList.TaskList)
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

            Data data = new Data();
            LoadList.SaveData(data);
            this.WorkerBox.Items.Clear();
            this.TaskBox.Items.Clear();


        }
        }


    }


