using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class EnemyBehaviour : MonoBehaviour
{
    public EnemyController EnemyController;

    public Renderer Rend;

    [HideInInspector]public Mesh EnemyMesh;

    public void Init(EnemyController enemyController)
    {
        EnemyMesh = GetComponent<MeshFilter>().mesh;
        EnemyController = enemyController;
        Rend = GetComponent<Renderer>();
    }

    public void ChangeColor()
    {
        Color col = new Color(Random.Range(0f,1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        Rend.material.color = col;
    }

    public void StartMove()
    {
        ChangeColor();
        StartCoroutine(MoveForvard());
        StartCoroutine(RotateRandom());
    }

    public void StopMove()
    {
        StopCoroutine(MoveForvard());
        StopCoroutine(RotateRandom());
    }

    private IEnumerator MoveForvard()
    {
        while (gameObject.activeSelf)
        {
            Vector3 pos = -Vector3.forward *Time.deltaTime* GameController.Instance.ObservableCurrentSpeed.Item;
            transform.Translate(pos, Space.World);
            yield return null;
        }
    }

    private IEnumerator RotateRandom()
    {
        while (gameObject.activeSelf)
        {            
            Vector3 angle = new Vector3(Random.Range(0,180), Random.Range(0, 180), Random.Range(0, 180))*Time.deltaTime;            
            transform.Rotate(angle, Space.Self);
            //transform.rotation = Random.rotation;
            yield return null;
        }
    } 
}
