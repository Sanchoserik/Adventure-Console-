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
            h.gold = 100000;

            A_Item h1s = new healP1S("healpot1", h);
            A_Item.buy(h1s, h);
            h1s.name = "healpot2";
            A_Item.buy(h1s, h);
            // add 2 heal pot
            A_Item regh1s = new healReP1S("regpot1", h);
            A_Item.buy(regh1s, h);
            //add1 reg pot

            h.baseMaxHP = 1000;
            h.maxHP = 1000;
            h.currHP = 100;

            h.inv_items[0].use(h);
            Console.ReadLine();
            
        }
    }
}
