using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NodeCanvas.Framework;

public class GetRandomPositionAction : ActionTask
{
    public BBParameter<Vector3> randomPosition;  // This stores the random position
    public float range = 5f; // Adjust the range for random movement

    protected override void OnExecute()
    {
        Vector3 newPos = new Vector3(
            Random.Range(-range, range),
            0f,  // Keep Y at 0 so the cube stays on the ground
            Random.Range(-range, range)
        );

        randomPosition.value = newPos;  // Store the new random position
        EndAction(true);
    }
}
