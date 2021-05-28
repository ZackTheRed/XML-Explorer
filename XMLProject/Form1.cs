using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace XMLProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var path = @"D:\Temp\fichier.xml";
            var list = listBox1.Items.Cast<String>().ToList();
            XElement xml = new XElement("Elements", list.Select(i => new XElement("Element", i)));
            if (File.Exists(path)) {
                File.Delete(path);
                xml.Save(path);
                MessageBox.Show("Le fichier XML est crée avec succès!\nMerci de verifier le chemin: D:\\Temp\fichier.xml");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (textBox1.Text != String.Empty)
                {
                    listBox1.Items.Add(textBox1.Text);
                    textBox1.Text = String.Empty;
                }
            }
        }
    }
}
