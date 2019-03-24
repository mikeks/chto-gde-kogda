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
			wmp.uiMode = "none";
			tbVolume_Scroll(null, null);
		}

		private void StopTimer()
		{
			MinuteTimer.Enabled = false;
			label1.Visible = false;
//			button1.BackColor = Color.DeepSkyBlue;
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
//				button1.BackColor = Color.Red;
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
				//label1.ForeColor = Color.Red;
            }
			else if (tm >= tmEnd)
			{

				wmp.URL = "min-start.mp3";
				StopTimer();

			} else
			{
				//label1.ForeColor = Color.Coral;
			}
		}

		private void RefreshSpeedLabel()
		{
			tm10sec = rountTimeTrackBar.Value;
			tmEnd = tm10sec + 10;
			label2.Text = string.Format("Время: {0}/{1} сек.", tm10sec, tmEnd);
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

		private void btnRazd_Click(object sender, EventArgs e)
		{
			wmp.URL = "razd-mat.mp3";
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

		private void btnIntroduce_Click(object sender, EventArgs e)
		{
			wmp.URL = "intro.mp3";
		}

		private void btnRightAnswer_Click_1(object sender, EventArgs e)
		{
			wmp.URL = "rightAnswer.mp3";
		}

		private void btnWrongAnswer_Click(object sender, EventArgs e)
		{
			wmp.URL = "wrongAnswer.mp3";
		}

		private void btnZero_Click(object sender, EventArgs e)
		{
			wmp.URL = "zero.mp3";
		}

		private void btnVolchok_Click(object sender, EventArgs e)
		{
			var fn = "to-gde-kogda-volchok.mp3";
			wmp.URL = wmp.URL == null || !wmp.URL.Contains(fn) ? fn : null;
		}

		private int cBtnsIndex = 0;
		private Button cBtn;



		DateTime lastPressTime;

		private void Form1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((DateTime.Now - lastPressTime).TotalMilliseconds > 600)
			{
				switch (e.KeyChar)
				{
					case 'a':
					case 'ф':
						gongButtonClick(null, null);
						break;
					case 'c':
					case 'с': // they are different!
						minuteButtonClick(null, null);
						break;
					case 'b':
					case 'и':
						if (!miUseMiddlePedal.Checked) return;
						btnVolchok_Click(null, null);
						break;
				}
			}	

			lastPressTime = DateTime.Now;

		}



		private void blitzModeCheckbox_CheckedChanged(object sender, EventArgs e)
		{
			if (blitzModeCheckbox.Checked)
			{
				rountTimeTrackBar.Value = 10;
				BlitzLabel.Visible = true;
				BlitzTimer.Enabled = true;
			} else
			{
				rountTimeTrackBar.Value = 50;
				BlitzLabel.Visible = false;
				BlitzTimer.Enabled = false;
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
					BlitzLabel.ForeColor = Color.White;
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



		private void btnStop_Click(object sender, EventArgs e)
		{
			wmp.URL = null;
			
		}

		private void button3_Click_1(object sender, EventArgs e)
		{
			wmp.settings.volume = 10;
		}

		private void tbVolume_Scroll(object sender, EventArgs e)
		{
			wmp.settings.volume = tbVolume.Value;
			lbVolume.Text = $"Громкость: {tbVolume.Value}%";
		}

		private void miShowPlayer_Click(object sender, EventArgs e)
		{
			if (miShowPlayer.Checked)
				wmp.uiMode = "full";
			else
				wmp.uiMode = "none";
		}

		int initialFadeOutVolume;

		private void btnFadeOut_Click(object sender, EventArgs e)
		{
			if (FadeOutTimer.Enabled || string.IsNullOrEmpty(wmp.URL)) return;
			FadeOutTimer.Enabled = true;
			initialFadeOutVolume = wmp.settings.volume;
		}

		private void FadeOutTimer_Tick(object sender, EventArgs e)
		{
			if (wmp.settings.volume > 10)
			{
				//wmp.settings.volume -= 5;
				tbVolume.Value -= 4;
				tbVolume_Scroll(null, null);
			} else
			{
				wmp.URL = null;
				tbVolume.Value = initialFadeOutVolume;
				tbVolume_Scroll(null, null);
				//wmp.settings.volume = initialFadeOutVolume;
				FadeOutTimer.Enabled = false;
			}
		}
	}
}
