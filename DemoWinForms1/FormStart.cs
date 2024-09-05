using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoWinForms1
{
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{textBox1.Text} är tillagd i filen");
            
            string path = @"C:\Users\Birca\Desktop\Namnlista.txt"; 

            using(StreamWriter sw = new StreamWriter(path, true))
            {  
              sw.WriteLine(textBox1.Text);
            }
            textBox1.Clear();
        }

     }   
 }


