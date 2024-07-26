using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AirlineSystem
{
    public partial class Form2 : Form
    
    {
        masterEntities masterEntities;
        static int id = 0;
        public Form2(int ? id)
        {
            
            InitializeComponent();
            if (id != null)
            {
                button1.Visible = false;
                masterEntities = new masterEntities();
                CUSTOMER c = masterEntities.CUSTOMERs.Where(a => a.id == id.Value).FirstOrDefult();
                nametxt.Text = c.NAME;
                DOB.Text =(DateTime)c.DATEOFBIRTH;
            }
            else
            {
                button2.Visible = false;
            }
        }

        public Form2()
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            masterEntities masterEntities = new masterEntities();
            CUSTOMER customers = new CUSTOMER
            {
                NAME = nametxt.Text,
                USERNAME = userntxt.Text,
                CUSTOMERID = idtxt.Text,
                EMAIL = etxt.Text,
                COUNTRY = countrytxt.Text,
                DATEOFBIRTH = DOB.Text,
                PASSWORD = passwtxt.Text,
                CITY = citytxt.Text

            };
            masterEntities.CUSTOMERs.Add(customers);
            masterEntities.SaveChanges();
            MessageBox.Show("One Customer Added");
        }
    }
}
