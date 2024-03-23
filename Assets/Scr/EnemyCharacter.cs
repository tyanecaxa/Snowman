using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCharacter : MonoBehaviour
{
    [SerializeField] private HealthSo health;

    public void TakeDamage(float value)
    {
        health.currentHealth -= value;
        if(health.currentHealth <= 0 )
        {
            Destroy(gameObject);
        }
    }

}
