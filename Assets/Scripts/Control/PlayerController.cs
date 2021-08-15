using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RPG.Movement;

namespace RPG.Control
{
    public class PlayerController : MonoBehaviour
    {
        public void moveToCursor()
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            bool hasHit = Physics.Raycast(ray, out hit);

            if (hasHit)
            {
                GetComponent<Mover>().moveTo(hit.point);
            }
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButton(0))
            {
                moveToCursor();
            }
        }
    }
}
