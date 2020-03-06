using System;
using System.Collections.Generic;
using System.Text;

namespace TeamPract1.Events
{
    public class GameEventArgs
    {
      
        public string Message { get; }
   
        public GameEventArgs(string mes)
        {
            Message = mes;
            
        }

    }
}
