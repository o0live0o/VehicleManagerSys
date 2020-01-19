using HZH_Controls.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleManagerSys.Core.Report;

namespace VehicleManagerSys.Main.CustomForms
{
    public partial class ReportTestForm : Form
    {
        private static SafetyTechnologyReport safetyTechnologyReport = new SafetyTechnologyReport("");
        public ReportTestForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss");
            pictureBox1.Image = null;
            Stopwatch stopwatch = new Stopwatch();
            Stopwatch stopwatch1 = new Stopwatch();
            stopwatch.Start();
           
            Bitmap bitmap = safetyTechnologyReport.CreateReport();
            stopwatch.Stop();
            long i = stopwatch.ElapsedMilliseconds;
            label3.Text = i.ToString();

            stopwatch1.Start();
            MemoryStream memoryStream = new MemoryStream();
            bitmap.Save(memoryStream,ImageFormat.Png);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = Image.FromStream(memoryStream);
            stopwatch1.Stop();
            long j = stopwatch1.ElapsedMilliseconds;
            label4.Text = j.ToString();
            label2.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
