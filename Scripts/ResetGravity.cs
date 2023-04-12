
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetGravity : MonoBehaviour {

    void OnCollisionEnter(Collision collision)
    {

        // Reset Gravity
        Physics.gravity = new Vector3(0f, -9.8f, 0f);

    }

}