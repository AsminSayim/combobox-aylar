using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace combobox_aylar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            listBox1.Items.Clear(); 

            if (comboBox1.SelectedIndex == 0) 
            {
                listBox1.Items.Add("MART");
                listBox1.Items.Add("NİSAN");
                listBox1.Items.Add("MAYIS");
                pictureBox1.Image = Properties.Resources.ilkbahar;
            }
            else if (comboBox1.SelectedIndex == 1) 
            {
                listBox1.Items.Add("HAZİRAN");
                listBox1.Items.Add("TEMMUZ");
                listBox1.Items.Add("AĞUSTOS");
                pictureBox1.Image = Properties.Resources.yaz;
            }
            else if (comboBox1.SelectedIndex == 2) 
            {
                listBox1.Items.Add("EYLÜL");
                listBox1.Items.Add("EKİM");
                listBox1.Items.Add("KASIM");
                pictureBox1.Image = Properties.Resources.sonbahar;
            }
            else if (comboBox1.SelectedIndex == 3) 
            {
                listBox1.Items.Add("ARALIK");
                listBox1.Items.Add("OCAK");
                listBox1.Items.Add("ŞUBAT");
                pictureBox1.Image = Properties.Resources.kış;
            }
        }
           
        }
    }

