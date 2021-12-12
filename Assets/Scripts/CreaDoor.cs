using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CheckPoint;
using KeyCodeScript;

public class CreaDoor : MonoBehaviour
{

    private bool investigateFlag = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (investigateFlag && Input.GetKeyDown(KeySet.investigateKey))
        {
            if (FlagManager.crearFlag)
            {
                Debug.Log("クリア");
            }
            else
            {
                Debug.Log("カギがかかっている。");
            }
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
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
