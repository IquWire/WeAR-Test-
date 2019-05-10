using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public PlayerConfig PlayerConfig;

    public ObservableInt CurrentHealth = new ObservableInt();

    public void Awake()
    {
        Setup();
    }

    public void Setup()
    {
        CurrentHealth.Item = PlayerConfig.StartHealth;
        PlayerConfig.Init(this);
    }
	
	void Update ()
    {
        Shoot();
	}

    public void TakeDamage(EnemyDamageInfo damageInfo)
    {
        PlayerConfig.PlayerTakeDamage.TakeDamage(damageInfo);
    }

    public void Shoot()
    {
        if (PlayerConfig.PlayerShooting.CanShoot())
        {
            PlayerConfig.PlayerShooting.Shoot();
        }
    }

    public void Die()
    {
        PlayerConfig.PlayerDie.Die();
    }
}
