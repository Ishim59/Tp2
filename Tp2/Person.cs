using System.Xml.Linq;
using System;
using Tp2;

namespace Tp11
{
    class Person
    {
        string name;
        string surname;
        DateTime data;
        public Person(string name, string surname, DateTime data)
        {
            this.name = name;
            this.surname = surname;
            this.data = data;
        }
        public Person()
        {
            name = "Иван";
            surname = "Иванов";
            data = new DateTime(2000, 1, 1);
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Surname
        {
            get => surname;
            set => surname = value;
        }
        public DateTime Data
        {
            get => data;
            set => data = value;
        }
        public int Year
        {
            get => data.Year;
            set => data.AddYears(value - data.Year);
        }
        public override string ToString()
        {
            return $"{name} {surname} {data}";
        }
        public virtual string ToShortString()
        {
            return $"{name} {surname}";

        }
        public override bool Equals(object? obj)
        {
            return obj is Person a && a.name == name && a.surname == surname && a.data == data;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(name, surname, data);
        }
        public static bool operator ==(Person a, Person b)
        {
            return a.Equals(b);
        }
        public static bool operator !=(Person a, Person b)
        {
            return !(a == b);
        }
        public virtual object DeepCopy() => new Person { name = name, surname = surname, data = data };

    }
    public enum Frequency
    {
        Weekly,
        Monhly,
        Yearly
    }
}
