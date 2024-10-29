using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigidbody2;

    private int health = 15;

    public int Health { get => health; set => health = value; }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody2.velocity = new Vector3(0,-1,0);

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
