using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseTracker
{
    public class Jockey
    {
        #region private proporties
        private string id;
        private string name;       
        private decimal rating;           
        private string form;
        #endregion

        #region public proporties
        public string Id
        {
            get { return id; }
            set { id = value; }
        } 
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public decimal Rating
        {
            get { return rating; }
            set { rating = value; }
        }

        public string Form
        {
            get { return form; }
            set { form = value; }
        }
        #endregion public proporties

        public Jockey(string id, string name, decimal rating, string form)
        {
            this.id = id;
            this.name = name;
            this.rating = rating;
            this.form = form;
        }

        public Jockey()
        {
            this.id = "";
            this.name = "";
            this.rating = 0;
            this.form = "";
        }

    }
}

