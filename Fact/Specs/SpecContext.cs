using System;

namespace Fact.Specs
{
    public class SpecContext
    {
        public It it { get; }
        public Context context { get; }
        public static Action before { set { value.Invoke(); } }

        public SpecContext()
        {
            this.it = new It();
            this.context = new Context();
        }
    }
}
