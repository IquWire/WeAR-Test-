using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//must be nice implement rreference on Player in void Init(PlayerController player)
[CreateAssetMenu(fileName = "PlayerShooting", menuName = "Player/PlayerShooting", order = 1)]
public class PlayerShooting : ScriptableObject
{
    public delegate void ShootPlayerDelegate();
    public event ShootPlayerDelegate ShootPlayerEvent;

    public PlayerController Player;

    public void Init(PlayerController player)
    {
        Player = player;
    }

    public virtual bool CanShoot()
    {
        return true;
    }

    public virtual void Shoot()
    {
        if (ShootPlayerEvent != null)
        {
            ShootPlayerEvent.Invoke();
        }
    }
}
