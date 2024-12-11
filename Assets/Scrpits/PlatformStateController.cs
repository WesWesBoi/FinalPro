using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;

public class PlatformStateController : MonoBehaviour
{

    public Unity.VisualScripting.StateMachine myMachine;
    public Variables myVars;

    public GameObject myPlayer;
    // Start is called before the first frame update
    void Start()
    {
        myMachine = GetComponent<Unity.VisualScripting.StateMachine>();
        myVars = GetComponent<Variables>();
        myPlayer = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            // code goes here
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            //code goes here
        }
    }
}
