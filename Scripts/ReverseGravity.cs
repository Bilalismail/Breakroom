using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReverseGravity : MonoBehaviour {

    private bool reversed = true;

    void OnCollisionEnter(Collision collision) {

    /*   if (reversed)
       { */
            // Reverse gravity
            Physics.gravity = new Vector3(0f, 9.8f, 0f);
            
   /*    }
       else
       {
            // Unreverse Gravity
            Physics.gravity = new Vector3(0f, -9.8f, 0f);

        }*/

        reversed = !reversed;

    }

}


