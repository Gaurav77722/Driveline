using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class SpeedoMeter : MonoBehaviour
{
    [SerializeField] public RectTransform needle;
    private float needleStartPosition = 217f;
    private float needleEndPosition = -39.3f;

    private float carMaxSpeed = 180f;
    public Rigidbody Car;

    private float speed = 0.0f;

    private void FixedUpdate()
    {
        speed = Car.velocity.magnitude * 3.6f;
        updateNeedle();
    }

    private void updateNeedle()
    {
        if (needle != null)
        {
            needle.localEulerAngles =
                new Vector3(0, 0, Mathf.Lerp(needleStartPosition, needleEndPosition, speed / carMaxSpeed));
        }
    }
}
