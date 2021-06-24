using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D body;

    private float horizontal;
    private float vertical;

    public float speed = 5.0f;
    public float hp = 100f;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //We use the GetAxis method to take in WASD and arrow key inputs
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }

    //Good practice to have any physics related operations in fixedUpdate,
    //as physics are updated immediately after this method (not the case with Update)
    private void FixedUpdate()
    {
        //add velocity in the direction of the movement keys being pressed
        body.velocity = new Vector2(horizontal * speed, vertical * speed);
    }

    public void SpeedCooldown()
    {
        StartCoroutine("Cooldown");
    }
    IEnumerator Cooldown()
    {

        yield return new WaitForSeconds(3.0f);
        speed -= 10.0f;

    }
}
