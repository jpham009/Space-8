using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    public static GameMaster gm; //instance

    void Start()
    {
        if(gm == null)
        {
            //gm = GameObject.name("_GM").GetComponent<GameMaster>();
        }
    }

    public Transform playerObject;
    public Transform spawnPoint; 

    public void RespawnPlayer ()
    {
        Instantiate(playerObject, spawnPoint.position, spawnPoint.rotation);
    }
    //public static void KillPlayer (GameObject player)
    //{
    //    Destroy(player.gameObject);
    //    gm.RespawnPlayer();
    //}
}
