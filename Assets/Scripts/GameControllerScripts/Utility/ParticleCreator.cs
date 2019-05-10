using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleCreator : MonoBehaviour, IService
{
    public ParTicleGameObject ParticlePrefab;

    public void StartService()
    {
        gameObject.SetActive(true);
    }

    public void StopService()
    {
        gameObject.SetActive(false);
    }

    public void CreateSpark(Vector3 position, Mesh mesh, Color color)
    {
        ParTicleGameObject tempSpark = Instantiate(ParticlePrefab, position, Quaternion.identity);
        tempSpark.Init(mesh,position,color);
    }
}
