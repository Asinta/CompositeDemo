using System;
using CompositeDemo.CompositeAbstract;

namespace CompositeDemo.CompositeConcrete
{
    public class Label : IUiComponent
    {
        private readonly string _label;

        public Label(string label)
        {
            _label = label;
        }
        
        public void Draw()
        {
            Console.WriteLine($"print {GetType().Name}({_label})");
        }
    }
}