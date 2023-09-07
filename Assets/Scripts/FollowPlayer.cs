using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 behindOffset = new Vector3(0, 5, -7);
    private Vector3 driverSeatOffset = new Vector3(0, 3, 2);
    private int spaceInputCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetKeyDown("space"))
        {
            spaceInputCount++;
        }

        if (spaceInputCount % 2 == 0)
        {
            transform.position = player.transform.position + behindOffset;
            transform.rotation = Quaternion.Euler(20, 0, 0);
        }
        else
        {
            transform.position = player.transform.position + driverSeatOffset;
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
