using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    //public  class PhoneBook
    //{
    //    public static Dictionary<string, string> contacts = new Dictionary<string, string>();

    //    public string this[string name]
    //    {
    //        get
    //        {
    //            foreach (KeyValuePair<string, string> c in contacts)
    //            {
    //                if (c.Key != null && c.Value != null && c.Key == name)
    //                {
    //                    return c.Key + " " + c.Value;
    //                }
    //            }
    //            return "";
    //        }
    //        set
    //        {
    //            try
    //            {
    //                contacts.Add(name, value);
    //            }
    //            catch
    //            {
    //                MessageBox.Show("***Sorry, the key and value pair you want to input already exists.***");
    //            }
    //        }
    //    }

    //    public static void DeleteContact(string name)
    //    {
    //        contacts.Remove(name);
    //    }
    //}

    public static class PhoneBook
    {
        private static Dictionary<string, string> contacts = new Dictionary<string, string>();

        public static void AddContact(string name, string number)
        {
            contacts.Add(name, number);
        }

        public static Dictionary<string, string> GetContact()
        {
            return contacts;
        }

        public static void RemoveContact(string name)
        {
            contacts.Remove(name);
        }
    }
}
