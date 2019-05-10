using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerTakeDamageDefault", menuName = "Player/PlayerTakeDamageDefault", order = 1)]
public class PlayerTakeDamageDefault : PlayerTakeDamage
{
    public override void TakeDamage(EnemyDamageInfo damageInfo)
    {
        Player.CurrentHealth.Item -= damageInfo.Sender.Config.Damage;
        Debug.Log("TakeDamage");

        if (Player.CurrentHealth.Item <= 0)
        {
            Player.Die();
        }

        base.TakeDamage(damageInfo);
    }
}
