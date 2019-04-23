using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerControls : MonoBehaviour
{
    private Rigidbody player;
    private int speed = 40;
    public Camera playerCam;
    void Start()
    {
        player = GetComponent<Rigidbody>();
        player.drag = 2;
    }
    void Update()
    {
        if (playerCam == Camera.current)
        {

            if (Input.GetKey(KeyCode.W))
            {
                player.AddForce(transform.forward * speed);
            }
            if (Input.GetKey(KeyCode.S))
            {
                player.AddForce(transform.forward * -speed);
            }
            if (Input.GetKey(KeyCode.A))
            {
                player.AddForce(transform.right * -speed);
            }
            if (Input.GetKey(KeyCode.D))
            {
                player.AddForce(transform.right * speed);
            }
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                speed = speed * 2;
            }
        }
    }
}