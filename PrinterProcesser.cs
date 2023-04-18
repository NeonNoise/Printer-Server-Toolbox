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

        public enum AddPrinterType
        {
            Name,
            DriverOB
        }

        public static string GetAllPrinters()
        {
            string scriptArguments = $"-l";
            return StartScriptProcess(prnmngr, scriptArguments);
        }

        public static List<PrinterOB> GetAllInstalledPrinters()
        {
            List<PrinterOB> PrintersList = new List<PrinterOB>();

            //todo: Get List

            return PrintersList;
        }

        public static List<PrinterDriver> GetAllPrintDrivers()
        {
            string scriptArguments = $"-l";
            string rawPrintDriverList = StartScriptProcess(prndrvr, scriptArguments);
            StringReader stringReader = new StringReader(rawPrintDriverList);
            Regex driverName = new Regex(@"^Driver name[^,]*");
            Regex driverPath = new Regex(@"^Driver path[^,]*");
            string line;
            List<PrinterDriver> printerDrivers = new List<PrinterDriver>();
            while((line = stringReader.ReadLine()) != null)
            {
                if (driverName.IsMatch(line))
                {
                    line = line.Remove(0, 11);
                    string[] lines = line.Split(',');
                    PrinterDriver newDriver = new PrinterDriver();
                    newDriver.Name = lines[0].Substring(1);
                    newDriver.Version = lines[1];
                    newDriver.Environment = lines[2];

                    stringReader.ReadLine();
                    stringReader.ReadLine();
                    stringReader.ReadLine();
                    line = stringReader.ReadLine();
                    line = line.Remove(0, 11);

                    newDriver.Path = line;

                    printerDrivers.Add(newDriver);
                    newDriver = new PrinterDriver();
                }
            }
            return printerDrivers;
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

        public static Stack<string> AddPrinters(List<PrinterOB> PrintersList)
        {
            Stack<string> Errors = new Stack<string>();
            string scriptArguments = "";
            foreach(PrinterOB activePrinter in PrintersList){
                AddPrinterPort(activePrinter.PortName, activePrinter.PortIP, false);
                scriptArguments = $"-a -p {activePrinter.Name} -m \"{activePrinter.Driver.Name}\" -r {activePrinter.PortName}";
                Errors.Push(StartScriptProcess(prnmngr, scriptArguments));
            }

            return Errors;
        }

        public static Stack<string> AddPrinters(Queue<PrinterOB> PrintersQueue)
        {
            Stack<string> Errors = new Stack<string>();
            string scriptArguments;
            PrinterOB activePrinter;
            while(PrintersQueue.Count > 0)
            {
                activePrinter = PrintersQueue.Dequeue();
                scriptArguments = $"-a -p {activePrinter.Name} -m \"{activePrinter.Driver.Name}\" -r {activePrinter.PortName}";
                Errors.Push(StartScriptProcess(prnmngr, scriptArguments));
            }

            return Errors;
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
