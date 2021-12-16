using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KeyCodeScript;
using CheckPoint;

public class YajirushiScript : MonoBehaviour
{

    private bool investigateFlag = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeySet.investigateKey))
        {
            if (FlagManager.dengenFlag)
            {
                Debug.Log("�d����������");
            }
            else
            {
                Debug.Log("��ɓd��������B�����_������΁A�X�C�b�`������������");
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
