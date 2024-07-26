using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineSystem
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            masterEntities masterEntities = new masterEntities();
           var item =  masterEntities.CUSTOMERs.ToList();
            dataGridView1.DataSource = item;
        }
        private void searchtxt_TextChanged(object sender, EventArgs e)
        {
            masterEntities masterEntities = new masterEntities();
            var item = masterEntities.CUSTOMERs.ToList();
            dataGridView1.DataSource = item;

        }

        private void searchtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            masterEntities masterEntities = new masterEntities();
            var item = masterEntities.CUSTOMERs.Where(a=> a.NAME.Equals(searchtxt.Text)).ToList();
            dataGridView1.DataSource = item;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.SelectedCells[0].Value);
            CUSTOMER c = new CUSTOMER();
            c.showDialog();
        }
    }
}
