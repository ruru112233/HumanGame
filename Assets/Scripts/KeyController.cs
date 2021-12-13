using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EnumScript;
using KeyCodeScript;
using CheckPoint;

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
                GameManager.instance.spriteManager.PanelSet(GameManager.instance.spriteManager.sprites[SetKeyType(keyType) - 1], SetKeyType(keyType));
                Destroy(this.gameObject);
            }
        }
    }

    int SetKeyType(Enums.KeyType keyType)
    {
        int keyNo = 0;

        switch (keyType)
        {
            case Enums.KeyType.Black:
                FlagManager.crearFlag = true;
                keyNo = 1;
                break;
            case Enums.KeyType.Blue:
                keyNo = 2;
                break;
            case Enums.KeyType.Green:
                keyNo = 3;
                break;
            case Enums.KeyType.Red:
                keyNo = 4;
                break;
        }

        return keyNo;
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
