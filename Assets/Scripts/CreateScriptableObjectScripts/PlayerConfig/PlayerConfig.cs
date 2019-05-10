using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerConfig", menuName = "Player/PlayerConfig", order = 1)]
public class PlayerConfig : ScriptableObject
{
    public int StartHealth;

    public PlayerShooting PlayerShooting;
    public PlayerTakeDamage PlayerTakeDamage;
    public PlayerDie PlayerDie;
    public PlayerController Player;

    public void Init(PlayerController player)
    {
        Player = player;
        PlayerShooting.Init(player);
        PlayerTakeDamage.Init(player);
        PlayerDie.Init(player);
    }
}
