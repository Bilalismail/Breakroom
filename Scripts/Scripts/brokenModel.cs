using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brokenModel : MonoBehaviour {

    public GameObject brokenObject;
    public Rigidbody rb;
    public float check;
    public GameObject weapon;



    void OnCollisionEnter(Collision collision)
    {

        rb = GetComponent<Rigidbody>();
       // weapon = GetComponent<>();

        check = rb.velocity.magnitude;

        if (check > 1f){
            GameObject brokenbit = Instantiate(brokenObject, transform.position, transform.rotation);
            brokenbit.AddComponent<Rigidbody>();
            brokenbit.AddComponent<BoxCollider>();
            //brokenbit.AddComponent<>("Grenade.cs");
            Destroy(gameObject);
        }

    }


   }

