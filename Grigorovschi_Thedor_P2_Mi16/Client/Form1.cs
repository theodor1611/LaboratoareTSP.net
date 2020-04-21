using MyPhotosP2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        //InterfaceApiClient client = new InterfaceApiClient();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
        }

        private void buttonMemorare_Click(object sender, EventArgs e)
        {
            InterfaceApiClient client = new InterfaceApiClient();
            if (textBox1.Text != null)
            {
                client.PreluarePoza(textBox1.Text);
                textBox1.Text = "";
                client.Close();
            }
        }

        private void buttonCautare_Click(object sender, EventArgs e)
        {
            InterfaceApiClient client = new InterfaceApiClient();
            //List<DTO> rezultate = new List<DTO>();
            if (textBox2.Text != null && textBox3.Text != null)
            {
                //rezultate = client.Cautare(textBox2.Text, textBox3.Text);
                var bindingList = new BindingList<DTO>(client.Cautare(textBox2.Text, textBox3.Text));
                var source = new BindingSource(bindingList, null);
                dataGridView1.DataSource = source;
                client.Close();
            }
        }

        private void buttonAddProp_Click(object sender, EventArgs e)
        {
            InterfaceApiClient client = new InterfaceApiClient();
            if (textBox1.Text != null && textBox2.Text != null && textBox3.Text != null)
            {
                client.AdaugaProprietate(textBox1.Text, textBox2.Text, textBox3.Text);
                client.Close();
            }
        }

        private void buttonDelProp_Click(object sender, EventArgs e)
        {
            InterfaceApiClient client = new InterfaceApiClient();
            if (textBox1.Text != null && textBox2.Text != null && textBox3.Text != null)
            {
                client.StergeProprietate(textBox1.Text, textBox2.Text, textBox3.Text);
                client.Close();
            }
        }

        private void buttonDelPhoto_Click(object sender, EventArgs e)
        {
            InterfaceApiClient client = new InterfaceApiClient();
            if (textBox1.Text != null)
            {
                client.StergePoza(textBox1.Text);
                client.Close();
            }
        }

        private void buttonChangeProp_Click(object sender, EventArgs e)
        {
            InterfaceApiClient client = new InterfaceApiClient();
            if (textBox2.Text != null && textBox3.Text != null)
            {
                client.SchimbaProprietate(textBox2.Text, textBox3.Text);
                client.Close();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string fullPath = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();

            Process.Start(fullPath);
        }

    }
}
