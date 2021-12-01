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
    public partial class Form_Csaladihaz : Form
    {
        public Form_Csaladihaz()
        {
            InitializeComponent();
        }

        private void Form_Csaladihaz_Load(object sender, EventArgs e)
        {
            foreach (string item in Enum.GetNames(typeof(Anyagok)))
            {
                comboBox_Epitesianyag.Items.Add(item);
            }
            foreach (string item in Enum.GetNames(typeof(TetoAnyaga)))
            {
                comboBox_TetoTipusa.Items.Add(item);
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_Cim.Text))
            {
                return;
            }
            TetoAnyaga tetoAnyaga = (TetoAnyaga)Enum.Parse(typeof(TetoAnyaga), comboBox_TetoTipusa.SelectedItem.ToString());
            Anyagok epitesiAnyag = (Anyagok)Enum.Parse(typeof(Anyagok), comboBox_Epitesianyag.SelectedItem.ToString());
            Csaladihaz uj = new Csaladihaz(
                textBox_Cim.Text,
                (int)numericUpDown_Alapterulet.Value,
                epitesiAnyag,
                dateTimePicker_Kezdes.Value,
                dateTimePicker_Befejezes.Value,
                (int)numericUpDown_OttElok.Value,
                checkBox_Garazs.Checked,
                tetoAnyaga
                );
            Program.form_Nyito.listBox_Epuletek.Items.Add(uj);
            textBox_Cim.Text = "";
            numericUpDown_Alapterulet.Value = numericUpDown_Alapterulet.Minimum;
            dateTimePicker_Kezdes.Value = DateTime.Now;
            dateTimePicker_Befejezes.Value = DateTime.Now;
            numericUpDown_OttElok.Value = numericUpDown_OttElok.Minimum;
            comboBox_Epitesianyag.SelectedItem = -1;
            comboBox_TetoTipusa.SelectedIndex = -1;
        }
    }
}
