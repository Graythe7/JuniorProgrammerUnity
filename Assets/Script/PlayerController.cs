using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        //Move vehicle Forward
        transform.Translate(Vector3.forward * Time.deltaTime * 20);
    }
}
