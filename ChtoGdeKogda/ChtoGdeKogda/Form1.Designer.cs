namespace ChtoGdeKogda
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.MinuteTimer = new System.Windows.Forms.Timer(this.components);
			this.button1 = new System.Windows.Forms.Button();
			this.rountTimeTrackBar = new System.Windows.Forms.TrackBar();
			this.label2 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.btnSecondTour = new System.Windows.Forms.Button();
			this.btnFirstTour = new System.Windows.Forms.Button();
			this.btnFinishLost = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.blitzModeCheckbox = new System.Windows.Forms.CheckBox();
			this.BlitzLabel = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.BlitzTimer = new System.Windows.Forms.Timer(this.components);
			this.btnIntroduce = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnRazd = new System.Windows.Forms.Button();
			this.btnVolchok = new System.Windows.Forms.Button();
			this.btnRightAnswer = new System.Windows.Forms.Button();
			this.btnWrongAnswer = new System.Windows.Forms.Button();
			this.btnZero = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.чГКToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.miShowPlayer = new System.Windows.Forms.ToolStripMenuItem();
			this.miUseMiddlePedal = new System.Windows.Forms.ToolStripMenuItem();
			this.FadeOutTimer = new System.Windows.Forms.Timer(this.components);
			this.panel3 = new System.Windows.Forms.Panel();
			this.wmp = new AxWMPLib.AxWindowsMediaPlayer();
			this.btnFadeOut = new System.Windows.Forms.Button();
			this.lbVolume = new System.Windows.Forms.Label();
			this.tbVolume = new System.Windows.Forms.TrackBar();
			this.btnStop = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.rountTimeTrackBar)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.wmp)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbVolume)).BeginInit();
			this.SuspendLayout();
			// 
			// MinuteTimer
			// 
			this.MinuteTimer.Interval = 1000;
			this.MinuteTimer.Tick += new System.EventHandler(this.TimerMin_Tick);
			// 
			// button1
			// 
			this.button1.Dock = System.Windows.Forms.DockStyle.Left;
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
			this.button1.ForeColor = System.Drawing.Color.Coral;
			this.button1.Location = new System.Drawing.Point(230, 0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(242, 192);
			this.button1.TabIndex = 1;
			this.button1.Text = "Минута";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.minuteButtonClick);
			// 
			// rountTimeTrackBar
			// 
			this.rountTimeTrackBar.BackColor = System.Drawing.Color.Black;
			this.rountTimeTrackBar.LargeChange = 10;
			this.rountTimeTrackBar.Location = new System.Drawing.Point(12, 242);
			this.rountTimeTrackBar.Maximum = 70;
			this.rountTimeTrackBar.Minimum = 10;
			this.rountTimeTrackBar.Name = "rountTimeTrackBar";
			this.rountTimeTrackBar.Size = new System.Drawing.Size(348, 45);
			this.rountTimeTrackBar.SmallChange = 10;
			this.rountTimeTrackBar.TabIndex = 3;
			this.rountTimeTrackBar.TickFrequency = 2;
			this.rountTimeTrackBar.Value = 50;
			this.rountTimeTrackBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Black;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.Color.Coral;
			this.label2.Location = new System.Drawing.Point(12, 219);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "label2";
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Black;
			this.button2.Dock = System.Windows.Forms.DockStyle.Left;
			this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.Coral;
			this.button2.Location = new System.Drawing.Point(0, 0);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(230, 192);
			this.button2.TabIndex = 5;
			this.button2.Text = "Гонг";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.gongButtonClick);
			// 
			// btnSecondTour
			// 
			this.btnSecondTour.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnSecondTour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSecondTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSecondTour.ForeColor = System.Drawing.Color.Coral;
			this.btnSecondTour.Location = new System.Drawing.Point(535, 0);
			this.btnSecondTour.Name = "btnSecondTour";
			this.btnSecondTour.Size = new System.Drawing.Size(242, 124);
			this.btnSecondTour.TabIndex = 8;
			this.btnSecondTour.Text = "НАЧАЛО ВТОРОГО И ТРЕТЬЕГО ТУРА";
			this.btnSecondTour.UseVisualStyleBackColor = true;
			this.btnSecondTour.Click += new System.EventHandler(this.button5_Click);
			// 
			// btnFirstTour
			// 
			this.btnFirstTour.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnFirstTour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFirstTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFirstTour.ForeColor = System.Drawing.Color.Coral;
			this.btnFirstTour.Location = new System.Drawing.Point(242, 0);
			this.btnFirstTour.Name = "btnFirstTour";
			this.btnFirstTour.Size = new System.Drawing.Size(293, 124);
			this.btnFirstTour.TabIndex = 9;
			this.btnFirstTour.Text = "НАЧАЛО ПЕРВОГО ТУРА";
			this.btnFirstTour.UseVisualStyleBackColor = true;
			this.btnFirstTour.Click += new System.EventHandler(this.button6_Click);
			// 
			// btnFinishLost
			// 
			this.btnFinishLost.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnFinishLost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFinishLost.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.btnFinishLost.ForeColor = System.Drawing.Color.Coral;
			this.btnFinishLost.Location = new System.Drawing.Point(1391, 0);
			this.btnFinishLost.Name = "btnFinishLost";
			this.btnFinishLost.Size = new System.Drawing.Size(206, 124);
			this.btnFinishLost.TabIndex = 10;
			this.btnFinishLost.Text = "ОБЪЯВЛЕНИЕ ИТОГОВ Проигрыш знатоков";
			this.btnFinishLost.UseVisualStyleBackColor = true;
			this.btnFinishLost.Click += new System.EventHandler(this.button7_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Black;
			this.panel1.Controls.Add(this.btnSecondTour);
			this.panel1.Controls.Add(this.btnFirstTour);
			this.panel1.Controls.Add(this.btnFinishLost);
			this.panel1.Controls.Add(this.btnIntroduce);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 781);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1597, 124);
			this.panel1.TabIndex = 12;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Black;
			this.panel2.Controls.Add(this.btnWrongAnswer);
			this.panel2.Controls.Add(this.btnRightAnswer);
			this.panel2.Controls.Add(this.btnVolchok);
			this.panel2.Controls.Add(this.btnZero);
			this.panel2.Controls.Add(this.btnRazd);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.button1);
			this.panel2.Controls.Add(this.button2);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 24);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1597, 192);
			this.panel2.TabIndex = 13;
			// 
			// blitzModeCheckbox
			// 
			this.blitzModeCheckbox.AutoSize = true;
			this.blitzModeCheckbox.BackColor = System.Drawing.Color.Black;
			this.blitzModeCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.blitzModeCheckbox.ForeColor = System.Drawing.Color.Coral;
			this.blitzModeCheckbox.Location = new System.Drawing.Point(16, 293);
			this.blitzModeCheckbox.Name = "blitzModeCheckbox";
			this.blitzModeCheckbox.Size = new System.Drawing.Size(230, 41);
			this.blitzModeCheckbox.TabIndex = 14;
			this.blitzModeCheckbox.Text = "Режим Блица";
			this.blitzModeCheckbox.UseVisualStyleBackColor = false;
			this.blitzModeCheckbox.CheckedChanged += new System.EventHandler(this.blitzModeCheckbox_CheckedChanged);
			// 
			// BlitzLabel
			// 
			this.BlitzLabel.AutoSize = true;
			this.BlitzLabel.BackColor = System.Drawing.Color.Black;
			this.BlitzLabel.Font = new System.Drawing.Font("Blackoak Std", 130F, System.Drawing.FontStyle.Bold);
			this.BlitzLabel.ForeColor = System.Drawing.Color.Brown;
			this.BlitzLabel.Location = new System.Drawing.Point(414, 273);
			this.BlitzLabel.Name = "BlitzLabel";
			this.BlitzLabel.Size = new System.Drawing.Size(762, 233);
			this.BlitzLabel.TabIndex = 16;
			this.BlitzLabel.Text = "БЛИЦ!";
			this.BlitzLabel.Visible = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Black;
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 24);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1597, 881);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 17;
			this.pictureBox1.TabStop = false;
			// 
			// BlitzTimer
			// 
			this.BlitzTimer.Tick += new System.EventHandler(this.BlitzTimer_Tick);
			// 
			// btnIntroduce
			// 
			this.btnIntroduce.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnIntroduce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnIntroduce.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIntroduce.ForeColor = System.Drawing.Color.Coral;
			this.btnIntroduce.Location = new System.Drawing.Point(0, 0);
			this.btnIntroduce.Name = "btnIntroduce";
			this.btnIntroduce.Size = new System.Drawing.Size(242, 124);
			this.btnIntroduce.TabIndex = 12;
			this.btnIntroduce.Text = "Представление игроков";
			this.btnIntroduce.UseVisualStyleBackColor = true;
			this.btnIntroduce.Click += new System.EventHandler(this.btnIntroduce_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Black;
			this.label1.Dock = System.Windows.Forms.DockStyle.Left;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 120F);
			this.label1.ForeColor = System.Drawing.Color.Coral;
			this.label1.Location = new System.Drawing.Point(472, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(255, 181);
			this.label1.TabIndex = 8;
			this.label1.Text = "00";
			this.label1.Visible = false;
			// 
			// btnRazd
			// 
			this.btnRazd.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnRazd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRazd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRazd.ForeColor = System.Drawing.Color.Coral;
			this.btnRazd.Location = new System.Drawing.Point(1414, 0);
			this.btnRazd.Name = "btnRazd";
			this.btnRazd.Size = new System.Drawing.Size(183, 192);
			this.btnRazd.TabIndex = 9;
			this.btnRazd.Text = "Раздаточный материал";
			this.btnRazd.UseVisualStyleBackColor = true;
			this.btnRazd.Click += new System.EventHandler(this.btnRazd_Click);
			// 
			// btnVolchok
			// 
			this.btnVolchok.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnVolchok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnVolchok.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVolchok.ForeColor = System.Drawing.Color.Coral;
			this.btnVolchok.Location = new System.Drawing.Point(1135, 0);
			this.btnVolchok.Name = "btnVolchok";
			this.btnVolchok.Size = new System.Drawing.Size(154, 192);
			this.btnVolchok.TabIndex = 12;
			this.btnVolchok.Text = "Волчок";
			this.btnVolchok.UseVisualStyleBackColor = true;
			this.btnVolchok.Click += new System.EventHandler(this.btnVolchok_Click);
			// 
			// btnRightAnswer
			// 
			this.btnRightAnswer.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnRightAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRightAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRightAnswer.ForeColor = System.Drawing.Color.Coral;
			this.btnRightAnswer.Location = new System.Drawing.Point(974, 0);
			this.btnRightAnswer.Name = "btnRightAnswer";
			this.btnRightAnswer.Size = new System.Drawing.Size(161, 192);
			this.btnRightAnswer.TabIndex = 14;
			this.btnRightAnswer.Text = "Верный ответ";
			this.btnRightAnswer.UseVisualStyleBackColor = true;
			this.btnRightAnswer.Click += new System.EventHandler(this.btnRightAnswer_Click_1);
			// 
			// btnWrongAnswer
			// 
			this.btnWrongAnswer.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnWrongAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnWrongAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnWrongAnswer.ForeColor = System.Drawing.Color.Coral;
			this.btnWrongAnswer.Location = new System.Drawing.Point(813, 0);
			this.btnWrongAnswer.Name = "btnWrongAnswer";
			this.btnWrongAnswer.Size = new System.Drawing.Size(161, 192);
			this.btnWrongAnswer.TabIndex = 15;
			this.btnWrongAnswer.Text = "Неверный ответ";
			this.btnWrongAnswer.UseVisualStyleBackColor = true;
			this.btnWrongAnswer.Click += new System.EventHandler(this.btnWrongAnswer_Click);
			// 
			// btnZero
			// 
			this.btnZero.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnZero.ForeColor = System.Drawing.Color.Coral;
			this.btnZero.Location = new System.Drawing.Point(1289, 0);
			this.btnZero.Name = "btnZero";
			this.btnZero.Size = new System.Drawing.Size(125, 192);
			this.btnZero.TabIndex = 16;
			this.btnZero.Text = "13 сектор";
			this.btnZero.UseVisualStyleBackColor = true;
			this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.чГКToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1597, 24);
			this.menuStrip1.TabIndex = 22;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// чГКToolStripMenuItem
			// 
			this.чГКToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miShowPlayer,
            this.miUseMiddlePedal});
			this.чГКToolStripMenuItem.Name = "чГКToolStripMenuItem";
			this.чГКToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
			this.чГКToolStripMenuItem.Text = "ЧГК";
			// 
			// miShowPlayer
			// 
			this.miShowPlayer.CheckOnClick = true;
			this.miShowPlayer.Name = "miShowPlayer";
			this.miShowPlayer.Size = new System.Drawing.Size(247, 22);
			this.miShowPlayer.Text = "Показать плейр";
			this.miShowPlayer.Click += new System.EventHandler(this.miShowPlayer_Click);
			// 
			// miUseMiddlePedal
			// 
			this.miUseMiddlePedal.Checked = true;
			this.miUseMiddlePedal.CheckOnClick = true;
			this.miUseMiddlePedal.CheckState = System.Windows.Forms.CheckState.Checked;
			this.miUseMiddlePedal.Name = "miUseMiddlePedal";
			this.miUseMiddlePedal.Size = new System.Drawing.Size(247, 22);
			this.miUseMiddlePedal.Text = "Использовать среднюю педаль";
			// 
			// FadeOutTimer
			// 
			this.FadeOutTimer.Tick += new System.EventHandler(this.FadeOutTimer_Tick);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Black;
			this.panel3.Controls.Add(this.btnFadeOut);
			this.panel3.Controls.Add(this.lbVolume);
			this.panel3.Controls.Add(this.tbVolume);
			this.panel3.Controls.Add(this.btnStop);
			this.panel3.Controls.Add(this.wmp);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel3.Location = new System.Drawing.Point(1223, 216);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(374, 565);
			this.panel3.TabIndex = 25;
			// 
			// wmp
			// 
			this.wmp.Enabled = true;
			this.wmp.Location = new System.Drawing.Point(17, 6);
			this.wmp.Name = "wmp";
			this.wmp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmp.OcxState")));
			this.wmp.Size = new System.Drawing.Size(348, 185);
			this.wmp.TabIndex = 1;
			// 
			// btnFadeOut
			// 
			this.btnFadeOut.BackColor = System.Drawing.Color.Black;
			this.btnFadeOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFadeOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
			this.btnFadeOut.ForeColor = System.Drawing.Color.Coral;
			this.btnFadeOut.Location = new System.Drawing.Point(14, 269);
			this.btnFadeOut.Name = "btnFadeOut";
			this.btnFadeOut.Size = new System.Drawing.Size(348, 68);
			this.btnFadeOut.TabIndex = 28;
			this.btnFadeOut.Text = "Плавно убрать музыку";
			this.btnFadeOut.UseVisualStyleBackColor = false;
			this.btnFadeOut.Click += new System.EventHandler(this.btnFadeOut_Click);
			// 
			// lbVolume
			// 
			this.lbVolume.AutoSize = true;
			this.lbVolume.BackColor = System.Drawing.Color.Black;
			this.lbVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbVolume.ForeColor = System.Drawing.Color.Coral;
			this.lbVolume.Location = new System.Drawing.Point(14, 203);
			this.lbVolume.Name = "lbVolume";
			this.lbVolume.Size = new System.Drawing.Size(90, 20);
			this.lbVolume.TabIndex = 27;
			this.lbVolume.Text = "Громкость";
			// 
			// tbVolume
			// 
			this.tbVolume.BackColor = System.Drawing.Color.Black;
			this.tbVolume.LargeChange = 10;
			this.tbVolume.Location = new System.Drawing.Point(18, 226);
			this.tbVolume.Maximum = 100;
			this.tbVolume.Name = "tbVolume";
			this.tbVolume.Size = new System.Drawing.Size(344, 45);
			this.tbVolume.SmallChange = 10;
			this.tbVolume.TabIndex = 26;
			this.tbVolume.TickFrequency = 2;
			this.tbVolume.Value = 50;
			this.tbVolume.Scroll += new System.EventHandler(this.tbVolume_Scroll);
			// 
			// btnStop
			// 
			this.btnStop.BackColor = System.Drawing.Color.Black;
			this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
			this.btnStop.ForeColor = System.Drawing.Color.Coral;
			this.btnStop.Location = new System.Drawing.Point(14, 343);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(348, 68);
			this.btnStop.TabIndex = 25;
			this.btnStop.Text = "Оборвать музыку";
			this.btnStop.UseVisualStyleBackColor = false;
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1597, 905);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.BlitzLabel);
			this.Controls.Add(this.blitzModeCheckbox);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.rountTimeTrackBar);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.menuStrip1);
			this.KeyPreview = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "ЧТО? ГДЕ? КОГДА? - ФИЛАДЕЛЬФИЯ";
			this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
			((System.ComponentModel.ISupportInitialize)(this.rountTimeTrackBar)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.wmp)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbVolume)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Timer MinuteTimer;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TrackBar rountTimeTrackBar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button btnSecondTour;
		private System.Windows.Forms.Button btnFirstTour;
		private System.Windows.Forms.Button btnFinishLost;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.CheckBox blitzModeCheckbox;
		private System.Windows.Forms.Label BlitzLabel;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Timer BlitzTimer;
		private System.Windows.Forms.Button btnIntroduce;
		private System.Windows.Forms.Button btnVolchok;
		private System.Windows.Forms.Button btnRazd;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnRightAnswer;
		private System.Windows.Forms.Button btnWrongAnswer;
		private System.Windows.Forms.Button btnZero;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem чГКToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem miShowPlayer;
		private System.Windows.Forms.ToolStripMenuItem miUseMiddlePedal;
		private System.Windows.Forms.Timer FadeOutTimer;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button btnFadeOut;
		private System.Windows.Forms.Label lbVolume;
		private System.Windows.Forms.TrackBar tbVolume;
		private System.Windows.Forms.Button btnStop;
		private AxWMPLib.AxWindowsMediaPlayer wmp;
	}
}

