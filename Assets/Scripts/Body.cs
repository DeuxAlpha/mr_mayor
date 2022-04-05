using System;
using UnityEngine;

public class Body : MonoBehaviour
{
    private float _bodyLeftRight = 0.0001f;
    private float _bodyUpDown = 0.0001f;
    
    public void HandleRotationRequest(BodyRotationRequestDirection direction, float amount)
    {
        switch (direction)
        {
            case BodyRotationRequestDirection.Dismissed:
                return;
            case BodyRotationRequestDirection.Left:
                ThinkTurnLeftAndRight(-amount);
                break;
            case BodyRotationRequestDirection.Right:
                ThinkTurnLeftAndRight(amount);
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(direction), direction, null);
        }

        AdjustBody();
    }

    private void AdjustBody()
    {
        transform.localRotation = Quaternion.Euler(_bodyUpDown, _bodyLeftRight, 0.001f);
    }

    private void ThinkTurnLeftAndRight(float input)
    {
        _bodyLeftRight += input;
    }
}