using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageInfo
{
    public PlayerController Receiver;
    public EnemyController Sender;

    public EnemyDamageInfo(EnemyController sender, PlayerController receiver)
    {
        Sender = sender;
        Receiver = receiver;
    }
}
