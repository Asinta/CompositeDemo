using System;
using CompositeDemo.CompositeAbstract;

namespace CompositeDemo.CompositeConcrete
{
    public class Button : IUiComponent
    {
        private readonly string _label;

        public Button(string label)
        {
            _label = label;
        }
        
        public void Draw()
        {
            Console.WriteLine($"print {GetType().Name}({_label})");
        }
    }
}