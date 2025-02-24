using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NodeCanvas.Framework;
using NodeCanvas.StateMachines;

public class FerretCollisionDetector : MonoBehaviour
{
   
    public FSMOwner fsmOwner;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Vegetable"))
        {
            if (fsmOwner != null)
            {
                fsmOwner.SendEvent("EatVegetable");
            }
            else
            {
                Debug.LogWarning("FSMOwner not assigned on FerretCollisionDetector!");
            }
        }
    }
}
