using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float value = 100;
    public RectTransform valueRectTransform;
    public GameObject gameplayUI;

    private float _maxValue;

    private void Start()
    {
        _maxValue = value;
        DrawHealthBarEnemy();
    }
    public void DealDamage(float damage)
    {
        value -= damage;
        if (value <= 0)
        {
            Destroy(gameObject);
        }
        DrawHealthBarEnemy();
    }

    private void DrawHealthBarEnemy()
    {
        valueRectTransform.transform.localScale = new Vector2(value / _maxValue, 1);
    }
}

