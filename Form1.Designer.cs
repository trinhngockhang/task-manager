namespace WindowsFormsApp1
{
    partial class taskManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblProcessText = new System.Windows.Forms.Label();
            this.numberP = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.killToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.processName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.processId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ram = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.respone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CPU = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProcessText
            // 
            this.lblProcessText.AutoSize = true;
            this.lblProcessText.Location = new System.Drawing.Point(24, 63);
            this.lblProcessText.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblProcessText.Name = "lblProcessText";
            this.lblProcessText.Size = new System.Drawing.Size(90, 25);
            this.lblProcessText.TabIndex = 1;
            this.lblProcessText.Text = "Process";
            // 
            // numberP
            // 
            this.numberP.AutoSize = true;
            this.numberP.Location = new System.Drawing.Point(154, 63);
            this.numberP.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.numberP.Name = "numberP";
            this.numberP.Size = new System.Drawing.Size(24, 25);
            this.numberP.TabIndex = 2;
            this.numberP.Text = "0";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.killToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 40);
            // 
            // killToolStripMenuItem
            // 
            this.killToolStripMenuItem.Name = "killToolStripMenuItem";
            this.killToolStripMenuItem.Size = new System.Drawing.Size(122, 36);
            this.killToolStripMenuItem.Text = "Kill";
            this.killToolStripMenuItem.Click += new System.EventHandler(this.killToolStripMenuItem_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.processName,
            this.processId,
            this.respone,
            this.CPU,
            this.ram});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(29, 117);
            this.listView1.Margin = new System.Windows.Forms.Padding(6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1287, 696);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // processName
            // 
            this.processName.Text = "Process Name";
            this.processName.Width = 179;
            // 
            // processId
            // 
            this.processId.Text = "ID";
            this.processId.Width = 96;
            // 
            // ram
            // 
            this.ram.DisplayIndex = 3;
            this.ram.Text = "Ram";
            this.ram.Width = 126;
            // 
            // respone
            // 
            this.respone.Text = "Status";
            this.respone.Width = 182;
            // 
            // CPU
            // 
            this.CPU.DisplayIndex = 2;
            this.CPU.Text = "CPU";
            this.CPU.Width = 175;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // taskManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1431, 865);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.numberP);
            this.Controls.Add(this.lblProcessText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "taskManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Manager";
            this.Load += new System.EventHandler(this.taskManager_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblProcessText;
        private System.Windows.Forms.Label numberP;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem killToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader processName;
        private System.Windows.Forms.ColumnHeader ram;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ColumnHeader CPU;
        private System.Windows.Forms.ColumnHeader respone;
        private System.Windows.Forms.ColumnHeader processId;
    }
}

