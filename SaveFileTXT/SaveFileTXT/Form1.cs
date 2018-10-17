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

namespace SaveFileTXT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = saveFile.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter oStreamWriter = null;

            try
            {
                oStreamWriter = new StreamWriter(textBox2.Text);
                oStreamWriter.WriteLine(textBox1.Text);

                MessageBox.Show("Save is Done!", "Messege",
                    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                oStreamWriter = null;

            }
            finally
            {
                oStreamWriter.Dispose();
                oStreamWriter = null;
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

