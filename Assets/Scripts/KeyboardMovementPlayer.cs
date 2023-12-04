using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardMovementPlayer : MonoBehaviour
{
    public GameObject player1;

    public float movementSpeed;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            player1.transform.Translate(Vector3.forward * Time.deltaTime * movementSpeed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            player1.transform.Translate(Vector3.back * Time.deltaTime * movementSpeed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            player1.transform.Translate(Vector3.right * Time.deltaTime * movementSpeed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            player1.transform.Translate(Vector3.left * Time.deltaTime * movementSpeed);
        }
    }
}