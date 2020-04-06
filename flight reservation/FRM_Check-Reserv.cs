using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flight_reservation
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dynamicDTP = new DateTimePicker();
            dynamicDTP.Name = "DyanmicDateTimePicker";
            dynamicDTP.Location = new System.Drawing.Point(12, 12);
            dynamicDTP.Size = new System.Drawing.Size(200, 25);
            dynamicDTP.Width = 200;
            dynamicDTP.Height = 25;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FRM_Home f = new FRM_Home();
            f.Show();
        }
    }
}
