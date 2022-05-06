using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvaderActions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject); // Self
        Destroy(collision.gameObject); // Missile
    }
}
