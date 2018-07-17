using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adventure.Items;
using Adventure.Items.Potions;
namespace Adventure
{
    class Program
    {
        static void Main(string[] args)
        {
            C_Hero h = new C_Hero();
            A_Item it = new healP1S(0,"n");          
            A_Item.buy(it, h);
        }
    }
}
