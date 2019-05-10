using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesCatcherController : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        EnemyController enemy = other.gameObject.GetComponent<EnemyController>();
        if (enemy != null)
        {            
            enemy.Atack();
        }
    }
}
