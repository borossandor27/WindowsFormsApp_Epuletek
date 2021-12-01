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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.form_csaladihaz.ShowDialog();
        }
    }
}
