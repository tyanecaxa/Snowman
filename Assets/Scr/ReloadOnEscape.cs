using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadOnEscape : MonoBehaviour
{
    [SerializeField] public HealthSo playerHealth;
    [SerializeField] public HealthSo enemyHealth;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            playerHealth.currentHealth = 100;
            enemyHealth.currentHealth = 100;
        }
    }
}
