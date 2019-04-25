using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript2 : MonoBehaviour
{
    [Header("Camera")]
    [Tooltip("Reference to the target GameObject")]
    public GameObject player;
    [Tooltip("Current relative offset to the target")]
    public Vector3 offset;
    [Tooltip("Multiplier for the movement speed")]
    [Range(0f, 5f)]
    public float smoothSpeed = 0.125f;
    [Tooltip("Maximum or highest camera position on the Y-axis.")]
    public float maxHeight = 5f;
    [Tooltip("Minimum or lowest camera position on the Y-axis.")]
    public float minHeight = -1f;

    private bool perspective = false;
    

    public Camera cameraObj;

    // Use this for initialization
    void Start()
    {
        //player = GameObject.Find("Player");
        //if (!Camera.main.orthographic)
        //{
        //    perspective = true;
        //}
    }

    // LateUpdate is called every frame, if the Behaviour is enabled
    void Update()
    {
        if (player != null)
        {
            Vector2 smoothedPosition = Vector2.Lerp(cameraObj.transform.position, player.transform.position + offset, smoothSpeed);
            //smoothedPosition.y = Mathf.Clamp(smoothedPosition.y, minHeight, maxHeight);
            transform.position = new Vector3(smoothedPosition.x, smoothedPosition.y, player.transform.position.z + offset.z);
        }
        //if (perspective)
        //{
        //    transform.LookAt(target);
        //}
    }
}
