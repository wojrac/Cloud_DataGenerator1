using System;

namespace CloudBackend1.Models
{
    public abstract class Area
    {
        public string Name { get; protected set; }
        public int ContagionNumber{get;protected set;}
        public Area(string name)
        {
            Name = name;
        }
        
        public abstract void RandContagion();
    }
}