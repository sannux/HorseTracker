using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseTracker
{
    public class Horse
    {
        #region private proporties
        private string horse_ID;
        private string name;
        private int age;
        private string gender;
        private decimal weight;
        private int daySinceLastRun;
        private string form;
        private int totalWins;
        private int penalties;
        private decimal rating;
        private string trainer;
        #endregion

        #region public proporties
        public string Horse_ID
        {
            get { return horse_ID; }
            set { horse_ID = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public decimal Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public int DaySinceLastRun
        {
            get { return daySinceLastRun; }
            set { daySinceLastRun = value; }
        }

        public string Form
        {
            get { return form; }
            set { form = value; }
        }

        public int TotalWins
        {
            get { return totalWins; }
            set { totalWins = value; }
        }

        public int Penalties
        {
            get { return penalties; }
            set { penalties = value; }
        }

        public decimal Rating
        {
            get { return rating; }
            set { rating = value; }
        }

        public string Trainer
        {
            get { return trainer; }
            set { trainer = value; }
        }
        #endregion 

        public Horse(string horse_ID, string name, int age, string gender, decimal weight, int daySinceLastRun,
            string form, int totalWins, int penalties, decimal rating, string trainer)
        {
            this.horse_ID = horse_ID;
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.weight = weight;
            this.daySinceLastRun = daySinceLastRun;
            this.form = form;
            this.totalWins = totalWins;
            this.penalties = penalties;
            this.rating = rating;
            this.trainer = trainer;
        }

        public Horse()
        {
            this.horse_ID = "";
            this.name = "";
            this.age = 0;
            this.gender = "";
            this.weight = 0;
            this.daySinceLastRun = 0;
            this.form = "";
            this.totalWins = 0;
            this.penalties = 0;
            this.rating = 0;
            this.trainer = "";
        }
    }
}
