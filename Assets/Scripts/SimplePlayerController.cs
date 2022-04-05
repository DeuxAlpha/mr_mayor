using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class SimplePlayerController : MonoBehaviour
{
    private void FixedUpdate()
    {
        var mouseXAxisMovement = Input.GetAxis("Mouse X");
        HandleLeftAndRightLooking(mouseXAxisMovement);

        var mouseYAxisMovement = Input.GetAxis("Mouse Y");
        HandleUpAndDownLooking(mouseYAxisMovement);

        var playerHealth = GameManager._playerHealth;
        Debug.Log($"Player Health is : {playerHealth.ToString(CultureInfo.InvariantCulture)}", this);
        
        
    }

    private void HandleLeftAndRightLooking(float inputAmount)
    {
        Debug.Log("left and right ggo brrrr");
    }

    private void HandleUpAndDownLooking(float inputAmount)
    {
        Debug.Log("up and down also ggo brrrr"); 
    }
}
