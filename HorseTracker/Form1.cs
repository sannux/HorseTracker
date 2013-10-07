using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorseTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tb_username_Enter(object sender, EventArgs e)
        {
            tb_username.Text = "";
        }

        private void tb_username_Leave(object sender, EventArgs e)
        {
            if (tb_username.Text == "")
            {
                tb_username.Text = "username";
            }
        }

        private void tb_pass_Enter(object sender, EventArgs e)
        {
            tb_pass.Text = "";

            tb_pass.PasswordChar = '*';
        }

        private void tb_pass_Leave(object sender, EventArgs e)
        {
            if (tb_pass.Text == "")
            {
                tb_pass.PasswordChar = '\0';
                tb_pass.Text = "password";
            }
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            string usrnm = tb_username.Text;
            string pass = tb_pass.Text;

            string posdata = "username=" + usrnm + "&password=" + pass;

            Httputil proxy = new Httputil();
            string res = proxy.Post("login", posdata);

            string[] split = res.Split(':');

            if (res != "")
            {
                Main main = new Main();
                main.User_id = split[1];
                main.Tag = this;
                main.Show(this);
                Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Login Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bt_ok.Select();
        }

        private void bt_reg_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Tag = this;
            register.Show(this);
            Hide();
        }

        
    }
}
