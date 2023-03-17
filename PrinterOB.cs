﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace PrinterServerToolbox
{
    public class PrinterOB
    {
        private string portIP;
        private bool isNullPort;
        Regex IPFormat = new Regex(@"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}");
        Regex IPNulFormat = new Regex(@"nul");

        public string Name;
        public string Comment;
        public string Location;
        public string PortName;
        public string PortIP
        {
            get
            {
                return portIP;
            }
            set
            {
                if (IPFormat.IsMatch(value))
                {
                    portIP = value;
                }
                else if (IPNulFormat.IsMatch(value))
                {
                    isNullPort = true;
                    PortIP = value;
                }
                else
                {
                    portIP = "0.0.0.0";
                }
            }
        }
        public PrinterDriver Driver;
        public bool AdvancedPrinterFeaturesEnabled;
        public string PrintProcessor;
        public PrinterPropertys PrinterDefaults;
    }
}
