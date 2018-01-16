namespace WindowsFormsApplication18
{
	partial class Form2
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.labelCruiser = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.labelBaseColor = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.labelDopColor = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.panel9 = new System.Windows.Forms.Panel();
			this.panel8 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.groupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.labelCruiser);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(24, 24);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(252, 167);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Тип";
			// 
			// labelCruiser
			// 
			this.labelCruiser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelCruiser.Location = new System.Drawing.Point(34, 88);
			this.labelCruiser.Name = "labelCruiser";
			this.labelCruiser.Size = new System.Drawing.Size(164, 51);
			this.labelCruiser.TabIndex = 1;
			this.labelCruiser.Text = "Cruiser";
			this.labelCruiser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelCruiser_MouseDown);
			// 
			// label1
			// 
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Location = new System.Drawing.Point(34, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(164, 43);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ship";
			this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
			// 
			// buttonOK
			// 
			this.buttonOK.Location = new System.Drawing.Point(24, 206);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 1;
			this.buttonOK.Text = "Добавить";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(24, 250);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 2;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// labelBaseColor
			// 
			this.labelBaseColor.AllowDrop = true;
			this.labelBaseColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelBaseColor.Location = new System.Drawing.Point(64, 186);
			this.labelBaseColor.Name = "labelBaseColor";
			this.labelBaseColor.Size = new System.Drawing.Size(148, 43);
			this.labelBaseColor.TabIndex = 2;
			this.labelBaseColor.Text = "Основной цвет";
			this.labelBaseColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
			this.labelBaseColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
			// 
			// panel1
			// 
			this.panel1.AllowDrop = true;
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.labelDopColor);
			this.panel1.Controls.Add(this.labelBaseColor);
			this.panel1.Location = new System.Drawing.Point(299, 24);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(270, 316);
			this.panel1.TabIndex = 3;
			this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
			this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(27, 16);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(220, 151);
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// labelDopColor
			// 
			this.labelDopColor.AllowDrop = true;
			this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelDopColor.Location = new System.Drawing.Point(64, 254);
			this.labelDopColor.Name = "labelDopColor";
			this.labelDopColor.Size = new System.Drawing.Size(148, 43);
			this.labelDopColor.TabIndex = 3;
			this.labelDopColor.Text = "Доп. цвет";
			this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
			this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.panel9);
			this.groupBox2.Controls.Add(this.panel8);
			this.groupBox2.Controls.Add(this.panel7);
			this.groupBox2.Controls.Add(this.panel6);
			this.groupBox2.Controls.Add(this.panel5);
			this.groupBox2.Controls.Add(this.panel4);
			this.groupBox2.Controls.Add(this.panel3);
			this.groupBox2.Controls.Add(this.panel2);
			this.groupBox2.Location = new System.Drawing.Point(605, 24);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(118, 229);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Цвета";
			// 
			// panel9
			// 
			this.panel9.BackColor = System.Drawing.Color.Gold;
			this.panel9.Location = new System.Drawing.Point(71, 175);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(31, 30);
			this.panel9.TabIndex = 5;
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.SlateGray;
			this.panel8.Location = new System.Drawing.Point(16, 175);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(31, 30);
			this.panel8.TabIndex = 6;
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.Yellow;
			this.panel7.Location = new System.Drawing.Point(71, 121);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(31, 30);
			this.panel7.TabIndex = 5;
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.Red;
			this.panel6.Location = new System.Drawing.Point(16, 121);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(31, 30);
			this.panel6.TabIndex = 4;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.Blue;
			this.panel5.Location = new System.Drawing.Point(71, 75);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(31, 30);
			this.panel5.TabIndex = 3;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.panel4.Location = new System.Drawing.Point(16, 75);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(31, 30);
			this.panel4.TabIndex = 2;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.White;
			this.panel3.Location = new System.Drawing.Point(71, 29);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(31, 30);
			this.panel3.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel2.Location = new System.Drawing.Point(16, 29);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(31, 30);
			this.panel2.TabIndex = 0;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(754, 394);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Form2";
			this.Text = "FormSelectCar";
			this.groupBox1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label labelCruiser;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Label labelBaseColor;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label labelDopColor;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel2;
	}
}