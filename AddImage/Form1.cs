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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnAddImage_Click(object sender, EventArgs e)
		{
			AddImage form = new AddImage();
			form.ShowDialog();
		}

		private void btnShowImage_Click(object sender, EventArgs e)
		{
			ShowImage form = new ShowImage();
			form.ShowDialog();
		}
	}
}
