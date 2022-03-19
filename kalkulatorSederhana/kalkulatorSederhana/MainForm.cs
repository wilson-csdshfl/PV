/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 3/18/2022
 * Time: 8:37 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace kalkulatorSederhana
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, System.EventArgs e)
		{
			if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
			{
				MessageBox.Show("angka 1 dan angka 2 tidak boleh kosong");
			}
			else
			{
				int a, b, c;
				a = int.Parse(this.textBox1.Text);
				b = int.Parse(this.textBox2.Text);
				c = a + b;
				this.LBLhasil.Text = c.ToString();
			}
		}

		void Button2Click(object sender, System.EventArgs e)
		{
			if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
			{
				MessageBox.Show("angka 1 dan angka 2 tidak boleh kosong");
			}
			else
			{
				int a, b, c;
				a = int.Parse(this.textBox1.Text);
				b = int.Parse(this.textBox2.Text);
				c = a - b;
				this.LBLhasil.Text = c.ToString();
			}
		}
		
		void Button3Click(object sender, System.EventArgs e)
		{
			if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
			{
				MessageBox.Show("angka 1 dan angka 2 tidak boleh kosong");
			}
			else
			{
				int a, b, c;
				a = int.Parse(this.textBox1.Text);
				b = int.Parse(this.textBox2.Text);
				c = a * b;
				this.LBLhasil.Text = c.ToString();
			}
		}
		
		void Button4Click(object sender, System.EventArgs e)
		{
			if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
			{
				MessageBox.Show("angka 1 dan angka 2 tidak boleh kosong");
			}
			else
			{
				float a, b, c;
				a = float.Parse(this.textBox1.Text);
				b = float.Parse(this.textBox2.Text);
				c = a / b;
				this.LBLhasil.Text = c.ToString();
			}
		}
		
		void Button5Click(object sender, System.EventArgs e)
		{
			textBox1.Clear();
			textBox2.Clear();
			this.LBLhasil.Text="";
		}
	}
}
