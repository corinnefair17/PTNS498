using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SignController : MonoBehaviour
{
    public Text pressE;
    // Start is called before the first frame update
    void Start()
    {
        pressE.enabled = false;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player") 
        {
            pressE.enabled = true;
        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            pressE.enabled = false;
        }
    }
}
