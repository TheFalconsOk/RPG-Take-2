using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Core
{
    public class ActionScheduler : MonoBehaviour
    {
        IAction currentAction;
        public void StartAction(IAction action)
        {
            if (currentAction != null)
            {
                if (currentAction != action)
                {
                    print("cancel " + currentAction.ToString());
                    currentAction.Cancel();
                    currentAction = action;
                }
            }
            else
            {
                currentAction = action;
            }
        }
    }
}
