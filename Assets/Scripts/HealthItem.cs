using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthItem : MonoBehaviour
{
    private GameObject player;
   
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public void Use()
    {
        player.GetComponent<PlayerController>().hp += 10.0f;
        Destroy(gameObject);
    }
}
