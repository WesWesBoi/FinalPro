using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleStateMachine : MonoBehaviour
{
    public enum stateMode
    {
        RED,
        GREEN,
        BLUE,
        CYAN
    }
   
    public stateMode myMode;
    Renderer myRend;
    Material myMat;

    // Start is called before the first frame update
    void Start()
    {
        myRend = GetComponent<Renderer>();
        myMat = myRend.material;
    }

    // Update is called once per frame
    void Update()
    {
      switch (myMode)
      {
         
              case stateMode.RED:
                myMat.color = Color.red;
            break;

              case stateMode.GREEN:
                myMat.color = Color.green;
            break;

              case stateMode.BLUE:
                myMat.color = Color.blue;
            break;

            case stateMode:CYAN:
                myMat.color = Color.cyan;
            break;


      }


    }
    






    
        

        

}
