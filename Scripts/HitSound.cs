using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Valve.VR.InteractionSystem
{


public class HitSound : MonoBehaviour {

    public AudioClip hitSound;

    private AudioSource source;


    private Interactable interactable;


    // Use this for initialization
    void Start () {

        source = GetComponent<AudioSource>();
            interactable = this.GetComponent<Interactable>();

    }

        // Update is called once per frame
        private void OnCollisionEnter(Collision collision)
        {

           /* if (interactable != null && interactable.attachedToHand != null)
            { //don't explode in hand
                return;
            } else
            {
                source.PlayOneShot(hitSound, 1f);
            }*/

            source.PlayOneShot(hitSound, 1f);


        }


    }

}


