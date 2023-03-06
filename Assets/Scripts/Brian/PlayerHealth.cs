using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    float maxHealth = 100;
    float currHealth;
    bool alive = true;
    [SerializeField] Image hpBar;
    void Start()
    {
        currHealth = maxHealth;
    }

    void Update()
    {
        if (alive == true)
        {
            if (currHealth <= 0)
            {
                PlayerDied();
            }
            hpBar.fillAmount = currHealth / maxHealth;
        }
    }
    public void TakeDamage(float damage)
    {
        currHealth = currHealth - damage;
    }
    public void PlayerDied()
    {
        alive = false;
        Debug.Log("dead");
    }

    public void RestartLevel()
    {
        //maybe reload scene or just teleport the player to the start and reset scripts
        currHealth = maxHealth;
        alive = true;
    }
}
