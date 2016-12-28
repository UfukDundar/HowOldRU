using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HowOldRU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dtBirth = dtBirthday.Value;
            DateTime dtPresent = DateTime.Now;
            int age = dtPresent.Year - dtBirth.Year;
            txtAge.Text = age.ToString();
            txtTotalDay.Text = (dtPresent - dtBirth).TotalDays.ToString();
            txtTotalHours.Text = (dtPresent - dtBirth).TotalHours.ToString();
            txtTotalMinutes.Text = (dtPresent - dtBirth).TotalMinutes.ToString();
            txtTotalSeconds.Text = (dtPresent - dtBirth).TotalSeconds.ToString();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dtBirth = dtBirthday.Value;
            DateTime dtPresent = DateTime.Now;
            int age = dtPresent.Year - dtBirth.Year;
            txtAge.Text = age.ToString();
            txtTotalDay.Text = (dtPresent - dtBirth).TotalDays.ToString("#,###");
            txtTotalHours.Text = (dtPresent - dtBirth).TotalHours.ToString("#,###");
            txtTotalMinutes.Text = (dtPresent - dtBirth).TotalMinutes.ToString("#,###");
            txtTotalSeconds.Text = (dtPresent - dtBirth).TotalSeconds.ToString("#,###");
        }
    }
}
