using System;

namespace CloudBackend1.Models
{
    public class MediumArea:Area
    {
        public MediumArea(string name) : base(name)
        { }
        public override void RandContagion()
        {
            var rand = new Random();
            this.ContagionNumber = rand.Next(1000, 10000);
        }
    }
}