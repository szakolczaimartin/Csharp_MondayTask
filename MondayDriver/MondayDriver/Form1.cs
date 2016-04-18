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

namespace MondayDriver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] drives = System.IO.Directory.GetLogicalDrives();

            foreach (string item in drives)
            {
                comboBox1.Items.Add(item);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
               listBox1.Items.Clear();
                pathText.Text = comboBox1.Text;
                string[] directoryList = Directory.GetDirectories(pathText.Text);
                foreach (string item in directoryList)
                {
                    listBox1.Items.Add(item);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            getPath(listBox1.SelectedItem.ToString());

        }



        public void getPath(string marketItem)
        {
            try
            {
                string[] directoryList = Directory.GetDirectories(@marketItem);
                string[] fileList = Directory.GetFiles(@marketItem);
                pathText.Text = @marketItem;
                listBox1.Items.Clear();
                foreach (var directory in directoryList)
                {
                    listBox1.Items.Add(directory);
                }
                foreach (var file in fileList)
                {
                    listBox1.Items.Add(file);
                }
            }
            catch (Exception exception)
            {
                
                    MessageBox.Show("This is a File.");
                

            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Delete this file?","Important Question",MessageBoxButtons.YesNo);

            if (result1 == DialogResult.Yes)
            {
                File.Delete(@listBox1.SelectedItem.ToString());
                getPath(pathText.Text);
            }

                     
        }
    }


}
