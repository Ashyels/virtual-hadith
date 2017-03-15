using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Virtual_Hadist
{
    public partial class Form_Start : Form
    {
        public Form_Start()
        {
            InitializeComponent();
            btn_Start.Visible = true;
        }

        private void Form_Start_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            Form_Menu fm = new Form_Menu();
            this.Hide();
            fm.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
           

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
