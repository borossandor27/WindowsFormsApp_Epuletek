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
        public string Muvelet = "uj";
        public Form_Csaladihaz()
        {
            InitializeComponent();
        }

        private void Form_Csaladihaz_Load(object sender, EventArgs e)
        {
            Csaladihaz kiv = (Csaladihaz)Program.form_Nyito.listBox_Epuletek.SelectedItem;
            if (Muvelet.Equals("update"))
            {
                textBox_Cim.Text = kiv.Cim;
                textBox_Cim.ReadOnly = true;
                numericUpDown_Alapterulet.Value = kiv.Alapterulet;
                comboBox_Epitesianyag.Enabled = false;
                dateTimePicker_Befejezes.Value = kiv.Befejezes;
                dateTimePicker_Kezdes.Value = kiv.Kezdes;
                numericUpDown_OttElok.Value = kiv.OttElok;
                checkBox_Garazs.Checked = kiv.VanGarazs;
            }
            foreach (string item in Enum.GetNames(typeof(Anyagok)))
            {
                int index = comboBox_Epitesianyag.Items.Add(item);
                if (Muvelet.Equals("update") && kiv.Epitesianyag.ToString().Equals(item))
                {
                    //-- Ha nem állítjuk be, akkor -1 marad !!!
                    comboBox_Epitesianyag.SelectedIndex = index;
                }
            }
            foreach (string item in Enum.GetNames(typeof(TetoAnyaga)))
            {
                int index = comboBox_TetoTipusa.Items.Add(item);
                if (Muvelet.Equals("update") && kiv.Tetotipus.ToString().Equals(item))
                {
                    comboBox_TetoTipusa.SelectedIndex = index;
                }
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_Cim.Text))
            {
                return;
            }
            TetoAnyaga tetoAnyaga = (TetoAnyaga)Enum.Parse(typeof(TetoAnyaga), comboBox_TetoTipusa.SelectedIndex.ToString());
            Anyagok epitesiAnyag = (Anyagok)Enum.Parse(typeof(Anyagok), comboBox_Epitesianyag.SelectedIndex.ToString());
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
            if (Muvelet.Equals("update"))
            {
                int index = Program.form_Nyito.listBox_Epuletek.SelectedIndex;
                Program.form_Nyito.listBox_Epuletek.Items.RemoveAt(index);
                Program.form_Nyito.listBox_Epuletek.Items.Insert(index, uj);
            }
            else
            {
                Program.form_Nyito.listBox_Epuletek.Items.Add(uj);
            }
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
