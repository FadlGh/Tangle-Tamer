using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health = 10;
    
    public void EditHealth(int amount)
    {
        health += amount;
    }
    void Update()
    {
        print(health);

        if (health > 10)
        {
            health = 10;
        }

        if (health < 0)
        {
            health = 0;
        }
    }
}
