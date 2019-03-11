using UnityEngine;
using System.Collections;
using System;

public class CameraScript : MonoBehaviour
{
    public Camera cameraObj;
    public Vector3 specificVector;
    public float smoothSpeed;
    public GameObject player;
    private Vector3 offset;         //Private variable to store the offset distance between the player and camera

    void Start()
    {
        //just turn camera in Inspector, for example
        cameraObj = Camera.main;
    }

    void Update()
    {

        if (cameraObj.transform.position.y < player.transform.position.y - 2)
        {
            specificVector = new Vector3(player.transform.position.x, player.transform.position.y - 2, cameraObj.transform.position.z);
            cameraObj.transform.position = Vector3.Lerp(cameraObj.transform.position, specificVector, smoothSpeed * Time.deltaTime);
        }
        else if (cameraObj.transform.position.y > player.transform.position.y + 2)
        {
            specificVector = new Vector3(player.transform.position.x, player.transform.position.y + 2, cameraObj.transform.position.z);
            cameraObj.transform.position = Vector3.Lerp(cameraObj.transform.position, specificVector, smoothSpeed * Time.deltaTime);
        }
        else
        {
            specificVector = new Vector3(player.transform.position.x, cameraObj.transform.position.y, cameraObj.transform.position.z);
            cameraObj.transform.position = Vector3.Lerp(cameraObj.transform.position, specificVector, smoothSpeed * Time.deltaTime);
        }
    }


}