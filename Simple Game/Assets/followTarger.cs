﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followTarger : MonoBehaviour
{
    public Transform target;
    public Vector3 offset = new Vector3(0f, 1f, -3f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void LateUpdate()
    {
        transform.position = target.position + offset;
    }
}
