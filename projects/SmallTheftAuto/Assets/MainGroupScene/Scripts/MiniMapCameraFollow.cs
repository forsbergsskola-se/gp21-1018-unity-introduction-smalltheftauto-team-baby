using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MiniMapCameraFollow : MonoBehaviour
{
    public Transform player;

    private void LateUpdate()
    {
        Vector3 newPosition = player.position;
        newPosition.z = transform.position.z;
        transform.position = newPosition;
    }
}
