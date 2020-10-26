using System;
namespace CloudBackend1.Models
{
    public class BigArea : Area
    {
        public BigArea(string name) : base(name)
        {}
        public override void RandContagion()
        {
            var rand = new Random();
            this.ContagionNumber = rand.Next(3000,20000); 
        }
    }
}