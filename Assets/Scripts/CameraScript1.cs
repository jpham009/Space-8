using UnityEngine;
using System.Collections;

public class CameraScript1 : MonoBehaviour
{

    public Transform player;
    public float offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.position.x + offset, transform.position.y, transform.position.z);
    }
}