using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
   public abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Experience { get; set; }
    }
}
