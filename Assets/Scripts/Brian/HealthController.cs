using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    //THIS IS MORE TEMPORARY
    public bool takeDamage;
    public float damageAmount = 1;
    public bool revive;

    public GameObject playerObj;

    // Update is called once per frame
    void Update()
    {
        if (takeDamage == true)
        {
            takeDamage = false;
            playerObj.GetComponent<PlayerHealth>().TakeDamage(damageAmount);
        }
        if (revive == true)
        {
            revive = false;
            playerObj.GetComponent<PlayerHealth>().RestartLevel();
        }
    }
}
