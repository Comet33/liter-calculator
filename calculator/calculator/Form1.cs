using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        private Dictionary<string, int> liquids = new Dictionary<string, int>();
        string path = "log.txt";
        public Form1()
        {
            InitializeComponent();
            this.Text = "Перевод из литров в киллограмы";
            this.Icon = Properties.Resources.
            this.MaximizeBox = false;

            if (File.Exists("liquids.json"))
            {
                updateListView();
            }
            else
            {
                liquids.Add("Вода", 1000);
                liquids.Add("Молоко", 1040);
            }
            resultText.Text = "";

            if (!File.Exists(path))
                File.Create(path).Close();

            liquidList.SelectedIndex = 0;
        }

        private void resultBtn_Click(object sender, EventArgs e)
        {
            foreach(var liquid in liquids)
            {
                if(liquid.Key == liquidList.SelectedItem.ToString())
                {
                    double v = double.Parse(inputLitters.Text);
                    int p = liquid.Value;
                    String res = String.Format("{0:F1}", p*v/1000);
                    resultText.Text = "Результат: "+res+" кг.";
                    SaveData(
                        string.Format(
                            "Вы ввели: {0} - {1}л и получили {2}", liquidList.SelectedItem.ToString(), v.ToString(), res
                            ));
                }
            }   
        }

        private void liquidList_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(var liquid in liquids)
            {
                if(liquid.Key == liquidList.SelectedItem.ToString())
                {
                    littersText.Text = "Плотность: " + liquid.Value;
                }
            }
        }

        private void SaveData(string text)
        {
            string date = DateTime.Now.ToString("dd.MM.yyy");
            string time = DateTime.Now.ToString("HH:mm:ss");
            File.AppendAllText(path, date + " "+time+" "+text+"\n");
        }

        private void addNewLiquid_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(liquids);
            form2.ShowDialog();
            updateListView();
        }

        private void updateListView()
        {
            int indexSelected = 0;
            if (liquidList.SelectedIndex != 0 || liquidList.SelectedIndex != null)
                indexSelected = liquidList.SelectedIndex;
            liquids.Clear();
            liquidList.Items.Clear();
            var text = File.ReadAllText("liquids.json");
            liquids = JsonConvert.DeserializeObject<Dictionary<string, int>>(text);
            foreach (var liquid in liquids)
            {
                liquidList.Items.Add(liquid.Key);
            }
            liquidList.SelectedIndex = indexSelected;
        }

        private void developer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Разработчик: Субботин Павел \nГруппа: исп-320а");
        }
    }
}
