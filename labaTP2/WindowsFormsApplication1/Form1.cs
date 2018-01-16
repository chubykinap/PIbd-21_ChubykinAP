using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication18
{
    public partial class Form1 : Form
    {
        Parking parking;
        Form2 form = new Form2();
        private Logger log;

        public Form1()
        {
            InitializeComponent();
            log = LogManager.GetCurrentClassLogger();
            parking = new Parking(5);
            for (int i = 1; i < 6; i++)
            {
                listBox1.Items.Add("Порт №" + i);
            }
            listBox1.SelectedIndex = parking.getLVL;
            DrawPort();
        }

        private void DrawPort()
        {
            if (listBox1.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(picture.Width, picture.Height);
                Graphics g = Graphics.FromImage(bmp);
                parking.Draw(g);
                picture.Image = bmp;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != "")
            {
                try
                {
                    ITechnika ship = parking.GetInParking(Convert.ToInt32(maskedTextBox1.Text) - 1);
                    Bitmap bmp = new Bitmap(pictureTake.Width, pictureTake.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    ship.setPos(15, 10);
                    ship.drawSudno(gr);
                    pictureTake.Image = bmp;
                    log.Info("Удаление корабля с номером {0} с парковки", Convert.ToInt32(maskedTextBox1.Text));
                    DrawPort();
                }
                catch (ParkingIndexOutOfRangeException ex)
                {
                    MessageBox.Show(ex.Message, "Неверный номер.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Общая ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            parking.LevelUp();
            listBox1.SelectedIndex = parking.getLVL;
            log.Info("Переход на уровень ниже. Текущий уровень: " + parking.getLVL);
            DrawPort();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            parking.LevelDown();
            listBox1.SelectedIndex = parking.getLVL;
            log.Info("Переход на уровень выше. Текущий уровень: " + parking.getLVL);
            DrawPort();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            form = new Form2();
            form.AddEvent(AddShip);
            form.Show();
        }

        private void AddShip(ITechnika ship)
        {
            if (ship != null)
            {
                try
                {
                    int place = parking.PutInParking(ship);
                    DrawPort();
                    MessageBox.Show("Вашеместо: " + (place + 1));
                    log.Info("Добавление нового корабля на парковку. Его место: " + (place + 1));
                }
                catch (ParkingOverflowException e)
                {
                    MessageBox.Show(e.Message, "Ошибка переполнения.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Общая ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (parking.save(saveFileDialog1.FileName))
                {
                    MessageBox.Show("Сохранение прошло успешно.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не сохранилось.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (parking.load(openFileDialog1.FileName))
                {
                    MessageBox.Show("Загружено.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не загружено.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            DrawPort();
        }
    }
}
