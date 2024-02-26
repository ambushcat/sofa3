using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sofa3.Theater
{
    public class MovieTheater : Component
    {
        private List<Component> children = new List<Component>();
        public override void Add(Component component)
        {
            this.children.Add(component);
        }

        public override void Remove(Component component)
        {
            this.children.Remove(component);
        }

        public override string Operation()
        {
            int i = 0;
            string result = "Theater(";

            foreach (Component component in children)
            {
                result += component.Operation();
            }

            return result + ")";
        }
    }
}
