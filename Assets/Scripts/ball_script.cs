using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ball_script : MonoBehaviour
{
    Rigidbody2D rb;
    float speed = 25f;
    AudioSource audiosource;
    public racket_script l_racket, r_racket;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(1, 0) * speed;
        audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        audiosource.Play();
        if (collision.gameObject.tag == "lbar_tag")
        {
            r_racket.MakeScore();
        }
        else if (collision.gameObject.tag == "rbar_tag")
        {
            l_racket.MakeScore();
        }
        else if (collision.gameObject.tag == "lracket_tag")
        {
            ComputeBounceOffDirection(collision, 1);
        }
        else if (collision.gameObject.tag == "rracket_tag")
        {
            ComputeBounceOffDirection(collision, -1);
        }
    }

    private void ComputeBounceOffDirection(Collision2D collision, float x)
    {
       
        var a = transform.position.y - collision.transform.position.y;
        var b = collision.collider.bounds.size.y / 2f;
        var y = a / b;
        rb.velocity = new Vector2(x, y) * speed ;
    }
}
