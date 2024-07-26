using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineSystem
{
    public partial class Form1 : Form
    {
        private masterEntities masterEntities;

        public Form1()
        {
            InitializeComponent();
            masterEntities = new masterEntities();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(usertxt.Text) && !string.IsNullOrEmpty(passtxt.Text))
            {
                try
                {
                    var user = masterEntities.ADMINs.SingleOrDefault(a => a.USERNAME.Equals(usertxt.Text));
                    if (user != null)
                    {
                        if (user.PASSWORD.Equals(passtxt.Text))
                        {
                            MessageBox.Show("Login successful!");
                            // Transition to Form2
                            Form2 form2 = new Form2();
                            form2.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Wrong password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            passtxt.Clear();
                            passtxt.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wrong username!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        usertxt.Clear();
                        passtxt.Clear();
                        usertxt.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter the username and password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
