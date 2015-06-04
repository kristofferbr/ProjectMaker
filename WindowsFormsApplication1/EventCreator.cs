using System;
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
    public partial class EventCreator : Form
    {
        public EventCreator()
        {
            InitializeComponent();
        }

        private void createEvent_Click(object sender, EventArgs e)
        {
            DateTime startDate = DateTime.Parse(startDateTextBox.Text);
            
            List<EventDay> eventHorizont = new List<EventDay>();

            int amountOfDays = Int32.Parse(daysTextBox.Text);

            for (int i = 0; i < amountOfDays; i++)
            {
                DateTime thisEventDay = startDate.AddDays(i);
                EventDay eventDay = new EventDay(thisEventDay, DateTime.Parse(startTimeTextBox.Text), DateTime.Parse(endTimeTextBox.Text));
            }

            string eventName = eventNameTextBox.Text;

            Event newEvent = new Event(eventName, eventHorizont);

            IFormatter form = new BinaryFormatter();
            Stream stream = new FileStream(newEvent.eventName + ".bin", FileMode.Create, FileAccess.Write, FileShare.None);

            form.Serialize(stream, newEvent);
            stream.Close();

            Close();
        }

        private void abort_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
