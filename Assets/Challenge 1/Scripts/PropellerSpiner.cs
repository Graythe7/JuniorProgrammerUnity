using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerSpiner : MonoBehaviour
{
    public float speed = 50f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, speed, Space.Self);
    }
}
