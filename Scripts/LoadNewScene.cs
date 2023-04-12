using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewScene : MonoBehaviour {

    public string SceneLoad;

    private void OnCollisionEnter(Collision collision)
    {

       if (collision.gameObject.name == "Hammer")
        {
            SceneManager.LoadScene(SceneLoad);
        }
 
    }
}
