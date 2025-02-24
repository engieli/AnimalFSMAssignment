using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NodeCanvas.Framework;

public class CirclePlayerAction : ActionTask<Transform>
{
    private Transform playerTransform;
    public float circleRadius = 2f;
    public float circleSpeed = 2f;

    private float angle = 0f;

    protected override void OnExecute()
    {
   
        GameObject player = GameObject.FindWithTag("Player");

        if (player != null)
        {
            playerTransform = player.transform;
        }
        else
        {
            Debug.LogError("Player not found! Make sure the Player has the correct tag.");
            EndAction(false);
            return;
        }
    }

    protected override void OnUpdate()
    {
        if (playerTransform != null)
        {
            angle += circleSpeed * Time.deltaTime;
            Vector3 offset = new Vector3(Mathf.Cos(angle), 0, Mathf.Sin(angle)) * circleRadius;
            agent.position = playerTransform.position + offset;
        }
    }
}
