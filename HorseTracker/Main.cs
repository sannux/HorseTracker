using System;
using System.Collections;
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
    public partial class Main : Form
    {
        private string user_id;

        public string User_id
        {
            get { return user_id; }
            set { user_id = value; }
        }

        
        private Dictionary<string, string> final_list;

        public Main()
        {
            
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                #region gettin horse list
                Httputil proxy = new Httputil();
                string res = proxy.Get("horseList");

                if (res != "")
                {
                    foreach (var horse_name in ReturnHorseNames(res))
                    {
                        list_horses.Items.Add(horse_name);
                    }
                }
                #endregion
            }
            



        }

        private List<string> ReturnHorseNames(string res)
        {
            char[] trash = { '[', '{', '}', ']', '\"' };
            string newres = res.Trim(trash).Replace("\"},{\"", ",").Replace("\":\"", ":").
                Replace("\",\"", "|").Replace("horse_name:", string.Empty).Replace("horse_id:", string.Empty);

            List<string> lst_horse = new List<string>(newres.Split(','));
            final_list = new Dictionary<string, string>();
            final_list.Clear();

            foreach (var horse in lst_horse)
            {
                string[] temp = horse.Split('|');
                final_list.Add(temp[0], temp[1]);
            }

            List<string> horse_names = new List<string>(final_list.Keys);

            return horse_names;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Search";
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            list_horses.SelectedItems.Clear();
            list_horses.SelectionMode = SelectionMode.MultiSimple;
            for (int i = list_horses.Items.Count - 1; i >= 0; i--)
            {
                if (list_horses.Items[i].ToString().ToLower().Contains(textBox1.Text.ToLower()))
                {
                    list_horses.SetSelected(i, true);
                }
            }

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //this is actually the same code as the button code
                list_horses.SelectedItems.Clear();
                for (int i = list_horses.Items.Count - 1; i >= 0; i--)
                {
                    if (list_horses.Items[i].ToString().ToLower().Contains(textBox1.Text.ToLower()))
                    {
                        list_horses.SetSelected(i, true);
                    }
                }
            }
        }

        private void bt_favOK_Click(object sender, EventArgs e)
        {
            fav_list.SelectedItems.Clear();
            for (int i = fav_list.Items.Count - 1; i >= 0; i--)
            {
                if (fav_list.Items[i].ToString().ToLower().Contains(txt_favsearch.Text.ToLower()))
                {
                    fav_list.SetSelected(i, true);
                }
            }
        }

        private void txt_favsearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                fav_list.SelectedItems.Clear();
                for (int i = fav_list.Items.Count - 1; i >= 0; i--)
                {
                    if (fav_list.Items[i].ToString().ToLower().Contains(txt_favsearch.Text.ToLower()))
                    {
                        fav_list.SetSelected(i, true);
                    }
                }
            }
        }

        private void list_horses_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (list_horses.SelectedItem != null)
            {
                string horse_name = list_horses.SelectedItem.ToString();

                foreach (var _name in final_list)
                {
                    if (_name.Key == horse_name)
                    {
                        HorseDetails horseDetails = new HorseDetails();
                        horseDetails.temp_horse = new Horse();
                        horseDetails.temp_horse.Horse_ID = _name.Value;
                        horseDetails.User_id = user_id;
                        horseDetails.Tag = this;
                        horseDetails.Show(this);
                        Hide();
                    }
                }

            }
        }

        private void list_horses_MouseClick(object sender, MouseEventArgs e)
        {
            list_horses.SelectionMode = SelectionMode.One;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                #region gettin horse list
                final_list.Clear();
                list_horses.Items.Clear();
                Httputil proxy = new Httputil();
                string res = proxy.Get("horseList");
                if (res != "")
                {
                    foreach (var horse_name in ReturnHorseNames(res))
                    {
                        list_horses.Items.Add(horse_name);
                    }
                }
                #endregion
            }

            if (tabControl1.SelectedTab == tabPage2)
            {
                #region get fav horse list
                final_list.Clear();
                fav_list.Items.Clear();
                Httputil favproxy = new Httputil();
                string postData = "&userid=" + user_id;
                string fav_res = favproxy.Get("favHorsesList", postData);
                if (fav_res != "")
                {
                    foreach (var horse_name in ReturnHorseNames(fav_res))
                    {
                        fav_list.Items.Add(horse_name);
                    }
                }
                #endregion
            }

        }
    }
}
