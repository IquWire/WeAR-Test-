using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LoseConditions", menuName = "LoseConditions/LoseConditions", order = 1)]
public class LoseConditions : ScriptableObject
{
    public GameController GameColtroller;

    public void Init(GameController gameColtroller)
    {
        GameColtroller = gameColtroller;
    }

    public virtual bool CheckLose()
    {
        return false;
    }
}
