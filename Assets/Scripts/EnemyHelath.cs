using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHelath : MonoBehaviour
{
    [SerializeField] int maxHitPoints = 3;
    [SerializeField] int currentHitPoints;

    void Start()
    {
        currentHitPoints = maxHitPoints;
    }

    public void TakeDamage(int value)
    {
        currentHitPoints -= value;
        if (currentHitPoints < 1)
        {
            Destroy(gameObject);
        }
    }
}
