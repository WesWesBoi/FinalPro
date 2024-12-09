using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject Camera1;
    public GameObject Camera2;
    public GameObject Camera3;

    public Control myPlayer;

    
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            CameraOne();
        }

        if (Input.GetKeyDown("2"))
        {
            CameraTwo();
        }

        if (Input.GetKeyDown("3"))
        {
            CameraThree();
        }
    }

    void CameraOne()
    {
        Camera1.SetActive(true);
        Camera2.SetActive(false);
        Camera3.SetActive(false);
      
    }

    void CameraTwo()
    {
        Camera3.SetActive(false);
        Camera2.SetActive(true);
        Camera1.SetActive(false);
    }

    void CameraThree()
    {
        Camera3.SetActive(true);
        Camera2.SetActive(false);
        Camera1.SetActive(false);
    }

    
}