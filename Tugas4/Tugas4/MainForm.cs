/*
 * Created by SharpDevelop.
 * User: John
 * Date: 3/8/2022
 * Time: 8:36 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Tugas4
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
		
		void Button1Click(object sender, EventArgs e)
		{
			MessageBox.Show("Nama \t   : " + this.textBox1.Text + "\nNIM \t   : " + this.textBox2.Text + "\nKelas \t   : " + comboBox1.SelectedItem + "\nMata Kuliah : " + this.textBox3.Text);
		}
	}
}
