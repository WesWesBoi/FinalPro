using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlat : MonoBehaviour
{

    [SerializeField] GameObject[] MovingPlats;
    int currentMovingPlatIndex = 0;

    [SerializeField] float speed = 1f;

    void Update()
    {
        if (Vector3.Distance(transform.position, MovingPlats[currentMovingPlatIndex].transform.position) < 0.1f)
        {
            currentMovingPlatIndex++;
            if (currentMovingPlatIndex >= MovingPlats.Length)
            {
                currentMovingPlatIndex = 0;
            }
        }

        transform.position = Vector3.MoveTowards(transform.position, MovingPlats[currentMovingPlatIndex].transform.position, speed * Time.deltaTime);

    }
}
