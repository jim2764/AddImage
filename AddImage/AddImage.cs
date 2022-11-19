using Ispan.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddImage
{
	public partial class AddImage : Form
	{
		public AddImage()
		{
			InitializeComponent();
			label2.Visible = false;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			// 預設路徑
			openFileDialog1.InitialDirectory = "C:";

			// 視窗標題
			openFileDialog1.Title = "Please select an image";

			// 選擇那些檔案
			openFileDialog1.Filter = "Image Only(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";

			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				// 圖片的Path print在Label上
				string path = System.IO.Path.GetFullPath(openFileDialog1.FileName);
				label2.Visible = true;
				label2.Text = path;

				// 圖片print在PictureBox上
				pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
				pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			}
			else
			{
				label2.Visible = true;
				label2.Text = "No Selection";
			}
				
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			string filename = string.Empty;
			// 將Image儲存在Image資料夾中
			try
			{
				// 得到檔案名稱
				string sourcePath = openFileDialog1.FileName;

				// 取的目的地 Path + filename
				filename = System.IO.Path.GetFileName(openFileDialog1.FileName);
				string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
				string destinationPath = path + "\\Image\\" + filename;

				// 移動檔案
				System.IO.File.Copy(sourcePath, destinationPath);
				MessageBox.Show("已成功儲存Image");
			}
			catch (Exception ex)
			{
				// 若找不到檔案
				MessageBox.Show(ex.Message);
				return;
			}


			// 將Image fileName 儲存入DataBase
			SqlDbHelper sqlDbHelper = new SqlDbHelper("default");
			string sql = "INSERT INTO Image(FileName) VALUES(@FileName)";
			SqlParameter[] parameters = new SqlParameterBuilder()
										.AddNVarchar("@FileName", 50, filename)
										.Builder();
			sqlDbHelper.ExecuteNonQuery(sql, parameters);

			DialogResult = DialogResult.OK;
		}
	}
}
