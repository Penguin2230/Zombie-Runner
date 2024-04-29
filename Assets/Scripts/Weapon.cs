using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] Camera FPCamera;
    [SerializeField] float range = 100f;

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
        Physics.Raycast(FPCamera.transform.position, FPCamera.transform.forward, out hit, range);

        if (hit.transform == null) { return; }

        Debug.Log("I hit this thing: " + hit.transform.name);
    }
}
