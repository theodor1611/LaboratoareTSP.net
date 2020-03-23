using System;
using System.Collections.Generic;
using System.Text;

namespace S1_TSP.net
{
    public class Event
    {
        // delegate pentru eveniment
        public delegate void InfoDelegate(object obj);
        // event ce foloseste delegate InfoDelegate
        public event InfoDelegate InfoChanged;
        // data membru
        object _obiect;
        public object SetInfo
        {
            set
            {
                _obiect = value;
                // genereaza eveniment
                InfoChanged(_obiect);
            }
        }
    }
}
