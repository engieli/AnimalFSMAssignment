using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using NodeCanvas.Framework;

public class JumpAction : ActionTask<Transform>
{
    public float jumpHeight = 2f; 
    public float jumpDuration = 0.5f; 
    private Vector3 startPos;
    private float elapsedTime = 0f;
    private bool isJumping = false;

   
    protected override void OnExecute()
    {
        startPos = agent.position; 
        isJumping = true;
        elapsedTime = 0f;
    }

    protected override void OnUpdate()
    {
        if (isJumping)
        {
            elapsedTime += Time.deltaTime;

            float t = elapsedTime / jumpDuration;
            float height = Mathf.Sin(t * Mathf.PI) * jumpHeight;
            agent.position = new Vector3(startPos.x, startPos.y + height, startPos.z);

            if (elapsedTime >= jumpDuration)
            {
                agent.position = startPos; 
                isJumping = false;
                EndAction(true);
            }
        }
    }
}
