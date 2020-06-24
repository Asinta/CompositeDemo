using System;
using CompositeDemo.CompositeAbstract;

namespace CompositeDemo.CompositeConcrete
{
    public class Picture : IUiComponent
    {
        private readonly string _label;

        public Picture(string label)
        {
            _label = label;
        }
        
        public void Draw()
        {
            Console.WriteLine($"print {GetType().Name}({_label})");
        }
    }
}