using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameConfig", menuName = "GameConfig/GameConfig", order = 1)]

public class GameConfig : ScriptableObject
{
    public float StartSpeed;
    public float SpeedMultiplier;

    public int FreqIncreaseSpeed;

    public WinConditions WinCondition;
    public LoseConditions LoseCondition;

    public GameController GameController;

    public void Init(GameController gameController)
    {
        GameController = gameController;

        WinCondition.Init(gameController);
        LoseCondition.Init(gameController);
    }
}
