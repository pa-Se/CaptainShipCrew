using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice2 : MonoBehaviour
{

    static Rigidbody rb;
    public static Vector3 diceVelocity;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        diceVelocity = rb.velocity;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            DiceNumberTextScript.diceNumber = 0;
            float dirX = Random.Range(0, 100);
            float dirY = Random.Range(0, 100);
            float dirZ = Random.Range(0, 500);
            transform.position = new Vector3(Random.Range(-15, -5), Random.Range(1, 10), Random.Range(-4, 3));
            transform.rotation = Quaternion.identity;
            rb.AddForce(transform.up * 50);
            rb.AddTorque(dirX, dirY, dirZ);
        }
    }
}
