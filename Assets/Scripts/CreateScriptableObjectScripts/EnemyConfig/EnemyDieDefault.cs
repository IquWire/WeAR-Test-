using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyDieDefault", menuName = "Enemy/EnemyDieDefault", order = 1)]
public class EnemyDieDefault : EnemyDie
{
    public override void Die()
    {
        ServicesHolder.Instance.ParticleCreator.CreateSpark(EnemyController.gameObject.transform.position,
                                                            EnemyController.EnemyBehaviour.EnemyMesh,
                                                            EnemyController.EnemyBehaviour.Rend.material.color);
        Destroy(EnemyController.gameObject,0.1f);
    }
}
