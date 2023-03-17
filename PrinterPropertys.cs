using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterServerToolbox
{
    public class PrinterPropertys
    {
        private string shortPath;
        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Path
        {
            get
            {
                return (shortPath + name);
            }
        }
    }
}
