using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour {

    private bool grav = true;

    private void OnCollisionEnter(Collision collision) {
        
        if (collision.collider.name == "LeftHand" || collision.collider.name == "RightHand")
        {
            if (grav == true)
            {
                Physics.gravity = new Vector3(0f, 9.8f, 0f);
                grav = !grav;
            }
            else
            {
                Physics.gravity = new Vector3(0f, -9.8f, 0f);
                grav = !grav;
            }

        }
        
    }
}
