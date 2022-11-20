using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice
{
   public class DriverClassForDrawable
    {
        public static void Main()
        {
            Rectangle obj = new Rectangle();
            obj.draw();
            Circle obj1 = new Circle();
            obj1.draw();
        }
    }
}
   