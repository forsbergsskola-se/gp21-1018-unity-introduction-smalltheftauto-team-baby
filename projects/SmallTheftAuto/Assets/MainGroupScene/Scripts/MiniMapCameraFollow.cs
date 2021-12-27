using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// TODO: I almost thought you didn't have a minimap because your UI Canvas is not setup scalable. In small resolutions, the minimap is outside the screen. Remember to anchor it to the bottom right corner.
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
