using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace MissonManagementApplication
{
    public partial class Form2 : Form
    {
        Form1 form1 = new Form1();
        public Form2()
        {
            InitializeComponent();
        }

        private void ekleButton_Click(object sender, EventArgs e)
        {
            string gorevadi=gorevadiTextBox.Text;
            string aciklama = aciklamaTextBox.Text;
            string oncelikderecesi = oncelikderecesiTextBox.Text;
            string bitistarihi = bitistarihiTextBox.Text;

            

            this.Hide();
        }

        private void iptaletButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
