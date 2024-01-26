using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class r_script : racket_script
{
    Rigidbody2D rb;
    public GameObject ball;
    [SerializeField] private float mindist = 1.5f;
    public float speed = 250f;
    private float dist;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        dist = Mathf.Abs(transform.position.y - ball.transform.position.y);
        if (dist > mindist)
        {
            if (ball.transform.position.y > transform.position.y)
            {
                rb.velocity = new Vector2(0, 1) * speed * Time.deltaTime;
            }
            else if (ball.transform.position.y < transform.position.y)
            {
                rb.velocity = new Vector2(0, -1) * speed * Time.deltaTime;
            }
        }
    }
}
