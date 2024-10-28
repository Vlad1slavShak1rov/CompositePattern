using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class Section:IDocumentComponent
    {
        string heading;
        List<IDocumentComponent> children = new List<IDocumentComponent>();
        public Section(string text)
        {
            this.heading = text;
        }

        public void Add(IDocumentComponent component)
        {
            if (component is Paragraph paragraph) children.Add(component);
            else throw new ArgumentException();

        }

        public void Remove(IDocumentComponent component)
        {
            children.Remove(component);
        }

        public void Display()
        {
            Console.WriteLine(heading);
            foreach (IDocumentComponent component in children) 
                component.Display();
            
        }
    }
}
