using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChtoGdeKogda
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			RefreshButtons();
        }

		private void StopTimer() {
			TimerMin.Enabled = false;
			label1.Visible = false;
			button1.BackColor = Color.DeepSkyBlue;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (TimerMin.Enabled) {
				StopTimer();
			} else {
				wmp.URL = "min-start.mp3";
				TimerMin.Enabled = true;
				tm = 0;
				label1.Visible = true;
				button1.BackColor = Color.Red;
			}
		}

		private int tm = 0;

		private int tm10sec = 50;
		private int tmEnd = 60;



		private void TimerMin_Tick(object sender, EventArgs e)
		{
			tm++;
			label1.Text = tm.ToString();
			if (tm == tm10sec) {

				wmp.URL = "min-10-sec.mp3";

			}
			else if (tm >= tmEnd) {

				wmp.URL = "min-start.mp3";
				StopTimer();

			}
		}

		private void RefreshSpeedLabel() {
			tm10sec = trackBar1.Value;
			tmEnd = tm10sec + 10;
			label2.Text = string.Format("Time: {0}/{1}", tm10sec, tmEnd);
		}


		private void trackBar1_Scroll(object sender, EventArgs e)
		{
			RefreshSpeedLabel();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			wmp.URL = "gong.mp3";
        }

		private void button3_Click(object sender, EventArgs e)
		{
			wmp.URL = "gong.mp3";
		}

		private void button4_Click(object sender, EventArgs e)
		{
			wmp.URL = "razd-mat.mp3";
        }

		private void button5_Click(object sender, EventArgs e)
		{
			wmp.URL = "Sing_sing_sing.mp3";
        }

		private void button6_Click(object sender, EventArgs e)
		{
			wmp.URL = "Thus_Sprach_Zarathustra.mp3";
        }

		private void button7_Click(object sender, EventArgs e)
		{
			wmp.URL = "Dance_Macabre.mp3";
        }

		private void Form1_Load(object sender, EventArgs e)
		{
			RefreshSpeedLabel();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			wmp.URL = "min-10-sec.mp3";
		}

		private void button3_Click_1(object sender, EventArgs e)
		{
			wmp.URL = "gong.mp3";
		}

		private int cBtnsIndex = 0;
		private Button cBtn;

		void RefreshButtons() {
			var btns = new Button[] { button2, button1, button3 };

			if (cBtnsIndex >= btns.Length) cBtnsIndex = 0;
			cBtn = btns[cBtnsIndex];

			foreach (var b in btns)
			{
				b.BackColor = b == cBtn ? Color.Lime : Color.LightGray;
			}

			//cBtn.PerformClick();
		}

		void NextButton() {
			cBtnsIndex++;
			RefreshButtons();
		}

		private void Form1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 'b') {
				if (cBtn != null) cBtn.PerformClick();
				NextButton();
			}
		}
	}
}
