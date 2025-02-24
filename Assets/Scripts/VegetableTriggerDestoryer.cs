using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VegetableTriggerDestoryer : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ferret"))
        {
            Debug.Log("Vegetable triggered by Ferret, destroying the vegetable.");
            Destroy(gameObject);
        }
    }
}
//repo push