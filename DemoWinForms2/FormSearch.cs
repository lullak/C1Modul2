using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoWinForms2
{
    public partial class FormSearch : Form
    {
        public FormSearch()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\Birca\Desktop\Namnlista.txt";
            string searchCondition = textBoxSearchCondition.Text;
            listBoxSearchResults.Items.Clear();
            //StreamReader sr = new StreamReader(path);
            //List<string> names = new List<string>();

            //foreach (string name in names)
            //{
            //    listBoxSearchResults.Text = name;
            //}
            //sr.Close();
            using (StreamReader sr = new StreamReader(path)) 
            {
                string row;
                while ((row = sr.ReadLine()) != null) 
                {
                    if (row.ToLower().Contains(searchCondition.ToLower()))
                    {
                        listBoxSearchResults.Items.Add(row);
                    }
                }
            }
        }
    }
}
