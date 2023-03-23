using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2
{
    class Edition
    {
        protected string title;
        protected DateTime date;
        protected int circul;
        public Edition(string title, DateTime date, int circul)
        {
            Title = title;
            Date = date;
            CirculOfEdition = circul;
        }
        public Edition() 
        {
            Title = "NameOfTitle";
            Date = DateTime.Now;
            CirculOfEdition = 13;
        }
        public string Title { get => title; set => title = value; }
        public DateTime Date { get=> date; set=> date = value; }
        public int Circul { get=> circul; set=> circul = value; }

        public int CirculOfEdition
        {
            get { return circul; }
            set
            {
                if ( value < 0 ) 
                {
                    throw new ArgumentOutOfRangeException("Error! CirculOfEdition less than zero!");
                }
                circul= value;
            }
        }
        public virtual bool Equals(object? obj)
        {
            return obj is Edition a && a.title == title && a.date == date && a.circul == circul;
        }
        public static bool operator == (Edition a, Edition b) 
        {
            return a.Equals(b);
        }
        public static bool operator != (Edition a, Edition b) 
        {
            return !(a == b);
        }
        public virtual int GetHashCode()
        {
            return HashCode.Combine(title, date, circul);
        }
        public virtual string ToString()
        {
            return $"{title}, {date}, {circul}";
        }
        public virtual object DeepCopy() => new Edition(Title, date, circul);

    }
}
