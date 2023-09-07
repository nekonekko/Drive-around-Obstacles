using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRightController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private bool rightInput;
    private bool leftInput;
    private bool forwardInput;
    private bool backInput;

    // Update is called once per frame
    void Update()
    {
        rightInput = Input.GetKey(KeyCode.RightArrow);
        leftInput = Input.GetKey(KeyCode.LeftArrow);
        forwardInput = Input.GetKey(KeyCode.UpArrow);
        backInput = Input.GetKey(KeyCode.DownArrow);

        if (rightInput && !leftInput)
        {
            transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed);
        }
        else if (!rightInput && leftInput)
        {
            transform.Rotate(Vector3.down, Time.deltaTime * turnSpeed);
        }

        if (forwardInput && !backInput)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        else if (!forwardInput && backInput)
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
    }
}
