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
    public partial class Form2 : Form
    {
        Dictionary<string, int> liquids = new Dictionary<string, int>();
        public Form2(Dictionary<string, int> liquids)
        {
            InitializeComponent();
            this.Text = "Добавить новую жидкость";
            this.liquids = liquids;
            this.MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = inputName.Text;
            string density = inputDensity.Text;
            if(name != null && density != null && name!="" && density != "")
            {
                liquids.Add(name, int.Parse(density));
                JsonConvert.SerializeObject(liquids, Formatting.Indented);
                string json = JsonConvert.SerializeObject(liquids);
                File.WriteAllText("liquids.json", json);
                this.Close();
            }
            else
            {
                MessageBox.Show("Вы должны заполнить все поля!");
            }
        }

        private void inputDensity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
