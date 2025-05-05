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
        Hashtable disk = new Hashtable();
        List<string> song = new List<string>();
        int index = 0;
        int flag = 0;


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
            listBox1.Items.Clear();
            string name = textBox2.Text;
            List<string> copySong = new List<string>(song);
            Dictionary<string, List<string>> NewSongs = new Dictionary<string, List<string>>();

            NewSongs.Add(name, copySong);
            disk.Add(index, NewSongs);

            Dictionary<string, List<string>> CopySongs = (Dictionary<string, List<string>>)disk[0];
            textBox2.Clear();
            index++;
            listBox2.Items.Clear();
            listBox1.Items.Add($"Название диска {name}");
            
            foreach(List<string> sList in CopySongs.Values)
            {
                foreach (string s in sList) 
                {
                   listBox1.Items.Add(s);
                }
            }
            Back.Enabled = false;
        }

        private void DeleteInCatalog_Click(object sender, EventArgs e) // Удалить песню из каталога
        {
            int index = listBox2.SelectedIndex;
            if (index >= 0)
            {
                song.RemoveAt(index);
                listBox2.Items.RemoveAt(index);
            }
        }

        private void Back_Click(object sender, EventArgs e) // Прошлый каталог
        {
            if (flag == 0)
            {
               
            }
            else
            {
                flag--;
                Dictionary<string, List<string>> CopySongs = (Dictionary<string, List<string>>)disk[flag];
                listBox1.Items.Add($"Название диска {Convert.ToString(CopySongs.Keys)}");

                foreach (List<string> sList in CopySongs.Values)
                {
                    foreach (string s in sList)
                    {
                        listBox1.Items.Add(s);
                    }
                }

            }
        }

        private void Next_Click(object sender, EventArgs e) // Следующий каталог
        {
            flag++;
            Dictionary<string, List<string>> CopySongs = (Dictionary<string, List<string>>)disk[flag];
            listBox1.Items.Add($"Название диска {Convert.ToString(CopySongs.Keys)}");

            foreach (List<string> sList in CopySongs.Values)
            {
                foreach (string s in sList)
                {
                        listBox1.Items.Add(s);
                }
            }
            Back.Enabled = true;
            if (flag == disk.Count-1)
            {
                Next.Enabled = false;
            }
        }
    }
}
