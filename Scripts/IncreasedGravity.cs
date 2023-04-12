using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreasedGravity : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {

        // Increased Gravity
        Physics.gravity = new Vector3(0f, Physics.gravity.y * 3, 0f);
    }

}
