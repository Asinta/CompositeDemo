using System;
using CompositeDemo.CompositeAbstract;

namespace CompositeDemo.CompositeConcrete
{
    public class TextBox : IUiComponent
    {
        private readonly string _label;

        public TextBox(string label)
        {
            _label = label;
        }
        
        public void Draw()
        {
            Console.WriteLine($"print {GetType().Name}({_label})");
        }
    }
}