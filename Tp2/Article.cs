using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using Tp2;

namespace Tp11
{
    class Article : IRateAndCopy
    {
        public virtual object DeepCopy()
        {
            Article articleCopy = new Article(this.AuthorInfo,this.Title,this.Rating);
            return articleCopy;
        }

        double IRateAndCopy.Rating { get; }

        public Person AuthorInfo
        {
            get; set;
        }
        public string Title
        {
            get; set;
        }
        public double Rating
        {
            get; set;
        }
        public Article(Person authorInfo, string title, double rating)
        {
            this.AuthorInfo = authorInfo;
            this.Title = title;
            this.Rating = rating;
        }
        public Article()
        {
            AuthorInfo = new Person("Артур", "Сидоров", new DateTime(1900, 1, 1));
            Title = "Правда России";
            Rating = 12;
        }
        public override string ToString()
        {
            return $"{AuthorInfo}, {Title}, {Rating}";
        }

    }
}
