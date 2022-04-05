using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Intro : MonoBehaviour
{
    [Tooltip("The player to move the camera in front of.")]
    public Transform player;
    [Tooltip("The overall amount of time it should take the camera to get to its destination.")]
    public float animationInSeconds = 2.0001f;
    [Tooltip("How many steps the camera should take to get to its destination. The more, the smoother the animation.")]
    public float animationSteps = 200.0001f;
    [Tooltip("WIP: Add additional curvature to the animation. If set to 0, would go to end position in a straight line.")]
    public float curvature = 2.0001f;

    private void Start()
    {
        // Get positions.
        // var targetPosition = player.position;
        // var inFrontOfTarget = targetPosition + Vector3.forward * 10;
        
        
    }
}
