using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyTakeDamageDefault", menuName = "Enemy/EnemyTakeDamageDefault", order = 1)]
public class EnemyTakeDamageDefault : EnemyTakeDamage
{
    public override void TakeDamage(PlayerDamageInfo damageInfo)
    {
        base.TakeDamage(damageInfo);

        GameController.Instance.ObservableScore.Item += EnemyController.Config.ScorePrice;
        EnemyController.Die();
        Debug.Log("TakeDamage");
    }
}
