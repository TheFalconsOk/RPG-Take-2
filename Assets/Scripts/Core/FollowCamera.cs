using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Core
{
    public class FollowCamera : MonoBehaviour
    {
        [SerializeField] Transform target;

        void LateUpdate()
        {
            GetComponent<Transform>().position = target.position;
        }
    }
}
