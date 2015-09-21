using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TraktorMapper.Code.Events
{
    public class Events
    {
        //First we have to define a delegate that acts as a signature for the
        //function that is ultimately called when the event is triggered.
        //You will notice that the second parameter is of MyEventArgs type.
        //This object will contain information about the triggered event.
        public delegate void CEventHandler(object source, CEventArgs e);

        //This is a class which describes the event to the class that recieves it.
        //An EventArgs class must always derive from System.EventArgs.
        public class CEventArgs : EventArgs
        {
            private string EventInfo;

            public CEventArgs(string Text)
            {
                EventInfo = Text;
            }
            public string GetInfo()
            {
                return EventInfo;
            }
        }
    }
}
