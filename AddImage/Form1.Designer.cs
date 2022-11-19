namespace AddImage
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnAddImage = new System.Windows.Forms.Button();
			this.btnShowImage = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnAddImage
			// 
			this.btnAddImage.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnAddImage.Location = new System.Drawing.Point(26, 71);
			this.btnAddImage.Name = "btnAddImage";
			this.btnAddImage.Size = new System.Drawing.Size(124, 73);
			this.btnAddImage.TabIndex = 0;
			this.btnAddImage.Text = "Add Image";
			this.btnAddImage.UseVisualStyleBackColor = true;
			this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
			// 
			// btnShowImage
			// 
			this.btnShowImage.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnShowImage.Location = new System.Drawing.Point(203, 71);
			this.btnShowImage.Name = "btnShowImage";
			this.btnShowImage.Size = new System.Drawing.Size(124, 73);
			this.btnShowImage.TabIndex = 0;
			this.btnShowImage.Text = "ShowImage";
			this.btnShowImage.UseVisualStyleBackColor = true;
			this.btnShowImage.Click += new System.EventHandler(this.btnShowImage_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(367, 217);
			this.Controls.Add(this.btnShowImage);
			this.Controls.Add(this.btnAddImage);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnAddImage;
		private System.Windows.Forms.Button btnShowImage;
	}
}

