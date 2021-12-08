using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp_Epuletek
{
    public partial class Form_Nyito : Form
    {
        public Form_Nyito()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AdatokBetoltese();
        }

        private void AdatokBetoltese()
        {
            //-- adatok betöltése az "epuletek.csv" fájlból ----------
            if (File.Exists("epuletek.csv"))
            {
                //-- Létezik a fájl, beolvassuk az adatokat
                using (StreamReader sr = new StreamReader("epuletek.csv"))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] sor = sr.ReadLine().Split(';');
                        if (sor[0].Equals("csaladi"))
                        {
                            Csaladihaz uj = new Csaladihaz(
                                sor[1],
                                int.Parse(sor[2]),
                                (Anyagok)Enum.Parse(typeof(Anyagok), sor[3]),
                                DateTime.Parse(sor[4]),
                                DateTime.Parse(sor[5]),
                                int.Parse(sor[6]),
                                bool.Parse(sor[7]),
                                (TetoAnyaga)Enum.Parse(typeof(TetoAnyaga), sor[8])
                                );
                            listBox_Epuletek.Items.Add(uj);
                        }
                        else
                        {
                            Tombhaz uj = new Tombhaz(
                                sor[1],
                                int.Parse(sor[2]),
                                (Anyagok)Enum.Parse(typeof(Anyagok), sor[3]),
                                DateTime.Parse(sor[4]),
                                DateTime.Parse(sor[5]),
                                int.Parse(sor[6]),
                                (Fenntartas)Enum.Parse(typeof(Fenntartas), sor[7]),
                                bool.Parse(sor[8]));
                            listBox_Epuletek.Items.Add(uj);
                        }
                    }
                }
            }

        }

        private void button_uj_csaladi_Click(object sender, EventArgs e)
        {
            Program.form_csaladihaz.ShowDialog();
        }

        private void button_uj_tombhaz_Click(object sender, EventArgs e)
        {
            Program.form_Tombhaz.ShowDialog();
        }

        private void Save_Epuletek()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("epuletek.csv"))
                {
                    foreach (var item in listBox_Epuletek.Items)
                    {
                        if (typeof(Csaladihaz) == item.GetType())
                        {
                            sw.WriteLine(((Csaladihaz)item).toCSV());
                        }
                        else
                        {
                            sw.WriteLine(((Tombhaz)item).toCSV());
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            //MessageBox.Show("Sikeres mentés");
        }

        private void Form_Nyito_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("valóban kilép?","Megerősítés",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Save_Epuletek();
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }

        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (listBox_Epuletek.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kiválasztott épület");
                return;
            }
            if (MessageBox.Show("Valóban törli?", "Figyelmeztetés",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                listBox_Epuletek.Items.RemoveAt(listBox_Epuletek.SelectedIndex);
            }
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            if (listBox_Epuletek.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kiválasztva elem");
                return;
            }
            
            if (listBox_Epuletek.SelectedItem.GetType()== typeof(Csaladihaz))
            {
                Program.form_csaladihaz.Muvelet = "update";
                Program.form_csaladihaz.ShowDialog();
            }
            else
            {
                //-- Tömbház adatainak a módosítása
            }

        }
    }
}
