using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamageInfo
{
    public PlayerController Sender;
    public EnemyController Receiver;

    public PlayerDamageInfo(PlayerController sender, EnemyController receiver)
    {
        Sender = sender;
        Receiver = receiver;
    }
}
