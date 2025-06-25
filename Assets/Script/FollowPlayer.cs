using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0f, 7f, -8f);

    private void LateUpdate()
    {
        //offset the camera according the player's position 
        transform.position = player.transform.position + offset;
    }

}
