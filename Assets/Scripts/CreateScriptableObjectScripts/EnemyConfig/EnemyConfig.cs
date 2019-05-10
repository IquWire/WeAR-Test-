using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyConfig", menuName = "EnemyConfig/EnemyConfig", order = 1)]
public class EnemyConfig : ScriptableObject
{
    public int Damage;
    public int ScorePrice;

    public EnemyAtack EnemyAtack;
    public EnemyTakeDamage EnemyTakeDamage;
    public EnemyDie EnemyDie;

    public EnemyController Enemy;

    public void Init(EnemyController enemy)
    {
        Enemy = enemy;
        EnemyAtack.Init(enemy);
        EnemyTakeDamage.Init(enemy);
        EnemyDie.Init(enemy);
    }
}
