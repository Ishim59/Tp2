using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Tp2;

namespace Tp11
{
    class Magazine : Edition, IRateAndCopy, IEnumerable<Article>
    {
        public override object DeepCopy()
        {
            Magazine magazineCopy = new Magazine(this.EditInfo,this.frequency);
            foreach(var var_ in editors)
                magazineCopy.AddEditors(var_);
            foreach(var var_ in articles)
                magazineCopy.AddArticles(var_);
            return magazineCopy;
        }
        double IRateAndCopy.Rating { get; }

        Frequency frequency;
        List<Article> articles = new();
        List<Person> editors = new();


        public Magazine(Edition ed, Frequency frequency) : base(ed.Title,ed.Date,ed.Circul)
        {
            this.frequency = frequency;
        }
        public Magazine():base()
        {
            frequency = Frequency.Weekly;
        }
       
        public List<Article> Articles
        {
            get => articles;
            set => articles = value;
        }
        public List<Person> Editors
        {
            get => editors;
            set => editors = value;
        }
        public double Average
        {
            get
            {
                double sum = 0;
                foreach (var a in articles)
                    sum += a.Rating;
                if (articles.Count > 0)
                    return sum / articles.Count;
                return 0;
            }
        }

        public bool this[Frequency frequency]
        {
            get { return frequency == this.frequency; }
        }
        public void AddArticles(params Article[] articles)
        {
            this.articles.AddRange(articles);
        }
        public void AddEditors(params Person[] editors)
        {
            this.editors.AddRange(editors);
        }
        public override string ToString()
        {
            StringBuilder ts = new StringBuilder();
            ts.Append($"{title}, {frequency}, {date}, {circul} \n");
            foreach (var _var in Articles)
            {
                ts.Append(_var.ToString());
                ts.Append('\n');
            }
            foreach(var _var in Editors)
            {
                ts.Append(_var.ToString());
                ts.Append("\n");
            }
            return ts.ToString();

        }
        public virtual string ToShortString()
        {
            return $"{title}, {frequency}, {date}, {circul}, {Average}";
        }

        public Edition EditInfo
        {
            get => new Edition(Title,Date,Circul);
            set
            {
                Title = value.Title;
                Date = value.Date;
                Circul = value.Circul;
            }
        }

        public IEnumerable RateOver (double minRate)
        {
            foreach(var var_ in articles)
            {
                Article ar = (Article)var_;
                if (ar.Rating > minRate)
                    yield return ar;
            }
        }
        public IEnumerable ExistOfTitle(string title)
        {
            foreach(var var_ in articles)
            {
                Article ar = (Article)var_;
                if (ar.Title.IndexOf(title) > -1)
                    yield return ar;
            }
        }
        public IEnumerable ArticlesWithoutEditors()
        {
            foreach (var var_ar in articles)
            {
                bool t = true;
                foreach (var var_ed in editors)
                {
                    if (var_ar.AuthorInfo == var_ed)
                        t = false;
                }
                if (t)
                    yield return var_ar;
            }
        }
        public IEnumerable EditorsWithoutArticles()
        {
            foreach (var var_ed in editors)
            {
                bool t = true;
                foreach (var var_ar in articles)
                {
                    if (var_ar.AuthorInfo == var_ed)
                        t = false;
                }
                if (t)
                    yield return var_ed;
            }
        }
        
        public IEnumerator<Article> GetEnumerator()
        {
            return new MagazineEnumerator(articles, editors);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public class MagazineEnumerator : IEnumerator<Article>
        {

            private List<Article> _articles;
            private List<Person> _editors;
            public MagazineEnumerator(List<Article> articles, List<Person> editors)
            {
                _articles = articles;
                _editors = editors;
            }


            int ind = -1;
            public Article? Current => (ind >= 0 && ind < _articles.Count) ? _articles[ind] : null;

            object? IEnumerator.Current => Current;

            public void Dispose()
            {

            }
            public bool MoveNext()
            {
                while (++ind < _articles.Count)
                {
                    foreach (var editor in _editors)
                    {
                        if (editor == _articles[ind].AuthorInfo)
                            return true;
                    }
                }
                return ind < _articles.Count;
            }
            public void Reset()
            {
                ind = -1;
            }
        }

    }
}
