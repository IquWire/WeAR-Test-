using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyAtackDefault", menuName = "Enemy/EnemyAtackDefault", order = 1)]
public class EnemyAtackDefault : EnemyAtack
{
    public override void Atack()
    {
        base.Atack();

        EnemyDamageInfo damageInfo = new EnemyDamageInfo(EnemyController, GameController.Instance.Player);

        GameController.Instance.Player.TakeDamage(damageInfo);

        Debug.Log("Atack");

        EnemyController.Die();
    }
}
