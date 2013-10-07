using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorseTracker
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void tb_fullname_Enter(object sender, EventArgs e)
        {
            tb_fullname.Text = "";
        }

        private void tb_fullname_Leave(object sender, EventArgs e)
        {
            if (tb_fullname.Text == "")
            {
                tb_fullname.Text = "Enter Full Name";
            }
        }

        private void tb_username_Leave(object sender, EventArgs e)
        {
            if (tb_username.Text == "")
            {
                tb_username.Text = "Enter Username";
            }
            
        }

        private void tb_username_Enter(object sender, EventArgs e)
        {
            tb_username.Text = "";
        }

        private void tb_pass_Leave(object sender, EventArgs e)
        {
            if (tb_pass.Text == "")
            {
                tb_pass.PasswordChar = '\0';
                tb_pass.Text = "Enter Password";
            }
        }

        private void tb_pass_Enter(object sender, EventArgs e)
        {
            tb_pass.Text = "";

            tb_pass.PasswordChar = '*';
        }

        private void tb_confirm_Enter(object sender, EventArgs e)
        {
            tb_confirm.Text = "";

            tb_confirm.PasswordChar = '*';
        }

        private void tb_confirm_Leave(object sender, EventArgs e)
        {
            if (tb_confirm.Text == "")
            {
                tb_confirm.PasswordChar = '\0';
                tb_confirm.Text = "Confirm password";
            }
        }

        private void tb_email_Enter(object sender, EventArgs e)
        {
            tb_email.Text = "";
        }

        private void tb_email_Leave(object sender, EventArgs e)
        {
            if (tb_email.Text == "")
            {
                tb_email.Text = "Enter Email";
            }
        }

        private void bt_reg_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            string code = string.Format("{0}{1}{2}{3}", time.Hour, time.Minute, time.Second, time.Millisecond);
            long c = Convert.ToInt64(code);

            string date = b_date.Value.ToString("yyyy-MM-dd");

            if (tb_fullname.Text != "" ||
                tb_fullname.Text != "Enter Full Name" ||
                tb_username.Text != "" ||
                tb_username.Text != "Enter Username" ||
                tb_pass.Text != "" ||
                tb_pass.Text != "Enter Password" ||
                tb_confirm.Text != "" ||
                tb_confirm.Text != "Confirm password" ||
                tb_email.Text != "" ||
                tb_email.Text != "Enter Email")
            {
                if (tb_pass.Text == tb_confirm.Text)
                {
                    if(IsEmailValid(tb_email.Text))
                    {
                        string id = "U"+c.ToString();
                        User user_reg = new User(id, tb_username.Text, tb_pass.Text, tb_fullname.Text, tb_email.Text, date);
                        Httputil proxy = new Httputil();
                        string res = proxy.Post("register", user_reg.ToString());

                        if (res != "")
                        {

                            MessageBox.Show("Successfully registered", "Success", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Main main = new Main();
                            main.User_id = id;
                            main.Tag = this;
                            main.Show(this);
                            Hide();
                        }
                        
                    }
                }
            }

        }

        public bool IsEmailValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            bt_reg.Select();
        }
    }
}
