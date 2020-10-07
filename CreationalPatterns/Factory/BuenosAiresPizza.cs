using System.Collections.Generic;
using System.Linq;

namespace CreationalPatterns.Factory
{
    class BuenosAiresPizza : Pizza
    {
        public BuenosAiresPizza(IList<string> ingredients) : base(ingredients)
        {
            Dough = DoughType.None;
        }

        public override void Bake() { }
        public override void Cut() { }
        public override void Box() { }
    }
}
