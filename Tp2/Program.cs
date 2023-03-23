using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using Tp11;
using Tp2;

class Program
{
    public static void Main()
    {
        ////1
        //Person person1 = new Person("name", "surname", DateTime.Today);
        //Person person2 = new Person("name", "surname", DateTime.Today);
        //Console.WriteLine(person1 == person2);
        //Console.WriteLine(person1.Equals(person2));
        //Console.WriteLine(person1.GetHashCode());
        //Console.WriteLine(person2.GetHashCode() + "\n");
        //Console.ReadKey();
        ////2
        //try
        //{
        //    Edition edition = new Edition("title", DateTime.Today, 10);
        //    Console.WriteLine("All right!");
        //}
        //catch (ArgumentOutOfRangeException ex)
        //{
        //    Console.WriteLine($"{ex.Message}");
        //}
        //Console.WriteLine();
        //Console.ReadKey();

        ////3
        //Magazine magazine3 = new Magazine();
        //magazine3.AddEditors(new Person());
        //magazine3.AddArticles(new Article());
        //Console.WriteLine(magazine3.ToString());
        //Console.ReadKey();

        ////4
        //Console.WriteLine(magazine3.EditInfo.ToString());
        //Console.WriteLine();
        //Console.ReadKey();

        ////5
        //Magazine magazine5 = new Magazine();
        //Magazine magazineCopy = (Magazine)magazine5.DeepCopy();
        //magazine5.Title = "NewTitle";
        //magazine5.Date = DateTime.Today;
        //magazine5.Circul = 100;
        //magazine5 = new Magazine(magazine5.EditInfo, Frequency.Yearly);
        //Console.WriteLine(magazine5.ToString());
        //Console.WriteLine(magazineCopy.ToString());
        //Console.ReadKey();

        ////6,7
        //Magazine articles = new Magazine();
        //articles.AddArticles(new Article(new Person("Name1", "SurName1", DateTime.Today), "TitleOf", 20),
        //    new Article(new Person("Name2", "SurName2", DateTime.Today), "Title12", 30),
        //    new Article(new Person("Name3", "SurName3", DateTime.Today), "Ttle", 40));
        //foreach (var article in articles.RateOver(20))
        //    Console.WriteLine(article);
        //Console.WriteLine();
        //foreach (var article in articles.ExistOfTitle("Title"))
        //    Console.WriteLine(article);
        //Console.WriteLine();

        ////8
        //Magazine articles = new Magazine();
        //articles.AddArticles(new Article(new Person("Name1", "SurName1", DateTime.Today), "Title", 10),
        //    new Article(new Person("Name2", "SurName2", DateTime.Today), "Title", 10),
        //    new Article(new Person("Name3", "SurName3", DateTime.Today), "Title", 10),
        //    new Article(new Person("Name5", "SurName5", DateTime.Today), "Title", 10),
        //     new Article(new Person("Name6", "SurName6", DateTime.Today), "Title", 10));
        //articles.AddEditors(new Person("Name1", "SurName1", DateTime.Today),
        //    new Person("Name3", "SurName3", DateTime.Today),
        //    new Person("Name4", "SurName4", DateTime.Today),
        //    new Person("Name5", "SurName5", DateTime.Today),
        //    new Person("Name7", "SurName7", DateTime.Today));
        //foreach (var article in articles.ArticlesWithoutEditors())
        //{
        //    Console.WriteLine(article);
        //}
        //Console.WriteLine();
        ////9
        //foreach(var article in articles) { Console.WriteLine(article); }
        //Console.WriteLine();    
        ////10
        //foreach (var article in articles.EditorsWithoutArticles())
        //{
        //    Console.WriteLine(article);
        //}




    }
}