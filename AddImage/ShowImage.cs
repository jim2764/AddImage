using Ispan.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddImage
{
	public partial class ShowImage : Form
	{
		public ShowImage()
		{
			InitializeComponent();
			DataBind();
		}

		private void DataBind()
		{
			string sql = "SELECT FileName FROM Image";
			SqlDbHelper sqlDbHelper = new SqlDbHelper("default");
			string[] result = sqlDbHelper.Select(sql, null)
										 .AsEnumerable()
										 .Select(x => x.Field<string>("FileName"))
										 .Prepend(string.Empty)
										 .ToArray();
			comboBox1.DataSource = result;
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBox1.SelectedIndex == 0) return;

			string filename = comboBox1.Text;

			pictureBox1.Image = Image.FromFile($"D:\\Source\\AddImage\\AddImage\\Image\\{filename}");
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
		}
	}
}
