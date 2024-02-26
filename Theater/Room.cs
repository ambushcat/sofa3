using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sofa3.Theater
{
    public class Room : Component
    {
        private List<Component> children = new List<Component>();
        public override string Operation()
        {
            string result = "Room(";

            foreach (Component component in children)
            {
                result += component.Operation();
            }
            return result + ")";
        }

        public override void Add(Component component)
        {
            this.children.Add(component);
        }

        public override void Remove(Component component)
        {
            this.children.Remove(component);
        }
    }
}
