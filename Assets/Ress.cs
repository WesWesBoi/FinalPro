using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ress : MonoBehaviour
{
    public GameObject player;
    public Transform SpawnPoint;

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            player.transform.position = SpawnPoint.transform.position;
        }
    }
}