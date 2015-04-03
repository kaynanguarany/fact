using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fact.Factory
{
    public class Builder
    {
        private static List<BuilderFactItem> facts = new List<BuilderFactItem>();

        public static Builder Current { get; } = new Builder();

        public void Clear() => facts?.Clear();

        public void Set(object value) => Set("default", value);

        public T Build<T>() => Build<T>("default");

        public T Build<T>(string context)
        {
            var result = from fact in facts
                         where fact.Type == typeof(T) && fact.Context == context
                         select fact;

            return (T)result.First().Object;
        }

        public void Set(string context, object value)
        {
            facts?.Add(new BuilderFactItem(value.GetType(), value, context));
        }
    }
}
