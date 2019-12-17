using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("up"))
        {
            //rb.AddForce(new Vector3(5,0,0) * 5 * Time.deltaTime);
            rb.AddForce(transform.forward * 5);
        }
    }
}
