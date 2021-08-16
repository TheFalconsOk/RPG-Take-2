using RPG.Movement;
using UnityEngine;

namespace RPG.Combat
{
    public class Fighter : MonoBehaviour
    {
        [SerializeField] float weaponRange = 2f;
        Transform target;

        private void Update()
        {
            if (target == null) return;
            if (target != null && GetTargetInRange())
            {
                GetComponent<Mover>().MoveTo(target.position);
            }
            else
            {
                GetComponent<Mover>().Stop();
            }


        }

        private bool GetTargetInRange()
        {
            return Vector3.Distance(transform.position, target.position) > weaponRange;
        }

        public void Attack(CombatTarget combatTarget)
        {
            print("have it");
            target = combatTarget.transform;
            print(target);
        }

        public void Cancel()
        {
            target = null;
        }
    }
}
