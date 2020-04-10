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

namespace flight_reservation
{
	public partial class FRM_Home : Form
	{
		public static int U_ID = 0;
		public static string U_Name = null;
		public FRM_Home()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			try
			{

				if (U_Name == null && U_ID == 0)
				{
					if (File.Exists("log.txt"))
					{
						var wr = new StreamReader(new FileStream("log.txt", FileMode.Open, FileAccess.ReadWrite));
						var un = wr.ReadLine();
						if (un != null && un.Length != 0)
						{
							U_ID = int.Parse(un);
							BTN_Login.Visible = false;
							LBL_Name.Visible = true;
							BTN_LogOut.Visible = true;
							U_Name = wr.ReadLine();
							LBL_Name.Text += U_Name;
							BTN_Book.Enabled = BTN_CancelRes.Enabled = BTN_ViewRes.Enabled = true;
						}
						wr.Close();
					}
				}
				else
				{
					BTN_Login.Visible = false;
					LBL_Name.Visible = true;
					BTN_LogOut.Visible = true;
					LBL_Name.Text += U_Name;
					BTN_Book.Enabled = BTN_CancelRes.Enabled = BTN_ViewRes.Enabled = true;
				}
			}
			catch (Exception eddd)
			{
				MessageBox.Show("There Are Some Problems In App", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void button7_Click(object sender, EventArgs e)
		{
			new FRM_Book().Show();
			this.Hide();
		}

		private void button9_Click(object sender, EventArgs e)
		{
			new FRM_Login().Show();
			this.Hide();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			new cancel().Show();
			this.Hide();
		}

		private void button4_Click_1(object sender, EventArgs e)
		{
			new FRM_Reservations().Show();
			this.Hide();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Hide();
			new FRM_Start().Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
			new Form3().Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			new Form7().Show();
		}

		private void BTN_LogOut_Click(object sender, EventArgs e)
		{
			try
			{
				File.Delete("log.txt");
				this.Hide();
				new FRM_Start().Show();
			}
			catch (Exception)
			{

			}
		}
	}
}
