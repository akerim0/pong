using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class l_script : racket_script
{
    string vertical = "Vertical";
    float speed = 450f;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Physics2D.gravity = new Vector2(0, 0);
        float press = Input.GetAxis(vertical);
        rb.velocity = new Vector2(0,1) * speed * press* Time.deltaTime;

        
    }
}
