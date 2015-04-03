using System;

namespace Fact.Specs
{
    public class Spec
    {
        private readonly int _indentation;

        protected Spec(int indentation = 0)
        {
            this._indentation = indentation;
        }

        public Action this[string message]
        {
            set 
            {
                Speclog.Current.Write(message, _indentation);
                value.Invoke(); 
            }
        }
    }
    
    public class Context : Spec { }

    public class It : Spec
    {
        public It() : base(4) { }
    }
}
