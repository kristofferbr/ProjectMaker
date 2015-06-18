using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMaker
{
    [Serializable]
    class Worker : UpperClass
    {

        
        private LinkedList<Tasks> _myTasks = new LinkedList<Tasks>();
        private LinkedList<TaskTime> _occTime = new LinkedList<TaskTime>();
        private string _name;
        private string _initials;
        private string _city;
        private Boolean _driverLicense;
        private string _phoneNumber;
        private int _activeTime;


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

        public string Initials
        {
            get
            {
                return _initials;
            }
            set
            {
                _initials = value;
            }
        }

        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                _city = value;
            }
        }

        public bool DriverLicense
        {
            get
            {
                return _driverLicense;
            }
            set
            {
                _driverLicense = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                _phoneNumber = value;
            }
        }

        public int ActiveTime
        {
            get
            {
                return _activeTime;
            }
            set
            {
                _activeTime = value;
            }
        }
   



    }
}
