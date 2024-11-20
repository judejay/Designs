using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Stuctural_Patterns.Composite
{
    public class Composite
    {

        // Composite pattern
        // Compose objects into tree structures to represent part-whole hierarchies.
        // Composite lets clients treat individual objects and compositions of
        // objects uniformly
        public void Run()
        {
            Item nut = new Part("Nut", 5);
            Item bolt = new Part("Bolt", 9);
            Item panel = new Part("Panel", 35);

            Item gizmo = new Assembly("Gizmo");
            gizmo.AddItem(nut);
            gizmo.AddItem(bolt);
            gizmo.AddItem(panel);

            Item widget = new Assembly("Widget");
            widget.AddItem(gizmo);
            widget.AddItem(new Part("Sprocket", 45));

            foreach (Item item in gizmo.Items)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Cost of Gizmo: " + gizmo.Cost);

            Console.WriteLine("\nComponents of Widget: ");
            foreach (Item item in widget.Items)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}