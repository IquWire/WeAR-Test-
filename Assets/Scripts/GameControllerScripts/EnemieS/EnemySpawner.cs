using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour, IService
{
    public EnemyController[] EnemyPrefabs;

    public Transform StartPoint;

    public float CreationInterval;
    public float Deviation;

    public void ActiveSpawner()
    {
        StartCoroutine(CreationCoroutine());
    }

    private IEnumerator CreationCoroutine()
    {
        while (true)
        {
            int rn = Random.Range(0, 3);
            EnemyController tempEnemy = Instantiate(EnemyPrefabs[rn]);
           
            tempEnemy.gameObject.transform.SetParent(StartPoint);
            tempEnemy.Setup();

            float rnXPos = Random.Range(-Deviation, Deviation);
            Vector3 pos = new Vector3(rnXPos, 0, 0);

            tempEnemy.gameObject.transform.localPosition = pos;

            tempEnemy.gameObject.GetComponent<EnemyBehaviour>().StartMove();

            yield return new WaitForSeconds(CreationInterval);
        }
    }

    public void StartService()
    {
        gameObject.SetActive(true);
    }

    public void StopService()
    {
        StopAllCoroutines();
    }
}
