using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMaker
{
    [Serializable()]
    class EventDay
    {
        private DateTime date;
        private DateTime startOfWorkDay;
        private DateTime endOfWorkDay;

        public EventDay(DateTime date, DateTime startOfWorkDay, DateTime endOfWorkDay)
        {
            this.date = date;
            this.startOfWorkDay = startOfWorkDay;
            this.endOfWorkDay = endOfWorkDay;
        }
    }
}
