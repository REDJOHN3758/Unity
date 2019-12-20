using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class duplicateObj : MonoBehaviour
{
    public GameObject prefab = null;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Instantiate(prefab, new Vector3(i * 2.0F, 0, 0), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
