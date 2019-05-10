using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyDie", menuName = "Enemy/EnemyDie", order = 1)]
public class EnemyDie : ScriptableObject
{
    public delegate void OnDieDelegate();
    public event OnDieDelegate OnDieEvent;

    public EnemyController EnemyController;

    public void Init(EnemyController enemyController)
    {
        EnemyController = enemyController;
    }

    public virtual void Die()
    {
        if (OnDieEvent != null)
        {
            OnDieEvent.Invoke();
        }
    }
}
