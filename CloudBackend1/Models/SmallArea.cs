using System;

namespace CloudBackend1.Models
{
    public class SmallArea:Area
    {
        public SmallArea(string name) : base(name)
        {}
        public override void RandContagion()
        {
            var rand = new Random();
            this.ContagionNumber = rand.Next(200,3000); 
        }
    }
}