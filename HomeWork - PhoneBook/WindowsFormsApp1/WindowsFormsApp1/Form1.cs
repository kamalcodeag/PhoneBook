using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            cmbBox1.SelectedIndex = 0;
            cmbBox2.SelectedIndex = 0;
        }

        private bool CheckContactName(string txtName)
        {
            foreach (var name in txtName)
            {
                if ((char)name >= 'a' && (char)name <= 'z' || (char)name >= 'A' && (char)name <= 'Z')
                {
                    return true;
                }
            }
            return false;
        }
        private bool CheckContactNumber(string txtNumber)
        {
            foreach (var name in txtNumber)
            {
                if (int.Parse(name.ToString()) > 1 && int.Parse(name.ToString()) < 10)
                {
                    if (txtNumber.Length == 7)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        private void FindNumbersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void FindNumbersToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, string> contact in PhoneBook.GetContact())
            {
                if (contact.Key != null && contact.Value != null)
                {
                    Form2 form2 = new Form2();
                    form2.ShowDialog();
                }
            }
        }


    }
}
