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
    public partial class HorseDetails : Form
    {
        public Horse temp_horse;

        private string user_id;

        public string User_id
        {
            get { return user_id; }
            set { user_id = value; }
        }
        
        public HorseDetails()
        {
            InitializeComponent();
        }

        private void HorseDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main main = new Main();
            main.User_id = user_id;
            main.Show();
        }

        private void HorseDetails_Load(object sender, EventArgs e)
        {
            Httputil proxy = new Httputil();
            string res = proxy.Get("getHorse", "&horseid="+temp_horse.Horse_ID);

            string new_res = res.Replace("[{\"horse_ID\":\"", string.Empty).
                                 Replace("\",\"horse_name\":\"", ",").
                                 Replace("\",\"horse_age\":\"", ",").
                                 Replace("\",\"horse_gender\":\"", ",").
                                 Replace("\",\"horse_weight\":\"", ",").
                                 Replace("\",\"day_since_last_run\":\"", ",").
                                 Replace("\",\"horse_form\":\"", ",").
                                 Replace("\",\"total_wins\":\"", ",").
                                 Replace("\",\"penalties\":\"", ",").
                                 Replace("\",\"horse_rating\":\"", ",").
                                 Replace("\",\"trainer\":\"", ",").
                                 Replace("\"}]", string.Empty);

            string[] horse_details = new_res.Split(',');

            temp_horse = new Horse(horse_details[0], horse_details[1], Convert.ToInt16(horse_details[2]), 
                horse_details[3], Convert.ToDecimal(horse_details[4]), Convert.ToInt16(horse_details[5]), 
                horse_details[6], Convert.ToInt16(horse_details[7]), Convert.ToInt16(horse_details[8]), 
                Convert.ToDecimal(horse_details[9]), horse_details[10]);

            lbl_age.Text = temp_horse.Age.ToString();
            lbl_dayrun.Text = temp_horse.DaySinceLastRun.ToString();
            lbl_form.Text = temp_horse.Form;
            lbl_gender.Text = temp_horse.Gender;
            lbl_name.Text = temp_horse.Name;
            lbl_penalty.Text = temp_horse.Penalties.ToString();
            lbl_rating.Text = temp_horse.Rating.ToString();
            lbl_totalwin.Text = temp_horse.TotalWins.ToString();
            lbl_trainer.Text = temp_horse.Trainer;
            lbl_weight.Text = temp_horse.Weight.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Httputil fav_proxy = new Httputil();
            string postData = "userid=" + user_id + "&horseid=" + temp_horse.Horse_ID;
            string res = fav_proxy.Post("favHorse", postData);

            if (res != "")
            {
                MessageBox.Show("Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
