using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyAtack", menuName = "Enemy/EnemyAtack", order = 1)]
public class EnemyAtack : ScriptableObject
{
    public delegate void OnAtackDelegate();
    public event OnAtackDelegate OnAtackEvent;

    public EnemyController EnemyController;

    public void Init(EnemyController enemyController)
    {
        EnemyController = enemyController;
    }

    public virtual void Atack()
    {
        if (OnAtackEvent != null)
        {
            OnAtackEvent.Invoke();
        }
    }
}
