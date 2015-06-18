using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMaker
{

    [Serializable]
    public class UpperClass
    {
                [Serializable]
                public struct TaskTime
        {
                public DateTime TaskStart;
                public DateTime TaskEnd;
        }

    }
}
