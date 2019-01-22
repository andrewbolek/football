using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class Team
    {
        public bool? Win { get; set; } // Property
    }

    public class Alabama : Team
    {
        public Alabama()
        { Win = false; }
    }

    public class Clemson : Team
    {
        public Clemson()
        { Win = true; }


    }
}


        
   
        
  

   

