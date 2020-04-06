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
    public partial class FRM_Home : Form
    {
        public FRM_Home()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            FRM_Book myNewForm = new FRM_Book();

            myNewForm.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FRM_Login fory = new FRM_Login();
            fory.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cancel can = new cancel();
            can.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            FRM_Reservations f = new FRM_Reservations();
            f.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FRM_Start f = new FRM_Start();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f = new Form3();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f = new Form7();
            f.Show();
        }
    }
}
