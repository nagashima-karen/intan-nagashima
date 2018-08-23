using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGun : MonoBehaviour {
    
    [SerializeField]
    private float speed = 10.0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up"))
        {
            if (transform.position.y >= 18.0f)
                return;
            transform.position += transform.up * speed * Time.deltaTime;
        }
        if (Input.GetKey("down"))
        {
            if (transform.position.y <= 5.0f) 
                return;
            transform.position -= transform.up * speed * Time.deltaTime;
        }
        if (Input.GetKey("right"))
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey("left"))
        {
            transform.position -= transform.right * speed * Time.deltaTime;
        }
    }
}
