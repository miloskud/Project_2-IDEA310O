using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class Poison : UsableItem.UsageEffect
{
    public int healthChange = -10;

    public override bool Use(CharacterData user)
    {
        user.Stats.ChangeHealth(healthChange);
        return true;
    }
}
