/*
 * Created by SharpDevelop.
 * User: Potato
 * Date: 4/19/2022
 * Time: 2:06 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Kasir
{
	/// <summary>
	/// Description of Koneksi.
	/// </summary>
	public class Koneksi
	{
		public MySqlConnection GetConn()
		{
			MySqlConnection Conn = new MySqlConnection("Server = localhost; Database = kasir; user = root");
			return Conn;
		}
	}
}
