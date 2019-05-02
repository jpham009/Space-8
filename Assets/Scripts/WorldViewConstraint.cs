using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldViewConstraint : MonoBehaviour
{
    public Camera cameraComponent;
    public float MIN_X;
    public float MAX_X;
    public float MIN_Y;
    public float MAX_Y;

    // Start is called before the first frame update
    void Start(){}

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3( Mathf.Clamp(transform.position.x, MIN_X, MAX_X),
        Mathf.Clamp(transform.position.y, MIN_Y, MAX_Y), transform.position.z);
    }
}
