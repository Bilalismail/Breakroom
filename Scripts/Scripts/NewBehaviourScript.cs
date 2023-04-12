using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public GameObject broeknVersion;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {

        Destroy(gameObject);
        Instantiate(broeknVersion, transform.position, transform.rotation);


    }


    }

