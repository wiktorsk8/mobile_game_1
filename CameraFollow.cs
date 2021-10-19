using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;

    private void Update()
    {
        transform.position = new Vector3(0, 1.5f, player.transform.position.z);
    }
}
