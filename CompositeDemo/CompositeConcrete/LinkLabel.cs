using System;
using CompositeDemo.CompositeAbstract;

namespace CompositeDemo.CompositeConcrete
{
    public class LinkLabel : IUiComponent
    {
        private readonly string _label;

        public LinkLabel(string label)
        {
            _label = label;
        }
        
        public void Draw()
        {
            Console.WriteLine($"print {GetType().Name}({_label})");
        }
    }
}