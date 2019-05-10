using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerDie", menuName = "Player/PlayerDie", order = 1)]

public class PlayerDie : ScriptableObject
{
    public delegate void PlayerDieDelegate();
    public event PlayerDieDelegate PlayerDieEvent;

    public PlayerController Player;

    public void Init(PlayerController player)
    {
        Player = player;
    }

    public virtual void Die()
    {
        if (PlayerDieEvent != null)
        {
            PlayerDieEvent.Invoke();
        }
    }
}
