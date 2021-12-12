using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EnumScript;
using KeyCodeScript;

public class KeyController : MonoBehaviour
{

    private bool playerFlag = false;

    public Enums.KeyType keyType;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerFlag)
        {
            if (Input.GetKey(KeySet.investigateKey))
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
