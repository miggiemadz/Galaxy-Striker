using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    [SerializeField] private GameObject Lazer;
    [SerializeField] private Transform bulletPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject newLazer = GameObject.Instantiate(Lazer);
            newLazer.transform.position = bulletPosition.position;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            gameObject.transform.position = new Vector3(0, -3, 0);

        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            gameObject.transform.position = new Vector3(-6, -3, 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            gameObject.transform.position = new Vector3(6, -3, 0);
        }
    }
}
