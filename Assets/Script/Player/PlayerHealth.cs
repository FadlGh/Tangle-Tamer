using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int health = 20;
    public Slider s;
    public void EditHealth(int amount)
    {
        health += amount;
    }
    void Update()
    {
        if (health > 20)
        {
            health = 20;
        }

        if (health < 0)
        {
            health = 0;
        }

        s.value = health;
    }
}
