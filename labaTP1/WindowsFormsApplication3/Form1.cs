using System;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form : System.Windows.Forms.Form
    {
        private Potato[] potato;
        private Kapusta[] kapusta;
        private Water water;
        private Other_ing other = new Other_ing();
        private Water_tap WaterTap =new Water_tap();
        private Knife knife = new Knife();
        private Terka terka = new Terka();
        private Pan pan = new Pan();
        private Stove stove = new Stove();
        private bool onStove = false;

        public Form()
        {
            InitializeComponent();
            other.be = true;
            Remove.Enabled = false;
            Remove.Enabled = false;
            Cook.Enabled = false;
        }


        private void CutKar_Click(object sender, EventArgs e)
        {
            if (potato == null)
            {
                MessageBox.Show("Картошки нет", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            for (int i = 0; i < potato.Length; i++)
            {
                knife.CutPot(potato[i]);
            }
            KarNumb.Enabled = false;
            AddKar.Enabled = true;
            CutKar.Enabled = false;
            MessageBox.Show("Картошка нарезана", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            if (kapusta == null)
            {
                MessageBox.Show("Капусты нет", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            for (int i = 0; i < kapusta.Length; i++)
            {
                knife.CutKap(kapusta[i]);
            }
            AddKap.Enabled = true;
            CutKap.Enabled = false;
            AddKap.Enabled = true;
            KapNumb.Enabled = false;
            MessageBox.Show("Капуста нарезана", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            onStove = true;
            Move.Enabled = false;
            MessageBox.Show("Кастрюля на плите", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            kapusta = new Kapusta[Convert.ToInt32(KapNumb.Value)];
            for (int i = 0; i < kapusta.Length; i++)
            {
                kapusta[i] = new Kapusta();
            }
        }

        private void KarNumb_ValueChanged(object sender, EventArgs e)
        {
            potato = new Potato[Convert.ToInt32(KarNumb.Value)];
            for (int i = 0; i < potato.Length; i++)
            {
                potato[i] = new Potato();
            }
        }

        private void Close_CheckedChanged(object sender, EventArgs e)
        {
            if (Close.Checked)
            {
                WaterTap.State = false;
                AddWater.Enabled = false;
                MessageBox.Show("Кран закрыт", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void On_Off_CheckedChanged(object sender, EventArgs e)
        {
            stove.state = On_Off.Checked;                        
            if (stove.state)
            {
                Cook.Enabled = true;
                MessageBox.Show("Плита включена", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Cook.Enabled = false;
                MessageBox.Show("Плита выключена", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Open_CheckedChanged(object sender, EventArgs e)
        {
            if (Open.Checked)
            {
                water = new Water();
                WaterTap.State = true;
                AddWater.Enabled = true;
                MessageBox.Show("Кран открыт", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Terka_Click(object sender, EventArgs e)
        {
            if (other.be == false)
            {
                MessageBox.Show("Зелени нет", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            terka.Nateret(other);
            AddOther.Enabled = true;
            Terka.Enabled = false;
            MessageBox.Show("Зелень натерта", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AddWater_Click(object sender, EventArgs e)
        {
            if (Open.Checked == false)
            {
                MessageBox.Show("Может воду включить?", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            pan.addWater(water);
            AddWater.Enabled = false;
            MessageBox.Show("Залили воду в кастрюлю", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AddKar_Click(object sender, EventArgs e)
        {                
            if (potato == null || potato.Length == 0)
            {
                MessageBox.Show("Картошки нет", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            for (int i = 0; i < potato.Length; i++)
            {
                if (potato[i].cutted == false)
                {
                    MessageBox.Show("Может нарезать для начала?", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                pan.addPotato(potato);
            }
            AddKar.Enabled = false;
            MessageBox.Show("Картошка в кастрюле", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);            
        }

        private void AddKap_Click(object sender, EventArgs e)
        {                
            if (kapusta == null || kapusta.Length == 0)
            {
                MessageBox.Show("Капусты нет", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            for (int i = 0; i < kapusta.Length; ++i)
            {
                if (kapusta[i].cutted == false)
                {
                    MessageBox.Show("Может нарезать для начала?", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                pan.addKap(kapusta);
            }
            AddKap.Enabled = false;
            MessageBox.Show("Капуста в кастрюле", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);            
        }

        private void AddOther_Click(object sender, EventArgs e)
        {
            if (other == null)
            {
                MessageBox.Show("Зелени нет", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (other.has_ready == false)
            {
                MessageBox.Show("Зелень бы натереть", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            pan.addOther(other);
            AddOther.Enabled = false;
            MessageBox.Show("Добавили зелень", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Cook_Click(object sender, EventArgs e)
        {
            if (!pan.Ready_to_cook)
            {
                MessageBox.Show("Не хватает ингридиентов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (!onStove)
            {
                MessageBox.Show("Поставь кастрюлю на плиту", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            stove.Pan = pan;
            Cook.Enabled = false;
            stove.Cook();
            if (!stove.Pan.Is_ready())
            {
                MessageBox.Show("Готово!", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Remove.Enabled = true;
            }
            else
            {
                MessageBox.Show("Что-то пошло не так", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Кухня_Load(object sender, EventArgs e)
        { }
        private void label2_Click(object sender, EventArgs e)
        { }
        private void groupBox2_Enter(object sender, EventArgs e)
        { }
        private void groupBox6_Enter(object sender, EventArgs e)
        { }
    }
}