using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    private GameObject player;
    public Text HealthText;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        HealthText.text = "HEALTH : " + player.GetComponent<PlayerController>().hp;
    }
}
