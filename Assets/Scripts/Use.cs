using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Use : MonoBehaviour
{
    public GameObject item;
    public int i;

    private Inventory inventory;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        inventory = player.GetComponent<Inventory>();
    }

    void Update()
    {
        if (transform.childCount <= 0)
        {
            inventory.isFull[i] = false;
        }
    }
    public void UseSelectedItem()
    {

        foreach (Transform child in transform)
        {
            //health potion
            if (child.tag == "Health")
            {
                player.GetComponent<PlayerController>().hp += 10;
            }
            //speed
            else
            {
                player.GetComponent<PlayerController>().hp += 5.0f;
                StartCoroutine("Cooldown");
            }

            GameObject.Destroy(child.gameObject);
        }
    }

    IEnumerator Cooldown()
    {

        yield return new WaitForSeconds(3.0f);
        player.GetComponent<PlayerController>().hp -= 5.0f;

    }
}
