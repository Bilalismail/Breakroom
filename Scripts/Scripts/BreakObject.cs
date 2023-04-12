
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakObject : MonoBehaviour
{

    public GameObject smallerVersion;

    private Vector3 velocity;
    public Rigidbody rb;
    private float check;
    private float timer = 5;
    private int intCount = 0;

 

    private void Update()
    {
        timer -= Time.deltaTime;

    }


    void OnCollisionEnter(Collision collision)
    {


        intCount += 1;

        rb = GetComponent<Rigidbody>();             

        check = rb.velocity.magnitude;

        velocity = collision.relativeVelocity;


        if (intCount > 1)

        {

            if (check > 3f)
            {

                transform.localScale -= new Vector3(0.5f, 0.5f, 0.5f);

                Instantiate(smallerVersion, transform.position, transform.rotation);
                Instantiate(smallerVersion, transform.position, transform.rotation);
                Instantiate(smallerVersion, transform.position, transform.rotation);
                Instantiate(smallerVersion, transform.position, transform.rotation);
                Instantiate(smallerVersion, transform.position, transform.rotation);
                Instantiate(smallerVersion, transform.position, transform.rotation);
                Instantiate(smallerVersion, transform.position, transform.rotation);


                Destroy(gameObject);
            }
            else if (check > 1f)
            {
                transform.localScale -= new Vector3(0.5f, 0.5f, 0.5f);
                Instantiate(smallerVersion, transform.position, transform.rotation);
                Instantiate(smallerVersion, transform.position, transform.rotation);
                Instantiate(smallerVersion, transform.position, transform.rotation);
                Instantiate(smallerVersion, transform.position, transform.rotation);
                Instantiate(smallerVersion, transform.position, transform.rotation);
                Instantiate(smallerVersion, transform.position, transform.rotation);
                Instantiate(smallerVersion, transform.position, transform.rotation);


                Destroy(gameObject);
            }
            

        }


    }


}


