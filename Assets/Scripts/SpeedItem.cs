using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedItem : MonoBehaviour
{
    private GameObject player;
   
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public void Use()
    {
        player.GetComponent<PlayerController>().speed += 10.0f;
        player.GetComponent<PlayerController>().SpeedCooldown();
        Destroy(gameObject);
    }

}
