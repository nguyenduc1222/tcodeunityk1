using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteGoToLeft : MonoBehaviour {

    public Rigidbody2D rb;
    private float t = 0.0f;
    private bool moving = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        if (Input.GetKeyDown("d"))
        {
            rb.velocity = new Vector3(5, 0, 0);
            moving = true;
            Debug.Log("jump");
        }

        if (moving)
        {
            t = t + Time.deltaTime;
            if (t > 1.0f)
            {
                Debug.Log(gameObject.transform.position.y + " : " + t);
                t = 0.0f;
            }
        }
    }

}
