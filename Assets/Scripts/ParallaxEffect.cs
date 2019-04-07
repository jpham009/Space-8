using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxEffect : MonoBehaviour
{
    public GameObject frame;       //Public variable to store a reference to the player game object
    public Vector3 offset; //Private variable to store the offset distance between the player and camera
    public float offX;
    public float offY;
    private Vector3 position;

    // Use this for initialization
    void Start()
    {
        //Calculate and store the offset value by getting the distance between the player's position and camera's position.
        //offset = transform.position - cam.transform.position;
        offset = transform.position - frame.transform.position + new Vector3(offX, offY, 0);
        
    }

    //void Update()
    //{
    //    // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
    //    transform.position = cam.transform.position + offset;
    //}

    void Update()
    {
        position.x = frame.transform.position.x + offset.x;
        position.y = frame.transform.position.y + offset.y;
        position.z = this.transform.position.z;
        this.transform.position = position; 

    }
}
