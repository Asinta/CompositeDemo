using System;
using System.Collections.Generic;

namespace CompositeDemo.CompositeAbstract
{
    public class ContainerComponent : IUiComponent
    {
        private readonly string _label;
        private readonly IList<IUiComponent> _uiComponents;

        protected ContainerComponent(string label)
        {
            _label = label;
            _uiComponents = new List<IUiComponent>();
        }

        public void AddComponent(IUiComponent component)
        {
            _uiComponents.Add(component);
        }

        public void RemoveComponent(IUiComponent component)
        {
            _uiComponents.Remove(component);
        }
        
        public void Draw()
        {
            Console.WriteLine($"print {GetType().Name}({_label})");
            foreach (var uiComponent in _uiComponents)
            {
                uiComponent.Draw();
            }
        }
    }
}