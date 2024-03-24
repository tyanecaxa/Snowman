using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCharacter : MonoBehaviour
{
    [SerializeField] private HealthSo health;
    [SerializeField] private SimpleEvent enemyDeathEvent;

    public void TakeDamage(float value)
    {
        health.currentHealth -= value;
        if(health.currentHealth <= 0 )
        {
            enemyDeathEvent.Raise();
            Destroy(gameObject);
        }
    }

}
