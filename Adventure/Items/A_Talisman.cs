using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Items
{
    abstract class A_Talisman
    {
        public int id;
        public string name;

        int currEne;
        int maxEne;
        string element;

        //move from inv to tInUSe
        public static void moveToOrder(C_Hero h, int pos, A_Talisman t)
        {
            if (h.in_useTalismans[pos] == null)
            {
                h.in_useTalismans[pos] = t;
                dell(h, t);
            }
            else
            {
                h.inv_talismans.Add(h.inv_talismans[pos]);
                h.in_useTalismans[pos] = t;
                dell(h, t);
            }
            findId(h);
        }
        //move from InUse to Invertory
        public static void moveToInv(C_Hero h, int pos)
        {
                h.inv_talismans.Add(h.inv_talismans[pos]);
                h.in_useTalismans[pos] = null;
                findId(h);                   
        }

        // tInUse1 <-> tInUse2
        public static void swapPosition(C_Hero h, int posX, int posY)
        {
            A_Talisman t = h.in_useTalismans[posY];
            h.in_useTalismans[posY] = h.in_useTalismans[posX];
            h.in_useTalismans[posX] = t;
        }
      
        //dell from inv
        public static void dell(C_Hero h, A_Talisman t)
        {
            h.inv_talismans.Remove(h.inv_talismans.Find(x => x.id == t.id));
            // findId's in inv
            findId(h);
        }

        //rename id in invertory
        private static void findId(C_Hero h)
        {
            for (int i = 0; i < h.inv_talismans.Count; ++i)
            {
                h.inv_talismans[i].id = i + 1;
            }
        }

        public static bool buy(A_Talisman talisman, C_Hero hero)
        {
            int price = 0;

            switch (talisman.GetType().Name)
            {
                case "defFire1S": price = 800; break;
                case "defFire2M": price = 1600; break;
                case "defFire3G": price = 3200; break;
                case "defFire4U": price = 6400; break;

                case "defAir1S": price = 800; break;
                case "defAir2M": price = 1600; break;
                case "defAir3G": price = 3200; break;
                case "defAir4U": price = 6400; break;

                case "defLightning1S": price = 800; break;
                case "defLightning2M": price = 1600; break;
                case "defLightning3G": price = 3200; break;
                case "defLightning4U": price = 6400; break;

                case "defEarth1S": price = 800; break;
                case "defEarth2M": price = 1600; break;
                case "defEarth3G": price = 3200; break;
                case "defEarth4U": price = 6400; break;

                case "defWater1S": price = 800; break;
                case "defWater2M": price = 1600; break;
                case "defWater3G": price = 3200; break;
                case "defWater4U": price = 6400; break;

                case "defDarkness1S": price = 800; break;
                case "defDarkness2M": price = 1600; break;
                case "defDarkness3G": price = 3200; break;
                case "defDarkness4U": price = 6400; break;

                case "defLight1S": price = 800; break;
                case "defLight2M": price = 1600; break;
                case "defLight3G": price = 3200; break;
                case "defLight4U": price = 6400; break;

                case "defLife1S": price = 800; break;
                case "defLife2M": price = 1600; break;
                case "defLife3G": price = 3200; break;
                case "defLife4U": price = 6400; break;

                case "defDeath1S": price = 800; break;
                case "defDeath2M": price = 1600; break;
                case "defDeath3G": price = 3200; break;
                case "defDeath4U": price = 6400; break;

            }
            if (hero.gold >= price)
            {
                hero.inv_talismans.Add(talisman);
                findId(hero);
                return true;
            }
            return false;
        }
        public static void sell(A_Talisman talisman, C_Hero hero)
        {
            int price = 0;

            switch (talisman.GetType().Name)
            {
                case "defFire1S": price = 200; break;
                case "defFire2M": price = 400; break;
                case "defFire3G": price = 800; break;
                case "defFire4U": price = 1600; break;

                case "defAir1S": price = 200; break;
                case "defAir2M": price = 500; break;
                case "defAir3G": price = 800; break;
                case "defAir4U": price = 1600; break;

                case "defLightning1S": price = 200; break;
                case "defLightning2M": price = 400; break;
                case "defLightning3G": price = 800; break;
                case "defLightning4U": price = 1600; break;

                case "defEarth1S": price = 200; break;
                case "defEarth2M": price = 400; break;
                case "defEarth3G": price = 800; break;
                case "defEarth4U": price = 1600; break;

                case "defWater1S": price = 200; break;
                case "defWater2M": price = 400; break;
                case "defWater3G": price = 800; break;
                case "defWater4U": price = 1600; break;

                case "defDarkness1S": price = 200; break;
                case "defDarkness2M": price = 400; break;
                case "defDarkness3G": price = 800; break;
                case "defDarkness4U": price = 1600; break;

                case "defLight1S": price = 200; break;
                case "defLight2M": price = 400; break;
                case "defLight3G": price = 800; break;
                case "defLight4U": price = 1600; break;

                case "defLife1S": price = 200; break;
                case "defLife2M": price = 400; break;
                case "defLife3G": price = 800; break;
                case "defLife4U": price = 1600; break;

                case "defDeath1S": price = 200; break;
                case "defDeath2M": price = 400; break;
                case "defDeath3G": price = 800; break;
                case "defDeath4U": price = 1600; break;

            }

            hero.gold += price;
            dell(hero, talisman);
            findId(hero);
        }

        public static int reChargePrice(A_Talisman t, int val)
        {
             return Convert.ToInt32(val * 1.8);
        }

        public static void reCharge(A_Talisman t, int val)
        {
            t.currEne += val;
        }

    }
}
