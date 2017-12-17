namespace Assemblies
{
	partial class Assemblies
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
			this.buttonGetAssemblies = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.buttonShowSubAssemblies = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.textBoxAssyQuantity = new System.Windows.Forms.TextBox();
			this.textBoxSubAssembliesQuantity = new System.Windows.Forms.TextBox();
			this.textBoxAssyWithSubAssyQuantity = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonGetAssemblies
			// 
			this.buttonGetAssemblies.Location = new System.Drawing.Point(12, 79);
			this.buttonGetAssemblies.Name = "buttonGetAssemblies";
			this.buttonGetAssemblies.Size = new System.Drawing.Size(158, 35);
			this.buttonGetAssemblies.TabIndex = 16;
			this.buttonGetAssemblies.Text = "Get Assemblies";
			this.buttonGetAssemblies.UseVisualStyleBackColor = true;
			this.buttonGetAssemblies.Click += new System.EventHandler(this.buttonGetAssemblies_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Assemblies.Properties.Resources.Logo;
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(159, 51);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 15;
			this.pictureBox1.TabStop = false;
			// 
			// buttonShowSubAssemblies
			// 
			this.buttonShowSubAssemblies.Location = new System.Drawing.Point(13, 161);
			this.buttonShowSubAssemblies.Name = "buttonShowSubAssemblies";
			this.buttonShowSubAssemblies.Size = new System.Drawing.Size(158, 35);
			this.buttonShowSubAssemblies.TabIndex = 17;
			this.buttonShowSubAssemblies.Text = "Show SubAssemblies";
			this.buttonShowSubAssemblies.UseVisualStyleBackColor = true;
			this.buttonShowSubAssemblies.Click += new System.EventHandler(this.buttonShowSubAssemblies_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(12, 120);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(158, 35);
			this.button2.TabIndex = 18;
			this.button2.Text = "Show Assemblies";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.buttonShowAssemblies_Click);
			// 
			// textBoxAssyQuantity
			// 
			this.textBoxAssyQuantity.Location = new System.Drawing.Point(187, 85);
			this.textBoxAssyQuantity.Name = "textBoxAssyQuantity";
			this.textBoxAssyQuantity.Size = new System.Drawing.Size(100, 22);
			this.textBoxAssyQuantity.TabIndex = 19;
			// 
			// textBoxSubAssembliesQuantity
			// 
			this.textBoxSubAssembliesQuantity.Location = new System.Drawing.Point(187, 167);
			this.textBoxSubAssembliesQuantity.Name = "textBoxSubAssembliesQuantity";
			this.textBoxSubAssembliesQuantity.Size = new System.Drawing.Size(100, 22);
			this.textBoxSubAssembliesQuantity.TabIndex = 20;
			// 
			// textBoxAssyWithSubAssyQuantity
			// 
			this.textBoxAssyWithSubAssyQuantity.Location = new System.Drawing.Point(187, 126);
			this.textBoxAssyWithSubAssyQuantity.Name = "textBoxAssyWithSubAssyQuantity";
			this.textBoxAssyWithSubAssyQuantity.Size = new System.Drawing.Size(100, 22);
			this.textBoxAssyWithSubAssyQuantity.TabIndex = 21;
			// 
			// Assemblies
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(308, 210);
			this.Controls.Add(this.textBoxAssyWithSubAssyQuantity);
			this.Controls.Add(this.textBoxSubAssembliesQuantity);
			this.Controls.Add(this.textBoxAssyQuantity);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.buttonShowSubAssemblies);
			this.Controls.Add(this.buttonGetAssemblies);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Assemblies";
			this.Text = "Assemblies";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button buttonGetAssemblies;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button buttonShowSubAssemblies;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBoxAssyQuantity;
		private System.Windows.Forms.TextBox textBoxSubAssembliesQuantity;
		private System.Windows.Forms.TextBox textBoxAssyWithSubAssyQuantity;
	}
}

