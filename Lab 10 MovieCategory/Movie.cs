using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10_MovieCategory
{
    class Movie
    {
        private string title = "";
        private string category = "";

        public Movie(string Title, string Category)
        {
            this.title = Title;
            this.category = Category;
        }

        public string Title
        {
           get {      return title;                       
                }
        }

        public string Category
        {get { return category; }
        }
        public void Oops() {
            throw new Exception("Something gone wrong oops.");
        }
        
    }
}
