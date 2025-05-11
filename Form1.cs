using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace prKol_ind4_Kuznetsov_a
{
    public partial class Form1 : Form
    {
        Hashtable disk = new Hashtable();  // Хранит диски и их содержимое
        List<string> song = new List<string>(); // Текущий список песен для создаваемого диска
        int index = 0; // Индекс для ключей в Hashtable
        int flag = -1; // Индикатор текущего отображаемого диска


        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e) // Добавить песню в каталог
        {
            song.Add(textBox1.Text);
            listBox2.Items.Add(textBox1.Text);
            textBox1.Clear();
        }

        private void button5_Click(object sender, EventArgs e) // Добавить каталог в Сет
        {
            string name = textBox2.Text;
            List<string> copySong = new List<string>(song);
            Dictionary<string, List<string>> NewSongs = new Dictionary<string, List<string>>();
            NewSongs.Add(name, copySong);
            disk.Add(index, NewSongs);

            textBox2.Clear();
            listBox2.Items.Clear();
            song.Clear();

            ShowDisk(index);
            flag = index;
            index++;

            Back.Enabled = flag > 0;
            Next.Enabled = disk.Count > 1 && flag < disk.Count - 1;
        }

        private void DeleteInCatalog_Click(object sender, EventArgs e) // Удалить песню из каталога
        {
            int selectedIndex = listBox2.SelectedIndex;
            if (selectedIndex >= 0)
            {
                song.RemoveAt(selectedIndex);
                listBox2.Items.RemoveAt(selectedIndex);
            }
        }

        private void Back_Click(object sender, EventArgs e) // Прошлый каталог
        {
            if (flag > 0)
            {
                flag--;
                ShowDisk(flag);
                Next.Enabled = true;
                Back.Enabled = flag > 0;
            }
        }

        private void Next_Click(object sender, EventArgs e) // Следующий каталог
        {
            if (flag < disk.Count - 1)
            {
                flag++;
                ShowDisk(flag);
                Back.Enabled = true;
                Next.Enabled = flag < disk.Count - 1;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DeleteInCatalogSet_Click(object sender, EventArgs e)  // Удалить песню из уже добавленного набора (не текущего, а сохранённого в каталоге)
        {
            if (flag >= 0 && disk.ContainsKey(flag) && listBox1.SelectedIndex > 0)
            {
                Dictionary<string, List<string>> currentDisk = (Dictionary<string, List<string>>)disk[flag];
                string songToRemove = listBox1.SelectedItem.ToString();

                foreach (var pair in currentDisk)
                {
                    pair.Value.Remove(songToRemove);
                }

                ShowDisk(flag);
            }
        }

        private void DeleteInSet_Click(object sender, EventArgs e)// Удалить весь диск из каталога
        {
            if (flag >= 0 && disk.ContainsKey(flag))
            {
                disk.Remove(flag);
                listBox1.Items.Clear();
                if (disk.Count > 0)
                {
                    flag = Math.Max(0, flag - 1);
                    ShowDisk(flag);
                }
                else
                {
                    flag = -1;
                    listBox1.Items.Add("Каталог пуст");
                }

                Back.Enabled = flag > 0;
                Next.Enabled = flag < disk.Count - 1;
            }

        }      
        private void ShowDisk(int idx)// Метод отображения содержимого диска по индексу
        {
            listBox1.Items.Clear();
            if (disk.ContainsKey(idx))
            {
                Dictionary<string, List<string>> currentDisk = (Dictionary<string, List<string>>)disk[idx];
                foreach (var pair in currentDisk)
                {
                    listBox1.Items.Add($"Название диска: {pair.Key}");
                    foreach (string s in pair.Value)
                    {
                        listBox1.Items.Add(s);
                    }
                }
            }
        }
    }
}
