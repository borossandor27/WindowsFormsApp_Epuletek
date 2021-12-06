using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Epuletek
{
    public partial class Form_Tombhaz : Form
    {
        public Form_Tombhaz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_Cim.Text))
            {
                return;
            }
            //-- további ellenőrzések
            Anyagok anyag = (Anyagok)Enum.Parse(typeof(Anyagok), comboBox_Epitesianyag.SelectedItem.ToString());
            string szoveg = comboBox_FenntartasTipusa.SelectedItem.ToString();
            Type tipus = typeof(Fenntartas);
            Fenntartas fenntartas = (Fenntartas)Enum.Parse(tipus, szoveg);
            Tombhaz uj = new Tombhaz(
                textBox_Cim.Text,
                (int)numericUpDown_Alapterulet.Value,
                anyag,
                dateTimePicker_Kezdes.Value,
                dateTimePicker_Befejezes.Value,
                (int)numericUpDown_LakasokSzama.Value,
                fenntartas,
                checkBox1.Checked);
            Program.form_Nyito.listBox_Epuletek.Items.Add(uj);
            textBox_Cim.Text = "";
            numericUpDown_Alapterulet.Value = numericUpDown_Alapterulet.Minimum;
            comboBox_Epitesianyag.SelectedIndex = -1;
            numericUpDown_LakasokSzama.Value = numericUpDown_LakasokSzama.Minimum;
            comboBox_FenntartasTipusa.SelectedIndex = -1;
            checkBox1.Checked = false;
        }

        private void Form_Tombhaz_Load(object sender, EventArgs e)
        {
            foreach (string item in Enum.GetNames(typeof(Anyagok)))
            {
                comboBox_Epitesianyag.Items.Add(item);
            }
            foreach (string item in Enum.GetNames(typeof(Fenntartas)))
            {
                comboBox_FenntartasTipusa.Items.Add(item);
            }
        }
    }
}
