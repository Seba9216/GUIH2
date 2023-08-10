using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIH2
{
    public class FancyEventArgs : EventArgs
    {
        public int KnapKlik { get; set; }
    }
    public delegate void FancyeventHandler(object sender, FancyEventArgs e); 

}
