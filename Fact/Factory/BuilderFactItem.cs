using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fact.Factory
{
    internal class BuilderFactItem
    {
        public Type Type { get; private set; }
        public object Object { get; private set; }
        public string Context { get; private set; }

        public BuilderFactItem(Type type, object value, string context = "default")
        {
            this.Type = type;
            this.Object = value;
            this.Context = context;
        }
    }
}
