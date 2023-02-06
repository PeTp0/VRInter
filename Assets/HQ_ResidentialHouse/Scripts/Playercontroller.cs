using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Playercontroller : MonoBehaviour
{
    public SteamVR_Action_Vector2 input;
    public float speed = 1;

    // Update is called once per frame
    void Update()
    {
        // move in camera forward
        Vector3 direction = Camera.main.transform.forward;
        // move in camera right
        transform.position += direction * input.axis.y * speed * Time.deltaTime;
        transform.position += Camera.main.transform.right * input.axis.x * speed * Time.deltaTime;
    }
}