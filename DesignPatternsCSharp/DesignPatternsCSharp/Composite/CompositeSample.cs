using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.Composite
{
    public abstract class Component {
        protected string Name { get; set; }
        public Component(string name) {
            this.Name = name;
        }

        public abstract void Add(Component component);
        public abstract void Remove(Component component);   
        public abstract void Display(int depth);

    }

    public class Composite : Component
    {
        List<Component> children = new List<Component>();

        public Composite(string name) : base(name) { }

        public override void Add(Component component)
        {
            children.Add(component);
        }

        public override void Remove(Component component) {
            children.Remove(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + Name);
            foreach (Component component in children)
            {
                component.Display(depth + 2);
            }
        }
    }

    public class Leaf : Component
    {
        public Leaf(string name) : base(name) { }

        public override void Add(Component component)
        {
            Console.WriteLine("Cannot add to a leaf");
        }

        public override void Remove(Component component)
        {
            Console.WriteLine("Cannot remove from a leaf");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + Name);
        }
    }

    public class CompositeSample
    {
        public void Run()
        {
            Composite root = new Composite("Picture");
            root.Add(new Leaf("Red Line"));
            root.Add(new Leaf("Blue Circle"));
            root.Add(new Leaf("Green Box"));

            Composite comp = new Composite("Two Circles");
            comp.Add(new Leaf("Black Circle"));
            comp.Add(new Leaf("White Circle"));
            root.Add(comp);

            root.Display(1);
        }
    }
}
