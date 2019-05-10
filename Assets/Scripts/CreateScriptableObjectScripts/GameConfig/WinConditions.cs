using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WinConditions", menuName = "WinConditions/WinConditions", order = 1)]
public class WinConditions : ScriptableObject
{
    public delegate void OnWinDelegate();
    public event OnWinDelegate OnWinEvent;

    public GameController GameColtroller;

    public void Init(GameController gameColtroller)
    {
        GameColtroller = gameColtroller;
    }

    public virtual bool CheckWin()
    {
        return false;
    }
}
