using System;
using System.Drawing;
using System.Windows.Forms;

/*
	Tugas II
	- [x] Button
	- [x] Label
	- [x] List Box	
 */
namespace window
{
	class Program
	{
		static void Main(string[] args)
		{
			Form window = new Form()
			{
				Name = "Main",
				Text = "Main",
				Width=300,
				Height=300
			};

			Label myNamelabel = new Label()
			{
				Name ="Name",
				Text = "Name : ",
				Location = new System.Drawing.Point(20,50)
			};

			Label myNametext = new Label()
			{
				Name = "wilson",
				Text = "Wilson",
				Location = new System.Drawing.Point(120,50)
			};

			Label komlabel = new Label()
			{
				Name = "Kom",
				Text = "Kom : ",
				Location = new System.Drawing.Point(20,100)
			};
			ListBox kom = new ListBox();
			kom.Location = new Point(120, 100);
			kom.Size = new Size(50, 50);
			kom.Items.Add("A");
			kom.Items.Add("B");
			kom.Items.Add("C");
			
			Button mybutton = new Button()
			{
				Text = "Submit",
				Location = new System.Drawing.Point(20,160),
				Height=30,
				Width =150
			};

			mybutton.Click += (o,s) =>
			{
				MessageBox.Show("Nama: " + myNametext.Text + "\nKom: A");
			};
			window.Controls.Add(myNamelabel);
			window.Controls.Add(myNametext);
			window.Controls.Add(komlabel);
			window.Controls.Add(kom);
			window.Controls.Add(mybutton);

			window.ShowDialog();
			while (window.Created)
			{
			
			}
		}

	}
}
