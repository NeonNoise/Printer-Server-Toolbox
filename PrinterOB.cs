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
        private string name;
        private bool isNullPort;

        readonly Regex IPFormat = new Regex(@"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}");
        readonly Regex IPNulFormat = new Regex(@"nul");

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if(value.StartsWith(" ")){
                    name = value.TrimStart(' ');
                }
                else
                {
                    name = value;
                }
            }
        }
        public string Comment;
        public string Location;
        public string PortName;
        public string ShareName;
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
                    isNullPort = false;
                    portIP = value;
                }
                else if (IPNulFormat.IsMatch(value))
                {
                    isNullPort = true;
                    PortIP = value;
                }
                else
                {
                    isNullPort = false;
                    portIP = "0.0.0.0";
                }
            }
        }
        public bool IsShared
        {
            get
            {
                if (string.IsNullOrEmpty(ShareName)){
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public PrinterDriver Driver;
        public bool AdvancedPrinterFeaturesEnabled;
        public string PrintProcessor;
        public PrinterConfig PrinterDefaults;


        public override string ToString()
        {
            string output = $"Name= {this.Name},Driver= {this.Driver.Name},Port Name/IP= {this.PortName}/{this.portIP}";
            return output;
        }
    }
}
