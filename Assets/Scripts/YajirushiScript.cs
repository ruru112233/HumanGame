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

        if (Input.GetKeyDown(KeySet.investigateKey) && investigateFlag)
        {
            if (FlagManager.dengenFlag)
            {
                Debug.Log("電源を消した");
                FlagManager.dengenOff = !FlagManager.dengenOff;
            }
            else
            {
                Debug.Log("上に電源がある。長い棒があれば、スイッチを押せそうだ");

            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("接触");
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
