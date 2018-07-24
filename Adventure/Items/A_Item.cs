﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Items
{
    abstract class A_Item
    {
        public int id;
        public string name;

        public abstract void use(C_Hero h);

        public static void dell(List<A_Item> items, int _id)
        {
            items.Remove(items.Find(x => x.id == _id));
        }

        public static bool buy(A_Item item, C_Hero hero)
        {
            int price = 0;

            switch (item.GetType().Name)
            {
                case "healP1S": price = 125; break;
                case "healP2M": price = 250; break;
                case "healP3G": price = 500; break;
                case "healP4U": price = 1000; break;

                case "healReP1S": price = 500; break;
                case "healReP2M": price = 1000; break;
                case "healReP3G": price = 2000; break;
                case "healReP4U": price = 4000; break;

                case "eneP1S": price = 200; break;
                case "eneP2M": price = 400; break;
                case "eneP3G": price = 800; break;
                case "eneP4U": price = 1600; break;

                case "eneReP1S": price = 500; break;
                case "eneReP2M": price = 1000; break;
                case "eneReP3G": price = 2000; break;
                case "eneReP4U": price = 4000; break;

                case "fireUpMix1S": price = 300; break;
                case "fireUpMix2M": price = 600; break;
                case "fireUpMix3G": price = 900; break;
                case "fireUpMix4U": price = 1800; break;

                case "airUpMix1S": price = 300; break;
                case "airUpMix2M": price = 600; break;
                case "airUpMix3G": price = 900; break;
                case "airUpMix4U": price = 1800; break;

                case "lightningUpMix1S": price = 300; break;
                case "lightningUpMix2M": price = 600; break;
                case "lightningUpMix3G": price = 900; break;
                case "lightningUpMix4U": price = 1800; break;

                case "earthUpMix1S": price = 300; break;
                case "earthUpMix2M": price = 600; break;
                case "earthUpMix3G": price = 900; break;
                case "earthUpMix4U": price = 1800; break;

                case "waterUpMix1S": price = 300; break;
                case "waterUpMix2M": price = 600; break;
                case "waterUpMix3G": price = 900; break;
                case "waterUpMix4U": price = 1800; break;

                case "darknessUpMix1S": price = 300; break;
                case "darknessUpMix2M": price = 600; break;
                case "darknessUpMix3G": price = 900; break;
                case "darknessUpMix4U": price = 1800; break;

                case "lightUpMix1S": price = 300; break;
                case "lightUpMix2M": price = 600; break;
                case "lightUpMix3G": price = 900; break;
                case "lightUpMix4U": price = 1800; break;

                case "lifeUpMix1S": price = 300; break;
                case "lifeUpMix2M": price = 600; break;
                case "lifeUpMix3G": price = 900; break;
                case "lifeUpMix4U": price = 1800; break;

                case "deathUpMix1S": price = 300; break;
                case "deathUpMix2M": price = 600; break;
                case "deathUpMix3G": price = 900; break;
                case "deathUpMix4U": price = 1800; break;

            }


            if (hero.gold >= price)
            {
                hero.inv_items.Add(item);
                findid(hero);
                return true;
            }
            return false;
        }

        public static void sell(A_Item item, C_Hero hero)
        {
            int price = 0;
            switch (item.GetType().Name)
            {
                case "healP1S": price = 31; break;
                case "healP2M": price = 62; break;
                case "healP3G": price = 125; break;
                case "healP4U": price = 250; break;

                case "healReP1S": price = 125; break;
                case "healReP2M": price = 250; break;
                case "healReP3G": price = 500; break;
                case "healReP4U": price = 1000; break;

                case "eneP1S": price = 50; break;
                case "eneP2M": price = 100; break;
                case "eneP3G": price = 200; break;
                case "eneP4U": price = 400; break;

                case "eneReP1S": price = 125; break;
                case "eneReP2M": price = 250; break;
                case "eneReP3G": price = 500; break;
                case "eneReP4U": price = 1000; break;

                case "fireUpMix1S": price = 75; break;
                case "fireUpMix2M": price = 150; break;
                case "fireUpMix3G": price = 225; break;
                case "fireUpMix4U": price = 450; break;

                case "airUpMix1S": price = 75; break;
                case "airUpMix2M": price = 150;break;
                case "airUpMix3G": price = 225;break;
                case "airUpMix4U": price = 450; break;

                case "lightningUpMix1S": price = 75; break;
                case "lightningUpMix2M": price = 150;break;
                case "lightningUpMix3G": price = 225;break;
                case "lightningUpMix4U": price = 450; break;

                case "earthUpMix1S": price = 75; break;
                case "earthUpMix2M": price = 150;break;
                case "earthUpMix3G": price = 225;break;
                case "earthUpMix4U": price = 450; break;

                case "waterUpMix1S": price = 75;  break;
                case "waterUpMix2M": price = 150; break;
                case "waterUpMix3G": price = 225; break;
                case "waterUpMix4U": price = 450; break;

                case "darknessUpMix1S": price = 75; break;
                case "darknessUpMix2M": price = 150;break;
                case "darknessUpMix3G": price = 225;break;
                case "darknessUpMix4U": price = 450; break;

                case "lightUpMix1S": price = 75; break;
                case "lightUpMix2M": price = 150;break;
                case "lightUpMix3G": price = 225;break;
                case "lightUpMix4U": price = 450; break;

                case "lifeUpMix1S": price = 75; break;
                case "lifeUpMix2M": price = 150;break;
                case "lifeUpMix3G": price = 225;break;
                case "lifeUpMix4U": price = 450; break;

                case "deathUpMix1S": price = 75; break;
                case "deathUpMix2M": price = 150;break;
                case "deathUpMix3G": price = 225;break;
                case "deathUpMix4U": price = 450; break;

            }
            hero.gold += price;
            dell(hero.inv_items, item.id);
            findid(hero);
        }

        public static void findid(C_Hero h)
        {
            for (int i = 0; i < h.inv_items.Count; ++i)
            {
                h.inv_items[i].id = i + 1;
            }
        }

    }
}
