using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] Transform target;

    void Update()
    {
        GetComponent<Transform>().position = target.position;
    }
}
