using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillGreen : MonoBehaviour
{

    public GameObject myPlayer;
    float positionX;
    float positionY;
    float positionZ;
    // Start is called before the first frame update
    void Start()
    {
        positionX = -66.4f;
        positionY = -2.3f;
        positionZ = 123f;
        myPlayer = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "Player")
        {

            myPlayer.transform.position = new Vector3(positionX, positionY, positionZ);

        }


    }

}
