using System;

namespace TrabajoPractico4
{
    public class Category 
    {
        public int id { get; set; }
        public String name { get; set; }

        public Category( String name)
        {            
            this.name = name;
        }

        public int CompareTo(Category other)
        {
            return name.CompareTo(other.name);
        }

        
    }
}