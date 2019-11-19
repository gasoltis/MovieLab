using System;
using System.Collections.Generic;
using System.Text;

namespace Movie
{
    class Movie
    {
        private string title;  // title is a PROPERTY
        private string category; // category is a PROPERTY

        public Movie () { } //DEFAULT CONSTRUCTOR

        public Movie(string title, string category) // CONSTRUCTOR
        {
            Title = title;
            Category = category;
        }

        public string Title

        {
            get { return title; }
            set { title = value; }
        }

        public string Category

        {
            get { return category; }
            set { category = value; }
        }

    }
}
