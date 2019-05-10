using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParTicleGameObject : MonoBehaviour
{
    public ParticleSystem Spark;

    public ParticleSystemRenderer partRend;

    public void Init(Mesh partMesh, Vector3 position, Color color)
    {
        transform.position = position;
        partRend.mesh = partMesh;
        partRend.material.color = color;
        
        Spark.Play();
        Destroy(gameObject, Spark.main.startLifetimeMultiplier);
    }
}
