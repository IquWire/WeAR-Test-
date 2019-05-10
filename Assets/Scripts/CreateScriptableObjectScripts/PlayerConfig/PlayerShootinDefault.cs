using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerShootinDefault", menuName = "Player/PlayerShootinDefault", order = 1)]
public class PlayerShootinDefault : PlayerShooting
{
    public override void Shoot()
    {
#if UNITY_EDITOR
        if (Input.GetMouseButtonDown(0))
        {
            ShootCore(Input.mousePosition);
        }
#elif UNITY_ANDROID
        if(Input.touchCount>0 && Input.GetTouch(0).phase==TouchPhase.Began)
        {
            ShootCore(Input.GetTouch(0).position);            
        }
#endif
    }

    private void ShootCore(Vector3 position)
    {
        Camera cam = Camera.main;
        Ray ray = cam.ScreenPointToRay(position);
        
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            EnemyController enemy = hit.collider.gameObject.GetComponent<EnemyController>();

            if (enemy != null)
            {
                PlayerDamageInfo damageInfo = new PlayerDamageInfo(Player, enemy);
                enemy.TakeDamage(damageInfo);
            }

            base.Shoot();
        }
    }
}
