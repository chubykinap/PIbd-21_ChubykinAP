using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication18
{
    class Parking
    {
        List<Port<ITechnika>> pStages;
        int countPlaces = 15;
        int placeSizeWidth = 210;
        int placeSizeHeight = 80;
        int currentLVL;
        public int getLVL { get { return currentLVL; } }

        public Parking(int countStages)
        {
            pStages = new List<Port<ITechnika>>(countStages);
            for (int i = 0; i < countStages; i++)
            {
                pStages.Add(new Port<ITechnika>(countPlaces, null));
            }
        }

        public void LevelUp()
        {
            if (currentLVL + 1 < pStages.Count)
            {
                currentLVL++;
            }
        }

        public void LevelDown()
        {
            if (currentLVL > 0)
            {
                currentLVL--;
            }
        }

        public int PutInParking(ITechnika ship)
        {
            return pStages[currentLVL] + ship;
        }

        public ITechnika GetInParking(int ticket)
        {
            return pStages[currentLVL] - ticket;
        }

        public void DrawPort(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            g.DrawString("P" + (currentLVL + 1), new Font("Arial", 30), new SolidBrush(Color.Blue), (countPlaces / 5) * placeSizeWidth - 70, 420);
            g.DrawRectangle(pen, 0, 0, (countPlaces / 5) * placeSizeWidth, 480);
            for (int i = 0; i < countPlaces / 5; i++)
            {
                for (int j = 0; j < 6; ++j)
                {
                    g.DrawLine(pen, i * placeSizeWidth, j * placeSizeHeight, i * placeSizeWidth + 110, j * placeSizeHeight);
                    if (j < 5)
                    {
                        g.DrawString((i * 5 + j + 1).ToString(), new Font("Arial", 30), new SolidBrush(Color.Blue), i * placeSizeWidth + 30, j * placeSizeHeight + 20);
                    }
                }
                g.DrawLine(pen, i * placeSizeWidth, 0, i * placeSizeWidth, 400);
            }
        }

        public void Draw(Graphics g)
        {
            DrawPort(g);
            int i = 0;
            foreach (var ship in pStages[currentLVL])
            {
                ship.setPos(20 + i / 5 * placeSizeWidth, i % 5 * placeSizeHeight + 15);
                ship.drawSudno(g);
                i++;
            }
        }

        public void Sort()
        {
            pStages.Sort();
        }

        public bool save(string file)
        {
            if (File.Exists(file))
            {
                File.Delete(file);
            }
            using (FileStream fs = new FileStream(file, FileMode.Create))
            {
                using (BufferedStream bs = new BufferedStream(fs))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes("CountLevels:" + pStages.Count + Environment.NewLine);
                    fs.Write(info, 0, info.Length);
                    foreach (var level in pStages)
                    {
                        info = new UTF8Encoding(true).GetBytes("Level" + Environment.NewLine);
                        fs.Write(info, 0, info.Length);
                        for (int i = 0; i < countPlaces; i++)
                        {
                            var ship = level[i];
                            if (ship != null)
                            {
                                if (ship.GetType().Name == "Ship")
                                {
                                    info = new UTF8Encoding(true).GetBytes("Ship:");
                                    fs.Write(info, 0, info.Length);
                                }
                                if (ship.GetType().Name == "Cruiser")
                                {
                                    info = new UTF8Encoding(true).GetBytes("Cruiser:");
                                    fs.Write(info, 0, info.Length);
                                }
                                info = new UTF8Encoding(true).GetBytes(ship.getInfo() + Environment.NewLine);
                                fs.Write(info, 0, info.Length);
                            }
                        }
                    }
                }
            }
            return true;
        }

        public bool load(string file)
        {
            if (!File.Exists(file))
            {
                return false;
            }
            using (FileStream fs = new FileStream(file, FileMode.Open))
            {
                string str = "";
                using (BufferedStream bs = new BufferedStream(fs))
                {
                    byte[] b = new byte[fs.Length];
                    UTF8Encoding temp = new UTF8Encoding(true);
                    while (bs.Read(b, 0, b.Length) > 0)
                    {
                        str += temp.GetString(b);
                    }
                }
                str = str.Replace("\r", "");
                var strs = str.Split('\n');
                if (strs[0].Contains("CountLevels"))
                {
                    int count = Convert.ToInt32(strs[0].Split(':')[1]);
                    if (pStages != null)
                    {
                        pStages.Clear();
                    }
                    pStages = new List<Port<ITechnika>>(count);
                }
                else
                {
                    return false;
                }
                int counter = -1;
                for (int i = 0; i < strs.Length; i++)
                {
                    if (strs[i] == "Level")
                    {
                        counter++;
                        pStages.Add(new Port<ITechnika>(countPlaces, null));
                    }
                    else if (strs[i].Split(':')[0] == "Ship")
                    {
                        ITechnika ship = new Ship(strs[i].Split(':')[1]);
                        int number = pStages[counter] + ship;
                        if (number == -1)
                        {
                            return false;
                        }
                    }
                    else if (strs[i].Split(':')[0] == "Cruiser")
                    {
                        ITechnika ship = new Cruiser(strs[i].Split(':')[1]);
                        int number = pStages[counter] + ship;
                        if (number == -1)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
    }
}
