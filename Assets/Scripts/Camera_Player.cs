using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Player : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
    public static float fps;

    void OnGUI()
    {
        //fps = 1.0f / Time.deltaTime;
        //GUI.Label(new Rect(666, 0, 1000000, 1000000), "FPS: " + (int)fps);
    }
}
