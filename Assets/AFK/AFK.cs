using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AFK : MonoBehaviour
{
    public static int AFKCount;

    private Health _myHealth;

    private void Start()
    {
        AFKCount += 1;
    }
    private void InitComponent()
    {
        _myHealth = GetComponent<Health>();
        _myHealth.ZeroHealth += DieDieMyDarling;
    }

    private void DieDieMyDarling()
    {
        Destroy(gameObject);
    }
    private void OnDestroy()
    {
        _myHealth.ZeroHealth -= DieDieMyDarling;
        AFKCount -= 1;
    }
  

    void Update()
    {
        
    }
}
