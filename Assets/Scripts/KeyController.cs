using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyController : MonoBehaviour
{

    private bool playerFlag = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerFlag)
        {
            if (Input.GetKey(KeyCode.C))
            {
                Destroy(this.gameObject);
            }
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        playerFlag = true;
    }

    private void OnTriggerExit(Collider other)
    {
        playerFlag = false;
    }


}
