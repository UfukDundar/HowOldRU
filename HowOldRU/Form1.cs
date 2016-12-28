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
        }
    }
}
