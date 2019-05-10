using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WinConditionMaxScore", menuName = "WinConditions/WinConditionMaxScore", order = 1)]
public class WinConditionMaxScore : WinConditions
{
    public int MaxScoreToWin;

    public override bool CheckWin()
    {
        return (MaxScoreToWin <= GameColtroller.ObservableScore.Item);
    }
}
