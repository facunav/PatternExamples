using System.Collections.Generic;

namespace CreationalPatterns.Factory
{
    public class MarDelPlataPizza : Pizza
    {
        public MarDelPlataPizza(IList<string> ingredients) : base(ingredients)
        {
            Dough = DoughType.Thin;
        }

        public override void Bake() { }
        public override void Cut() { }
        public override void Box() { }
    }
}
