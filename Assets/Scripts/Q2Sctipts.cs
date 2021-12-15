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
                Debug.Log("3���̔ԍ�������");
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("�ڐG");
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
