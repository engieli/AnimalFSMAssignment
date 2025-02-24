using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NodeCanvas.Framework;

public class EatAction : ActionTask
{
    public BBParameter<GameObject> vegetable;

    protected override void OnExecute()
    {
        if (vegetable.value != null)
        {
            UnityEngine.Object.Destroy(vegetable.value);
            Debug.Log("Vegetable has been eaten!");
        }
        else
        {
            Debug.LogWarning("No vegetable assigned to EatAction!");
        }

        EndAction(true);
    }
}
