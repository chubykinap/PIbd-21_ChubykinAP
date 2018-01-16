namespace WindowsFormsApplication3
{
    partial class Form
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
            this.KapNumb = new System.Windows.Forms.NumericUpDown();
            this.KarNumb = new System.Windows.Forms.NumericUpDown();
            this.Kapusta = new System.Windows.Forms.Label();
            this.Potato = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AddOther = new System.Windows.Forms.Button();
            this.AddKar = new System.Windows.Forms.Button();
            this.AddKap = new System.Windows.Forms.Button();
            this.AddWater = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Remove = new System.Windows.Forms.Button();
            this.Cook = new System.Windows.Forms.Button();
            this.Move = new System.Windows.Forms.Button();
            this.On_Off = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CutKap = new System.Windows.Forms.Button();
            this.CutKar = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Terka = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Close = new System.Windows.Forms.RadioButton();
            this.Open = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KapNumb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KarNumb)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.KapNumb);
            this.groupBox1.Controls.Add(this.KarNumb);
            this.groupBox1.Controls.Add(this.Kapusta);
            this.groupBox1.Controls.Add(this.Potato);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 87);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ингридиенты";
            // 
            // KapNumb
            // 
            this.KapNumb.Location = new System.Drawing.Point(82, 53);
            this.KapNumb.Name = "KapNumb";
            this.KapNumb.Size = new System.Drawing.Size(62, 20);
            this.KapNumb.TabIndex = 3;
            this.KapNumb.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // KarNumb
            // 
            this.KarNumb.Location = new System.Drawing.Point(82, 24);
            this.KarNumb.Name = "KarNumb";
            this.KarNumb.Size = new System.Drawing.Size(62, 20);
            this.KarNumb.TabIndex = 2;
            this.KarNumb.ValueChanged += new System.EventHandler(this.KarNumb_ValueChanged);
            // 
            // Kapusta
            // 
            this.Kapusta.AutoSize = true;
            this.Kapusta.Location = new System.Drawing.Point(19, 55);
            this.Kapusta.Name = "Kapusta";
            this.Kapusta.Size = new System.Drawing.Size(48, 13);
            this.Kapusta.TabIndex = 1;
            this.Kapusta.Text = "Капуста";
            this.Kapusta.Click += new System.EventHandler(this.label2_Click);
            // 
            // Potato
            // 
            this.Potato.AutoSize = true;
            this.Potato.Location = new System.Drawing.Point(19, 26);
            this.Potato.Name = "Potato";
            this.Potato.Size = new System.Drawing.Size(57, 13);
            this.Potato.TabIndex = 0;
            this.Potato.Text = "Картошка";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AddOther);
            this.groupBox2.Controls.Add(this.AddKar);
            this.groupBox2.Controls.Add(this.AddKap);
            this.groupBox2.Controls.Add(this.AddWater);
            this.groupBox2.Location = new System.Drawing.Point(192, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(135, 144);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Кастрюля";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // AddOther
            // 
            this.AddOther.Location = new System.Drawing.Point(7, 106);
            this.AddOther.Name = "AddOther";
            this.AddOther.Size = new System.Drawing.Size(120, 23);
            this.AddOther.TabIndex = 3;
            this.AddOther.Text = "Добавить зелень";
            this.AddOther.UseVisualStyleBackColor = true;
            this.AddOther.Click += new System.EventHandler(this.AddOther_Click);
            // 
            // AddKar
            // 
            this.AddKar.Location = new System.Drawing.Point(6, 77);
            this.AddKar.Name = "AddKar";
            this.AddKar.Size = new System.Drawing.Size(120, 23);
            this.AddKar.TabIndex = 2;
            this.AddKar.Text = "Добавить картошку";
            this.AddKar.UseVisualStyleBackColor = true;
            this.AddKar.Click += new System.EventHandler(this.AddKar_Click);
            // 
            // AddKap
            // 
            this.AddKap.Location = new System.Drawing.Point(7, 48);
            this.AddKap.Name = "AddKap";
            this.AddKap.Size = new System.Drawing.Size(120, 23);
            this.AddKap.TabIndex = 1;
            this.AddKap.Text = "Добавить капусту";
            this.AddKap.UseVisualStyleBackColor = true;
            this.AddKap.Click += new System.EventHandler(this.AddKap_Click);
            // 
            // AddWater
            // 
            this.AddWater.Location = new System.Drawing.Point(7, 19);
            this.AddWater.Name = "AddWater";
            this.AddWater.Size = new System.Drawing.Size(120, 23);
            this.AddWater.TabIndex = 0;
            this.AddWater.Text = "Залить воду";
            this.AddWater.UseVisualStyleBackColor = true;
            this.AddWater.Click += new System.EventHandler(this.AddWater_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Remove);
            this.groupBox3.Controls.Add(this.Cook);
            this.groupBox3.Controls.Add(this.Move);
            this.groupBox3.Controls.Add(this.On_Off);
            this.groupBox3.Location = new System.Drawing.Point(333, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(101, 154);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Плита";
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(6, 111);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(86, 37);
            this.Remove.TabIndex = 3;
            this.Remove.Text = "Убрать кастрюлю";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Cook
            // 
            this.Cook.Location = new System.Drawing.Point(6, 82);
            this.Cook.Name = "Cook";
            this.Cook.Size = new System.Drawing.Size(86, 23);
            this.Cook.TabIndex = 2;
            this.Cook.Text = "Готовить";
            this.Cook.UseVisualStyleBackColor = true;
            this.Cook.Click += new System.EventHandler(this.Cook_Click);
            // 
            // Move
            // 
            this.Move.Location = new System.Drawing.Point(6, 41);
            this.Move.Name = "Move";
            this.Move.Size = new System.Drawing.Size(86, 37);
            this.Move.TabIndex = 1;
            this.Move.Text = "Поставить кастрюлю";
            this.Move.UseVisualStyleBackColor = true;
            this.Move.Click += new System.EventHandler(this.button8_Click);
            // 
            // On_Off
            // 
            this.On_Off.AutoSize = true;
            this.On_Off.Location = new System.Drawing.Point(6, 19);
            this.On_Off.Name = "On_Off";
            this.On_Off.Size = new System.Drawing.Size(76, 17);
            this.On_Off.TabIndex = 0;
            this.On_Off.Text = "Включена";
            this.On_Off.UseVisualStyleBackColor = true;
            this.On_Off.CheckedChanged += new System.EventHandler(this.On_Off_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CutKap);
            this.groupBox4.Controls.Add(this.CutKar);
            this.groupBox4.Location = new System.Drawing.Point(23, 162);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(105, 135);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Нож";
            // 
            // CutKap
            // 
            this.CutKap.Location = new System.Drawing.Point(6, 74);
            this.CutKap.Name = "CutKap";
            this.CutKap.Size = new System.Drawing.Size(91, 44);
            this.CutKap.TabIndex = 1;
            this.CutKap.Text = "Нарезать капусту";
            this.CutKap.UseVisualStyleBackColor = true;
            this.CutKap.Click += new System.EventHandler(this.button2_Click);
            // 
            // CutKar
            // 
            this.CutKar.Location = new System.Drawing.Point(6, 24);
            this.CutKar.Name = "CutKar";
            this.CutKar.Size = new System.Drawing.Size(91, 44);
            this.CutKar.TabIndex = 0;
            this.CutKar.Text = "Нарезать картошку";
            this.CutKar.UseVisualStyleBackColor = true;
            this.CutKar.Click += new System.EventHandler(this.CutKar_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Terka);
            this.groupBox5.Location = new System.Drawing.Point(134, 162);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(90, 73);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Тёрка";
            // 
            // Terka
            // 
            this.Terka.Location = new System.Drawing.Point(9, 27);
            this.Terka.Name = "Terka";
            this.Terka.Size = new System.Drawing.Size(75, 39);
            this.Terka.TabIndex = 0;
            this.Terka.Text = "Натереть зелень";
            this.Terka.UseVisualStyleBackColor = true;
            this.Terka.Click += new System.EventHandler(this.Terka_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.Close);
            this.groupBox6.Controls.Add(this.Open);
            this.groupBox6.Location = new System.Drawing.Point(23, 105);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(162, 42);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Кран";
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // Close
            // 
            this.Close.AutoSize = true;
            this.Close.Checked = true;
            this.Close.Location = new System.Drawing.Point(82, 19);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(69, 17);
            this.Close.TabIndex = 1;
            this.Close.TabStop = true;
            this.Close.Text = "Закрыть";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.CheckedChanged += new System.EventHandler(this.Close_CheckedChanged);
            // 
            // Open
            // 
            this.Open.AutoSize = true;
            this.Open.Location = new System.Drawing.Point(7, 19);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(69, 17);
            this.Open.TabIndex = 0;
            this.Open.Text = "Открыть";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.CheckedChanged += new System.EventHandler(this.Open_CheckedChanged);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 331);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form";
            this.Text = "Кухня";
            this.Load += new System.EventHandler(this.Кухня_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KapNumb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KarNumb)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown KapNumb;
        private System.Windows.Forms.NumericUpDown KarNumb;
        private System.Windows.Forms.Label Kapusta;
        private System.Windows.Forms.Label Potato;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button CutKap;
        private System.Windows.Forms.Button CutKar;
        private System.Windows.Forms.Button Terka;
        private System.Windows.Forms.Button AddOther;
        private System.Windows.Forms.Button AddKar;
        private System.Windows.Forms.Button AddKap;
        private System.Windows.Forms.Button AddWater;
        private System.Windows.Forms.Button Move;
        private System.Windows.Forms.CheckBox On_Off;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton Open;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Cook;
        private System.Windows.Forms.RadioButton Close;
    }
}

