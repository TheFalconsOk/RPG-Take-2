using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace RPG.Movement
{
    public class Mover : MonoBehaviour
    {
        // Update is called once per frame
        void Update()
        {
            updateAnimation();
        }



        public void moveTo(Vector3 destination)
        {
            GetComponent<NavMeshAgent>().destination = destination;
        }

        void updateAnimation()
        {
            Vector3 velocity = GetComponent<NavMeshAgent>().velocity;
            Vector3 localVelocity = transform.InverseTransformDirection(velocity);
            float speed = localVelocity.z;
            GetComponent<Animator>().SetFloat("forwardSpeed", speed);
        }
    } 
}
