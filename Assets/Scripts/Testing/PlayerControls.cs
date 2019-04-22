using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    private Rigidbody player;
    void Start()
    {
        player = GetComponent<Rigidbody>();
        player.drag = 2;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            player.AddForce(transform.forward * 75);
        }
        if (Input.GetKey(KeyCode.S))
        {
            player.AddForce(transform.forward * -75);
        }
        if (Input.GetKey(KeyCode.A))
        {
            player.AddForce(transform.right * -75);
        }
        if (Input.GetKey(KeyCode.D))
        {
            player.AddForce(transform.right * 75);
        }
    }
}
