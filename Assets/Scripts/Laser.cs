using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        //rb.velocity = new Vector2(10, 0);
        rb.AddRelativeForce(new Vector2(1, 0) * 10 - rb.velocity);
    }
}
