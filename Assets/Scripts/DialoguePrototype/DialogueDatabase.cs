using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dialogue
{
    public static class DialogueDatabase
    {
        public static List<string> GetChapterOne()
        {
            List<string> chapter = new List<string>();

            chapter.Add("So for this new example, we wanna have several slides of text.");
            chapter.Add("The idea is that we wanna add some rhythm to the dialogue by separating it in different slides.\nIt actually makes it easier to read and to digest for the player.");
            chapter.Add("Also, sometimes, the totality of the dialogue can be pretty long you know . . .\nSo the idea is that we don't end in a situation where the dialogue is actually too big for the dialogue box.");
            chapter.Add("That's pretty much it !\nThan you for reading this ;)");

            return chapter;
        }
    }

}
