namespace WindowsFormsApplication1
{
    partial class Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.picture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.box1 = new System.Windows.Forms.CheckBox();
            this.box2 = new System.Windows.Forms.CheckBox();
            this.speed = new System.Windows.Forms.TextBox();
            this.disp = new System.Windows.Forms.TextBox();
            this.crew = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.move = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(12, 12);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(631, 349);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Max speed:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Max crew:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Displacement:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Color:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Front Cannon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 404);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Back Cannon";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(172, 448);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Color:";
            // 
            // box1
            // 
            this.box1.AutoSize = true;
            this.box1.Location = new System.Drawing.Point(339, 370);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(15, 14);
            this.box1.TabIndex = 8;
            this.box1.UseVisualStyleBackColor = true;
            // 
            // box2
            // 
            this.box2.AutoSize = true;
            this.box2.Location = new System.Drawing.Point(339, 404);
            this.box2.Name = "box2";
            this.box2.Size = new System.Drawing.Size(15, 14);
            this.box2.TabIndex = 9;
            this.box2.UseVisualStyleBackColor = true;
            // 
            // speed
            // 
            this.speed.Location = new System.Drawing.Point(94, 367);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(72, 20);
            this.speed.TabIndex = 10;
            // 
            // disp
            // 
            this.disp.Location = new System.Drawing.Point(252, 367);
            this.disp.Name = "disp";
            this.disp.Size = new System.Drawing.Size(81, 20);
            this.disp.TabIndex = 11;
            // 
            // crew
            // 
            this.crew.Location = new System.Drawing.Point(94, 401);
            this.crew.Name = "crew";
            this.crew.Size = new System.Drawing.Size(72, 20);
            this.crew.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(530, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Задать корабль";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(530, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Задать крейсер";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(94, 444);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 21);
            this.button3.TabIndex = 15;
            this.button3.Text = "Color1";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(212, 444);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(66, 21);
            this.button4.TabIndex = 16;
            this.button4.Text = "Color2";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // move
            // 
            this.move.Location = new System.Drawing.Point(532, 439);
            this.move.Name = "move";
            this.move.Size = new System.Drawing.Size(110, 21);
            this.move.TabIndex = 17;
            this.move.Text = "Движение";
            this.move.UseVisualStyleBackColor = true;
            this.move.Click += new System.EventHandler(this.move_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(339, 444);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(66, 21);
            this.button5.TabIndex = 19;
            this.button5.Text = "Color3";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(299, 448);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Color:";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 501);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.move);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.crew);
            this.Controls.Add(this.disp);
            this.Controls.Add(this.speed);
            this.Controls.Add(this.box2);
            this.Controls.Add(this.box1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picture);
            this.Name = "Form";
            this.Text = "Лабораторная №2";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox box1;
        private System.Windows.Forms.CheckBox box2;
        private System.Windows.Forms.TextBox speed;
        private System.Windows.Forms.TextBox disp;
        private System.Windows.Forms.TextBox crew;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button move;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label8;
    }
}

