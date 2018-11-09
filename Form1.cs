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

namespace WindowsFormsApp1
{
    public partial class taskManager : Form
    {
        Process[] process;
      //  private PerformanceCounter theCpu = new PerformanceCounter("Processor", "% Processor Time", "_total");

        private void getProcess()
        {
            process = Process.GetProcesses();
            if(int.Parse(numberP.Text) != process.Length)
            {
                listView1.Items.Clear();
                numberP.Text = process.Length.ToString();
                for(int i = 0; i < process.Length; i++)
                {
                    //get name of process
                    ListViewItem listView = new ListViewItem() { Text = process[i].ProcessName };
                    //get ram usage
                    listView.SubItems.Add(new ListViewItem.ListViewSubItem()
                    {
                        Text = ((long) process[i].PagedMemorySize64 / Math.Pow(2,20) ).ToString()
                    });

                    listView1.Items.Add(listView);
                }
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
    }
}
