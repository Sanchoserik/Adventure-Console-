using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adventure.Items;
using Adventure.Effects;

namespace Adventure
{
    class C_Hero
    {
        public int baseMaxHP; // base max
        public int maxHP; // all max
        public int currHP; // curr

        public int baseMaxENE; // base max
        public int maxENE; // all max
        public int currENE;

        public int baseFireDef;
        public int baseAirDef;
        public int baseLightningDef;
        public int baseEarthDef;
        public int baseWaterDef;
        public int baseLifeDef;
        public int baseDeathDef;
        public int baseLightDef;
        public int baseDarknessDef;

        public int gold;


        // invertory
        public List<A_Item> inv_items;

        public List<A_Talisman> inv_talismans;
        public List<A_Talisman> in_useTalismans;

        public List<A_Effect> global_card_stack; // global cards eff
        public List<A_Effect> eff_stack; // battle eff
        
        public C_Hero()
        {
            inv_items = new List<A_Item>();
            inv_talismans = new List<A_Talisman>();
            eff_stack = new List<A_Effect>();
        }

    }
}
