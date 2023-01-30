using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats
{
    public _Skills Skills;

    public class _Skills
    {
        public int FineCooking;
        public int MassCooking;

        public int SoupCooking;
        public int SaladCooking;
        public int SandwichCooking;
        public int CasseroleCooking;

        public _Skills()
        {
            FineCooking = 2;
            MassCooking = 1;

            SoupCooking = 1;
            SaladCooking = 2;
            SandwichCooking = 2;
            CasseroleCooking = 1;
        }
    }

    public CharacterStats()
    {
        Skills = new _Skills();
    }

}
