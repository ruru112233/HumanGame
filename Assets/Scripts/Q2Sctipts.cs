using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KeyCodeScript;

public class Q2Sctipts : MonoBehaviour
{
    private bool investigateFlag = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (investigateFlag)
        {
            if (Input.GetKeyDown(KeySet.investigateKey))
            {
                Debug.Log("3Œ…‚Ì”Ô†‚ğ“ü‚ê‚é");
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("ÚG");
            investigateFlag = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            investigateFlag = false;
        }
    }
}
