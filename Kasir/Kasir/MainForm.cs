/*
 * Created by SharpDevelop.
 * User: Potato
 * Date: 4/19/2022
 * Time: 1:53 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace Kasir
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		MySqlCommand cmd;
		MySqlDataAdapter da;
		DataSet ds;
		
		Koneksi Konn = new Koneksi();
		
		public MainForm()
		{	
			InitializeComponent();
		}

		void MainFormLoad(object sender, EventArgs e)
		{
			refresh_func();
		}
		
		
		void UpdateClick(object sender, EventArgs e)
		{
			if (!(kode_barang.Text == "" || nama_barang.Text == "" || harga_beli.Text == "" || harga_jual.Text == "" || jumlah.Text == ""))
			{
				MySqlConnection conn = Konn.GetConn();
				string query = "update tbl_barang set nama_barang='"+nama_barang.Text+"', harga_beli='"+harga_beli.Text+"', harga_jual='"+harga_jual.Text+"', jumlah_barang='"+ jumlah.Text +"', satuan_barang='"+satuan.Text+"' where kode_barang='"+kode_barang.Text+"';";
				cmd = new MySqlCommand(query, conn);
				conn.Open();
				cmd.ExecuteNonQuery();
				MessageBox.Show("Update Data Berhasil!");
				clean();
				refresh_func();
			}
			else
			{
				MessageBox.Show("Input Bermasalah");
			}
		}
		
		void SaveClick(object sender, EventArgs e)
		{
			if (!(kode_barang.Text == "" || nama_barang.Text == "" || harga_beli.Text == "" || harga_jual.Text == "" || jumlah.Text == ""))
			{
				MySqlConnection conn = Konn.GetConn();
				cmd = new MySqlCommand("insert into tbl_barang values ('" + kode_barang.Text + "','" + nama_barang.Text + "','" + harga_beli.Text + "','" + harga_jual.Text + "','" + jumlah.Text + "','" + satuan.Text + "')", conn);
				conn.Open();
				cmd.ExecuteNonQuery();
				MessageBox.Show("Insert Data Berhasil!");
				clean();
				refresh_func();
			}
			else
			{
				MessageBox.Show("Input Bermasalah");
			}
		}
		
		void DeleteClick(object sender, EventArgs e)
		{
			if (kode_barang.Text != "")
			{
				MySqlConnection conn = Konn.GetConn();
				string query = "delete from tbl_barang where kode_barang ='";
				cmd = new MySqlCommand(query + kode_barang.Text + "'", conn);
				conn.Open();
				cmd.ExecuteNonQuery();
				MessageBox.Show("Delete Data Berhasil!");
				clean();
				refresh_func();
			}
		}
		
		void ResetClick(object sender, EventArgs e)
		{
			clean();
		}
		
		void clean()
		{
			cari.Text = "";
			kode_barang.Text = "";
			nama_barang.Text = "";
			harga_beli.Text = "";
			harga_jual.Text = "";
			jumlah.Text = "";
			satuan.Text = "";
		}

		void RefreshClick(object sender, EventArgs e)
		{
			refresh_func();
		}

		void refresh_func()
		{
			MySqlConnection conn = Konn.GetConn();
			try
			{
				conn.Open();
				cmd = new MySqlCommand("select * from tbl_barang", conn);
				ds = new DataSet();
				da = new MySqlDataAdapter(cmd);
				da.Fill(ds, "tbl_barang");
				dataGridView1.DataSource = ds;
				dataGridView1.DataMember = "tbl_barang";
				dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				conn.Close();
			}
		}
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex != -1)
			{
				clean();
				kode_barang.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
				nama_barang.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
				harga_beli.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();			
				harga_jual.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
				jumlah.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
				satuan.SelectedText = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
			}
		}
		
		
	}
}
