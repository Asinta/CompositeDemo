using CompositeDemo.CompositeAbstract;

namespace CompositeDemo.CompositeConcrete
{
    public class Frame : ContainerComponent
    {
        public Frame(string label) : base(label)
        {
        }
    }
}