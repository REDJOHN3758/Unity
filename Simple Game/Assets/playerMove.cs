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
        if (Input.GetKeyDown("up"))
        {
            //anim.SetTrigger("StartAnim");
            //rb.AddForce(new Vector3(5,0,0) * 5 * Time.deltaTime);
            //rb.AddForce(transform.forward * 5);
            //rb.velocity = new Vector3(0, 0, 1) * speed * Time.deltaTime;
            Movement1();
        }
    }

    public void Movement1()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.position = transform.position + new Vector3(horizontalInput * speed * Time.deltaTime, 0, verticalInput * speed * Time.deltaTime);
    }
}
