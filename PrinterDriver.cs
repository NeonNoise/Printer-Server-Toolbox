using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PrinterServerToolbox
{
    public class PrinterDriver
    {
        public string Name;
        public string Path;
        public string Version;
        public string Environment;

        public PrinterDriver()
        {

        }
        public PrinterDriver(string path)
        {
            Path = path;
        }
        public PrinterDriver(string name,string path)
        {
            Name = name;
            Path = path;
        }
        public PrinterDriver(string name, string path, string version, string enviroment)
        {
            Name = name;
            Path = path;
            Version = version;
            Environment = enviroment;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
