using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(30, 0, 10);

    // LateUpdate runs after all Update functions
    void LateUpdate()
    {
        transform.position = plane.transform.position + offset;
    }
}