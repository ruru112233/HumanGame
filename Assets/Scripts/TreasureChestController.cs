using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KeyCodeScript;
using CheckPoint;

public class TreasureChestController : MonoBehaviour
{

    private bool investigateFlag = false;

    [SerializeField]
    private GameObject upper;
    // Start is called before the first frame update
    void Start()
    {
        FlagManager.treasureFlag = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (investigateFlag && Input.GetKeyDown(KeySet.investigateKey))
        {
            if (FlagManager.treasureFlag)
            {
                if (FlagManager.getKinobou) return;
                
                Debug.Log("�󔠂��J����");
                upper.transform.rotation = Quaternion.Euler(-170, -90,0);
                GameManager.instance.spriteManager.PanelSet(GameManager.instance.spriteManager.sprites[4], 5);
                FlagManager.getKinobou = true;
            }
            else
            {
                Debug.Log("�󔠂ɂ̓J�M���������Ă���B");
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
