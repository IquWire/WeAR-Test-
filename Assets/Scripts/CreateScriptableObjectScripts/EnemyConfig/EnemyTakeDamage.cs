using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyTakeDamage", menuName = "Enemy/EnemyTakeDamage", order = 1)]
public class EnemyTakeDamage : ScriptableObject
{
    public delegate void OnTakeDamageDelegate(PlayerDamageInfo damageInfo);
    public event OnTakeDamageDelegate OnTakeDamageEvent;

    public EnemyController EnemyController;

    public void Init(EnemyController enemyController)
    {
        EnemyController = enemyController;
    }

    public virtual void TakeDamage(PlayerDamageInfo damageInfo)
    {
        if (OnTakeDamageEvent != null)
        {
            OnTakeDamageEvent.Invoke(damageInfo);
        }
    }
}
