using System;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    public int desiredGravity;

    // Update is called once per frame
    public void Update()
    {
        // Set the gravity direction according to phone tilt
        float c = (float)(desiredGravity / Math.Sqrt(Math.Pow(Input.acceleration.x, 2) + Math.Pow(Input.acceleration.y, 2)));

        float gravX = Input.acceleration.x * c;
        float gravY = Input.acceleration.y * c;

        Physics2D.gravity = new Vector2(gravX, gravY);
    }
}
