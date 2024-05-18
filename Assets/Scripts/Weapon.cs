using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] Camera FPCamera;
    [SerializeField] float range = 100f;
    [SerializeField] int damage = 1;

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        RaycastHit hit;

        if (Physics.Raycast(FPCamera.transform.position, FPCamera.transform.forward, out hit, range) && hit.transform != null)
        {
            EnemyHelath targetHealth = hit.transform.GetComponent<EnemyHelath>();

            if (targetHealth)
            {
                targetHealth.TakeDamage(damage);
            }
        }
    }
}
