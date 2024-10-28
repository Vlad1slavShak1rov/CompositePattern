using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    internal class Document:IDocumentComponent
    {
        string name;
        List<IDocumentComponent> nodes = new List<IDocumentComponent>();
        public Document(string name)
        {
            this.name = name;
        }

        public void Add(IDocumentComponent component) 
        {
            if (component is Section section) nodes.Add(component);
            else throw new ArgumentException();
        }
        public void Remove(IDocumentComponent component) { nodes.Remove(component); }
        public void Display()
        {
            Console.WriteLine(name);
            foreach (IDocumentComponent component in nodes) 
                component.Display();
        }
    }
}
