using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PrinterServerToolbox
{

    public static class PrinterProcesser
    {
        //Script Path Reference
        private static readonly string prnmngr = @"C:\Windows\System32\printing_Admin_Scripts\en-US\Prnmngr.vbs";
        private static readonly string prnport = @"C:\Windows\System32\Printing_Admin_Scripts\en-US\Prnport.vbs";
        private static readonly string prndrvr = @"C:\Windows\System32\Printing_Admin_Scripts\en-US\Prndrvr.vbs";
        private static readonly string prncnfg = @"C:\Windows\System32\Printing_Admin_Scripts\en-US\Prndrvr.vbs";


        public static string GetAllPrinters()
        {
            string scriptArguments = $"-l";
            return StartScriptProcess(prnmngr, scriptArguments);
        }

        public static string GetAllPrintDrivers()
        {
            string scriptArguments = $"-l";
            string rawPrintDriverList = StartScriptProcess(prndrvr, scriptArguments);
            StringReader stringReader = new StringReader(rawPrintDriverList);
            Regex driverName = new Regex(@"");
            return "no";
        }


        public static void AddPrinterPort(string PortName, string PortIP, bool SNMPon)
        {
            string snmp = "d";
            if (SNMPon)
            {
                snmp = "e";
            }
            string scriptArguments = $"-a -r {PortName} -o raw -h {PortIP} -m{snmp}";
            StartScriptProcess(prnport, scriptArguments);
        }

        public static void AddPrinterDriver(string Model,string InfPath)
        {
            string scriptArguments = $"-a -m {Model} -i {InfPath}";
            StartScriptProcess(prndrvr, scriptArguments);
        }

        public static void AddPrinters(List<PrinterOB> PrintersList)
        {
            foreach(PrinterOB printer in PrintersList){

                string scriptArguments = $"-a -p {printer.Name} -m {printer.Driver}";
                StartScriptProcess(prnmngr, scriptArguments);

            }
        }




        private static string StartScriptProcess(string scriptDirectory, string arguments)
        {
            Process script = new Process();
            script.StartInfo.FileName = "cscript.exe";
            script.StartInfo.Arguments = scriptDirectory + " " + arguments;
            script.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            script.StartInfo.UseShellExecute = false;
            script.StartInfo.RedirectStandardOutput = true;
            script.Start();
            StreamReader reader = script.StandardOutput;
            string Output = reader.ReadToEnd();
            script.WaitForExit();
            script.Close();
            return Output;
        }
    }
}
