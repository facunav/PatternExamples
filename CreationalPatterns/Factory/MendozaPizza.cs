using System.Collections.Generic;

namespace CreationalPatterns.Factory
{
    public class MendozaPizza : Pizza
    {
        public MendozaPizza(IList<string> ingredients) : base(ingredients)
        {
            Dough = DoughType.Pan;
        }

        public override void Bake() { }
        public override void Cut() { }
        public override void Box() { }
    }
}
