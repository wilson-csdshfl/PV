/*
 * Created by SharpDevelop.
 * User: Potato
 * Date: 4/19/2022
 * Time: 1:53 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Kasir
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.label_cari = new System.Windows.Forms.Label();
			this.label_harga_jual = new System.Windows.Forms.Label();
			this.label_harga_beli = new System.Windows.Forms.Label();
			this.label_nama_barang = new System.Windows.Forms.Label();
			this.label_kode_barang = new System.Windows.Forms.Label();
			this.label_satuan = new System.Windows.Forms.Label();
			this.label_jumlah = new System.Windows.Forms.Label();
			this.cari = new System.Windows.Forms.TextBox();
			this.jumlah = new System.Windows.Forms.TextBox();
			this.harga_jual = new System.Windows.Forms.TextBox();
			this.harga_beli = new System.Windows.Forms.TextBox();
			this.nama_barang = new System.Windows.Forms.TextBox();
			this.kode_barang = new System.Windows.Forms.TextBox();
			this.satuan = new System.Windows.Forms.ComboBox();
			this.search = new System.Windows.Forms.Button();
			this.update = new System.Windows.Forms.Button();
			this.refresh = new System.Windows.Forms.Button();
			this.reset = new System.Windows.Forms.Button();
			this.delete = new System.Windows.Forms.Button();
			this.save = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label_cari
			// 
			this.label_cari.Location = new System.Drawing.Point(12, 18);
			this.label_cari.Name = "label_cari";
			this.label_cari.Size = new System.Drawing.Size(100, 23);
			this.label_cari.TabIndex = 0;
			this.label_cari.Text = "Cari";
			// 
			// label_harga_jual
			// 
			this.label_harga_jual.Location = new System.Drawing.Point(12, 119);
			this.label_harga_jual.Name = "label_harga_jual";
			this.label_harga_jual.Size = new System.Drawing.Size(100, 23);
			this.label_harga_jual.TabIndex = 1;
			this.label_harga_jual.Text = "Harga Jual";
			// 
			// label_harga_beli
			// 
			this.label_harga_beli.Location = new System.Drawing.Point(12, 96);
			this.label_harga_beli.Name = "label_harga_beli";
			this.label_harga_beli.Size = new System.Drawing.Size(100, 23);
			this.label_harga_beli.TabIndex = 2;
			this.label_harga_beli.Text = "Harga Beli";
			// 
			// label_nama_barang
			// 
			this.label_nama_barang.Location = new System.Drawing.Point(12, 73);
			this.label_nama_barang.Name = "label_nama_barang";
			this.label_nama_barang.Size = new System.Drawing.Size(100, 23);
			this.label_nama_barang.TabIndex = 3;
			this.label_nama_barang.Text = "Nama Barang";
			// 
			// label_kode_barang
			// 
			this.label_kode_barang.Location = new System.Drawing.Point(12, 50);
			this.label_kode_barang.Name = "label_kode_barang";
			this.label_kode_barang.Size = new System.Drawing.Size(100, 23);
			this.label_kode_barang.TabIndex = 4;
			this.label_kode_barang.Text = "Kode Barang";
			// 
			// label_satuan
			// 
			this.label_satuan.Location = new System.Drawing.Point(12, 165);
			this.label_satuan.Name = "label_satuan";
			this.label_satuan.Size = new System.Drawing.Size(100, 23);
			this.label_satuan.TabIndex = 5;
			this.label_satuan.Text = "Satuan";
			// 
			// label_jumlah
			// 
			this.label_jumlah.Location = new System.Drawing.Point(12, 142);
			this.label_jumlah.Name = "label_jumlah";
			this.label_jumlah.Size = new System.Drawing.Size(100, 23);
			this.label_jumlah.TabIndex = 6;
			this.label_jumlah.Text = "Jumlah";
			// 
			// cari
			// 
			this.cari.Location = new System.Drawing.Point(118, 12);
			this.cari.Name = "cari";
			this.cari.Size = new System.Drawing.Size(345, 20);
			this.cari.TabIndex = 7;
			// 
			// jumlah
			// 
			this.jumlah.Location = new System.Drawing.Point(118, 139);
			this.jumlah.Name = "jumlah";
			this.jumlah.Size = new System.Drawing.Size(345, 20);
			this.jumlah.TabIndex = 9;
			// 
			// harga_jual
			// 
			this.harga_jual.Location = new System.Drawing.Point(118, 116);
			this.harga_jual.Name = "harga_jual";
			this.harga_jual.Size = new System.Drawing.Size(345, 20);
			this.harga_jual.TabIndex = 10;
			// 
			// harga_beli
			// 
			this.harga_beli.Location = new System.Drawing.Point(118, 93);
			this.harga_beli.Name = "harga_beli";
			this.harga_beli.Size = new System.Drawing.Size(345, 20);
			this.harga_beli.TabIndex = 11;
			// 
			// nama_barang
			// 
			this.nama_barang.Location = new System.Drawing.Point(118, 70);
			this.nama_barang.Name = "nama_barang";
			this.nama_barang.Size = new System.Drawing.Size(345, 20);
			this.nama_barang.TabIndex = 12;
			// 
			// kode_barang
			// 
			this.kode_barang.Location = new System.Drawing.Point(118, 47);
			this.kode_barang.Name = "kode_barang";
			this.kode_barang.Size = new System.Drawing.Size(345, 20);
			this.kode_barang.TabIndex = 13;
			// 
			// satuan
			// 
			this.satuan.AllowDrop = true;
			this.satuan.FormattingEnabled = true;
			this.satuan.Items.AddRange(new object[] {
									"Unit",
									"Pcs",
									"Kg",
									"gram"});
			this.satuan.Location = new System.Drawing.Point(118, 162);
			this.satuan.Name = "satuan";
			this.satuan.Size = new System.Drawing.Size(119, 21);
			this.satuan.TabIndex = 14;
			// 
			// search
			// 
			this.search.Location = new System.Drawing.Point(469, 10);
			this.search.Name = "search";
			this.search.Size = new System.Drawing.Size(75, 23);
			this.search.TabIndex = 15;
			this.search.Text = "Go!";
			this.search.UseVisualStyleBackColor = true;
			// 
			// update
			// 
			this.update.Location = new System.Drawing.Point(469, 45);
			this.update.Name = "update";
			this.update.Size = new System.Drawing.Size(75, 23);
			this.update.TabIndex = 16;
			this.update.Text = "Update";
			this.update.UseVisualStyleBackColor = true;
			this.update.Click += new System.EventHandler(this.UpdateClick);
			// 
			// refresh
			// 
			this.refresh.Location = new System.Drawing.Point(469, 137);
			this.refresh.Name = "refresh";
			this.refresh.Size = new System.Drawing.Size(75, 23);
			this.refresh.TabIndex = 17;
			this.refresh.Text = "Refresh";
			this.refresh.UseVisualStyleBackColor = true;
			this.refresh.Click += new System.EventHandler(this.RefreshClick);
			// 
			// reset
			// 
			this.reset.Location = new System.Drawing.Point(469, 114);
			this.reset.Name = "reset";
			this.reset.Size = new System.Drawing.Size(75, 23);
			this.reset.TabIndex = 18;
			this.reset.Text = "Reset";
			this.reset.UseVisualStyleBackColor = true;
			this.reset.Click += new System.EventHandler(this.ResetClick);
			// 
			// delete
			// 
			this.delete.Location = new System.Drawing.Point(469, 91);
			this.delete.Name = "delete";
			this.delete.Size = new System.Drawing.Size(75, 23);
			this.delete.TabIndex = 19;
			this.delete.Text = "Delete";
			this.delete.UseVisualStyleBackColor = true;
			this.delete.Click += new System.EventHandler(this.DeleteClick);
			// 
			// save
			// 
			this.save.Location = new System.Drawing.Point(469, 68);
			this.save.Name = "save";
			this.save.Size = new System.Drawing.Size(75, 23);
			this.save.TabIndex = 20;
			this.save.Text = "Simpan";
			this.save.UseVisualStyleBackColor = true;
			this.save.Click += new System.EventHandler(this.SaveClick);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 200);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(532, 249);
			this.dataGridView1.TabIndex = 21;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(555, 461);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.save);
			this.Controls.Add(this.delete);
			this.Controls.Add(this.reset);
			this.Controls.Add(this.refresh);
			this.Controls.Add(this.update);
			this.Controls.Add(this.search);
			this.Controls.Add(this.satuan);
			this.Controls.Add(this.kode_barang);
			this.Controls.Add(this.nama_barang);
			this.Controls.Add(this.harga_beli);
			this.Controls.Add(this.harga_jual);
			this.Controls.Add(this.jumlah);
			this.Controls.Add(this.cari);
			this.Controls.Add(this.label_jumlah);
			this.Controls.Add(this.label_satuan);
			this.Controls.Add(this.label_kode_barang);
			this.Controls.Add(this.label_nama_barang);
			this.Controls.Add(this.label_harga_beli);
			this.Controls.Add(this.label_harga_jual);
			this.Controls.Add(this.label_cari);
			this.Name = "MainForm";
			this.Text = "Kasir";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button save;
		private System.Windows.Forms.Button delete;
		private System.Windows.Forms.Button reset;
		private System.Windows.Forms.Button refresh;
		private System.Windows.Forms.Button update;
		private System.Windows.Forms.Button search;
		private System.Windows.Forms.ComboBox satuan;
		private System.Windows.Forms.TextBox kode_barang;
		private System.Windows.Forms.TextBox nama_barang;
		private System.Windows.Forms.TextBox harga_beli;
		private System.Windows.Forms.TextBox harga_jual;
		private System.Windows.Forms.TextBox jumlah;
		private System.Windows.Forms.TextBox cari;
		private System.Windows.Forms.Label label_jumlah;
		private System.Windows.Forms.Label label_satuan;
		private System.Windows.Forms.Label label_kode_barang;
		private System.Windows.Forms.Label label_nama_barang;
		private System.Windows.Forms.Label label_harga_beli;
		private System.Windows.Forms.Label label_harga_jual;
		private System.Windows.Forms.Label label_cari;
	}
}
