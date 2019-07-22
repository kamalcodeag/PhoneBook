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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (var contact in PhoneBook.GetContact())
            {
                comboBox1.Items.Add(contact.Key);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Silməyə əminsinizmi ?", "Təsdiq", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                PhoneBook.RemoveContact(comboBox1.SelectedItem.ToString());
                comboBox1.Items.Clear();
                foreach (var contact in PhoneBook.GetContact())
                {
                    comboBox1.Items.Add(contact.Key);
                }
                MessageBox.Show("Silindi");
            }
        }
    }
}
