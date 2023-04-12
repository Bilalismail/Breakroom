using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoGravity : MonoBehaviour
{

    void OnCollisionEnter(Collision collision){
        
        // No Gravity
        Physics.gravity = new Vector3(0f, 0f, 0f);

    }

}
