using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public Rigidbody rb;
    public Animator anim;
    float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.velocity = new Vector3(0, 0, 1) * speed;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rb.velocity = new Vector3(0, 0, -1) * speed;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.velocity = new Vector3(1, 0, 0) * speed;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector3(-1, 0, 0) * speed;
        }
    }
}
