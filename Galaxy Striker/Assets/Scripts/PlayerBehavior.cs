using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    // The variable of our Laser prefab and the position it spawns from
    [SerializeField] private GameObject Lazer;
    [SerializeField] private Transform bulletPosition;

    void Start()
    {
        
    }

    void Update()
    {
        // If the player pushes the space key the rocket shoots a laser
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject newLazer = GameObject.Instantiate(Lazer);
            newLazer.transform.position = bulletPosition.position;
        }

        // If the player pushes the s key they move to the middle column
        if (Input.GetKeyDown(KeyCode.S))
        {
            gameObject.transform.position = new Vector3(0, -3, 0);

        }

        // If the player pushes the a key they move to the left column
        if (Input.GetKeyDown(KeyCode.A))
        {
            gameObject.transform.position = new Vector3(-6, -3, 0);
        }

        // If the player pushes the d key they move to the right column
        if (Input.GetKeyDown(KeyCode.D))
        {
            gameObject.transform.position = new Vector3(6, -3, 0);
        }
    }
}
