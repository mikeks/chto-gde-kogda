﻿namespace ChtoGdeKogda
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
			this.TimerMin = new System.Windows.Forms.Timer(this.components);
			this.wmp = new AxWMPLib.AxWindowsMediaPlayer();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.label2 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.button3 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.wmp)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// TimerMin
			// 
			this.TimerMin.Interval = 1000;
			this.TimerMin.Tick += new System.EventHandler(this.TimerMin_Tick);
			// 
			// wmp
			// 
			this.wmp.Enabled = true;
			this.wmp.Location = new System.Drawing.Point(12, 219);
			this.wmp.Name = "wmp";
			this.wmp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmp.OcxState")));
			this.wmp.Size = new System.Drawing.Size(323, 136);
			this.wmp.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(248, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(374, 158);
			this.button1.TabIndex = 1;
			this.button1.Text = "МИНУТА!";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(360, 219);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(175, 135);
			this.label1.TabIndex = 2;
			this.label1.Text = "00";
			this.label1.Visible = false;
			// 
			// trackBar1
			// 
			this.trackBar1.LargeChange = 10;
			this.trackBar1.Location = new System.Drawing.Point(15, 374);
			this.trackBar1.Maximum = 70;
			this.trackBar1.Minimum = 50;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(277, 45);
			this.trackBar1.SmallChange = 10;
			this.trackBar1.TabIndex = 3;
			this.trackBar1.TickFrequency = 2;
			this.trackBar1.Value = 60;
			this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(23, 396);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "label2";
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(12, 12);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(230, 158);
			this.button2.TabIndex = 5;
			this.button2.Text = "Внимание! Вопрос!";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button4
			// 
			this.button4.Dock = System.Windows.Forms.DockStyle.Right;
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(1093, 0);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(210, 124);
			this.button4.TabIndex = 7;
			this.button4.Text = "А теперь внимание -- РАЗДАТОЧНЫЙ МАТЕРИАЛ";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.Dock = System.Windows.Forms.DockStyle.Left;
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.Location = new System.Drawing.Point(0, 0);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(242, 124);
			this.button5.TabIndex = 8;
			this.button5.Text = "НАЧАЛО ВТОРОГО И ТРЕТЬЕГО ТУРА";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button6
			// 
			this.button6.Dock = System.Windows.Forms.DockStyle.Left;
			this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.Location = new System.Drawing.Point(242, 0);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(293, 124);
			this.button6.TabIndex = 9;
			this.button6.Text = "НАЧАЛО ПЕРВОГО ТУРА";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button7
			// 
			this.button7.Dock = System.Windows.Forms.DockStyle.Right;
			this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button7.Location = new System.Drawing.Point(887, 0);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(206, 124);
			this.button7.TabIndex = 10;
			this.button7.Text = "ОБЪЯВЛЕНИЕ ИТОГОВ ИГРЫ";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(15, 425);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(129, 74);
			this.button8.TabIndex = 11;
			this.button8.Text = "10 sec snd";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button6);
			this.panel1.Controls.Add(this.button5);
			this.panel1.Controls.Add(this.button7);
			this.panel1.Controls.Add(this.button4);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 688);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1303, 124);
			this.panel1.TabIndex = 12;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.button3);
			this.panel2.Controls.Add(this.button2);
			this.panel2.Controls.Add(this.button1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1303, 192);
			this.panel2.TabIndex = 13;
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(628, 12);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(307, 158);
			this.button3.TabIndex = 6;
			this.button3.Text = "Внимание! Правильный ответ!";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click_1);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1303, 812);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.trackBar1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.wmp);
			this.KeyPreview = true;
			this.Name = "Form1";
			this.Text = "ЧТО? ГДЕ? КОГДА? - ФИЛАДЕЛЬФИЯ";
			this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
			((System.ComponentModel.ISupportInitialize)(this.wmp)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Timer TimerMin;
		private AxWMPLib.AxWindowsMediaPlayer wmp;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button button3;
	}
}
