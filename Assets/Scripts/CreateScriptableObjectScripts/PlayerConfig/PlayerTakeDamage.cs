using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerTakeDamage", menuName = "Player/PlayerTakeDamage", order = 1)]
public class PlayerTakeDamage : ScriptableObject
{
    public delegate void PlayerTakeDamageDelegate(EnemyDamageInfo damageInfo);
    public event PlayerTakeDamageDelegate PlayerTakeDamageEvent;

    public PlayerController Player;

    public void Init(PlayerController player)
    {
        Player = player;
    }

    public virtual void TakeDamage(EnemyDamageInfo damageInfo)
    {
        if (PlayerTakeDamageEvent != null)
        {
            PlayerTakeDamageEvent.Invoke(damageInfo);
        }
    }
}
