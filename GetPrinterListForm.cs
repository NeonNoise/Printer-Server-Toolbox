using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace PrinterServerToolbox
{
    public partial class GetPrinterListForm : Form
    {
        public GetPrinterListForm()
        {
            InitializeComponent();
        }



        private void RunPrinterList(object sender, EventArgs e)
        {

            //Server name
            //Printer name
            //Share name
            //Driver name
            //Port name
            //Comment
            //Location
            //Print processor
            //Data type
            //Average pages per minute
            //Printer status
            Debug.WriteLine("Starting Run Printer List");
            string RawPrinterList = PrinterProcesser.GetAllPrinters();
            List<string[]> PrinterList = new List<string[]>();
            StringReader reader = new StringReader(RawPrinterList);
            string Line;
            string[] printer = new string[11];
            int printercount = 0;
            while((Line = reader.ReadLine()) != null)
            {
                if (Line.Contains("Server name") | Line.Contains("Printer name") | Line.Contains("Share name") | Line.Contains("Driver name") | Line.Contains("Port name") | Line.Contains("Comment") | Line.Contains("Location") | Line.Contains("Print processor") | Line.Contains("Data type") | Line.Contains("Average pages per minute"))
                {
                    Debug.WriteLine(Line);
                    string[] Lines = Line.Split(' ');
                    StringBuilder stringBuilder = new StringBuilder();
                    if ((Lines[1] == "name" | Lines[1] == "processor" | Lines[1] == "type") && Lines.Length > 2)
                    {
                        
                        for(int i=2; i < Lines.Length; i++)
                        {
                            if(i != 2)
                            {
                                stringBuilder.Append(" " + Lines[i]);
                            }
                            else
                            {
                                stringBuilder.Append(Lines[i]);
                            }
                            
                        }
                    }
                    else if(Lines[0] == "Average")
                    {
                        if(Lines.Length > 4)
                        {
                            for (int i = 4; i < Lines.Length; i++)
                            {
                                if (i != 2)
                                {
                                    stringBuilder.Append(" " + Lines[i]);
                                }
                                else
                                {
                                    stringBuilder.Append(Lines[i]);
                                }

                            }
                        }
                        else
                        {
                            stringBuilder.Append("0");
                        }

                    }
                    else
                    {
                        for (int i = 1; i < Lines.Length; i++)
                        {
                            if (i != 2)
                            {
                                stringBuilder.Append(" " + Lines[i]);
                            }
                            else
                            {
                                stringBuilder.Append(Lines[i]);
                            }

                        }
                    }

                    printer[printercount] = stringBuilder.ToString();
                    printercount++;
                }
                else if(Line.Contains("Printer status"))
                {
                    Debug.WriteLine("Printer Found");
                    printer[printercount] = Line;
                    printercount = 0;
                    PrinterList.Add(printer);
                    printer = new string[11];
                }

            }
            string[][] PrinterArray = PrinterList.ToArray();
            Debug.WriteLine(PrinterList.Count);
            Debug.WriteLine(PrinterArray.Length);
            foreach(string[] printerEntry in PrinterArray)
            {
                Debug.WriteLine("New Printer:");
                foreach(string entry in printerEntry)
                {
                    Debug.Write(entry + " ");
                }
                PrinterListView.Rows.Add(printerEntry);

                Debug.WriteLine("End of Printer");
            }

            
        }

        private void PrinterListView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
