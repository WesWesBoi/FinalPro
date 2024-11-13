using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public bool debugs = true;
    float speed = 10;
    Rigidbody myRB;

    public enum playerMode
    {
        ONPLATFORM,
        AIRBORNE,
        GROUNDED
    }

    public playerMode myMode;

    public SimpleStateMachine debugMachine;

    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody>();
        debugMachine = GetComponent<SimpleStateMachine>();
        if(debugMachine == null) {  debugMachine = GetComponentInChildren<SimpleStateMachine>(); }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        myRB.AddForce(transform.TransformDirection(Direction(debugs)) * speed);

        //run code that is relevant to the PLAYER or the PLAYER DEBUG STATE MACHINE here
        //NOT PLATFORM

        switch (myMode)
        {
            case playerMode.ONPLATFORM:
                debugMachine.myMode = SimpleStateMachine.stateMode.RED;
                break;

        }
    }

    Vector3 Direction(bool debugs)
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 dir = new Vector3(h, 0, v);

        if (debugs)
        {
            Debug.DrawRay(transform.position, myRB.velocity, Color.yellow);
            //Debug.Log("vector: " + dir);
            Debug.DrawRay(transform.position, transform.TransformDirection(dir * 2f), Color.white);
            Debug.DrawRay(transform.position + Vector3.up, transform.forward, Color.green);
            Debug.DrawRay(transform.position + Vector3.up, transform.right, Color.green);
        }
        return dir;
    }

    private void OnCollisionEnter(Collision collision)
    {

    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            myMode = playerMode.ONPLATFORM;
        }

        if(collision.gameObject.tag == "Ground")
        {
            myMode = playerMode.GROUNDED;
        }

    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Platform" || collision.gameObject.tag == "Ground")
        {
            myMode = playerMode.AIRBORNE;
            //check to turn off the mode here 
        }
    }


}
