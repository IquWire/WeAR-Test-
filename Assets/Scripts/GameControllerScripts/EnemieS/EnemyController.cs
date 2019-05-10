using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public EnemyConfig Config;

    public EnemyBehaviour EnemyBehaviour;

    public void Setup()
    {
        EnemyBehaviour = GetComponent<EnemyBehaviour>();

        Config.Init(this);
        EnemyBehaviour.Init(this);
    }

    public void Atack()
    {
        Debug.Log("EnemyController Atack + ");

        Config.EnemyAtack.Atack();
    }

    public void TakeDamage(PlayerDamageInfo damageInfo )
    {
        Config.EnemyTakeDamage.TakeDamage(damageInfo);
    }

    public void Die()
    {
        Config.EnemyDie.Die();
    }
}
