using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class PropellorControllerX : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = transform.rotation * Quaternion.Euler(0, 0, 1 * speed);
    }
}
