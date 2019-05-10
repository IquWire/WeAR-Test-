using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LoseConditionLowHP", menuName = "LoseConditions/LoseConditionLowHP", order = 1)]
public class LoseConditionLowHP : LoseConditions
{
    public int threshould = 0;

    public override bool CheckLose()
    {
        return (GameColtroller.Player.CurrentHealth.Item <= threshould);
    }
}
