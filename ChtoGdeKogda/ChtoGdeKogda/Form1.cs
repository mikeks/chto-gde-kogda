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

		private void StopTimer()
		{
			MinuteTimer.Enabled = false;
			label1.Visible = false;
			button1.BackColor = Color.DeepSkyBlue;
		}

		private void minuteButtonClick(object sender, EventArgs e)
		{
			if (MinuteTimer.Enabled)
			{
				StopTimer();
			}
			else
			{
				wmp.URL = "min-start.mp3";
				MinuteTimer.Enabled = true;
				tm = 0;
				label1.Text = "0";
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
			if (tm == tm10sec)
			{

				wmp.URL = "min-10-sec.mp3";
				label1.ForeColor = Color.Red;
            }
			else if (tm >= tmEnd)
			{

				wmp.URL = "min-start.mp3";
				StopTimer();

			} else
			{
				label1.ForeColor = Color.Black;
			}
		}

		private void RefreshSpeedLabel()
		{
			tm10sec = rountTimeTrackBar.Value;
			tmEnd = tm10sec + 10;
			label2.Text = string.Format("Time: {0}/{1}", tm10sec, tmEnd);
		}


		private void trackBar1_Scroll(object sender, EventArgs e)
		{
			RefreshSpeedLabel();
		}

		private void gongButtonClick(object sender, EventArgs e)
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

		private void rightAnswerButtonClick(object sender, EventArgs e)
		{
			wmp.URL = "gong.mp3";
		}

		private int cBtnsIndex = 0;
		private Button cBtn;

		void RefreshButtons()
		{
			Button[] btns; 
			if (blitzModeCheckbox.Checked)
			{
				btns = new Button[] { button1 };
			} else
			{
				btns = new Button[] { button2, button1, button3 };
			}

			if (cBtnsIndex >= btns.Length) cBtnsIndex = 0;
			cBtn = btns[cBtnsIndex];

			foreach (var b in btns)
			{
				b.BackColor = b == cBtn ? Color.Lime : Color.LightGray;
			}

			//cBtn.PerformClick();
		}

		void NextButton()
		{
			cBtnsIndex++;
			RefreshButtons();
		}

		void PedalPressed()
		{
			if (cBtn != null) cBtn.PerformClick();
			NextButton();
		}

		DateTime lastPressTime;

		private void Form1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((DateTime.Now - lastPressTime).TotalMilliseconds > 600)
			{
				if (onePedalModeCheckbox.Checked)
				{
					if (e.KeyChar != 'b') return;
					PedalPressed();
				}
				else
				{
					switch (e.KeyChar)
					{
						case 'a':
							gongButtonClick(null, null);
							break;
						case 'c':
							minuteButtonClick(null, null);
							break;
					}
				}
			}	

			lastPressTime = DateTime.Now;

		}

		private void KeyboardTimer_Tick(object sender, EventArgs e)
		{

		}

		private void resetButton_Click(object sender, EventArgs e)
		{
			cBtnsIndex = 0;
			RefreshButtons();
			StopTimer();
        }

		private void blitzModeCheckbox_CheckedChanged(object sender, EventArgs e)
		{
			if (blitzModeCheckbox.Checked)
			{
				rountTimeTrackBar.Value = 20;
				BlitzTimer.Enabled = true;
				BlitzLabel.Visible = true;
			} else
			{
				rountTimeTrackBar.Value = 60;
				BlitzTimer.Enabled = false;
				BlitzLabel.Visible = false;
			}
			RefreshSpeedLabel();
		}

		private void BlitzTimer_Tick(object sender, EventArgs e)
		{
			switch ((new Random().Next(5)))
			{
				case 0:
					BlitzLabel.ForeColor = Color.Red;
					break;
				case 1:
					BlitzLabel.ForeColor = Color.Green;
					break;
				case 2:
					BlitzLabel.ForeColor = Color.Orange;
					break;
				case 3:
					BlitzLabel.ForeColor = Color.Black;
					break;
				case 4:
					BlitzLabel.ForeColor = Color.Violet;
					break;
				default:
					BlitzLabel.ForeColor = Color.Blue;
					break;
			}

		}
	}
}
