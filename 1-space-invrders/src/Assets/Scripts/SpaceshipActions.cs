using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipActions : MonoBehaviour
{
    public float speed = 0.2f;
    public GameObject missilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 speed = new Vector3(0.05f, 0, 0);
        float rightLimit = 16;
        float leftLimit = -rightLimit;

        if (Input.GetKey(KeyCode.LeftArrow) &&
            transform.position.x > leftLimit)
        {
            transform.position -= speed;
        }

        if (Input.GetKey(KeyCode.RightArrow) &&
            transform.position.x < rightLimit)
        {
            transform.position += speed;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(missilePrefab, new Vector3(transform.position.x, 1.1f, 0), Quaternion.identity);
        }
    }
}
