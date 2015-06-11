using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProjectMaker
{
    public partial class EventOverview : Form
    {
        private string directoryPath = @"Z:\Desktop\Git\ProjectMaker\WindowsFormsApplication1\bin\Debug";
        private string fileExtension = "*.bin";
        private Event chosenEvent;

        public EventOverview()
        {
            InitializeComponent();

        }

        private void EventOverview_Load(object sender, EventArgs e)
        {

            UpdateEventListBox();

        }

        public void UpdateEventListBox()
        {
            PopulateListBox(listBox1, directoryPath, fileExtension);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string curItem = listBox1.SelectedItem.ToString();
                chosenEvent = new Event(curItem);
                textBox1.Text = "";
                string data = chosenEvent.eventName + "\n" + chosenEvent.eventDescription;
                textBox1.Text = data;
            }

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string file = this.listBox1.SelectedItem.ToString();
                EventManager m = new EventManager(file);
                m.Show();
                //this.close();
            }
        }

        private void PopulateListBox(ListBox lsb, string Folder, string FileType)
        {
            lsb.Items.Clear();
            DirectoryInfo dinfo = new DirectoryInfo(Folder);
            FileInfo[] Files = dinfo.GetFiles(FileType);
            foreach (FileInfo file in Files)
            {
                string rawFileName = file.Name;
                string fileExtension = file.Extension;
                lsb.Items.Add(rawFileName.Substring(0, rawFileName.Length - fileExtension.Length));
            }
        }

        private string Read(string file)
        {

            StreamReader reader = new StreamReader(file);
            string data = reader.ReadToEnd();
            reader.Close();

            return data;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void newEvent_Click(object sender, EventArgs e)
        {
            EventCreator m = new EventCreator(this);
            m.Show();
        }
    }
}
