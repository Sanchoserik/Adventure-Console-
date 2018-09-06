using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adventure.Monsters;

namespace Adventure.Skills
{
    abstract class A_Skill
    {
        int flag;

        public abstract void basicattackskiill(C_Hero caster, List<C_Monster> targets);

    }
}
