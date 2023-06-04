using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectibles : MonoBehaviour
{
    public CollectibleData collectibleData;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<PlayerHealth>().EditHealth(collectibleData.collectibleValue);
            GameObject.FindGameObjectWithTag("AM").GetComponent<AudioManager>().Play(collectibleData.soundName);
            Destroy(gameObject);
        }
    }
}
