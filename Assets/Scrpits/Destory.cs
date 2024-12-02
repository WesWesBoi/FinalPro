using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destory : MonoBehaviour
{

    public GameObject myPlayer;
    float positionX;
    float positionY;
    float positionZ;
    // Start is called before the first frame update
    void Start()
    {
        positionX = 4.87f;
        positionY = 0.07999995f;
        positionZ = 9.87295e-19f;
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