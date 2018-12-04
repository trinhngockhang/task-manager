using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Management;
using System.Security.Permissions;

namespace WindowsFormsApp1
{
   
    public partial class taskManager : Form
    {
        Process[] process;
        public Boolean f5 = false;

        private void getProcess()
        {
            process = Process.GetProcesses();
            ImageList Imagelist = new ImageList();
            double cpuPercent = 0;
            if (int.Parse(numberP.Text) != process.Length)
            {
                float[] firstTimeCpu = new float[process.Length];
                DateTime[] timeStart = new DateTime[process.Length];
                DateTime[] timeEnd = new DateTime[process.Length];
                PerformanceCounter[] performanceCounters = new PerformanceCounter[process.Length];
                DateTime test = DateTime.Now;
                // khoi tao bo dem cpu time
                for(int i = 0;i < process.Length; i++)
                {
                    performanceCounters[i] = new PerformanceCounter("Process", "% Processor Time", process[i].ProcessName);
                    try
                    {
                        firstTimeCpu[i] = performanceCounters[i].NextValue();
                        timeStart[i] = DateTime.Now;
                    }
                    catch
                    {
                        firstTimeCpu[i] = 0;
                        timeStart[i] = DateTime.Now;
                    }        
                }
                long totalRam = 0;
                listView1.BeginUpdate();
                listView1.Items.Clear();
                numberP.Text = process.Length.ToString();
                Thread.Sleep(50);
                for(int i = 0; i <process.Length; i++)
                {
                    
                    double cpuUsageFloat;
                    // tong ram
                    totalRam += process[i].PagedMemorySize64;
                    string status = (process[i].Responding == true ? "Responding" : "Not responding");
                    string ramUsage = (Math.Round(process[i].PagedMemorySize64 / Math.Pow(2, 20), 1) + " Mb").ToString();
                    try
                    {
                        timeEnd[i] =  DateTime.Now;
                        Console.WriteLine("time : " +i + "  "  + (timeEnd[i] - timeStart[i]).TotalMilliseconds);
                        cpuUsageFloat = (performanceCounters[i].NextValue() - firstTimeCpu[i]) / ( timeEnd[i].Subtract(timeStart[i]).TotalMilliseconds) * 100;
                       
                    }
                    catch
                    {
                        cpuUsageFloat = 0f;
                    }
                    //lay cpu
                    string cpuUsage = Math.Round((double) cpuUsageFloat, 1).ToString() + "%";
                    //tinh tong cpu loai bo process dac biet
                    if(process[i].ProcessName != "Idle")
                    {
                        cpuPercent += cpuUsageFloat;
                    }
                        // cac cot 
                        string[] row =
                        {
                            process[i].ProcessName,
                            process[i].Id.ToString(),
                            status,
                            cpuUsage,
                            ramUsage                        
                        };
                    try
                    {
                        Console.WriteLine("file location  " + process[i].MainModule.FileName);
                        Imagelist.Images.Add(
                            // Add an unique Key as identifier for the icon (same as the ID of the process)
                            process[i].Id.ToString(),
                            // Add Icon to the List 
                            Icon.ExtractAssociatedIcon(process[i].MainModule.FileName).ToBitmap()
                            );
                    }
                    catch { }
                    // add cac cot vao listview 
                    ListViewItem listView = new ListViewItem(row)
                    {
                        ImageIndex = Imagelist.Images.IndexOfKey(process[i].Id.ToString())
                    };

                    listView1.Items.Add(listView);
                    

                   
                }
                
                listView1.LargeImageList = Imagelist;
                listView1.SmallImageList = Imagelist;
                listView1.EndUpdate();
                ram.Text = "Ram(" + Math.Round(totalRam / Math.Pow(2, 20) / 12958 * 100 ,1) + "%)";
                
                CPU.Text = "CPU(" + Math.Round(cpuPercent) + "%)";
            }
        }
        public taskManager()
        {
            InitializeComponent();
            getProcess();
           
        }

        
        //kill process
        private void killToolStripMenuItem_Click(object sender, EventArgs e)
        {
            process[listView1.SelectedIndices[0]].Kill();
        }
        //update  by 1 second
        private void timer1_Tick(object sender, EventArgs e)
        {
            getProcess();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void taskManager_Load(object sender, EventArgs e)
        {

        }
    }
}
