/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 5/18/2024
 * Time: 4:15 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace shapesDrawings
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.TextBox txtx;
		private System.Windows.Forms.TextBox txtw;
		private System.Windows.Forms.TextBox txth;
		private System.Windows.Forms.TextBox txty;
		private System.Windows.Forms.TextBox txttip;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtfnt;
		private System.Windows.Forms.TextBox txtfgc;
		private System.Windows.Forms.TextBox txtbgc;
		private System.Windows.Forms.Button button7;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.txtx = new System.Windows.Forms.TextBox();
			this.txtw = new System.Windows.Forms.TextBox();
			this.txth = new System.Windows.Forms.TextBox();
			this.txty = new System.Windows.Forms.TextBox();
			this.txttip = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtfnt = new System.Windows.Forms.TextBox();
			this.txtfgc = new System.Windows.Forms.TextBox();
			this.txtbgc = new System.Windows.Forms.TextBox();
			this.button7 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Location = new System.Drawing.Point(13, 13);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1183, 505);
			this.panel1.TabIndex = 0;
			this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1MouseDown);
			// 
			// button1
			// 
			this.button1.Enabled = false;
			this.button1.Location = new System.Drawing.Point(1207, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "RECT";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Enabled = false;
			this.button2.Location = new System.Drawing.Point(1207, 41);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "CIRCLE";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.Enabled = false;
			this.button3.Location = new System.Drawing.Point(1207, 71);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 3;
			this.button3.Text = "LINE";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(1207, 593);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 4;
			this.button4.Text = "CLRSCR";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(1203, 517);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 65);
			this.button5.TabIndex = 5;
			this.button5.Text = "RE DRAW ALL";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// button6
			// 
			this.button6.Enabled = false;
			this.button6.Location = new System.Drawing.Point(1207, 100);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(75, 23);
			this.button6.TabIndex = 6;
			this.button6.Text = "addShape";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.Button6Click);
			// 
			// txtx
			// 
			this.txtx.Location = new System.Drawing.Point(13, 548);
			this.txtx.Name = "txtx";
			this.txtx.Size = new System.Drawing.Size(100, 20);
			this.txtx.TabIndex = 7;
			// 
			// txtw
			// 
			this.txtw.Location = new System.Drawing.Point(120, 548);
			this.txtw.Name = "txtw";
			this.txtw.Size = new System.Drawing.Size(100, 20);
			this.txtw.TabIndex = 8;
			// 
			// txth
			// 
			this.txth.Location = new System.Drawing.Point(120, 596);
			this.txth.Name = "txth";
			this.txth.Size = new System.Drawing.Size(100, 20);
			this.txth.TabIndex = 10;
			// 
			// txty
			// 
			this.txty.Location = new System.Drawing.Point(12, 596);
			this.txty.Name = "txty";
			this.txty.Size = new System.Drawing.Size(100, 20);
			this.txty.TabIndex = 9;
			// 
			// txttip
			// 
			this.txttip.Location = new System.Drawing.Point(227, 548);
			this.txttip.Name = "txttip";
			this.txttip.Size = new System.Drawing.Size(100, 20);
			this.txttip.TabIndex = 11;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 522);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 12;
			this.label1.Text = "x";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(120, 522);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 13;
			this.label2.Text = "w";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(226, 522);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 14;
			this.label3.Text = "tip";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(14, 570);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 15;
			this.label4.Text = "y";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(120, 571);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 16;
			this.label5.Text = "h";
			// 
			// label6
			// 
			this.label6.Enabled = false;
			this.label6.Location = new System.Drawing.Point(356, 570);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 22;
			this.label6.Text = "font";
			// 
			// label7
			// 
			this.label7.Enabled = false;
			this.label7.Location = new System.Drawing.Point(464, 522);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 21;
			this.label7.Text = "foreground";
			// 
			// label8
			// 
			this.label8.Enabled = false;
			this.label8.Location = new System.Drawing.Point(356, 522);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 20;
			this.label8.Text = "background";
			// 
			// txtfnt
			// 
			this.txtfnt.Enabled = false;
			this.txtfnt.Location = new System.Drawing.Point(357, 596);
			this.txtfnt.Name = "txtfnt";
			this.txtfnt.Size = new System.Drawing.Size(100, 20);
			this.txtfnt.TabIndex = 19;
			// 
			// txtfgc
			// 
			this.txtfgc.Enabled = false;
			this.txtfgc.Location = new System.Drawing.Point(464, 548);
			this.txtfgc.Name = "txtfgc";
			this.txtfgc.Size = new System.Drawing.Size(100, 20);
			this.txtfgc.TabIndex = 18;
			// 
			// txtbgc
			// 
			this.txtbgc.Enabled = false;
			this.txtbgc.Location = new System.Drawing.Point(357, 548);
			this.txtbgc.Name = "txtbgc";
			this.txtbgc.Size = new System.Drawing.Size(100, 20);
			this.txtbgc.TabIndex = 17;
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(604, 545);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(75, 65);
			this.button7.TabIndex = 23;
			this.button7.Text = "add shape";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.Button7Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1294, 644);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtfnt);
			this.Controls.Add(this.txtfgc);
			this.Controls.Add(this.txtbgc);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txttip);
			this.Controls.Add(this.txth);
			this.Controls.Add(this.txty);
			this.Controls.Add(this.txtw);
			this.Controls.Add(this.txtx);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.panel1);
			this.Name = "MainForm";
			this.Text = "shapesDrawings";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
