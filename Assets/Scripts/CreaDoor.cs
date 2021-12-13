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
            if (FlagManager.crearFlag && FlagManager.blackKeyFlag)
            {
                GameManager.instance.spriteManager.PanelToNull(1);
                Debug.Log("�N���A");
            }
            else if (FlagManager.crearFlag && !FlagManager.blackKeyFlag)
            {
                Debug.Log("�����Ă�J�M�ŊJ����ꂻ��");
            }
            else
            {
                Debug.Log("�J�M���������Ă���B");
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
